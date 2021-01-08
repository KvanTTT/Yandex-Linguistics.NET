namespace YandexLinguistics.NET.Gui
{
	partial class frmMain
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tpSpeller = new System.Windows.Forms.TabPage();
			this.tbSpellerBaseUrl = new System.Windows.Forms.TextBox();
			this.rtbSpellerOutput = new System.Windows.Forms.RichTextBox();
			this.tbSpellerInput = new System.Windows.Forms.TextBox();
			this.label35 = new System.Windows.Forms.Label();
			this.label31 = new System.Windows.Forms.Label();
			this.linkLabel4 = new System.Windows.Forms.LinkLabel();
			this.btnSpellerCheck = new System.Windows.Forms.Button();
			this.cbIncludeErrorWords = new System.Windows.Forms.CheckBox();
			this.cbSpellerUk = new System.Windows.Forms.CheckBox();
			this.cbSpellerEn = new System.Windows.Forms.CheckBox();
			this.cbSpellerRu = new System.Windows.Forms.CheckBox();
			this.label24 = new System.Windows.Forms.Label();
			this.nudSpellerDelay = new System.Windows.Forms.NumericUpDown();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cbIgnoreCapitalization = new System.Windows.Forms.CheckBox();
			this.cbByWords = new System.Windows.Forms.CheckBox();
			this.cbFlagLatin = new System.Windows.Forms.CheckBox();
			this.cbNoSuggest = new System.Windows.Forms.CheckBox();
			this.cbIgnoreLatin = new System.Windows.Forms.CheckBox();
			this.cbFindRepeatWords = new System.Windows.Forms.CheckBox();
			this.cbIgnoreUrls = new System.Windows.Forms.CheckBox();
			this.cbIgnoreDigits = new System.Windows.Forms.CheckBox();
			this.cbIgnoreUppercase = new System.Windows.Forms.CheckBox();
			this.label23 = new System.Windows.Forms.Label();
			this.label21 = new System.Windows.Forms.Label();
			this.label22 = new System.Windows.Forms.Label();
			this.tpTranslator = new System.Windows.Forms.TabPage();
			this.tbTranslatorBaseUrl = new System.Windows.Forms.TextBox();
			this.tbTranslatorKey = new System.Windows.Forms.TextBox();
			this.tbTranslatorDetectedLang = new System.Windows.Forms.TextBox();
			this.rtbTranslatorOutput = new System.Windows.Forms.RichTextBox();
			this.tbTranslatorInput = new System.Windows.Forms.TextBox();
			this.label34 = new System.Windows.Forms.Label();
			this.label30 = new System.Windows.Forms.Label();
			this.linkLabel1 = new System.Windows.Forms.LinkLabel();
			this.label26 = new System.Windows.Forms.Label();
			this.btnTranslate = new System.Windows.Forms.Button();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.nudTranslatorDelay = new System.Windows.Forms.NumericUpDown();
			this.cbTranslatorDetectInputLang = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cmbTranslatorOutputLang = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbTranslatorInputLang = new System.Windows.Forms.ComboBox();
			this.tpDictionary = new System.Windows.Forms.TabPage();
			this.tbDictionaryBaseUrl = new System.Windows.Forms.TextBox();
			this.tbDictionaryKey = new System.Windows.Forms.TextBox();
			this.tbDictionaryIndent = new System.Windows.Forms.TextBox();
			this.rbDictionaryOutput = new System.Windows.Forms.RichTextBox();
			this.tbDictionaryInput = new System.Windows.Forms.TextBox();
			this.label33 = new System.Windows.Forms.Label();
			this.label29 = new System.Windows.Forms.Label();
			this.linkLabel3 = new System.Windows.Forms.LinkLabel();
			this.label27 = new System.Windows.Forms.Label();
			this.btnDetermine = new System.Windows.Forms.Button();
			this.label14 = new System.Windows.Forms.Label();
			this.cbDictionaryFormatting = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.nudDictionaryDelay = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbPartOfSpeech = new System.Windows.Forms.CheckBox();
			this.cbFamily = new System.Windows.Forms.CheckBox();
			this.cbMorpho = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbDictionaryLangUi = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbDictionaryLangPairs = new System.Windows.Forms.ComboBox();
			this.tpPredictor = new System.Windows.Forms.TabPage();
			this.tbPredictorBaseUrl = new System.Windows.Forms.TextBox();
			this.tbPredictorKey = new System.Windows.Forms.TextBox();
			this.tbHintCount = new System.Windows.Forms.TextBox();
			this.tbEndOfWorld = new System.Windows.Forms.TextBox();
			this.tbPos = new System.Windows.Forms.TextBox();
			this.tbPredictorInput = new System.Windows.Forms.TextBox();
			this.label32 = new System.Windows.Forms.Label();
			this.label28 = new System.Windows.Forms.Label();
			this.linkLabel2 = new System.Windows.Forms.LinkLabel();
			this.label25 = new System.Windows.Forms.Label();
			this.btnPredict = new System.Windows.Forms.Button();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nudPredictorDelay = new System.Windows.Forms.NumericUpDown();
			this.lbHints = new System.Windows.Forms.ListBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nudMaxHintCount = new System.Windows.Forms.NumericUpDown();
			this.cmbPredictorLangs = new System.Windows.Forms.ComboBox();
			this.tcServices = new System.Windows.Forms.TabControl();
			this.tpSpeller.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudSpellerDelay)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.tpTranslator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudTranslatorDelay)).BeginInit();
			this.tpDictionary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudDictionaryDelay)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tpPredictor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudPredictorDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize) (this.nudMaxHintCount)).BeginInit();
			this.tcServices.SuspendLayout();
			this.SuspendLayout();
			// 
			// tpSpeller
			// 
			this.tpSpeller.Controls.Add(this.tbSpellerBaseUrl);
			this.tpSpeller.Controls.Add(this.rtbSpellerOutput);
			this.tpSpeller.Controls.Add(this.tbSpellerInput);
			this.tpSpeller.Controls.Add(this.label35);
			this.tpSpeller.Controls.Add(this.label31);
			this.tpSpeller.Controls.Add(this.linkLabel4);
			this.tpSpeller.Controls.Add(this.btnSpellerCheck);
			this.tpSpeller.Controls.Add(this.cbIncludeErrorWords);
			this.tpSpeller.Controls.Add(this.cbSpellerUk);
			this.tpSpeller.Controls.Add(this.cbSpellerEn);
			this.tpSpeller.Controls.Add(this.cbSpellerRu);
			this.tpSpeller.Controls.Add(this.label24);
			this.tpSpeller.Controls.Add(this.nudSpellerDelay);
			this.tpSpeller.Controls.Add(this.groupBox2);
			this.tpSpeller.Controls.Add(this.label23);
			this.tpSpeller.Controls.Add(this.label21);
			this.tpSpeller.Controls.Add(this.label22);
			this.tpSpeller.Location = new System.Drawing.Point(4, 29);
			this.tpSpeller.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpSpeller.Name = "tpSpeller";
			this.tpSpeller.Size = new System.Drawing.Size(814, 699);
			this.tpSpeller.TabIndex = 3;
			this.tpSpeller.Text = "Speller";
			this.tpSpeller.UseVisualStyleBackColor = true;
			// 
			// tbSpellerBaseUrl
			// 
			this.tbSpellerBaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSpellerBaseUrl.Location = new System.Drawing.Point(136, 20);
			this.tbSpellerBaseUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSpellerBaseUrl.Name = "tbSpellerBaseUrl";
			this.tbSpellerBaseUrl.ReadOnly = true;
			this.tbSpellerBaseUrl.Size = new System.Drawing.Size(660, 26);
			this.tbSpellerBaseUrl.TabIndex = 42;
			this.tbSpellerBaseUrl.Text = "http://speller.yandex.net/services/spellservice.json";
			this.tbSpellerBaseUrl.TextChanged += new System.EventHandler(this.tbSpellerBaseUrl_TextChanged);
			// 
			// rtbSpellerOutput
			// 
			this.rtbSpellerOutput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSpellerOutput.Location = new System.Drawing.Point(136, 418);
			this.rtbSpellerOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbSpellerOutput.Name = "rtbSpellerOutput";
			this.rtbSpellerOutput.ReadOnly = true;
			this.rtbSpellerOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbSpellerOutput.Size = new System.Drawing.Size(660, 184);
			this.rtbSpellerOutput.TabIndex = 28;
			this.rtbSpellerOutput.Text = "";
			// 
			// tbSpellerInput
			// 
			this.tbSpellerInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSpellerInput.Location = new System.Drawing.Point(136, 218);
			this.tbSpellerInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbSpellerInput.Multiline = true;
			this.tbSpellerInput.Name = "tbSpellerInput";
			this.tbSpellerInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbSpellerInput.Size = new System.Drawing.Size(660, 184);
			this.tbSpellerInput.TabIndex = 26;
			this.tbSpellerInput.TextChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			this.tbSpellerInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// label35
			// 
			this.label35.AutoSize = true;
			this.label35.Location = new System.Drawing.Point(12, 25);
			this.label35.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label35.Name = "label35";
			this.label35.Size = new System.Drawing.Size(29, 20);
			this.label35.TabIndex = 41;
			this.label35.Text = "Url";
			// 
			// label31
			// 
			this.label31.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label31.AutoSize = true;
			this.label31.Location = new System.Drawing.Point(12, 654);
			this.label31.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label31.Name = "label31";
			this.label31.Size = new System.Drawing.Size(348, 20);
			this.label31.TabIndex = 40;
			this.label31.Text = "Проверка правописания: «Яндекс.Спеллер»";
			// 
			// linkLabel4
			// 
			this.linkLabel4.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel4.AutoSize = true;
			this.linkLabel4.Location = new System.Drawing.Point(372, 654);
			this.linkLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel4.Name = "linkLabel4";
			this.linkLabel4.Size = new System.Drawing.Size(196, 20);
			this.linkLabel4.TabIndex = 39;
			this.linkLabel4.TabStop = true;
			this.linkLabel4.Text = "http://api.yandex.ru/speller/";
			this.linkLabel4.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// btnSpellerCheck
			// 
			this.btnSpellerCheck.Location = new System.Drawing.Point(136, 614);
			this.btnSpellerCheck.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnSpellerCheck.Name = "btnSpellerCheck";
			this.btnSpellerCheck.Size = new System.Drawing.Size(158, 35);
			this.btnSpellerCheck.TabIndex = 1;
			this.btnSpellerCheck.Text = "Check";
			this.btnSpellerCheck.UseVisualStyleBackColor = true;
			this.btnSpellerCheck.Click += new System.EventHandler(this.btnSpellerCheck_Click);
			// 
			// cbIncludeErrorWords
			// 
			this.cbIncludeErrorWords.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.cbIncludeErrorWords.AutoSize = true;
			this.cbIncludeErrorWords.Location = new System.Drawing.Point(619, 620);
			this.cbIncludeErrorWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbIncludeErrorWords.Name = "cbIncludeErrorWords";
			this.cbIncludeErrorWords.Size = new System.Drawing.Size(176, 24);
			this.cbIncludeErrorWords.TabIndex = 38;
			this.cbIncludeErrorWords.Text = "Include Error Words";
			this.cbIncludeErrorWords.UseVisualStyleBackColor = true;
			// 
			// cbSpellerUk
			// 
			this.cbSpellerUk.AutoSize = true;
			this.cbSpellerUk.Location = new System.Drawing.Point(136, 135);
			this.cbSpellerUk.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbSpellerUk.Name = "cbSpellerUk";
			this.cbSpellerUk.Size = new System.Drawing.Size(55, 24);
			this.cbSpellerUk.TabIndex = 37;
			this.cbSpellerUk.Text = "Uk";
			this.cbSpellerUk.UseVisualStyleBackColor = true;
			this.cbSpellerUk.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbSpellerEn
			// 
			this.cbSpellerEn.AutoSize = true;
			this.cbSpellerEn.Location = new System.Drawing.Point(136, 100);
			this.cbSpellerEn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbSpellerEn.Name = "cbSpellerEn";
			this.cbSpellerEn.Size = new System.Drawing.Size(55, 24);
			this.cbSpellerEn.TabIndex = 36;
			this.cbSpellerEn.Text = "En";
			this.cbSpellerEn.UseVisualStyleBackColor = true;
			this.cbSpellerEn.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbSpellerRu
			// 
			this.cbSpellerRu.AutoSize = true;
			this.cbSpellerRu.Location = new System.Drawing.Point(136, 65);
			this.cbSpellerRu.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbSpellerRu.Name = "cbSpellerRu";
			this.cbSpellerRu.Size = new System.Drawing.Size(56, 24);
			this.cbSpellerRu.TabIndex = 35;
			this.cbSpellerRu.Text = "Ru";
			this.cbSpellerRu.UseVisualStyleBackColor = true;
			this.cbSpellerRu.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(12, 174);
			this.label24.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(82, 20);
			this.label24.TabIndex = 34;
			this.label24.Text = "Hint Delay";
			// 
			// nudSpellerDelay
			// 
			this.nudSpellerDelay.Increment = new decimal(new int[] {10, 0, 0, 0});
			this.nudSpellerDelay.Location = new System.Drawing.Point(136, 171);
			this.nudSpellerDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudSpellerDelay.Maximum = new decimal(new int[] {5000, 0, 0, 0});
			this.nudSpellerDelay.Name = "nudSpellerDelay";
			this.nudSpellerDelay.Size = new System.Drawing.Size(102, 26);
			this.nudSpellerDelay.TabIndex = 33;
			this.nudSpellerDelay.Value = new decimal(new int[] {300, 0, 0, 0});
			this.nudSpellerDelay.ValueChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.cbIgnoreCapitalization);
			this.groupBox2.Controls.Add(this.cbByWords);
			this.groupBox2.Controls.Add(this.cbFlagLatin);
			this.groupBox2.Controls.Add(this.cbNoSuggest);
			this.groupBox2.Controls.Add(this.cbIgnoreLatin);
			this.groupBox2.Controls.Add(this.cbFindRepeatWords);
			this.groupBox2.Controls.Add(this.cbIgnoreUrls);
			this.groupBox2.Controls.Add(this.cbIgnoreDigits);
			this.groupBox2.Controls.Add(this.cbIgnoreUppercase);
			this.groupBox2.Location = new System.Drawing.Point(252, 60);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox2.Size = new System.Drawing.Size(546, 146);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Speller Options";
			// 
			// cbIgnoreCapitalization
			// 
			this.cbIgnoreCapitalization.AutoSize = true;
			this.cbIgnoreCapitalization.Location = new System.Drawing.Point(370, 100);
			this.cbIgnoreCapitalization.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbIgnoreCapitalization.Name = "cbIgnoreCapitalization";
			this.cbIgnoreCapitalization.Size = new System.Drawing.Size(180, 24);
			this.cbIgnoreCapitalization.TabIndex = 8;
			this.cbIgnoreCapitalization.Text = "Ignore Capitalization";
			this.cbIgnoreCapitalization.UseVisualStyleBackColor = true;
			this.cbIgnoreCapitalization.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbByWords
			// 
			this.cbByWords.AutoSize = true;
			this.cbByWords.Location = new System.Drawing.Point(370, 65);
			this.cbByWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbByWords.Name = "cbByWords";
			this.cbByWords.Size = new System.Drawing.Size(103, 24);
			this.cbByWords.TabIndex = 7;
			this.cbByWords.Text = "By Words";
			this.cbByWords.UseVisualStyleBackColor = true;
			this.cbByWords.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbFlagLatin
			// 
			this.cbFlagLatin.AutoSize = true;
			this.cbFlagLatin.Location = new System.Drawing.Point(370, 29);
			this.cbFlagLatin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbFlagLatin.Name = "cbFlagLatin";
			this.cbFlagLatin.Size = new System.Drawing.Size(105, 24);
			this.cbFlagLatin.TabIndex = 6;
			this.cbFlagLatin.Text = "Flag Latin";
			this.cbFlagLatin.UseVisualStyleBackColor = true;
			this.cbFlagLatin.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbNoSuggest
			// 
			this.cbNoSuggest.AutoSize = true;
			this.cbNoSuggest.Location = new System.Drawing.Point(184, 100);
			this.cbNoSuggest.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbNoSuggest.Name = "cbNoSuggest";
			this.cbNoSuggest.Size = new System.Drawing.Size(119, 24);
			this.cbNoSuggest.TabIndex = 5;
			this.cbNoSuggest.Text = "No Suggest";
			this.cbNoSuggest.UseVisualStyleBackColor = true;
			this.cbNoSuggest.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreLatin
			// 
			this.cbIgnoreLatin.AutoSize = true;
			this.cbIgnoreLatin.Location = new System.Drawing.Point(184, 65);
			this.cbIgnoreLatin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbIgnoreLatin.Name = "cbIgnoreLatin";
			this.cbIgnoreLatin.Size = new System.Drawing.Size(120, 24);
			this.cbIgnoreLatin.TabIndex = 4;
			this.cbIgnoreLatin.Text = "Ignore Latin";
			this.cbIgnoreLatin.UseVisualStyleBackColor = true;
			this.cbIgnoreLatin.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbFindRepeatWords
			// 
			this.cbFindRepeatWords.AutoSize = true;
			this.cbFindRepeatWords.Location = new System.Drawing.Point(184, 29);
			this.cbFindRepeatWords.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbFindRepeatWords.Name = "cbFindRepeatWords";
			this.cbFindRepeatWords.Size = new System.Drawing.Size(173, 24);
			this.cbFindRepeatWords.TabIndex = 3;
			this.cbFindRepeatWords.Text = "Find Repeat Words";
			this.cbFindRepeatWords.UseVisualStyleBackColor = true;
			this.cbFindRepeatWords.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreUrls
			// 
			this.cbIgnoreUrls.AutoSize = true;
			this.cbIgnoreUrls.Location = new System.Drawing.Point(9, 100);
			this.cbIgnoreUrls.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbIgnoreUrls.Name = "cbIgnoreUrls";
			this.cbIgnoreUrls.Size = new System.Drawing.Size(113, 24);
			this.cbIgnoreUrls.TabIndex = 2;
			this.cbIgnoreUrls.Text = "Ignore Urls";
			this.cbIgnoreUrls.UseVisualStyleBackColor = true;
			this.cbIgnoreUrls.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreDigits
			// 
			this.cbIgnoreDigits.AutoSize = true;
			this.cbIgnoreDigits.Location = new System.Drawing.Point(9, 65);
			this.cbIgnoreDigits.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbIgnoreDigits.Name = "cbIgnoreDigits";
			this.cbIgnoreDigits.Size = new System.Drawing.Size(125, 24);
			this.cbIgnoreDigits.TabIndex = 1;
			this.cbIgnoreDigits.Text = "Ignore Digits";
			this.cbIgnoreDigits.UseVisualStyleBackColor = true;
			this.cbIgnoreDigits.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreUppercase
			// 
			this.cbIgnoreUppercase.AutoSize = true;
			this.cbIgnoreUppercase.Location = new System.Drawing.Point(9, 29);
			this.cbIgnoreUppercase.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbIgnoreUppercase.Name = "cbIgnoreUppercase";
			this.cbIgnoreUppercase.Size = new System.Drawing.Size(163, 24);
			this.cbIgnoreUppercase.TabIndex = 0;
			this.cbIgnoreUppercase.Text = "Ignore Uppercase";
			this.cbIgnoreUppercase.UseVisualStyleBackColor = true;
			this.cbIgnoreUppercase.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(12, 65);
			this.label23.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(81, 20);
			this.label23.TabIndex = 31;
			this.label23.Text = "Language";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(12, 423);
			this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(113, 20);
			this.label21.TabIndex = 29;
			this.label21.Text = "Corrected Text";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(12, 223);
			this.label22.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(46, 20);
			this.label22.TabIndex = 27;
			this.label22.Text = "Input";
			// 
			// tpTranslator
			// 
			this.tpTranslator.Controls.Add(this.tbTranslatorBaseUrl);
			this.tpTranslator.Controls.Add(this.tbTranslatorKey);
			this.tpTranslator.Controls.Add(this.tbTranslatorDetectedLang);
			this.tpTranslator.Controls.Add(this.rtbTranslatorOutput);
			this.tpTranslator.Controls.Add(this.tbTranslatorInput);
			this.tpTranslator.Controls.Add(this.label34);
			this.tpTranslator.Controls.Add(this.label30);
			this.tpTranslator.Controls.Add(this.linkLabel1);
			this.tpTranslator.Controls.Add(this.label26);
			this.tpTranslator.Controls.Add(this.btnTranslate);
			this.tpTranslator.Controls.Add(this.label20);
			this.tpTranslator.Controls.Add(this.label19);
			this.tpTranslator.Controls.Add(this.nudTranslatorDelay);
			this.tpTranslator.Controls.Add(this.cbTranslatorDetectInputLang);
			this.tpTranslator.Controls.Add(this.label18);
			this.tpTranslator.Controls.Add(this.cmbTranslatorOutputLang);
			this.tpTranslator.Controls.Add(this.label16);
			this.tpTranslator.Controls.Add(this.label17);
			this.tpTranslator.Controls.Add(this.label15);
			this.tpTranslator.Controls.Add(this.cmbTranslatorInputLang);
			this.tpTranslator.Location = new System.Drawing.Point(4, 29);
			this.tpTranslator.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpTranslator.Name = "tpTranslator";
			this.tpTranslator.Size = new System.Drawing.Size(814, 699);
			this.tpTranslator.TabIndex = 2;
			this.tpTranslator.Text = "Translator";
			this.tpTranslator.UseVisualStyleBackColor = true;
			// 
			// tbTranslatorBaseUrl
			// 
			this.tbTranslatorBaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTranslatorBaseUrl.Location = new System.Drawing.Point(124, 20);
			this.tbTranslatorBaseUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbTranslatorBaseUrl.Name = "tbTranslatorBaseUrl";
			this.tbTranslatorBaseUrl.ReadOnly = true;
			this.tbTranslatorBaseUrl.Size = new System.Drawing.Size(656, 26);
			this.tbTranslatorBaseUrl.TabIndex = 39;
			this.tbTranslatorBaseUrl.Text = "https://translate.yandex.net/api/v1.5/tr.json";
			this.tbTranslatorBaseUrl.TextChanged += new System.EventHandler(this.tbTranslatorKey_TextChanged);
			// 
			// tbTranslatorKey
			// 
			this.tbTranslatorKey.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTranslatorKey.Location = new System.Drawing.Point(124, 60);
			this.tbTranslatorKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbTranslatorKey.Name = "tbTranslatorKey";
			this.tbTranslatorKey.Size = new System.Drawing.Size(656, 26);
			this.tbTranslatorKey.TabIndex = 35;
			this.tbTranslatorKey.TextChanged += new System.EventHandler(this.tbTranslatorKey_TextChanged);
			// 
			// tbTranslatorDetectedLang
			// 
			this.tbTranslatorDetectedLang.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTranslatorDetectedLang.Location = new System.Drawing.Point(633, 583);
			this.tbTranslatorDetectedLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbTranslatorDetectedLang.Name = "tbTranslatorDetectedLang";
			this.tbTranslatorDetectedLang.ReadOnly = true;
			this.tbTranslatorDetectedLang.Size = new System.Drawing.Size(148, 26);
			this.tbTranslatorDetectedLang.TabIndex = 32;
			// 
			// rtbTranslatorOutput
			// 
			this.rtbTranslatorOutput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbTranslatorOutput.Location = new System.Drawing.Point(124, 388);
			this.rtbTranslatorOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rtbTranslatorOutput.Name = "rtbTranslatorOutput";
			this.rtbTranslatorOutput.ReadOnly = true;
			this.rtbTranslatorOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbTranslatorOutput.Size = new System.Drawing.Size(656, 184);
			this.rtbTranslatorOutput.TabIndex = 24;
			this.rtbTranslatorOutput.Text = "";
			// 
			// tbTranslatorInput
			// 
			this.tbTranslatorInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTranslatorInput.Location = new System.Drawing.Point(124, 188);
			this.tbTranslatorInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbTranslatorInput.Multiline = true;
			this.tbTranslatorInput.Name = "tbTranslatorInput";
			this.tbTranslatorInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbTranslatorInput.Size = new System.Drawing.Size(656, 184);
			this.tbTranslatorInput.TabIndex = 22;
			this.tbTranslatorInput.TextChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			this.tbTranslatorInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
			// 
			// label34
			// 
			this.label34.AutoSize = true;
			this.label34.Location = new System.Drawing.Point(15, 25);
			this.label34.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label34.Name = "label34";
			this.label34.Size = new System.Drawing.Size(29, 20);
			this.label34.TabIndex = 38;
			this.label34.Text = "Url";
			// 
			// label30
			// 
			this.label30.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label30.AutoSize = true;
			this.label30.Location = new System.Drawing.Point(12, 654);
			this.label30.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label30.Name = "label30";
			this.label30.Size = new System.Drawing.Size(331, 20);
			this.label30.TabIndex = 37;
			this.label30.Text = "Переведено сервисом «Яндекс.Перевод»";
			// 
			// linkLabel1
			// 
			this.linkLabel1.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Location = new System.Drawing.Point(354, 654);
			this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new System.Drawing.Size(187, 20);
			this.linkLabel1.TabIndex = 36;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "http://translate.yandex.ru/";
			this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// label26
			// 
			this.label26.AutoSize = true;
			this.label26.Location = new System.Drawing.Point(15, 65);
			this.label26.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label26.Name = "label26";
			this.label26.Size = new System.Drawing.Size(35, 20);
			this.label26.TabIndex = 34;
			this.label26.Text = "Key";
			// 
			// btnTranslate
			// 
			this.btnTranslate.Location = new System.Drawing.Point(124, 583);
			this.btnTranslate.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnTranslate.Name = "btnTranslate";
			this.btnTranslate.Size = new System.Drawing.Size(158, 35);
			this.btnTranslate.TabIndex = 33;
			this.btnTranslate.Text = "Translate";
			this.btnTranslate.UseVisualStyleBackColor = true;
			this.btnTranslate.Click += new System.EventHandler(this.btnTranslate_Click);
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(466, 588);
			this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(156, 20);
			this.label20.TabIndex = 31;
			this.label20.Text = "Detected Input Lang";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(540, 106);
			this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(82, 20);
			this.label19.TabIndex = 30;
			this.label19.Text = "Hint Delay";
			// 
			// nudTranslatorDelay
			// 
			this.nudTranslatorDelay.Increment = new decimal(new int[] {10, 0, 0, 0});
			this.nudTranslatorDelay.Location = new System.Drawing.Point(633, 102);
			this.nudTranslatorDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudTranslatorDelay.Maximum = new decimal(new int[] {5000, 0, 0, 0});
			this.nudTranslatorDelay.Name = "nudTranslatorDelay";
			this.nudTranslatorDelay.Size = new System.Drawing.Size(102, 26);
			this.nudTranslatorDelay.TabIndex = 29;
			this.nudTranslatorDelay.Value = new decimal(new int[] {300, 0, 0, 0});
			this.nudTranslatorDelay.ValueChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// cbTranslatorDetectInputLang
			// 
			this.cbTranslatorDetectInputLang.AutoSize = true;
			this.cbTranslatorDetectInputLang.Location = new System.Drawing.Point(544, 142);
			this.cbTranslatorDetectInputLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbTranslatorDetectInputLang.Name = "cbTranslatorDetectInputLang";
			this.cbTranslatorDetectInputLang.Size = new System.Drawing.Size(164, 24);
			this.cbTranslatorDetectInputLang.TabIndex = 28;
			this.cbTranslatorDetectInputLang.Text = "Detect Input Lang";
			this.cbTranslatorDetectInputLang.UseVisualStyleBackColor = true;
			this.cbTranslatorDetectInputLang.CheckedChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(262, 106);
			this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(98, 20);
			this.label18.TabIndex = 27;
			this.label18.Text = "Output Lang";
			// 
			// cmbTranslatorOutputLang
			// 
			this.cmbTranslatorOutputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTranslatorOutputLang.FormattingEnabled = true;
			this.cmbTranslatorOutputLang.Location = new System.Drawing.Point(370, 100);
			this.cmbTranslatorOutputLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbTranslatorOutputLang.Name = "cmbTranslatorOutputLang";
			this.cmbTranslatorOutputLang.Size = new System.Drawing.Size(108, 28);
			this.cmbTranslatorOutputLang.TabIndex = 26;
			this.cmbTranslatorOutputLang.SelectedValueChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(14, 392);
			this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(55, 20);
			this.label16.TabIndex = 25;
			this.label16.Text = "Result";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(14, 192);
			this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(46, 20);
			this.label17.TabIndex = 23;
			this.label17.Text = "Input";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(14, 105);
			this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(86, 20);
			this.label15.TabIndex = 7;
			this.label15.Text = "Input Lang";
			// 
			// cmbTranslatorInputLang
			// 
			this.cmbTranslatorInputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTranslatorInputLang.FormattingEnabled = true;
			this.cmbTranslatorInputLang.Location = new System.Drawing.Point(124, 100);
			this.cmbTranslatorInputLang.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbTranslatorInputLang.Name = "cmbTranslatorInputLang";
			this.cmbTranslatorInputLang.Size = new System.Drawing.Size(108, 28);
			this.cmbTranslatorInputLang.TabIndex = 6;
			this.cmbTranslatorInputLang.SelectedValueChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// tpDictionary
			// 
			this.tpDictionary.Controls.Add(this.tbDictionaryBaseUrl);
			this.tpDictionary.Controls.Add(this.tbDictionaryKey);
			this.tpDictionary.Controls.Add(this.tbDictionaryIndent);
			this.tpDictionary.Controls.Add(this.rbDictionaryOutput);
			this.tpDictionary.Controls.Add(this.tbDictionaryInput);
			this.tpDictionary.Controls.Add(this.label33);
			this.tpDictionary.Controls.Add(this.label29);
			this.tpDictionary.Controls.Add(this.linkLabel3);
			this.tpDictionary.Controls.Add(this.label27);
			this.tpDictionary.Controls.Add(this.btnDetermine);
			this.tpDictionary.Controls.Add(this.label14);
			this.tpDictionary.Controls.Add(this.cbDictionaryFormatting);
			this.tpDictionary.Controls.Add(this.label13);
			this.tpDictionary.Controls.Add(this.label12);
			this.tpDictionary.Controls.Add(this.nudDictionaryDelay);
			this.tpDictionary.Controls.Add(this.groupBox1);
			this.tpDictionary.Controls.Add(this.label10);
			this.tpDictionary.Controls.Add(this.cmbDictionaryLangUi);
			this.tpDictionary.Controls.Add(this.label9);
			this.tpDictionary.Controls.Add(this.label8);
			this.tpDictionary.Controls.Add(this.cmbDictionaryLangPairs);
			this.tpDictionary.Location = new System.Drawing.Point(4, 29);
			this.tpDictionary.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpDictionary.Name = "tpDictionary";
			this.tpDictionary.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpDictionary.Size = new System.Drawing.Size(814, 699);
			this.tpDictionary.TabIndex = 1;
			this.tpDictionary.Text = "Dictionary";
			this.tpDictionary.UseVisualStyleBackColor = true;
			// 
			// tbDictionaryBaseUrl
			// 
			this.tbDictionaryBaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDictionaryBaseUrl.Location = new System.Drawing.Point(142, 9);
			this.tbDictionaryBaseUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDictionaryBaseUrl.Name = "tbDictionaryBaseUrl";
			this.tbDictionaryBaseUrl.ReadOnly = true;
			this.tbDictionaryBaseUrl.Size = new System.Drawing.Size(654, 26);
			this.tbDictionaryBaseUrl.TabIndex = 31;
			this.tbDictionaryBaseUrl.Text = "https://dictionary.yandex.net/api/v1/dicservice.json";
			this.tbDictionaryBaseUrl.TextChanged += new System.EventHandler(this.tbDictionaryKey_TextChanged);
			// 
			// tbDictionaryKey
			// 
			this.tbDictionaryKey.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDictionaryKey.Location = new System.Drawing.Point(142, 49);
			this.tbDictionaryKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDictionaryKey.Name = "tbDictionaryKey";
			this.tbDictionaryKey.Size = new System.Drawing.Size(656, 26);
			this.tbDictionaryKey.TabIndex = 27;
			this.tbDictionaryKey.TextChanged += new System.EventHandler(this.tbDictionaryKey_TextChanged);
			// 
			// tbDictionaryIndent
			// 
			this.tbDictionaryIndent.Location = new System.Drawing.Point(658, 135);
			this.tbDictionaryIndent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDictionaryIndent.Name = "tbDictionaryIndent";
			this.tbDictionaryIndent.Size = new System.Drawing.Size(100, 26);
			this.tbDictionaryIndent.TabIndex = 24;
			this.tbDictionaryIndent.Text = "    ";
			this.tbDictionaryIndent.TextChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// rbDictionaryOutput
			// 
			this.rbDictionaryOutput.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.rbDictionaryOutput.Location = new System.Drawing.Point(142, 275);
			this.rbDictionaryOutput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.rbDictionaryOutput.Name = "rbDictionaryOutput";
			this.rbDictionaryOutput.ReadOnly = true;
			this.rbDictionaryOutput.Size = new System.Drawing.Size(656, 299);
			this.rbDictionaryOutput.TabIndex = 20;
			this.rbDictionaryOutput.Text = "";
			// 
			// tbDictionaryInput
			// 
			this.tbDictionaryInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDictionaryInput.Location = new System.Drawing.Point(142, 235);
			this.tbDictionaryInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbDictionaryInput.Name = "tbDictionaryInput";
			this.tbDictionaryInput.Size = new System.Drawing.Size(656, 26);
			this.tbDictionaryInput.TabIndex = 10;
			this.tbDictionaryInput.TextChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label33
			// 
			this.label33.AutoSize = true;
			this.label33.Location = new System.Drawing.Point(20, 14);
			this.label33.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label33.Name = "label33";
			this.label33.Size = new System.Drawing.Size(29, 20);
			this.label33.TabIndex = 30;
			this.label33.Text = "Url";
			// 
			// label29
			// 
			this.label29.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label29.AutoSize = true;
			this.label29.Location = new System.Drawing.Point(9, 654);
			this.label29.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label29.Name = "label29";
			this.label29.Size = new System.Drawing.Size(441, 20);
			this.label29.TabIndex = 29;
			this.label29.Text = "Реализовано с помощью сервиса API «Яндекс.Словарь»";
			// 
			// linkLabel3
			// 
			this.linkLabel3.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel3.AutoSize = true;
			this.linkLabel3.Location = new System.Drawing.Point(476, 654);
			this.linkLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel3.Name = "linkLabel3";
			this.linkLabel3.Size = new System.Drawing.Size(217, 20);
			this.linkLabel3.TabIndex = 28;
			this.linkLabel3.TabStop = true;
			this.linkLabel3.Text = "http://api.yandex.ru/dictionary/";
			this.linkLabel3.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// label27
			// 
			this.label27.AutoSize = true;
			this.label27.Location = new System.Drawing.Point(20, 54);
			this.label27.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label27.Name = "label27";
			this.label27.Size = new System.Drawing.Size(35, 20);
			this.label27.TabIndex = 26;
			this.label27.Text = "Key";
			// 
			// btnDetermine
			// 
			this.btnDetermine.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.btnDetermine.Location = new System.Drawing.Point(142, 586);
			this.btnDetermine.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnDetermine.Name = "btnDetermine";
			this.btnDetermine.Size = new System.Drawing.Size(158, 35);
			this.btnDetermine.TabIndex = 25;
			this.btnDetermine.Text = "Determine";
			this.btnDetermine.UseVisualStyleBackColor = true;
			this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(530, 140);
			this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(55, 20);
			this.label14.TabIndex = 23;
			this.label14.Text = "Indent";
			// 
			// cbDictionaryFormatting
			// 
			this.cbDictionaryFormatting.AutoSize = true;
			this.cbDictionaryFormatting.Location = new System.Drawing.Point(537, 183);
			this.cbDictionaryFormatting.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbDictionaryFormatting.Name = "cbDictionaryFormatting";
			this.cbDictionaryFormatting.Size = new System.Drawing.Size(112, 24);
			this.cbDictionaryFormatting.TabIndex = 22;
			this.cbDictionaryFormatting.Text = "Formatting";
			this.cbDictionaryFormatting.UseVisualStyleBackColor = true;
			this.cbDictionaryFormatting.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(20, 280);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(55, 20);
			this.label13.TabIndex = 21;
			this.label13.Text = "Result";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(530, 98);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(82, 20);
			this.label12.TabIndex = 19;
			this.label12.Text = "Hint Delay";
			// 
			// nudDictionaryDelay
			// 
			this.nudDictionaryDelay.Increment = new decimal(new int[] {10, 0, 0, 0});
			this.nudDictionaryDelay.Location = new System.Drawing.Point(658, 95);
			this.nudDictionaryDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudDictionaryDelay.Maximum = new decimal(new int[] {5000, 0, 0, 0});
			this.nudDictionaryDelay.Name = "nudDictionaryDelay";
			this.nudDictionaryDelay.Size = new System.Drawing.Size(102, 26);
			this.nudDictionaryDelay.TabIndex = 18;
			this.nudDictionaryDelay.Value = new decimal(new int[] {300, 0, 0, 0});
			this.nudDictionaryDelay.ValueChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbPartOfSpeech);
			this.groupBox1.Controls.Add(this.cbFamily);
			this.groupBox1.Controls.Add(this.cbMorpho);
			this.groupBox1.Location = new System.Drawing.Point(286, 89);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.groupBox1.Size = new System.Drawing.Size(216, 137);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lookup Options";
			// 
			// cbPartOfSpeech
			// 
			this.cbPartOfSpeech.AutoSize = true;
			this.cbPartOfSpeech.Location = new System.Drawing.Point(9, 100);
			this.cbPartOfSpeech.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbPartOfSpeech.Name = "cbPartOfSpeech";
			this.cbPartOfSpeech.Size = new System.Drawing.Size(180, 24);
			this.cbPartOfSpeech.TabIndex = 16;
			this.cbPartOfSpeech.Text = "Part of Speech Filter";
			this.cbPartOfSpeech.UseVisualStyleBackColor = true;
			this.cbPartOfSpeech.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// cbFamily
			// 
			this.cbFamily.AutoSize = true;
			this.cbFamily.Location = new System.Drawing.Point(9, 29);
			this.cbFamily.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbFamily.Name = "cbFamily";
			this.cbFamily.Size = new System.Drawing.Size(80, 24);
			this.cbFamily.TabIndex = 14;
			this.cbFamily.Text = "Family";
			this.cbFamily.UseVisualStyleBackColor = true;
			this.cbFamily.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// cbMorpho
			// 
			this.cbMorpho.AutoSize = true;
			this.cbMorpho.Location = new System.Drawing.Point(9, 65);
			this.cbMorpho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cbMorpho.Name = "cbMorpho";
			this.cbMorpho.Size = new System.Drawing.Size(89, 24);
			this.cbMorpho.TabIndex = 15;
			this.cbMorpho.Text = "Morpho";
			this.cbMorpho.UseVisualStyleBackColor = true;
			this.cbMorpho.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(20, 135);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(102, 20);
			this.label10.TabIndex = 13;
			this.label10.Text = "Language UI";
			// 
			// cmbDictionaryLangUi
			// 
			this.cmbDictionaryLangUi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDictionaryLangUi.FormattingEnabled = true;
			this.cmbDictionaryLangUi.Location = new System.Drawing.Point(142, 131);
			this.cmbDictionaryLangUi.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbDictionaryLangUi.Name = "cmbDictionaryLangUi";
			this.cmbDictionaryLangUi.Size = new System.Drawing.Size(106, 28);
			this.cmbDictionaryLangUi.TabIndex = 12;
			this.cmbDictionaryLangUi.SelectedIndexChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(20, 240);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(46, 20);
			this.label9.TabIndex = 11;
			this.label9.Text = "Input";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(20, 94);
			this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(112, 20);
			this.label8.TabIndex = 5;
			this.label8.Text = "Language Pair";
			// 
			// cmbDictionaryLangPairs
			// 
			this.cmbDictionaryLangPairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDictionaryLangPairs.FormattingEnabled = true;
			this.cmbDictionaryLangPairs.Location = new System.Drawing.Point(142, 89);
			this.cmbDictionaryLangPairs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbDictionaryLangPairs.Name = "cmbDictionaryLangPairs";
			this.cmbDictionaryLangPairs.Size = new System.Drawing.Size(106, 28);
			this.cmbDictionaryLangPairs.TabIndex = 4;
			this.cmbDictionaryLangPairs.SelectedIndexChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// tpPredictor
			// 
			this.tpPredictor.Controls.Add(this.tbPredictorBaseUrl);
			this.tpPredictor.Controls.Add(this.tbPredictorKey);
			this.tpPredictor.Controls.Add(this.tbHintCount);
			this.tpPredictor.Controls.Add(this.tbEndOfWorld);
			this.tpPredictor.Controls.Add(this.tbPos);
			this.tpPredictor.Controls.Add(this.tbPredictorInput);
			this.tpPredictor.Controls.Add(this.label32);
			this.tpPredictor.Controls.Add(this.label28);
			this.tpPredictor.Controls.Add(this.linkLabel2);
			this.tpPredictor.Controls.Add(this.label25);
			this.tpPredictor.Controls.Add(this.btnPredict);
			this.tpPredictor.Controls.Add(this.label11);
			this.tpPredictor.Controls.Add(this.label6);
			this.tpPredictor.Controls.Add(this.nudPredictorDelay);
			this.tpPredictor.Controls.Add(this.lbHints);
			this.tpPredictor.Controls.Add(this.label7);
			this.tpPredictor.Controls.Add(this.label5);
			this.tpPredictor.Controls.Add(this.label4);
			this.tpPredictor.Controls.Add(this.label3);
			this.tpPredictor.Controls.Add(this.label2);
			this.tpPredictor.Controls.Add(this.label1);
			this.tpPredictor.Controls.Add(this.nudMaxHintCount);
			this.tpPredictor.Controls.Add(this.cmbPredictorLangs);
			this.tpPredictor.Location = new System.Drawing.Point(4, 29);
			this.tpPredictor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpPredictor.Name = "tpPredictor";
			this.tpPredictor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tpPredictor.Size = new System.Drawing.Size(814, 699);
			this.tpPredictor.TabIndex = 0;
			this.tpPredictor.Text = "Predictor";
			this.tpPredictor.UseVisualStyleBackColor = true;
			// 
			// tbPredictorBaseUrl
			// 
			this.tbPredictorBaseUrl.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPredictorBaseUrl.Location = new System.Drawing.Point(105, 9);
			this.tbPredictorBaseUrl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbPredictorBaseUrl.Name = "tbPredictorBaseUrl";
			this.tbPredictorBaseUrl.ReadOnly = true;
			this.tbPredictorBaseUrl.Size = new System.Drawing.Size(694, 26);
			this.tbPredictorBaseUrl.TabIndex = 24;
			this.tbPredictorBaseUrl.Text = "https://predictor.yandex.net/api/v1/predict.json";
			this.tbPredictorBaseUrl.TextChanged += new System.EventHandler(this.tbPredictorKey_TextChanged);
			// 
			// tbPredictorKey
			// 
			this.tbPredictorKey.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPredictorKey.Location = new System.Drawing.Point(105, 49);
			this.tbPredictorKey.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbPredictorKey.Name = "tbPredictorKey";
			this.tbPredictorKey.Size = new System.Drawing.Size(694, 26);
			this.tbPredictorKey.TabIndex = 20;
			this.tbPredictorKey.TextChanged += new System.EventHandler(this.tbPredictorKey_TextChanged);
			// 
			// tbHintCount
			// 
			this.tbHintCount.Location = new System.Drawing.Point(645, 345);
			this.tbHintCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbHintCount.Name = "tbHintCount";
			this.tbHintCount.ReadOnly = true;
			this.tbHintCount.Size = new System.Drawing.Size(91, 26);
			this.tbHintCount.TabIndex = 13;
			// 
			// tbEndOfWorld
			// 
			this.tbEndOfWorld.Location = new System.Drawing.Point(645, 305);
			this.tbEndOfWorld.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbEndOfWorld.Name = "tbEndOfWorld";
			this.tbEndOfWorld.ReadOnly = true;
			this.tbEndOfWorld.Size = new System.Drawing.Size(91, 26);
			this.tbEndOfWorld.TabIndex = 8;
			// 
			// tbPos
			// 
			this.tbPos.Location = new System.Drawing.Point(645, 265);
			this.tbPos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbPos.Name = "tbPos";
			this.tbPos.ReadOnly = true;
			this.tbPos.Size = new System.Drawing.Size(91, 26);
			this.tbPos.TabIndex = 6;
			// 
			// tbPredictorInput
			// 
			this.tbPredictorInput.Anchor = ((System.Windows.Forms.AnchorStyles) (((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPredictorInput.Location = new System.Drawing.Point(105, 195);
			this.tbPredictorInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tbPredictorInput.Name = "tbPredictorInput";
			this.tbPredictorInput.Size = new System.Drawing.Size(694, 26);
			this.tbPredictorInput.TabIndex = 0;
			this.tbPredictorInput.TextChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			this.tbPredictorInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPredictor_KeyDown);
			// 
			// label32
			// 
			this.label32.AutoSize = true;
			this.label32.Location = new System.Drawing.Point(14, 14);
			this.label32.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label32.Name = "label32";
			this.label32.Size = new System.Drawing.Size(29, 20);
			this.label32.TabIndex = 23;
			this.label32.Text = "Url";
			// 
			// label28
			// 
			this.label28.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.label28.AutoSize = true;
			this.label28.Location = new System.Drawing.Point(9, 654);
			this.label28.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label28.Name = "label28";
			this.label28.Size = new System.Drawing.Size(430, 20);
			this.label28.TabIndex = 22;
			this.label28.Text = "Реализовано с помощью сервиса «Яндекс.Предиктор»";
			// 
			// linkLabel2
			// 
			this.linkLabel2.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
			this.linkLabel2.AutoSize = true;
			this.linkLabel2.Location = new System.Drawing.Point(454, 654);
			this.linkLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel2.Name = "linkLabel2";
			this.linkLabel2.Size = new System.Drawing.Size(212, 20);
			this.linkLabel2.TabIndex = 21;
			this.linkLabel2.TabStop = true;
			this.linkLabel2.Text = "http://api.yandex.ru/predictor/";
			this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_LinkClicked);
			// 
			// label25
			// 
			this.label25.AutoSize = true;
			this.label25.Location = new System.Drawing.Point(14, 54);
			this.label25.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label25.Name = "label25";
			this.label25.Size = new System.Drawing.Size(35, 20);
			this.label25.TabIndex = 19;
			this.label25.Text = "Key";
			// 
			// btnPredict
			// 
			this.btnPredict.Location = new System.Drawing.Point(105, 466);
			this.btnPredict.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.btnPredict.Name = "btnPredict";
			this.btnPredict.Size = new System.Drawing.Size(158, 35);
			this.btnPredict.TabIndex = 18;
			this.btnPredict.Text = "Predict";
			this.btnPredict.UseVisualStyleBackColor = true;
			this.btnPredict.Click += new System.EventHandler(this.btnPredict_Click);
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(14, 251);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(46, 20);
			this.label11.TabIndex = 17;
			this.label11.Text = "Hints";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(350, 142);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(82, 20);
			this.label6.TabIndex = 16;
			this.label6.Text = "Hint Delay";
			// 
			// nudPredictorDelay
			// 
			this.nudPredictorDelay.Increment = new decimal(new int[] {10, 0, 0, 0});
			this.nudPredictorDelay.Location = new System.Drawing.Point(478, 137);
			this.nudPredictorDelay.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudPredictorDelay.Maximum = new decimal(new int[] {5000, 0, 0, 0});
			this.nudPredictorDelay.Name = "nudPredictorDelay";
			this.nudPredictorDelay.Size = new System.Drawing.Size(102, 26);
			this.nudPredictorDelay.TabIndex = 15;
			this.nudPredictorDelay.Value = new decimal(new int[] {300, 0, 0, 0});
			this.nudPredictorDelay.ValueChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			// 
			// lbHints
			// 
			this.lbHints.FormattingEnabled = true;
			this.lbHints.ItemHeight = 20;
			this.lbHints.Location = new System.Drawing.Point(105, 251);
			this.lbHints.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.lbHints.Name = "lbHints";
			this.lbHints.Size = new System.Drawing.Size(388, 204);
			this.lbHints.TabIndex = 14;
			this.lbHints.DoubleClick += new System.EventHandler(this.lbHints_DoubleClick);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(516, 349);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 20);
			this.label7.TabIndex = 12;
			this.label7.Text = "Hint count:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(14, 200);
			this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(46, 20);
			this.label5.TabIndex = 9;
			this.label5.Text = "Input";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(516, 309);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(105, 20);
			this.label4.TabIndex = 7;
			this.label4.Text = "End of World:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(516, 269);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(40, 20);
			this.label3.TabIndex = 5;
			this.label3.Text = "Pos:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(350, 102);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(118, 20);
			this.label2.TabIndex = 4;
			this.label2.Text = "Max Hint Count";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(14, 97);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(81, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Language";
			// 
			// nudMaxHintCount
			// 
			this.nudMaxHintCount.Location = new System.Drawing.Point(478, 97);
			this.nudMaxHintCount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.nudMaxHintCount.Maximum = new decimal(new int[] {20, 0, 0, 0});
			this.nudMaxHintCount.Minimum = new decimal(new int[] {1, 0, 0, 0});
			this.nudMaxHintCount.Name = "nudMaxHintCount";
			this.nudMaxHintCount.Size = new System.Drawing.Size(102, 26);
			this.nudMaxHintCount.TabIndex = 2;
			this.nudMaxHintCount.Value = new decimal(new int[] {3, 0, 0, 0});
			this.nudMaxHintCount.ValueChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			// 
			// cmbPredictorLangs
			// 
			this.cmbPredictorLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPredictorLangs.FormattingEnabled = true;
			this.cmbPredictorLangs.Location = new System.Drawing.Point(105, 92);
			this.cmbPredictorLangs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.cmbPredictorLangs.Name = "cmbPredictorLangs";
			this.cmbPredictorLangs.Size = new System.Drawing.Size(97, 28);
			this.cmbPredictorLangs.TabIndex = 1;
			this.cmbPredictorLangs.SelectedIndexChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			// 
			// tcServices
			// 
			this.tcServices.Controls.Add(this.tpPredictor);
			this.tcServices.Controls.Add(this.tpDictionary);
			this.tcServices.Controls.Add(this.tpTranslator);
			this.tcServices.Controls.Add(this.tpSpeller);
			this.tcServices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcServices.Location = new System.Drawing.Point(0, 0);
			this.tcServices.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.tcServices.Name = "tcServices";
			this.tcServices.SelectedIndex = 0;
			this.tcServices.Size = new System.Drawing.Size(822, 732);
			this.tcServices.TabIndex = 0;
			this.tcServices.SelectedIndexChanged += new System.EventHandler(this.tcServices_SelectedIndexChanged);
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 732);
			this.Controls.Add(this.tcServices);
			this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
			this.Name = "frmMain";
			this.Text = "Yandex Linguistics";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.Load += new System.EventHandler(this.frmMain_Load);
			this.tpSpeller.ResumeLayout(false);
			this.tpSpeller.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudSpellerDelay)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.tpTranslator.ResumeLayout(false);
			this.tpTranslator.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudTranslatorDelay)).EndInit();
			this.tpDictionary.ResumeLayout(false);
			this.tpDictionary.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudDictionaryDelay)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tpPredictor.ResumeLayout(false);
			this.tpPredictor.PerformLayout();
			((System.ComponentModel.ISupportInitialize) (this.nudPredictorDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize) (this.nudMaxHintCount)).EndInit();
			this.tcServices.ResumeLayout(false);
			this.ResumeLayout(false);
		}

		private System.Windows.Forms.Button btnDetermine;
		private System.Windows.Forms.Button btnPredict;
		private System.Windows.Forms.Button btnSpellerCheck;
		private System.Windows.Forms.Button btnTranslate;
		private System.Windows.Forms.CheckBox cbByWords;
		private System.Windows.Forms.CheckBox cbDictionaryFormatting;
		private System.Windows.Forms.CheckBox cbFamily;
		private System.Windows.Forms.CheckBox cbFindRepeatWords;
		private System.Windows.Forms.CheckBox cbFlagLatin;
		private System.Windows.Forms.CheckBox cbIgnoreCapitalization;
		private System.Windows.Forms.CheckBox cbIgnoreDigits;
		private System.Windows.Forms.CheckBox cbIgnoreLatin;
		private System.Windows.Forms.CheckBox cbIgnoreUppercase;
		private System.Windows.Forms.CheckBox cbIgnoreUrls;
		private System.Windows.Forms.CheckBox cbIncludeErrorWords;
		private System.Windows.Forms.CheckBox cbMorpho;
		private System.Windows.Forms.CheckBox cbNoSuggest;
		private System.Windows.Forms.CheckBox cbPartOfSpeech;
		private System.Windows.Forms.CheckBox cbSpellerEn;
		private System.Windows.Forms.CheckBox cbSpellerRu;
		private System.Windows.Forms.CheckBox cbSpellerUk;
		private System.Windows.Forms.CheckBox cbTranslatorDetectInputLang;
		private System.Windows.Forms.ComboBox cmbDictionaryLangPairs;
		private System.Windows.Forms.ComboBox cmbDictionaryLangUi;
		private System.Windows.Forms.ComboBox cmbPredictorLangs;
		private System.Windows.Forms.ComboBox cmbTranslatorInputLang;
		private System.Windows.Forms.ComboBox cmbTranslatorOutputLang;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.Label label25;
		private System.Windows.Forms.Label label26;
		private System.Windows.Forms.Label label27;
		private System.Windows.Forms.Label label28;
		private System.Windows.Forms.Label label29;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label30;
		private System.Windows.Forms.Label label31;
		private System.Windows.Forms.Label label32;
		private System.Windows.Forms.Label label33;
		private System.Windows.Forms.Label label34;
		private System.Windows.Forms.Label label35;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.ListBox lbHints;
		private System.Windows.Forms.LinkLabel linkLabel1;
		private System.Windows.Forms.LinkLabel linkLabel2;
		private System.Windows.Forms.LinkLabel linkLabel3;
		private System.Windows.Forms.LinkLabel linkLabel4;
		private System.Windows.Forms.NumericUpDown nudDictionaryDelay;
		private System.Windows.Forms.NumericUpDown nudMaxHintCount;
		private System.Windows.Forms.NumericUpDown nudPredictorDelay;
		private System.Windows.Forms.NumericUpDown nudSpellerDelay;
		private System.Windows.Forms.NumericUpDown nudTranslatorDelay;
		private System.Windows.Forms.RichTextBox rbDictionaryOutput;
		private System.Windows.Forms.RichTextBox rtbSpellerOutput;
		private System.Windows.Forms.RichTextBox rtbTranslatorOutput;
		private System.Windows.Forms.TextBox tbDictionaryBaseUrl;
		private System.Windows.Forms.TextBox tbDictionaryIndent;
		private System.Windows.Forms.TextBox tbDictionaryInput;
		private System.Windows.Forms.TextBox tbDictionaryKey;
		private System.Windows.Forms.TextBox tbEndOfWorld;
		private System.Windows.Forms.TextBox tbHintCount;
		private System.Windows.Forms.TextBox tbPos;
		private System.Windows.Forms.TextBox tbPredictorBaseUrl;
		private System.Windows.Forms.TextBox tbPredictorInput;
		private System.Windows.Forms.TextBox tbPredictorKey;
		private System.Windows.Forms.TextBox tbSpellerBaseUrl;
		private System.Windows.Forms.TextBox tbSpellerInput;
		private System.Windows.Forms.TextBox tbTranslatorBaseUrl;
		private System.Windows.Forms.TextBox tbTranslatorDetectedLang;
		private System.Windows.Forms.TextBox tbTranslatorInput;
		private System.Windows.Forms.TextBox tbTranslatorKey;
		private System.Windows.Forms.TabControl tcServices;
		private System.Windows.Forms.TabPage tpDictionary;
		private System.Windows.Forms.TabPage tpPredictor;
		private System.Windows.Forms.TabPage tpSpeller;
		private System.Windows.Forms.TabPage tpTranslator;

		#endregion
	}
}

