using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YandexLinguistics.NET.Dictionary;
using YandexLinguistics.NET.Gui.Properties;
using YandexLinguistics.NET.Predictor;
using YandexLinguistics.NET.Speller;
using YandexLinguistics.NET.Translator;

namespace YandexLinguistics.NET.Gui
{
	public partial class frmMain : Form
	{
		private PredictorService _predictorService;
		private DictionaryService _dictionaryService;
		private TranslatorService _translatorService;
		private SpellerService _spellerService;
		private System.Threading.Timer _predictorTimer;
		private System.Threading.Timer _dictionaryTimer;
		private System.Threading.Timer _translatorTimer;
		private System.Threading.Timer _spellerTimer;

		public frmMain()
		{
			InitializeComponent();
		}

		private async void frmMain_Load(object sender, EventArgs e)
		{
			tcServices.SelectedIndex = Settings.Default.SelectedTabIndex;

			nudMaxHintCount.Value = Settings.Default.PredictorMaxHintCount;
			nudPredictorDelay.Value = Settings.Default.PredictorHintDelay;
			tbPredictorInput.Text = Settings.Default.PredictorInput;

			cbFamily.Checked = Settings.Default.DictionaryFamily;
			cbMorpho.Checked = Settings.Default.DictionaryMorpho;
			cbPartOfSpeech.Checked = Settings.Default.DictionaryPartOfSpeech;
			nudPredictorDelay.Value = Settings.Default.DictionaryHintDelay;
			tbDictionaryInput.Text = Settings.Default.DictionaryInput;
			cbDictionaryFormatting.Checked = Settings.Default.DictionaryFormatting;
			rbDictionaryOutput.Text = Settings.Default.DictionaryOutputIndent;

			var langArray = ((Language[])Enum.GetValues(typeof(Language))).Select(lang => (object)lang).ToArray();
			cmbTranslatorInputLang.Items.AddRange(langArray);
			cmbTranslatorOutputLang.Items.AddRange(langArray);
			cmbTranslatorInputLang.SelectedItem = (Language)Enum.Parse(typeof(Language), Settings.Default.TranslatorInputLang);
			cmbTranslatorOutputLang.SelectedItem = (Language)Enum.Parse(typeof(Language), Settings.Default.TranslatorOutputLang);
			nudTranslatorDelay.Value = Settings.Default.TranslatorHintDelay;
			cbTranslatorDetectInputLang.Checked = Settings.Default.TranslatorDetectInputLang;
			tbTranslatorInput.Text = Settings.Default.TranslatorInput;

			cbSpellerRu.Checked = Settings.Default.SpellerRuLang;
			cbSpellerEn.Checked = Settings.Default.SpellerEnLang;
			cbSpellerUk.Checked = Settings.Default.SpellerUkLang;
			SpellerOptions options = (SpellerOptions)Settings.Default.SpellerOptions;
			cbIgnoreUppercase.Checked = options.HasFlag(SpellerOptions.IgnoreUppercase);
			cbIgnoreDigits.Checked = options.HasFlag(SpellerOptions.IgnoreDigits);
			cbIgnoreUrls.Checked = options.HasFlag(SpellerOptions.IgnoreUrls);
			cbFindRepeatWords.Checked = options.HasFlag(SpellerOptions.FindRepeatWords);
			cbIgnoreLatin.Checked = options.HasFlag(SpellerOptions.IgnoreLatin);
			cbNoSuggest.Checked = options.HasFlag(SpellerOptions.NoSuggest);
			cbFlagLatin.Checked = options.HasFlag(SpellerOptions.FlagLatin);
			cbByWords.Checked = options.HasFlag(SpellerOptions.ByWords);
			cbIgnoreCapitalization.Checked = options.HasFlag(SpellerOptions.IgnoreCapitalization);
			nudSpellerDelay.Value = Settings.Default.SpellerHintDelay;
			tbSpellerInput.Text = Settings.Default.SpellerInput;
			cbIncludeErrorWords.Checked = Settings.Default.SpellerIncludeErrorWords;

			_predictorService = new PredictorService(Settings.Default.PredictorKey);
			_dictionaryService = new DictionaryService(Settings.Default.DictionaryKey);
			_translatorService = new TranslatorService(Settings.Default.TranslatorKey);
			_spellerService = new SpellerService();

			_predictorTimer = new System.Threading.Timer(_ => UpdatePredictorResult(), null, Timeout.Infinite, Timeout.Infinite);
			_dictionaryTimer = new System.Threading.Timer(_ => UpdateDictionaryResult(), null, Timeout.Infinite, Timeout.Infinite);
			_translatorTimer = new System.Threading.Timer(_ => UpdateTranslatorResult(), null, Timeout.Infinite, Timeout.Infinite);
			_spellerTimer = new System.Threading.Timer(_ => UpdateSpellerResult(), null, Timeout.Infinite, Timeout.Infinite);

			await UpdatePredictorLanguages(sender, e);

			try
			{
				var dictionaryResult = await _dictionaryService.GetLanguagesAsync();
				var dictionaryLanguages = dictionaryResult.Select(lang => (object) lang).ToArray();

				cmbDictionaryLangPairs.Items.AddRange(dictionaryLanguages);
				cmbDictionaryLangPairs.SelectedItem = LanguagePair.Parse(Settings.Default.DictionaryLangPair);
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error");
			}

			tbPredictorKey.Text = Settings.Default.PredictorKey;
			tbDictionaryKey.Text = Settings.Default.DictionaryKey;
			tbTranslatorKey.Text = Settings.Default.TranslatorKey;
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.SelectedTabIndex = tcServices.SelectedIndex;

			Settings.Default.PredictorKey = tbPredictorKey.Text;
			Settings.Default.DictionaryKey = tbDictionaryKey.Text;
			Settings.Default.TranslatorKey = tbTranslatorKey.Text;

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

			Settings.Default.SpellerRuLang = cbSpellerRu.Checked;
			Settings.Default.SpellerEnLang = cbSpellerEn.Checked;
			Settings.Default.SpellerUkLang = cbSpellerUk.Checked;
			SpellerOptions options = 0;
			if (cbIgnoreUppercase.Checked)
				options |= SpellerOptions.IgnoreUppercase;
			if (cbIgnoreDigits.Checked)
				options |= SpellerOptions.IgnoreDigits;
			if (cbIgnoreUrls.Checked)
				options |= SpellerOptions.IgnoreUrls;
			if (cbFindRepeatWords.Checked)
				options |= SpellerOptions.FindRepeatWords;
			if (cbIgnoreLatin.Checked)
				options |= SpellerOptions.IgnoreLatin;
			if (cbNoSuggest.Checked)
				options |= SpellerOptions.NoSuggest;
			if (cbFlagLatin.Checked)
				options |= SpellerOptions.FlagLatin;
			if (cbByWords.Checked)
				options |= SpellerOptions.ByWords;
			if (cbIgnoreCapitalization.Checked)
				options |= SpellerOptions.IgnoreCapitalization;
			Settings.Default.SpellerOptions = (int)options;
			Settings.Default.SpellerHintDelay = (int)nudSpellerDelay.Value;
			Settings.Default.SpellerInput = tbSpellerInput.Text;
			Settings.Default.SpellerIncludeErrorWords = cbIncludeErrorWords.Checked;

			Settings.Default.Save();
		}

		private async void tbPredictorKey_TextChanged(object sender, EventArgs e)
		{
			_predictorService = new PredictorService(tbPredictorKey.Text, tbPredictorBaseUrl.Text);
			await UpdatePredictorLanguages(sender, e);
		}

		private async Task UpdatePredictorLanguages(object sender, EventArgs e)
		{
			try
			{
				var predictorResult = await _predictorService.GetLanguagesAsync();
				var predictorLanguages = predictorResult.Select(lang => (object) lang).ToArray();

				cmbPredictorLangs.Items.AddRange(predictorLanguages);
				cmbPredictorLangs.SelectedItem = Enum.Parse(typeof(Language), Settings.Default.PredictorLanguage);
				cmbDictionaryLangUi.Items.Add("");
				cmbDictionaryLangUi.Items.AddRange(predictorLanguages);
				cmbDictionaryLangUi.SelectedIndex = 0;

				UpdatePredictorResult2();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error");
			}
		}

		private void tbPredictor_TextChanged(object sender, EventArgs e)
		{
			_predictorTimer?.Change((int) nudPredictorDelay.Value, Timeout.Infinite);
		}

		private void btnPredict_Click(object sender, EventArgs e)
		{
			UpdatePredictorResult2();
		}

		private void tbDictionaryKey_TextChanged(object sender, EventArgs e)
		{
			_dictionaryService = new DictionaryService(tbDictionaryKey.Text, tbDictionaryBaseUrl.Text);
			tbDictionaryInput_TextChanged(sender, e);
		}

		private void tbTranslatorKey_TextChanged(object sender, EventArgs e)
		{
			_translatorService = new TranslatorService(tbTranslatorKey.Text, tbTranslatorBaseUrl.Text);
			tbTranslatorInput_TextChanged(sender, e);
		}

		private void tbSpellerBaseUrl_TextChanged(object sender, EventArgs e)
		{
			_spellerService = new SpellerService(tbSpellerBaseUrl.Text);
			tbSpellerInput_TextChanged(sender, e);
		}

		private void tbDictionaryInput_TextChanged(object sender, EventArgs e)
		{
			_dictionaryTimer?.Change((int)nudDictionaryDelay.Value, Timeout.Infinite);
		}

		private void tbTranslatorInput_TextChanged(object sender, EventArgs e)
		{
			_translatorTimer?.Change((int)nudTranslatorDelay.Value, Timeout.Infinite);
		}

		private void tbSpellerInput_TextChanged(object sender, EventArgs e)
		{
			_spellerTimer?.Change((int)nudSpellerDelay.Value, Timeout.Infinite);
		}

		private void btnDetermine_Click(object sender, EventArgs e)
		{
			UpdateDictionaryResult2();
		}

		private void btnTranslate_Click(object sender, EventArgs e)
		{
			UpdateTranslatorResult();
		}

		private void btnSpellerCheck_Click(object sender, EventArgs e)
		{
			UpdateSpellerResult();
		}

		private void tbPredictor_KeyDown(object sender, KeyEventArgs e)
		{
			if ((e.Control && e.KeyCode == Keys.Space) || e.KeyCode == Keys.Enter)
			{
				PredictorAppendSelectedText();
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

		private void lbHints_DoubleClick(object sender, EventArgs e)
		{
			PredictorAppendSelectedText();
		}

		private void PredictorAppendSelectedText()
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

		private void textBox_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.Control && e.KeyCode == Keys.A)
			{
				((TextBox)sender).SelectAll();
				e.SuppressKeyPress = true;
			}
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

		private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			System.Diagnostics.Process.Start(((LinkLabel)sender).Text);
		}

		private void UpdatePredictorResult()
		{
			Invoke(new Action(() => { UpdatePredictorResult2(); }));
		}

		private async void UpdatePredictorResult2()
		{
			try
			{
				lbHints.Items.Clear();
				if (!string.IsNullOrWhiteSpace(tbPredictorInput.Text) && cmbPredictorLangs.SelectedItem != null)
				{
					var response = await _predictorService.CompleteAsync((Language) cmbPredictorLangs.SelectedItem,
						tbPredictorInput.Text, (int) nudMaxHintCount.Value);

					tbHintCount.Text = response.Texts.Count.ToString();
					tbPos.Text = response.Position.ToString();
					tbEndOfWorld.Text = response.EndOfWord.ToString();

					if (response.Texts.Count > 0)
					{
						lbHints.Items.AddRange(response.Texts.Select(t => (object) t).ToArray());
						lbHints.SelectedIndex = 0;
					}
				}
				else
				{
					tbHintCount.Text = tbPos.Text = tbEndOfWorld.Text = "";
					lbHints.Items.Clear();
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.ToString(), "Error");
			}
		}

		private void UpdateDictionaryResult()
		{
			Invoke(new Action(() => { UpdateDictionaryResult2(); }));
		}

		private async void UpdateDictionaryResult2()
		{
			try
			{
				rbDictionaryOutput.Clear();
				if (!string.IsNullOrWhiteSpace(tbDictionaryInput.Text) && cmbDictionaryLangPairs.SelectedItem != null)
				{
					LookupOptions lookupOptions = 0;
					if (cbFamily.Checked)
						lookupOptions |= LookupOptions.Family;
					if (cbMorpho.Checked)
						lookupOptions |= LookupOptions.Morpho;
					if (cbPartOfSpeech.Checked)
						lookupOptions |= LookupOptions.PartOfSpeechFilter;
					var response = await _dictionaryService.LookupAsync((LanguagePair) cmbDictionaryLangPairs.SelectedItem,
						tbDictionaryInput.Text, cmbDictionaryLangUi.SelectedItem.ToString().ToLowerInvariant(),
						lookupOptions).ConfigureAwait(true);

					rbDictionaryOutput.Text =
						response.ToString(cbDictionaryFormatting.Checked, tbDictionaryIndent.Text);
				}
			}
			catch (Exception ex)
			{
				rbDictionaryOutput.Text = ex.ToString();
			}
		}

		private void UpdateTranslatorResult()
		{
			Invoke(new Action(() =>
			{
				rtbTranslatorOutput.Clear();
				try
				{
					if (!string.IsNullOrWhiteSpace(tbTranslatorInput.Text))
					{
						var response = _translatorService.TranslateAsync(tbTranslatorInput.Text,
							new LanguagePair((Language) cmbTranslatorInputLang.SelectedItem,
								(Language) cmbTranslatorOutputLang.SelectedItem), null,
							cbTranslatorDetectInputLang.Checked).Result;

						if (response.DetectedLanguage != null)
							tbTranslatorDetectedLang.Text = response.DetectedLanguage.Language.ToString();
						rtbTranslatorOutput.Text = response.Texts[0];
					}
				}
				catch (Exception ex)
				{
					tbTranslatorDetectedLang.Text = "";
					rtbTranslatorOutput.Text = ex.ToString();
				}
			}));
		}

		private void UpdateSpellerResult()
		{
			Invoke(new Action(() =>
			{
				try
				{
					rtbSpellerOutput.Clear();
					SpellerOptions options = 0;
					if (cbIgnoreUppercase.Checked)
						options |= SpellerOptions.IgnoreUppercase;
					if (cbIgnoreDigits.Checked)
						options |= SpellerOptions.IgnoreDigits;
					if (cbIgnoreUrls.Checked)
						options |= SpellerOptions.IgnoreUrls;
					if (cbFindRepeatWords.Checked)
						options |= SpellerOptions.FindRepeatWords;
					if (cbIgnoreLatin.Checked)
						options |= SpellerOptions.IgnoreLatin;
					if (cbNoSuggest.Checked)
						options |= SpellerOptions.NoSuggest;
					if (cbFlagLatin.Checked)
						options |= SpellerOptions.FlagLatin;
					if (cbByWords.Checked)
						options |= SpellerOptions.ByWords;
					if (cbIgnoreCapitalization.Checked)
						options |= SpellerOptions.IgnoreCapitalization;

					List<Language> langs = new List<Language>();
					if (cbSpellerRu.Checked)
						langs.Add(Language.Ru);
					if (cbSpellerEn.Checked)
						langs.Add(Language.En);
					if (cbSpellerUk.Checked)
						langs.Add(Language.Uk);

					var errors = _spellerService.CheckTextAsync(tbSpellerInput.Text, langs.ToArray(), options).Result;

					string input = tbSpellerInput.Text;

					if (errors.Count != 0)
					{
						StringBuilder output = new StringBuilder(input.Length);
						int currentErrorNumber = 0;
						int i = 0;
						int lastInd = 0;
						Error currentError = errors[0];
						var highlightedCharPoses = new Dictionary<int, CharMistakeType>();
						while (i < input.Length)
						{
							if (currentError.Column == i)
							{
								output.Append(input.Substring(lastInd, i - lastInd));
								if (currentError.Steers.Count > 0)
								{
									var firstSteer = currentError.Steers[0];
									output.Append(firstSteer);
									var poses = SpellerService.OptimalStringAlignmentDistance(currentError.Word, firstSteer);
									foreach (var pos in poses)
										highlightedCharPoses.Add(
											output.Length - firstSteer.Length + pos.Position,
											pos.Type);
								}
								else if (cbIncludeErrorWords.Checked)
									output.Append(currentError.Word);

								i += currentError.Length;
								currentErrorNumber++;
								if (currentErrorNumber < errors.Count)
									currentError = errors[currentErrorNumber];
								lastInd = i;
							}
							else
								i++;
						}
						output.Append(input.Substring(lastInd, i - lastInd));

						rtbSpellerOutput.Text = output.ToString();
						foreach (var pos in highlightedCharPoses)
						{
							if (pos.Value == CharMistakeType.Substitution)
							{
								rtbSpellerOutput.Select(pos.Key, 1);
								rtbSpellerOutput.SelectionColor = Color.Red;
							}
							else if (pos.Value == CharMistakeType.Deletion)
							{
								if (pos.Key == 0)
									rtbSpellerOutput.Select(0, 1);
								else
									rtbSpellerOutput.Select(pos.Key - 1, 2);
								rtbSpellerOutput.SelectionBackColor = Color.Gold;
							}
							else if (pos.Value == CharMistakeType.Insertion)
							{
								rtbSpellerOutput.Select(pos.Key, 1);
								rtbSpellerOutput.SelectionColor = Color.Blue;
							}
							else if (pos.Value == CharMistakeType.Transposition)
							{
								rtbSpellerOutput.Select(pos.Key, 2);
								rtbSpellerOutput.SelectionBackColor = Color.Violet;
							}
						}
					}
					else
					{
						rtbSpellerOutput.Text = input;
					}
				}
				catch (Exception ex)
				{
					rtbSpellerOutput.Text = ex.ToString();
				}
			}));
		}
	}
}
