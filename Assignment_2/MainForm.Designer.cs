namespace Assignment_2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblMam = new Label();
            lstBox = new ListBox();
            lblYear = new Label();
            txtYear = new TextBox();
            grpColor = new GroupBox();
            radWhite = new RadioButton();
            radBlack = new RadioButton();
            radBlue = new RadioButton();
            radRed = new RadioButton();
            grpFeatures = new GroupBox();
            chkLaneAssist = new CheckBox();
            chkSiriusRadio = new CheckBox();
            chkPowerWindows = new CheckBox();
            chkAC = new CheckBox();
            btnPurchase = new Button();
            lblSummary = new Label();
            grpColor.SuspendLayout();
            grpFeatures.SuspendLayout();
            SuspendLayout();
            // 
            // lblMam
            // 
            lblMam.AutoSize = true;
            lblMam.Location = new Point(48, 34);
            lblMam.Name = "lblMam";
            lblMam.Size = new Size(121, 20);
            lblMam.TabIndex = 0;
            lblMam.Text = "&Make and Model";
            lblMam.Click += label1_Click;
            // 
            // lstBox
            // 
            lstBox.FormattingEnabled = true;
            lstBox.Location = new Point(48, 75);
            lstBox.Name = "lstBox";
            lstBox.Size = new Size(150, 104);
            lstBox.TabIndex = 1;
            lstBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // lblYear
            // 
            lblYear.AutoSize = true;
            lblYear.Location = new Point(270, 34);
            lblYear.Name = "lblYear";
            lblYear.Size = new Size(37, 20);
            lblYear.TabIndex = 2;
            lblYear.Text = "&Year";
            lblYear.Click += label1_Click_1;
            // 
            // txtYear
            // 
            txtYear.Location = new Point(270, 75);
            txtYear.Name = "txtYear";
            txtYear.Size = new Size(125, 27);
            txtYear.TabIndex = 3;
            txtYear.TextChanged += textBox1_TextChanged;
            // 
            // grpColor
            // 
            grpColor.Controls.Add(radWhite);
            grpColor.Controls.Add(radBlack);
            grpColor.Controls.Add(radBlue);
            grpColor.Controls.Add(radRed);
            grpColor.Location = new Point(490, 34);
            grpColor.Name = "grpColor";
            grpColor.Size = new Size(250, 150);
            grpColor.TabIndex = 4;
            grpColor.TabStop = false;
            grpColor.Text = "&Color";
            grpColor.Enter += groupBox1_Enter;
            // 
            // radWhite
            // 
            radWhite.AutoSize = true;
            radWhite.Location = new Point(6, 120);
            radWhite.Name = "radWhite";
            radWhite.Size = new Size(69, 24);
            radWhite.TabIndex = 3;
            radWhite.TabStop = true;
            radWhite.Text = "White";
            radWhite.UseVisualStyleBackColor = true;
            radWhite.CheckedChanged += radWhite_CheckedChanged;
            // 
            // radBlack
            // 
            radBlack.AutoSize = true;
            radBlack.Location = new Point(6, 86);
            radBlack.Name = "radBlack";
            radBlack.Size = new Size(65, 24);
            radBlack.TabIndex = 2;
            radBlack.TabStop = true;
            radBlack.Text = "Black";
            radBlack.UseVisualStyleBackColor = true;
            radBlack.CheckedChanged += radBlack_CheckedChanged;
            // 
            // radBlue
            // 
            radBlue.AutoSize = true;
            radBlue.Location = new Point(6, 56);
            radBlue.Name = "radBlue";
            radBlue.Size = new Size(59, 24);
            radBlue.TabIndex = 1;
            radBlue.TabStop = true;
            radBlue.Text = "Blue";
            radBlue.UseVisualStyleBackColor = true;
            radBlue.CheckedChanged += radBlue_CheckedChanged;
            // 
            // radRed
            // 
            radRed.AutoSize = true;
            radRed.Location = new Point(6, 26);
            radRed.Name = "radRed";
            radRed.Size = new Size(56, 24);
            radRed.TabIndex = 0;
            radRed.TabStop = true;
            radRed.Text = "Red";
            radRed.UseVisualStyleBackColor = true;
            radRed.CheckedChanged += radRed_CheckedChanged;
            // 
            // grpFeatures
            // 
            grpFeatures.Controls.Add(chkLaneAssist);
            grpFeatures.Controls.Add(chkSiriusRadio);
            grpFeatures.Controls.Add(chkPowerWindows);
            grpFeatures.Controls.Add(chkAC);
            grpFeatures.Location = new Point(806, 34);
            grpFeatures.Name = "grpFeatures";
            grpFeatures.Size = new Size(254, 150);
            grpFeatures.TabIndex = 5;
            grpFeatures.TabStop = false;
            grpFeatures.Text = "&Features";
            // 
            // chkLaneAssist
            // 
            chkLaneAssist.AutoSize = true;
            chkLaneAssist.Location = new Point(6, 120);
            chkLaneAssist.Name = "chkLaneAssist";
            chkLaneAssist.Size = new Size(103, 24);
            chkLaneAssist.TabIndex = 3;
            chkLaneAssist.Text = "Lane Assist";
            chkLaneAssist.UseVisualStyleBackColor = true;
            // 
            // chkSiriusRadio
            // 
            chkSiriusRadio.AutoSize = true;
            chkSiriusRadio.Location = new Point(6, 87);
            chkSiriusRadio.Name = "chkSiriusRadio";
            chkSiriusRadio.Size = new Size(109, 24);
            chkSiriusRadio.TabIndex = 2;
            chkSiriusRadio.Text = "Sirius Radio";
            chkSiriusRadio.UseVisualStyleBackColor = true;
            // 
            // chkPowerWindows
            // 
            chkPowerWindows.AutoSize = true;
            chkPowerWindows.Location = new Point(6, 56);
            chkPowerWindows.Name = "chkPowerWindows";
            chkPowerWindows.Size = new Size(136, 24);
            chkPowerWindows.TabIndex = 1;
            chkPowerWindows.Text = "Power Windows";
            chkPowerWindows.UseVisualStyleBackColor = true;
            // 
            // chkAC
            // 
            chkAC.AutoSize = true;
            chkAC.Location = new Point(6, 26);
            chkAC.Name = "chkAC";
            chkAC.Size = new Size(50, 24);
            chkAC.TabIndex = 0;
            chkAC.Text = "AC";
            chkAC.UseVisualStyleBackColor = true;
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(48, 292);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(94, 29);
            btnPurchase.TabIndex = 6;
            btnPurchase.Text = "&Purchase";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += button1_Click;
            // 
            // lblSummary
            // 
            lblSummary.AutoSize = true;
            lblSummary.BorderStyle = BorderStyle.FixedSingle;
            lblSummary.Font = new Font("Times New Roman", 12F);
            lblSummary.Location = new Point(290, 292);
            lblSummary.MaximumSize = new Size(100, 100);
            lblSummary.MinimumSize = new Size(600, 100);
            lblSummary.Name = "lblSummary";
            lblSummary.Size = new Size(600, 100);
            lblSummary.TabIndex = 7;
            lblSummary.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 457);
            Controls.Add(lblSummary);
            Controls.Add(btnPurchase);
            Controls.Add(grpFeatures);
            Controls.Add(grpColor);
            Controls.Add(txtYear);
            Controls.Add(lblYear);
            Controls.Add(lstBox);
            Controls.Add(lblMam);
            Name = "MainForm";
            Text = "Assignment 2";
            Load += Form1_Load;
            grpColor.ResumeLayout(false);
            grpColor.PerformLayout();
            grpFeatures.ResumeLayout(false);
            grpFeatures.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblMam;
        private ListBox lstBox;
        private Label lblYear;
        private TextBox txtYear;
        private GroupBox grpColor;
        private RadioButton radWhite;
        private RadioButton radBlack;
        private RadioButton radBlue;
        private RadioButton radRed;
        private GroupBox grpFeatures;
        private CheckBox chkLaneAssist;
        private CheckBox chkSiriusRadio;
        private CheckBox chkPowerWindows;
        private CheckBox chkAC;
        private Button btnPurchase;
        private Label lblSummary;
    }
}
