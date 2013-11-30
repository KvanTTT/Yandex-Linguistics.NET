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
			this.tcServices = new System.Windows.Forms.TabControl();
			this.tpPredictor = new System.Windows.Forms.TabPage();
			this.label11 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.nudPredictorDelay = new System.Windows.Forms.NumericUpDown();
			this.lbHints = new System.Windows.Forms.ListBox();
			this.tbHintCount = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbEndOfWorld = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPos = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.nudMaxHintCount = new System.Windows.Forms.NumericUpDown();
			this.cmbPredictorLangs = new System.Windows.Forms.ComboBox();
			this.tbPredictorInput = new System.Windows.Forms.TextBox();
			this.tpDictionary = new System.Windows.Forms.TabPage();
			this.tbDictionaryIndent = new System.Windows.Forms.TextBox();
			this.label14 = new System.Windows.Forms.Label();
			this.cbDictionaryFormatting = new System.Windows.Forms.CheckBox();
			this.label13 = new System.Windows.Forms.Label();
			this.rbDictionaryOutput = new System.Windows.Forms.RichTextBox();
			this.label12 = new System.Windows.Forms.Label();
			this.nudDictionaryDelay = new System.Windows.Forms.NumericUpDown();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.cbPartOfSpeech = new System.Windows.Forms.CheckBox();
			this.cbFamily = new System.Windows.Forms.CheckBox();
			this.cbMorpho = new System.Windows.Forms.CheckBox();
			this.label10 = new System.Windows.Forms.Label();
			this.cmbDictionaryLangUi = new System.Windows.Forms.ComboBox();
			this.label9 = new System.Windows.Forms.Label();
			this.tbDictionaryInput = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.cmbDictionaryLangPairs = new System.Windows.Forms.ComboBox();
			this.tpTranslator = new System.Windows.Forms.TabPage();
			this.tbTranslatorDetectedLang = new System.Windows.Forms.TextBox();
			this.label20 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.nudTranslatorDelay = new System.Windows.Forms.NumericUpDown();
			this.cbTranslatorDetectInputLang = new System.Windows.Forms.CheckBox();
			this.label18 = new System.Windows.Forms.Label();
			this.cmbTranslatorOutputLang = new System.Windows.Forms.ComboBox();
			this.label16 = new System.Windows.Forms.Label();
			this.rtbTranslatorOutput = new System.Windows.Forms.RichTextBox();
			this.label17 = new System.Windows.Forms.Label();
			this.tbTranslatorInput = new System.Windows.Forms.TextBox();
			this.label15 = new System.Windows.Forms.Label();
			this.cmbTranslatorInputLang = new System.Windows.Forms.ComboBox();
			this.tpSpeller = new System.Windows.Forms.TabPage();
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
			this.rtbSpellerOutput = new System.Windows.Forms.RichTextBox();
			this.label22 = new System.Windows.Forms.Label();
			this.tbSpellerInput = new System.Windows.Forms.TextBox();
			this.cbIncludeErrorWords = new System.Windows.Forms.CheckBox();
			this.tcServices.SuspendLayout();
			this.tpPredictor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPredictorDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxHintCount)).BeginInit();
			this.tpDictionary.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDictionaryDelay)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.tpTranslator.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTranslatorDelay)).BeginInit();
			this.tpSpeller.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSpellerDelay)).BeginInit();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// tcServices
			// 
			this.tcServices.Controls.Add(this.tpPredictor);
			this.tcServices.Controls.Add(this.tpDictionary);
			this.tcServices.Controls.Add(this.tpTranslator);
			this.tcServices.Controls.Add(this.tpSpeller);
			this.tcServices.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tcServices.Location = new System.Drawing.Point(0, 0);
			this.tcServices.Name = "tcServices";
			this.tcServices.SelectedIndex = 0;
			this.tcServices.Size = new System.Drawing.Size(549, 477);
			this.tcServices.TabIndex = 0;
			this.tcServices.SelectedIndexChanged += new System.EventHandler(this.tcServices_SelectedIndexChanged);
			// 
			// tpPredictor
			// 
			this.tpPredictor.Controls.Add(this.label11);
			this.tpPredictor.Controls.Add(this.label6);
			this.tpPredictor.Controls.Add(this.nudPredictorDelay);
			this.tpPredictor.Controls.Add(this.lbHints);
			this.tpPredictor.Controls.Add(this.tbHintCount);
			this.tpPredictor.Controls.Add(this.label7);
			this.tpPredictor.Controls.Add(this.label5);
			this.tpPredictor.Controls.Add(this.tbEndOfWorld);
			this.tpPredictor.Controls.Add(this.label4);
			this.tpPredictor.Controls.Add(this.tbPos);
			this.tpPredictor.Controls.Add(this.label3);
			this.tpPredictor.Controls.Add(this.label2);
			this.tpPredictor.Controls.Add(this.label1);
			this.tpPredictor.Controls.Add(this.nudMaxHintCount);
			this.tpPredictor.Controls.Add(this.cmbPredictorLangs);
			this.tpPredictor.Controls.Add(this.tbPredictorInput);
			this.tpPredictor.Location = new System.Drawing.Point(4, 22);
			this.tpPredictor.Name = "tpPredictor";
			this.tpPredictor.Padding = new System.Windows.Forms.Padding(3);
			this.tpPredictor.Size = new System.Drawing.Size(541, 451);
			this.tpPredictor.TabIndex = 0;
			this.tpPredictor.Text = "Predictor";
			this.tpPredictor.UseVisualStyleBackColor = true;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(3, 112);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(31, 13);
			this.label11.TabIndex = 17;
			this.label11.Text = "Hints";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(227, 41);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Hint Delay";
			// 
			// nudPredictorDelay
			// 
			this.nudPredictorDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudPredictorDelay.Location = new System.Drawing.Point(313, 38);
			this.nudPredictorDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudPredictorDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudPredictorDelay.Name = "nudPredictorDelay";
			this.nudPredictorDelay.Size = new System.Drawing.Size(68, 20);
			this.nudPredictorDelay.TabIndex = 15;
			this.nudPredictorDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudPredictorDelay.ValueChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			// 
			// lbHints
			// 
			this.lbHints.FormattingEnabled = true;
			this.lbHints.Location = new System.Drawing.Point(64, 112);
			this.lbHints.Name = "lbHints";
			this.lbHints.Size = new System.Drawing.Size(260, 134);
			this.lbHints.TabIndex = 14;
			// 
			// tbHintCount
			// 
			this.tbHintCount.Location = new System.Drawing.Point(424, 173);
			this.tbHintCount.Name = "tbHintCount";
			this.tbHintCount.ReadOnly = true;
			this.tbHintCount.Size = new System.Drawing.Size(62, 20);
			this.tbHintCount.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(338, 176);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Hint count:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(3, 79);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(31, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Input";
			// 
			// tbEndOfWorld
			// 
			this.tbEndOfWorld.Location = new System.Drawing.Point(424, 147);
			this.tbEndOfWorld.Name = "tbEndOfWorld";
			this.tbEndOfWorld.ReadOnly = true;
			this.tbEndOfWorld.Size = new System.Drawing.Size(62, 20);
			this.tbEndOfWorld.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(338, 150);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "End of World:";
			// 
			// tbPos
			// 
			this.tbPos.Location = new System.Drawing.Point(424, 121);
			this.tbPos.Name = "tbPos";
			this.tbPos.ReadOnly = true;
			this.tbPos.Size = new System.Drawing.Size(62, 20);
			this.tbPos.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(338, 124);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Pos:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(227, 15);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(80, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Max Hint Count";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(3, 12);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 13);
			this.label1.TabIndex = 3;
			this.label1.Text = "Language";
			// 
			// nudMaxHintCount
			// 
			this.nudMaxHintCount.Location = new System.Drawing.Point(313, 12);
			this.nudMaxHintCount.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
			this.nudMaxHintCount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudMaxHintCount.Name = "nudMaxHintCount";
			this.nudMaxHintCount.Size = new System.Drawing.Size(68, 20);
			this.nudMaxHintCount.TabIndex = 2;
			this.nudMaxHintCount.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
			this.nudMaxHintCount.ValueChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			// 
			// cmbPredictorLangs
			// 
			this.cmbPredictorLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPredictorLangs.FormattingEnabled = true;
			this.cmbPredictorLangs.Location = new System.Drawing.Point(64, 9);
			this.cmbPredictorLangs.Name = "cmbPredictorLangs";
			this.cmbPredictorLangs.Size = new System.Drawing.Size(66, 21);
			this.cmbPredictorLangs.TabIndex = 1;
			this.cmbPredictorLangs.SelectedIndexChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			// 
			// tbPredictorInput
			// 
			this.tbPredictorInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPredictorInput.Location = new System.Drawing.Point(64, 76);
			this.tbPredictorInput.Name = "tbPredictorInput";
			this.tbPredictorInput.Size = new System.Drawing.Size(465, 20);
			this.tbPredictorInput.TabIndex = 0;
			this.tbPredictorInput.TextChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			this.tbPredictorInput.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPredictor_KeyDown);
			// 
			// tpDictionary
			// 
			this.tpDictionary.Controls.Add(this.tbDictionaryIndent);
			this.tpDictionary.Controls.Add(this.label14);
			this.tpDictionary.Controls.Add(this.cbDictionaryFormatting);
			this.tpDictionary.Controls.Add(this.label13);
			this.tpDictionary.Controls.Add(this.rbDictionaryOutput);
			this.tpDictionary.Controls.Add(this.label12);
			this.tpDictionary.Controls.Add(this.nudDictionaryDelay);
			this.tpDictionary.Controls.Add(this.groupBox1);
			this.tpDictionary.Controls.Add(this.label10);
			this.tpDictionary.Controls.Add(this.cmbDictionaryLangUi);
			this.tpDictionary.Controls.Add(this.label9);
			this.tpDictionary.Controls.Add(this.tbDictionaryInput);
			this.tpDictionary.Controls.Add(this.label8);
			this.tpDictionary.Controls.Add(this.cmbDictionaryLangPairs);
			this.tpDictionary.Location = new System.Drawing.Point(4, 22);
			this.tpDictionary.Name = "tpDictionary";
			this.tpDictionary.Padding = new System.Windows.Forms.Padding(3);
			this.tpDictionary.Size = new System.Drawing.Size(541, 451);
			this.tpDictionary.TabIndex = 1;
			this.tpDictionary.Text = "Dictionary";
			this.tpDictionary.UseVisualStyleBackColor = true;
			// 
			// tbDictionaryIndent
			// 
			this.tbDictionaryIndent.Location = new System.Drawing.Point(463, 81);
			this.tbDictionaryIndent.Name = "tbDictionaryIndent";
			this.tbDictionaryIndent.Size = new System.Drawing.Size(68, 20);
			this.tbDictionaryIndent.TabIndex = 24;
			this.tbDictionaryIndent.Text = "    ";
			this.tbDictionaryIndent.TextChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(401, 82);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(37, 13);
			this.label14.TabIndex = 23;
			this.label14.Text = "Indent";
			// 
			// cbDictionaryFormatting
			// 
			this.cbDictionaryFormatting.AutoSize = true;
			this.cbDictionaryFormatting.Location = new System.Drawing.Point(404, 47);
			this.cbDictionaryFormatting.Name = "cbDictionaryFormatting";
			this.cbDictionaryFormatting.Size = new System.Drawing.Size(75, 17);
			this.cbDictionaryFormatting.TabIndex = 22;
			this.cbDictionaryFormatting.Text = "Formatting";
			this.cbDictionaryFormatting.UseVisualStyleBackColor = true;
			this.cbDictionaryFormatting.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(11, 140);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(37, 13);
			this.label13.TabIndex = 21;
			this.label13.Text = "Result";
			// 
			// rbDictionaryOutput
			// 
			this.rbDictionaryOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rbDictionaryOutput.Location = new System.Drawing.Point(93, 137);
			this.rbDictionaryOutput.Name = "rbDictionaryOutput";
			this.rbDictionaryOutput.ReadOnly = true;
			this.rbDictionaryOutput.Size = new System.Drawing.Size(440, 306);
			this.rbDictionaryOutput.TabIndex = 20;
			this.rbDictionaryOutput.Text = "";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(401, 22);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(56, 13);
			this.label12.TabIndex = 19;
			this.label12.Text = "Hint Delay";
			// 
			// nudDictionaryDelay
			// 
			this.nudDictionaryDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDictionaryDelay.Location = new System.Drawing.Point(463, 19);
			this.nudDictionaryDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudDictionaryDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudDictionaryDelay.Name = "nudDictionaryDelay";
			this.nudDictionaryDelay.Size = new System.Drawing.Size(68, 20);
			this.nudDictionaryDelay.TabIndex = 18;
			this.nudDictionaryDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudDictionaryDelay.ValueChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.cbPartOfSpeech);
			this.groupBox1.Controls.Add(this.cbFamily);
			this.groupBox1.Controls.Add(this.cbMorpho);
			this.groupBox1.Location = new System.Drawing.Point(239, 16);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(144, 89);
			this.groupBox1.TabIndex = 16;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Lookup Options";
			// 
			// cbPartOfSpeech
			// 
			this.cbPartOfSpeech.AutoSize = true;
			this.cbPartOfSpeech.Location = new System.Drawing.Point(6, 65);
			this.cbPartOfSpeech.Name = "cbPartOfSpeech";
			this.cbPartOfSpeech.Size = new System.Drawing.Size(122, 17);
			this.cbPartOfSpeech.TabIndex = 16;
			this.cbPartOfSpeech.Text = "Part of Speech Filter";
			this.cbPartOfSpeech.UseVisualStyleBackColor = true;
			this.cbPartOfSpeech.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// cbFamily
			// 
			this.cbFamily.AutoSize = true;
			this.cbFamily.Location = new System.Drawing.Point(6, 19);
			this.cbFamily.Name = "cbFamily";
			this.cbFamily.Size = new System.Drawing.Size(55, 17);
			this.cbFamily.TabIndex = 14;
			this.cbFamily.Text = "Family";
			this.cbFamily.UseVisualStyleBackColor = true;
			this.cbFamily.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// cbMorpho
			// 
			this.cbMorpho.AutoSize = true;
			this.cbMorpho.Location = new System.Drawing.Point(6, 42);
			this.cbMorpho.Name = "cbMorpho";
			this.cbMorpho.Size = new System.Drawing.Size(62, 17);
			this.cbMorpho.TabIndex = 15;
			this.cbMorpho.Text = "Morpho";
			this.cbMorpho.UseVisualStyleBackColor = true;
			this.cbMorpho.CheckedChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(11, 46);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(69, 13);
			this.label10.TabIndex = 13;
			this.label10.Text = "Language UI";
			// 
			// cmbDictionaryLangUi
			// 
			this.cmbDictionaryLangUi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDictionaryLangUi.FormattingEnabled = true;
			this.cmbDictionaryLangUi.Location = new System.Drawing.Point(93, 43);
			this.cmbDictionaryLangUi.Name = "cmbDictionaryLangUi";
			this.cmbDictionaryLangUi.Size = new System.Drawing.Size(72, 21);
			this.cmbDictionaryLangUi.TabIndex = 12;
			this.cmbDictionaryLangUi.SelectedIndexChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(11, 114);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(31, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Input";
			// 
			// tbDictionaryInput
			// 
			this.tbDictionaryInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbDictionaryInput.Location = new System.Drawing.Point(93, 111);
			this.tbDictionaryInput.Name = "tbDictionaryInput";
			this.tbDictionaryInput.Size = new System.Drawing.Size(440, 20);
			this.tbDictionaryInput.TabIndex = 10;
			this.tbDictionaryInput.TextChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(11, 19);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(76, 13);
			this.label8.TabIndex = 5;
			this.label8.Text = "Language Pair";
			// 
			// cmbDictionaryLangPairs
			// 
			this.cmbDictionaryLangPairs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbDictionaryLangPairs.FormattingEnabled = true;
			this.cmbDictionaryLangPairs.Location = new System.Drawing.Point(93, 16);
			this.cmbDictionaryLangPairs.Name = "cmbDictionaryLangPairs";
			this.cmbDictionaryLangPairs.Size = new System.Drawing.Size(72, 21);
			this.cmbDictionaryLangPairs.TabIndex = 4;
			this.cmbDictionaryLangPairs.SelectedIndexChanged += new System.EventHandler(this.tbDictionaryInput_TextChanged);
			// 
			// tpTranslator
			// 
			this.tpTranslator.Controls.Add(this.tbTranslatorDetectedLang);
			this.tpTranslator.Controls.Add(this.label20);
			this.tpTranslator.Controls.Add(this.label19);
			this.tpTranslator.Controls.Add(this.nudTranslatorDelay);
			this.tpTranslator.Controls.Add(this.cbTranslatorDetectInputLang);
			this.tpTranslator.Controls.Add(this.label18);
			this.tpTranslator.Controls.Add(this.cmbTranslatorOutputLang);
			this.tpTranslator.Controls.Add(this.label16);
			this.tpTranslator.Controls.Add(this.rtbTranslatorOutput);
			this.tpTranslator.Controls.Add(this.label17);
			this.tpTranslator.Controls.Add(this.tbTranslatorInput);
			this.tpTranslator.Controls.Add(this.label15);
			this.tpTranslator.Controls.Add(this.cmbTranslatorInputLang);
			this.tpTranslator.Location = new System.Drawing.Point(4, 22);
			this.tpTranslator.Name = "tpTranslator";
			this.tpTranslator.Size = new System.Drawing.Size(541, 451);
			this.tpTranslator.TabIndex = 2;
			this.tpTranslator.Text = "Translator";
			this.tpTranslator.UseVisualStyleBackColor = true;
			// 
			// tbTranslatorDetectedLang
			// 
			this.tbTranslatorDetectedLang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTranslatorDetectedLang.Location = new System.Drawing.Point(421, 332);
			this.tbTranslatorDetectedLang.Name = "tbTranslatorDetectedLang";
			this.tbTranslatorDetectedLang.ReadOnly = true;
			this.tbTranslatorDetectedLang.Size = new System.Drawing.Size(101, 20);
			this.tbTranslatorDetectedLang.TabIndex = 32;
			// 
			// label20
			// 
			this.label20.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.label20.AutoSize = true;
			this.label20.Location = new System.Drawing.Point(310, 335);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(105, 13);
			this.label20.TabIndex = 31;
			this.label20.Text = "Detected Input Lang";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Location = new System.Drawing.Point(359, 16);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(56, 13);
			this.label19.TabIndex = 30;
			this.label19.Text = "Hint Delay";
			// 
			// nudTranslatorDelay
			// 
			this.nudTranslatorDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudTranslatorDelay.Location = new System.Drawing.Point(421, 13);
			this.nudTranslatorDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudTranslatorDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudTranslatorDelay.Name = "nudTranslatorDelay";
			this.nudTranslatorDelay.Size = new System.Drawing.Size(68, 20);
			this.nudTranslatorDelay.TabIndex = 29;
			this.nudTranslatorDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			this.nudTranslatorDelay.ValueChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// cbTranslatorDetectInputLang
			// 
			this.cbTranslatorDetectInputLang.AutoSize = true;
			this.cbTranslatorDetectInputLang.Location = new System.Drawing.Point(362, 39);
			this.cbTranslatorDetectInputLang.Name = "cbTranslatorDetectInputLang";
			this.cbTranslatorDetectInputLang.Size = new System.Drawing.Size(112, 17);
			this.cbTranslatorDetectInputLang.TabIndex = 28;
			this.cbTranslatorDetectInputLang.Text = "Detect Input Lang";
			this.cbTranslatorDetectInputLang.UseVisualStyleBackColor = true;
			this.cbTranslatorDetectInputLang.CheckedChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(177, 22);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(66, 13);
			this.label18.TabIndex = 27;
			this.label18.Text = "Output Lang";
			// 
			// cmbTranslatorOutputLang
			// 
			this.cmbTranslatorOutputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTranslatorOutputLang.FormattingEnabled = true;
			this.cmbTranslatorOutputLang.Location = new System.Drawing.Point(249, 18);
			this.cmbTranslatorOutputLang.Name = "cmbTranslatorOutputLang";
			this.cmbTranslatorOutputLang.Size = new System.Drawing.Size(73, 21);
			this.cmbTranslatorOutputLang.TabIndex = 26;
			this.cmbTranslatorOutputLang.SelectedValueChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(11, 208);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(37, 13);
			this.label16.TabIndex = 25;
			this.label16.Text = "Result";
			// 
			// rtbTranslatorOutput
			// 
			this.rtbTranslatorOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbTranslatorOutput.Location = new System.Drawing.Point(85, 205);
			this.rtbTranslatorOutput.Name = "rtbTranslatorOutput";
			this.rtbTranslatorOutput.ReadOnly = true;
			this.rtbTranslatorOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbTranslatorOutput.Size = new System.Drawing.Size(440, 121);
			this.rtbTranslatorOutput.TabIndex = 24;
			this.rtbTranslatorOutput.Text = "";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(11, 78);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(31, 13);
			this.label17.TabIndex = 23;
			this.label17.Text = "Input";
			// 
			// tbTranslatorInput
			// 
			this.tbTranslatorInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbTranslatorInput.Location = new System.Drawing.Point(85, 75);
			this.tbTranslatorInput.Multiline = true;
			this.tbTranslatorInput.Name = "tbTranslatorInput";
			this.tbTranslatorInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbTranslatorInput.Size = new System.Drawing.Size(440, 121);
			this.tbTranslatorInput.TabIndex = 22;
			this.tbTranslatorInput.TextChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(11, 21);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(58, 13);
			this.label15.TabIndex = 7;
			this.label15.Text = "Input Lang";
			// 
			// cmbTranslatorInputLang
			// 
			this.cmbTranslatorInputLang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbTranslatorInputLang.FormattingEnabled = true;
			this.cmbTranslatorInputLang.Location = new System.Drawing.Point(85, 18);
			this.cmbTranslatorInputLang.Name = "cmbTranslatorInputLang";
			this.cmbTranslatorInputLang.Size = new System.Drawing.Size(73, 21);
			this.cmbTranslatorInputLang.TabIndex = 6;
			this.cmbTranslatorInputLang.SelectedValueChanged += new System.EventHandler(this.tbTranslatorInput_TextChanged);
			// 
			// tpSpeller
			// 
			this.tpSpeller.Controls.Add(this.cbIncludeErrorWords);
			this.tpSpeller.Controls.Add(this.cbSpellerUk);
			this.tpSpeller.Controls.Add(this.cbSpellerEn);
			this.tpSpeller.Controls.Add(this.cbSpellerRu);
			this.tpSpeller.Controls.Add(this.label24);
			this.tpSpeller.Controls.Add(this.nudSpellerDelay);
			this.tpSpeller.Controls.Add(this.groupBox2);
			this.tpSpeller.Controls.Add(this.label23);
			this.tpSpeller.Controls.Add(this.label21);
			this.tpSpeller.Controls.Add(this.rtbSpellerOutput);
			this.tpSpeller.Controls.Add(this.label22);
			this.tpSpeller.Controls.Add(this.tbSpellerInput);
			this.tpSpeller.Location = new System.Drawing.Point(4, 22);
			this.tpSpeller.Name = "tpSpeller";
			this.tpSpeller.Size = new System.Drawing.Size(541, 451);
			this.tpSpeller.TabIndex = 3;
			this.tpSpeller.Text = "Speller";
			this.tpSpeller.UseVisualStyleBackColor = true;
			// 
			// cbSpellerUk
			// 
			this.cbSpellerUk.AutoSize = true;
			this.cbSpellerUk.Location = new System.Drawing.Point(91, 59);
			this.cbSpellerUk.Name = "cbSpellerUk";
			this.cbSpellerUk.Size = new System.Drawing.Size(40, 17);
			this.cbSpellerUk.TabIndex = 37;
			this.cbSpellerUk.Text = "Uk";
			this.cbSpellerUk.UseVisualStyleBackColor = true;
			// 
			// cbSpellerEn
			// 
			this.cbSpellerEn.AutoSize = true;
			this.cbSpellerEn.Location = new System.Drawing.Point(91, 36);
			this.cbSpellerEn.Name = "cbSpellerEn";
			this.cbSpellerEn.Size = new System.Drawing.Size(39, 17);
			this.cbSpellerEn.TabIndex = 36;
			this.cbSpellerEn.Text = "En";
			this.cbSpellerEn.UseVisualStyleBackColor = true;
			// 
			// cbSpellerRu
			// 
			this.cbSpellerRu.AutoSize = true;
			this.cbSpellerRu.Location = new System.Drawing.Point(91, 13);
			this.cbSpellerRu.Name = "cbSpellerRu";
			this.cbSpellerRu.Size = new System.Drawing.Size(40, 17);
			this.cbSpellerRu.TabIndex = 35;
			this.cbSpellerRu.Text = "Ru";
			this.cbSpellerRu.UseVisualStyleBackColor = true;
			// 
			// label24
			// 
			this.label24.AutoSize = true;
			this.label24.Location = new System.Drawing.Point(8, 84);
			this.label24.Name = "label24";
			this.label24.Size = new System.Drawing.Size(56, 13);
			this.label24.TabIndex = 34;
			this.label24.Text = "Hint Delay";
			// 
			// nudSpellerDelay
			// 
			this.nudSpellerDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudSpellerDelay.Location = new System.Drawing.Point(91, 82);
			this.nudSpellerDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudSpellerDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudSpellerDelay.Name = "nudSpellerDelay";
			this.nudSpellerDelay.Size = new System.Drawing.Size(68, 20);
			this.nudSpellerDelay.TabIndex = 33;
			this.nudSpellerDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
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
			this.groupBox2.Location = new System.Drawing.Point(168, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(364, 95);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Speller Options";
			// 
			// cbIgnoreCapitalization
			// 
			this.cbIgnoreCapitalization.AutoSize = true;
			this.cbIgnoreCapitalization.Location = new System.Drawing.Point(247, 65);
			this.cbIgnoreCapitalization.Name = "cbIgnoreCapitalization";
			this.cbIgnoreCapitalization.Size = new System.Drawing.Size(121, 17);
			this.cbIgnoreCapitalization.TabIndex = 8;
			this.cbIgnoreCapitalization.Text = "Ignore Capitalization";
			this.cbIgnoreCapitalization.UseVisualStyleBackColor = true;
			this.cbIgnoreCapitalization.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbByWords
			// 
			this.cbByWords.AutoSize = true;
			this.cbByWords.Location = new System.Drawing.Point(247, 42);
			this.cbByWords.Name = "cbByWords";
			this.cbByWords.Size = new System.Drawing.Size(72, 17);
			this.cbByWords.TabIndex = 7;
			this.cbByWords.Text = "By Words";
			this.cbByWords.UseVisualStyleBackColor = true;
			this.cbByWords.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbFlagLatin
			// 
			this.cbFlagLatin.AutoSize = true;
			this.cbFlagLatin.Location = new System.Drawing.Point(247, 19);
			this.cbFlagLatin.Name = "cbFlagLatin";
			this.cbFlagLatin.Size = new System.Drawing.Size(72, 17);
			this.cbFlagLatin.TabIndex = 6;
			this.cbFlagLatin.Text = "Flag Latin";
			this.cbFlagLatin.UseVisualStyleBackColor = true;
			this.cbFlagLatin.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbNoSuggest
			// 
			this.cbNoSuggest.AutoSize = true;
			this.cbNoSuggest.Location = new System.Drawing.Point(123, 65);
			this.cbNoSuggest.Name = "cbNoSuggest";
			this.cbNoSuggest.Size = new System.Drawing.Size(82, 17);
			this.cbNoSuggest.TabIndex = 5;
			this.cbNoSuggest.Text = "No Suggest";
			this.cbNoSuggest.UseVisualStyleBackColor = true;
			this.cbNoSuggest.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreLatin
			// 
			this.cbIgnoreLatin.AutoSize = true;
			this.cbIgnoreLatin.Location = new System.Drawing.Point(123, 42);
			this.cbIgnoreLatin.Name = "cbIgnoreLatin";
			this.cbIgnoreLatin.Size = new System.Drawing.Size(82, 17);
			this.cbIgnoreLatin.TabIndex = 4;
			this.cbIgnoreLatin.Text = "Ignore Latin";
			this.cbIgnoreLatin.UseVisualStyleBackColor = true;
			this.cbIgnoreLatin.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbFindRepeatWords
			// 
			this.cbFindRepeatWords.AutoSize = true;
			this.cbFindRepeatWords.Location = new System.Drawing.Point(123, 19);
			this.cbFindRepeatWords.Name = "cbFindRepeatWords";
			this.cbFindRepeatWords.Size = new System.Drawing.Size(118, 17);
			this.cbFindRepeatWords.TabIndex = 3;
			this.cbFindRepeatWords.Text = "Find Repeat Words";
			this.cbFindRepeatWords.UseVisualStyleBackColor = true;
			this.cbFindRepeatWords.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreUrls
			// 
			this.cbIgnoreUrls.AutoSize = true;
			this.cbIgnoreUrls.Location = new System.Drawing.Point(6, 65);
			this.cbIgnoreUrls.Name = "cbIgnoreUrls";
			this.cbIgnoreUrls.Size = new System.Drawing.Size(77, 17);
			this.cbIgnoreUrls.TabIndex = 2;
			this.cbIgnoreUrls.Text = "Ignore Urls";
			this.cbIgnoreUrls.UseVisualStyleBackColor = true;
			this.cbIgnoreUrls.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreDigits
			// 
			this.cbIgnoreDigits.AutoSize = true;
			this.cbIgnoreDigits.Location = new System.Drawing.Point(6, 42);
			this.cbIgnoreDigits.Name = "cbIgnoreDigits";
			this.cbIgnoreDigits.Size = new System.Drawing.Size(85, 17);
			this.cbIgnoreDigits.TabIndex = 1;
			this.cbIgnoreDigits.Text = "Ignore Digits";
			this.cbIgnoreDigits.UseVisualStyleBackColor = true;
			this.cbIgnoreDigits.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIgnoreUppercase
			// 
			this.cbIgnoreUppercase.AutoSize = true;
			this.cbIgnoreUppercase.Location = new System.Drawing.Point(6, 19);
			this.cbIgnoreUppercase.Name = "cbIgnoreUppercase";
			this.cbIgnoreUppercase.Size = new System.Drawing.Size(111, 17);
			this.cbIgnoreUppercase.TabIndex = 0;
			this.cbIgnoreUppercase.Text = "Ignore Uppercase";
			this.cbIgnoreUppercase.UseVisualStyleBackColor = true;
			this.cbIgnoreUppercase.CheckedChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// label23
			// 
			this.label23.AutoSize = true;
			this.label23.Location = new System.Drawing.Point(8, 13);
			this.label23.Name = "label23";
			this.label23.Size = new System.Drawing.Size(55, 13);
			this.label23.TabIndex = 31;
			this.label23.Text = "Language";
			// 
			// label21
			// 
			this.label21.AutoSize = true;
			this.label21.Location = new System.Drawing.Point(8, 246);
			this.label21.Name = "label21";
			this.label21.Size = new System.Drawing.Size(77, 13);
			this.label21.TabIndex = 29;
			this.label21.Text = "Corrected Text";
			// 
			// rtbSpellerOutput
			// 
			this.rtbSpellerOutput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.rtbSpellerOutput.Location = new System.Drawing.Point(91, 243);
			this.rtbSpellerOutput.Name = "rtbSpellerOutput";
			this.rtbSpellerOutput.ReadOnly = true;
			this.rtbSpellerOutput.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
			this.rtbSpellerOutput.Size = new System.Drawing.Size(442, 121);
			this.rtbSpellerOutput.TabIndex = 28;
			this.rtbSpellerOutput.Text = "";
			// 
			// label22
			// 
			this.label22.AutoSize = true;
			this.label22.Location = new System.Drawing.Point(8, 116);
			this.label22.Name = "label22";
			this.label22.Size = new System.Drawing.Size(31, 13);
			this.label22.TabIndex = 27;
			this.label22.Text = "Input";
			// 
			// tbSpellerInput
			// 
			this.tbSpellerInput.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbSpellerInput.Location = new System.Drawing.Point(91, 113);
			this.tbSpellerInput.Multiline = true;
			this.tbSpellerInput.Name = "tbSpellerInput";
			this.tbSpellerInput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.tbSpellerInput.Size = new System.Drawing.Size(442, 121);
			this.tbSpellerInput.TabIndex = 26;
			this.tbSpellerInput.TextChanged += new System.EventHandler(this.tbSpellerInput_TextChanged);
			// 
			// cbIncludeErrorWords
			// 
			this.cbIncludeErrorWords.AutoSize = true;
			this.cbIncludeErrorWords.Location = new System.Drawing.Point(91, 370);
			this.cbIncludeErrorWords.Name = "cbIncludeErrorWords";
			this.cbIncludeErrorWords.Size = new System.Drawing.Size(120, 17);
			this.cbIncludeErrorWords.TabIndex = 38;
			this.cbIncludeErrorWords.Text = "Include Error Words";
			this.cbIncludeErrorWords.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(549, 477);
			this.Controls.Add(this.tcServices);
			this.Name = "frmMain";
			this.Text = "Yandex Linguistics";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.tcServices.ResumeLayout(false);
			this.tpPredictor.ResumeLayout(false);
			this.tpPredictor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudPredictorDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxHintCount)).EndInit();
			this.tpDictionary.ResumeLayout(false);
			this.tpDictionary.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDictionaryDelay)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.tpTranslator.ResumeLayout(false);
			this.tpTranslator.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudTranslatorDelay)).EndInit();
			this.tpSpeller.ResumeLayout(false);
			this.tpSpeller.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudSpellerDelay)).EndInit();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tcServices;
		private System.Windows.Forms.TabPage tpPredictor;
		private System.Windows.Forms.TextBox tbPredictorInput;
		private System.Windows.Forms.TabPage tpDictionary;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown nudMaxHintCount;
		private System.Windows.Forms.ComboBox cmbPredictorLangs;
		private System.Windows.Forms.TextBox tbEndOfWorld;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPos;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbHintCount;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.ListBox lbHints;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.NumericUpDown nudPredictorDelay;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.ComboBox cmbDictionaryLangPairs;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.TextBox tbDictionaryInput;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.CheckBox cbPartOfSpeech;
		private System.Windows.Forms.CheckBox cbFamily;
		private System.Windows.Forms.CheckBox cbMorpho;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.ComboBox cmbDictionaryLangUi;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.NumericUpDown nudDictionaryDelay;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.RichTextBox rbDictionaryOutput;
		private System.Windows.Forms.TextBox tbDictionaryIndent;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.CheckBox cbDictionaryFormatting;
		private System.Windows.Forms.TabPage tpTranslator;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.NumericUpDown nudTranslatorDelay;
		private System.Windows.Forms.CheckBox cbTranslatorDetectInputLang;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ComboBox cmbTranslatorOutputLang;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.RichTextBox rtbTranslatorOutput;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.TextBox tbTranslatorInput;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.ComboBox cmbTranslatorInputLang;
		private System.Windows.Forms.TextBox tbTranslatorDetectedLang;
		private System.Windows.Forms.Label label20;
		private System.Windows.Forms.TabPage tpSpeller;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.Label label23;
		private System.Windows.Forms.Label label21;
		private System.Windows.Forms.RichTextBox rtbSpellerOutput;
		private System.Windows.Forms.Label label22;
		private System.Windows.Forms.TextBox tbSpellerInput;
		private System.Windows.Forms.CheckBox cbByWords;
		private System.Windows.Forms.CheckBox cbFlagLatin;
		private System.Windows.Forms.CheckBox cbNoSuggest;
		private System.Windows.Forms.CheckBox cbIgnoreLatin;
		private System.Windows.Forms.CheckBox cbFindRepeatWords;
		private System.Windows.Forms.CheckBox cbIgnoreUrls;
		private System.Windows.Forms.CheckBox cbIgnoreDigits;
		private System.Windows.Forms.CheckBox cbIgnoreUppercase;
		private System.Windows.Forms.CheckBox cbIgnoreCapitalization;
		private System.Windows.Forms.Label label24;
		private System.Windows.Forms.NumericUpDown nudSpellerDelay;
		private System.Windows.Forms.CheckBox cbSpellerRu;
		private System.Windows.Forms.CheckBox cbSpellerUk;
		private System.Windows.Forms.CheckBox cbSpellerEn;
		private System.Windows.Forms.CheckBox cbIncludeErrorWords;
	}
}

