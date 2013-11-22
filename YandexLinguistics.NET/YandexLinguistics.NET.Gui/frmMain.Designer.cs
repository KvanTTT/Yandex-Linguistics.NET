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
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tpPredictor = new System.Windows.Forms.TabPage();
			this.label6 = new System.Windows.Forms.Label();
			this.nudDelay = new System.Windows.Forms.NumericUpDown();
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
			this.tbPredictor = new System.Windows.Forms.TextBox();
			this.tpDictionary = new System.Windows.Forms.TabPage();
			this.tabControl1.SuspendLayout();
			this.tpPredictor.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDelay)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxHintCount)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tpPredictor);
			this.tabControl1.Controls.Add(this.tpDictionary);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(547, 526);
			this.tabControl1.TabIndex = 0;
			// 
			// tpPredictor
			// 
			this.tpPredictor.Controls.Add(this.label6);
			this.tpPredictor.Controls.Add(this.nudDelay);
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
			this.tpPredictor.Controls.Add(this.tbPredictor);
			this.tpPredictor.Location = new System.Drawing.Point(4, 22);
			this.tpPredictor.Name = "tpPredictor";
			this.tpPredictor.Padding = new System.Windows.Forms.Padding(3);
			this.tpPredictor.Size = new System.Drawing.Size(539, 500);
			this.tpPredictor.TabIndex = 0;
			this.tpPredictor.Text = "Predictor";
			this.tpPredictor.UseVisualStyleBackColor = true;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(377, 14);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(56, 13);
			this.label6.TabIndex = 16;
			this.label6.Text = "Hint Delay";
			// 
			// nudDelay
			// 
			this.nudDelay.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
			this.nudDelay.Location = new System.Drawing.Point(463, 11);
			this.nudDelay.Maximum = new decimal(new int[] {
            5000,
            0,
            0,
            0});
			this.nudDelay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.nudDelay.Name = "nudDelay";
			this.nudDelay.Size = new System.Drawing.Size(68, 20);
			this.nudDelay.TabIndex = 15;
			this.nudDelay.Value = new decimal(new int[] {
            300,
            0,
            0,
            0});
			// 
			// lbHints
			// 
			this.lbHints.FormattingEnabled = true;
			this.lbHints.Location = new System.Drawing.Point(64, 85);
			this.lbHints.Name = "lbHints";
			this.lbHints.Size = new System.Drawing.Size(260, 134);
			this.lbHints.TabIndex = 14;
			// 
			// tbHintCount
			// 
			this.tbHintCount.Location = new System.Drawing.Point(437, 178);
			this.tbHintCount.Name = "tbHintCount";
			this.tbHintCount.ReadOnly = true;
			this.tbHintCount.Size = new System.Drawing.Size(62, 20);
			this.tbHintCount.TabIndex = 13;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(351, 181);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(59, 13);
			this.label7.TabIndex = 12;
			this.label7.Text = "Hint count:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(6, 52);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(34, 13);
			this.label5.TabIndex = 9;
			this.label5.Text = "Input:";
			// 
			// tbEndOfWorld
			// 
			this.tbEndOfWorld.Location = new System.Drawing.Point(437, 140);
			this.tbEndOfWorld.Name = "tbEndOfWorld";
			this.tbEndOfWorld.ReadOnly = true;
			this.tbEndOfWorld.Size = new System.Drawing.Size(62, 20);
			this.tbEndOfWorld.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(351, 143);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(72, 13);
			this.label4.TabIndex = 7;
			this.label4.Text = "End of World:";
			// 
			// tbPos
			// 
			this.tbPos.Location = new System.Drawing.Point(437, 102);
			this.tbPos.Name = "tbPos";
			this.tbPos.ReadOnly = true;
			this.tbPos.Size = new System.Drawing.Size(62, 20);
			this.tbPos.TabIndex = 6;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(351, 105);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(28, 13);
			this.label3.TabIndex = 5;
			this.label3.Text = "Pos:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(200, 13);
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
			this.nudMaxHintCount.Location = new System.Drawing.Point(286, 10);
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
			this.nudMaxHintCount.ValueChanged += new System.EventHandler(this.nudMaxHintCount_ValueChanged);
			// 
			// cmbPredictorLangs
			// 
			this.cmbPredictorLangs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cmbPredictorLangs.FormattingEnabled = true;
			this.cmbPredictorLangs.Location = new System.Drawing.Point(64, 9);
			this.cmbPredictorLangs.Name = "cmbPredictorLangs";
			this.cmbPredictorLangs.Size = new System.Drawing.Size(121, 21);
			this.cmbPredictorLangs.TabIndex = 1;
			this.cmbPredictorLangs.SelectedIndexChanged += new System.EventHandler(this.cmbPredictorLangs_SelectedIndexChanged);
			// 
			// tbPredictor
			// 
			this.tbPredictor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.tbPredictor.Location = new System.Drawing.Point(64, 49);
			this.tbPredictor.Name = "tbPredictor";
			this.tbPredictor.Size = new System.Drawing.Size(467, 20);
			this.tbPredictor.TabIndex = 0;
			this.tbPredictor.TextChanged += new System.EventHandler(this.tbPredictor_TextChanged);
			this.tbPredictor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbPredictor_KeyDown);
			// 
			// tpDictionary
			// 
			this.tpDictionary.Location = new System.Drawing.Point(4, 22);
			this.tpDictionary.Name = "tpDictionary";
			this.tpDictionary.Padding = new System.Windows.Forms.Padding(3);
			this.tpDictionary.Size = new System.Drawing.Size(539, 507);
			this.tpDictionary.TabIndex = 1;
			this.tpDictionary.Text = "Dictionary";
			this.tpDictionary.UseVisualStyleBackColor = true;
			// 
			// frmMain
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(547, 526);
			this.Controls.Add(this.tabControl1);
			this.Name = "frmMain";
			this.Text = "Yandex Linguistics";
			this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
			this.tabControl1.ResumeLayout(false);
			this.tpPredictor.ResumeLayout(false);
			this.tpPredictor.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.nudDelay)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.nudMaxHintCount)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tpPredictor;
		private System.Windows.Forms.TextBox tbPredictor;
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
		private System.Windows.Forms.NumericUpDown nudDelay;
	}
}

