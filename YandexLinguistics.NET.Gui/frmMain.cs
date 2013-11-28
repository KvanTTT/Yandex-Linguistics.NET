using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YandexLinguistics.NET.Gui.Properties;

namespace YandexLinguistics.NET.Gui
{
	public partial class frmMain : Form
	{
		Predictor Predictor;
		Dictionary Dictionary;
		Translator Translator;
		System.Threading.Timer PredictorTimer;
		System.Threading.Timer DictionaryTimer;
		System.Threading.Timer TranslatorTimer;

		public frmMain()
		{
			Predictor = new Predictor(ConfigurationManager.AppSettings["PredictorKey"]);
			Dictionary = new Dictionary(ConfigurationManager.AppSettings["DictionaryKey"]);
			Translator = new Translator(ConfigurationManager.AppSettings["TranslatorKey"]);
			PredictorTimer = new System.Threading.Timer(_ => UpdatePredictorResult(), null, Timeout.Infinite, Timeout.Infinite);
			DictionaryTimer = new System.Threading.Timer(_ => UpdateDictionaryResult(), null, Timeout.Infinite, Timeout.Infinite);
			TranslatorTimer = new System.Threading.Timer(_ => UpdateTranslatorResult(), null, Timeout.Infinite, Timeout.Infinite);

			InitializeComponent();

			tcServices.SelectedIndex = Settings.Default.SelectedTabIndex;

			cmbPredictorLangs.Items.AddRange(Predictor.GetLangs().Select(lang => (object)lang).ToArray());
			cmbDictionaryLangPairs.Items.AddRange(Dictionary.GetLangs().Select(lang => (object)lang).ToArray());
			cmbDictionaryLangUi.Items.Add("");
			cmbDictionaryLangUi.Items.AddRange(Predictor.GetLangs().Select(lang => (object)lang).ToArray());

			cmbPredictorLangs.SelectedItem = Enum.Parse(typeof(Lang), Settings.Default.PredictorLanguage);
			nudMaxHintCount.Value = Settings.Default.PredictorMaxHintCount;
			nudPredictorDelay.Value = Settings.Default.PredictorHintDelay;
			tbPredictorInput.Text = Settings.Default.PredictorInput;

			cmbDictionaryLangPairs.SelectedItem = new LangPair(Settings.Default.DictionaryLangPair);
			cmbDictionaryLangUi.SelectedIndex = 0;
			
			cbFamily.Checked = Settings.Default.DictionaryFamily;
			cbMorpho.Checked = Settings.Default.DictionaryMorpho;
			cbPartOfSpeech.Checked = Settings.Default.DictionaryPartOfSpeech;
			nudPredictorDelay.Value = Settings.Default.DictionaryHintDelay;
			tbDictionaryInput.Text = Settings.Default.DictionaryInput;
			cbDictionaryFormatting.Checked = Settings.Default.DictionaryFormatting;
			rbDictionaryOutput.Text = Settings.Default.DictionaryOutputIndent;

			var langArray = ((Lang[])Enum.GetValues(typeof(Lang))).Select(lang => (object)lang).ToArray();
			cmbTranslatorInputLang.Items.AddRange(langArray);
			cmbTranslatorOutputLang.Items.AddRange(langArray);
			cmbTranslatorInputLang.SelectedItem = (Lang)Enum.Parse(typeof(Lang), Settings.Default.TranslatorInputLang);
			cmbTranslatorOutputLang.SelectedItem = (Lang)Enum.Parse(typeof(Lang), Settings.Default.TranslatorOutputLang);
			nudTranslatorDelay.Value = Settings.Default.TranslatorHintDelay;
			cbTranslatorDetectInputLang.Checked = Settings.Default.TranslatorDetectInputLang;
			tbTranslatorInput.Text = Settings.Default.TranslatorInput;
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.SelectedTabIndex = tcServices.SelectedIndex;

			Settings.Default.PredictorLanguage = cmbPredictorLangs.SelectedItem.ToString();
			Settings.Default.PredictorMaxHintCount = (int)nudMaxHintCount.Value;
			Settings.Default.PredictorHintDelay = (int)nudPredictorDelay.Value;
			Settings.Default.PredictorInput = tbPredictorInput.Text;

			Settings.Default.DictionaryLangPair = cmbDictionaryLangPairs.SelectedItem.ToString();
			Settings.Default.DictionaryLangUi = cmbDictionaryLangUi.SelectedItem.ToString();
			Settings.Default.DictionaryMorpho = cbMorpho.Checked;
			Settings.Default.DictionaryFamily = cbFamily.Checked;
			Settings.Default.DictionaryPartOfSpeech = cbPartOfSpeech.Checked;
			Settings.Default.DictionaryHintDelay = (int)nudDictionaryDelay.Value;
			Settings.Default.DictionaryInput = tbDictionaryInput.Text;
			Settings.Default.DictionaryFormatting = cbDictionaryFormatting.Checked;
			Settings.Default.DictionaryOutputIndent = tbDictionaryIndent.Text;

			Settings.Default.TranslatorInputLang = cmbTranslatorInputLang.SelectedItem.ToString();
			Settings.Default.TranslatorOutputLang = cmbTranslatorOutputLang.SelectedItem.ToString();
			Settings.Default.TranslatorHintDelay = (int)nudTranslatorDelay.Value;
			Settings.Default.TranslatorDetectInputLang = cbTranslatorDetectInputLang.Checked;
			Settings.Default.TranslatorInput = tbTranslatorInput.Text;

			Settings.Default.Save();
		}

		private void tbPredictor_TextChanged(object sender, EventArgs e)
		{
			lbHints.Items.Clear();
			PredictorTimer.Change((int)nudPredictorDelay.Value, Timeout.Infinite);
		}

		private void tbDictionaryInput_TextChanged(object sender, EventArgs e)
		{
			rbDictionaryOutput.Clear();
			DictionaryTimer.Change((int)nudDictionaryDelay.Value, Timeout.Infinite);
		}

		private void tbTranslatorInput_TextChanged(object sender, EventArgs e)
		{
			rtbTranslatorOutput.Clear();
			TranslatorTimer.Change((int)nudTranslatorDelay.Value, Timeout.Infinite);
		}

		private void UpdatePredictorResult()
		{
			this.Invoke(new Action(() =>
			{
				try
				{
					var response = Predictor.Complete((Lang)cmbPredictorLangs.SelectedItem, tbPredictorInput.Text, (int)nudMaxHintCount.Value);

					tbHintCount.Text = response.Text.Count.ToString();
					tbPos.Text = response.Pos.ToString();
					tbEndOfWorld.Text = response.EndOfWord.ToString();

					if (response.Text.Count > 0)
					{
						lbHints.Items.AddRange(response.Text.Select(t => (object)t).ToArray());
						lbHints.SelectedIndex = 0;
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.ToString(), "Error");
				}
			}));
		}

		private void tbPredictor_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.Control && e.KeyCode == Keys.Space) || e.KeyCode == Keys.Enter)
			{
				if (lbHints.Items.Count > 0)
				{
					int pos = int.Parse(tbPos.Text);
					if (pos <= 0)
						tbPredictorInput.Text += ((string)lbHints.SelectedItem).Substring(-pos);
					else
						tbPredictorInput.Text += new string(' ', pos) + (string)lbHints.SelectedItem;
					tbPredictorInput.Select(tbPredictorInput.Text.Length, 0);
				}
			}
			else if (e.KeyCode == Keys.Down)
			{
				if (lbHints.Items.Count > 0)
					lbHints.SelectedIndex = (lbHints.SelectedIndex + 1) % lbHints.Items.Count;
			}
			else if (e.KeyCode == Keys.Up)
			{
				if (lbHints.Items.Count > 0)
					lbHints.SelectedIndex = (lbHints.SelectedIndex - 1 + lbHints.Items.Count) % lbHints.Items.Count;
			}
		}

		private void UpdateDictionaryResult()
		{
			this.Invoke(new Action(() =>
			{
				try
				{
					LookupOptions lookupOptions = 0;
					if (cbFamily.Checked)
						lookupOptions |= LookupOptions.Family;
					if (cbMorpho.Checked)
						lookupOptions |= LookupOptions.Morpho;
					if (cbPartOfSpeech.Checked)
						lookupOptions |= LookupOptions.PartOfSpeechFilter;
					var response = Dictionary.Lookup((LangPair)cmbDictionaryLangPairs.SelectedItem,
						tbDictionaryInput.Text, cmbDictionaryLangUi.SelectedItem.ToString().ToLowerInvariant(), lookupOptions);

					rbDictionaryOutput.Text = response.ToString(cbDictionaryFormatting.Checked, tbDictionaryIndent.Text);
				}
				catch (Exception ex)
				{
					rbDictionaryOutput.Text = ex.ToString();
				}
			}));
		}

		private void tcServices_SelectedIndexChanged(object sender, EventArgs e)
		{
			switch (tcServices.SelectedIndex)
			{
				case 0:
					tbPredictorInput.Focus();
					tbPredictorInput.Select(tbPredictorInput.Text.Length, 0);
					break;
				case 1:
					tbDictionaryInput.Focus();
					tbDictionaryInput.Select(tbDictionaryInput.Text.Length, 0);
					break;
				case 2:
					tbTranslatorInput.Focus();
					tbTranslatorInput.Select(tbTranslatorInput.Text.Length, 0);
					break;
			}
		}

		private void UpdateTranslatorResult()
		{
			this.Invoke(new Action(() =>
			{
				try
				{
					var response = Translator.Translate(tbTranslatorInput.Text,
						new LangPair((Lang)cmbTranslatorInputLang.SelectedItem, (Lang)cmbTranslatorOutputLang.SelectedItem), null, cbTranslatorDetectInputLang.Checked);

					if (response.Detected != null)
						tbTranslatorDetectedLang.Text = response.Detected.Lang.ToString();
					rtbTranslatorOutput.Text = response.Text;
				}
				catch (Exception ex)
				{
					tbTranslatorDetectedLang.Text = "";
					rtbTranslatorOutput.Text = ex.ToString();
				}
			}));
		}
	}
}
