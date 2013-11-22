using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Drawing;
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
		System.Threading.Timer timer;

		public frmMain()
		{
			Predictor = new Predictor(ConfigurationManager.AppSettings["PredictorKey"]);
			timer = new System.Threading.Timer(_ => UpdateCompleteSource(), null, Timeout.Infinite, Timeout.Infinite);
			
			InitializeComponent();

			cmbPredictorLangs.Items.AddRange(Predictor.GetLangs().Select(lang => (object)lang).ToArray());
			cmbPredictorLangs.SelectedItem = Enum.Parse(typeof(Lang), Settings.Default.PredictorLanguage);
			nudMaxHintCount.Value = Settings.Default.PredictorMaxHintCount;
			nudDelay.Value = Settings.Default.PredictorHintDelay;
		}

		private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
		{
			Settings.Default.PredictorLanguage = cmbPredictorLangs.SelectedItem.ToString();
			Settings.Default.PredictorMaxHintCount = (int)nudMaxHintCount.Value;
			Settings.Default.PredictorHintDelay = (int)nudDelay.Value;
			Settings.Default.Save();
		}

		private void tbPredictor_TextChanged(object sender, EventArgs e)
		{
			lbHints.Items.Clear();
			timer.Change((int)nudDelay.Value, Timeout.Infinite);
		}

		private void nudMaxHintCount_ValueChanged(object sender, EventArgs e)
		{
			lbHints.Items.Clear();
			timer.Change((int)nudDelay.Value, Timeout.Infinite);
		}

		private void cmbPredictorLangs_SelectedIndexChanged(object sender, EventArgs e)
		{
			lbHints.Items.Clear();
			timer.Change((int)nudDelay.Value, Timeout.Infinite);
		}

		private void UpdateCompleteSource()
		{
			this.Invoke(new Action(() => 
			{
				var response = Predictor.Complete((Lang)cmbPredictorLangs.SelectedItem, tbPredictor.Text, (int)nudMaxHintCount.Value);

				tbHintCount.Text = response.Text.Count.ToString();
				tbPos.Text = response.Pos.ToString();
				tbEndOfWorld.Text = response.EndOfWord.ToString();

				if (response.Text.Count > 0)
				{
					lbHints.Items.AddRange(response.Text.Select(t => (object)t).ToArray());
					lbHints.SelectedIndex = 0;
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
						tbPredictor.Text += ((string)lbHints.SelectedItem).Substring(-pos);
					else
						tbPredictor.Text += new string(' ', pos) + (string)lbHints.SelectedItem;
					tbPredictor.Select(tbPredictor.Text.Length, 0);
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
	}
}
