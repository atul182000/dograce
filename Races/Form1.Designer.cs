namespace Races
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.reset = new System.Windows.Forms.Button();
            this.BobLabel = new System.Windows.Forms.Label();
            this.AlLabel = new System.Windows.Forms.Label();
            this.JoeLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Race = new System.Windows.Forms.Button();
            this.dogNumberNumeric = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.betNumeric = new System.Windows.Forms.NumericUpDown();
            this.betsButton = new System.Windows.Forms.Button();
            this.NameOfBettorLabel = new System.Windows.Forms.Label();
            this.BobRadio = new System.Windows.Forms.RadioButton();
            this.AlRadio = new System.Windows.Forms.RadioButton();
            this.JoeRadio = new System.Windows.Forms.RadioButton();
            this.MinimumBetLabel = new System.Windows.Forms.Label();
            this.Dog1 = new System.Windows.Forms.PictureBox();
            this.Dog2 = new System.Windows.Forms.PictureBox();
            this.Dog3 = new System.Windows.Forms.PictureBox();
            this.Dog4 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Races.Resource1.track;
            this.pictureBox1.Location = new System.Drawing.Point(20, 20);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(778, 306);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.reset);
            this.groupBox1.Controls.Add(this.BobLabel);
            this.groupBox1.Controls.Add(this.AlLabel);
            this.groupBox1.Controls.Add(this.JoeLabel);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Race);
            this.groupBox1.Controls.Add(this.dogNumberNumeric);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.betNumeric);
            this.groupBox1.Controls.Add(this.betsButton);
            this.groupBox1.Controls.Add(this.NameOfBettorLabel);
            this.groupBox1.Controls.Add(this.BobRadio);
            this.groupBox1.Controls.Add(this.AlRadio);
            this.groupBox1.Controls.Add(this.JoeRadio);
            this.groupBox1.Controls.Add(this.MinimumBetLabel);
            this.groupBox1.Location = new System.Drawing.Point(20, 357);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(898, 248);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Betting Parlor";
            // 
            // reset
            // 
            this.reset.Location = new System.Drawing.Point(638, 205);
            this.reset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(112, 35);
            this.reset.TabIndex = 14;
            this.reset.Text = "Reset Position!";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // BobLabel
            // 
            this.BobLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BobLabel.Location = new System.Drawing.Point(524, 123);
            this.BobLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BobLabel.Name = "BobLabel";
            this.BobLabel.Size = new System.Drawing.Size(365, 30);
            this.BobLabel.TabIndex = 13;
            this.BobLabel.Text = "Bob\'s Bet";
            this.BobLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AlLabel
            // 
            this.AlLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.AlLabel.Location = new System.Drawing.Point(524, 85);
            this.AlLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AlLabel.Name = "AlLabel";
            this.AlLabel.Size = new System.Drawing.Size(365, 30);
            this.AlLabel.TabIndex = 12;
            this.AlLabel.Text = "Al\'s Bet";
            this.AlLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // JoeLabel
            // 
            this.JoeLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.JoeLabel.Location = new System.Drawing.Point(524, 46);
            this.JoeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.JoeLabel.Name = "JoeLabel";
            this.JoeLabel.Size = new System.Drawing.Size(365, 30);
            this.JoeLabel.TabIndex = 11;
            this.JoeLabel.Text = "Joe\'s Bet";
            this.JoeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(519, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Bets";
            // 
            // Race
            // 
            this.Race.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Race.Location = new System.Drawing.Point(759, 194);
            this.Race.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Race.Name = "Race";
            this.Race.Size = new System.Drawing.Size(130, 46);
            this.Race.TabIndex = 9;
            this.Race.Text = "Race!";
            this.Race.UseVisualStyleBackColor = true;
            this.Race.Click += new System.EventHandler(this.Race_Click);
            // 
            // dogNumberNumeric
            // 
            this.dogNumberNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dogNumberNumeric.Location = new System.Drawing.Point(524, 194);
            this.dogNumberNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dogNumberNumeric.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.dogNumberNumeric.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.dogNumberNumeric.Name = "dogNumberNumeric";
            this.dogNumberNumeric.Size = new System.Drawing.Size(81, 26);
            this.dogNumberNumeric.TabIndex = 8;
            this.dogNumberNumeric.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(350, 205);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label3.Size = new System.Drawing.Size(162, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "bucks on dog number";
            // 
            // betNumeric
            // 
            this.betNumeric.ForeColor = System.Drawing.SystemColors.WindowText;
            this.betNumeric.Location = new System.Drawing.Point(260, 194);
            this.betNumeric.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.betNumeric.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.betNumeric.Name = "betNumeric";
            this.betNumeric.Size = new System.Drawing.Size(81, 26);
            this.betNumeric.TabIndex = 6;
            this.betNumeric.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // betsButton
            // 
            this.betsButton.Location = new System.Drawing.Point(138, 189);
            this.betsButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.betsButton.Name = "betsButton";
            this.betsButton.Size = new System.Drawing.Size(112, 35);
            this.betsButton.TabIndex = 5;
            this.betsButton.Text = "Bets";
            this.betsButton.UseVisualStyleBackColor = true;
            this.betsButton.Click += new System.EventHandler(this.betsButton_Click);
            // 
            // NameOfBettorLabel
            // 
            this.NameOfBettorLabel.AutoSize = true;
            this.NameOfBettorLabel.Location = new System.Drawing.Point(10, 197);
            this.NameOfBettorLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.NameOfBettorLabel.Name = "NameOfBettorLabel";
            this.NameOfBettorLabel.Size = new System.Drawing.Size(117, 20);
            this.NameOfBettorLabel.TabIndex = 4;
            this.NameOfBettorLabel.Text = "Who\'s Betting?";
            // 
            // BobRadio
            // 
            this.BobRadio.AutoSize = true;
            this.BobRadio.Location = new System.Drawing.Point(15, 137);
            this.BobRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.BobRadio.Name = "BobRadio";
            this.BobRadio.Size = new System.Drawing.Size(63, 24);
            this.BobRadio.TabIndex = 3;
            this.BobRadio.TabStop = true;
            this.BobRadio.Text = "Bob";
            this.BobRadio.UseVisualStyleBackColor = true;
            this.BobRadio.Click += new System.EventHandler(this.radioClicked);
            // 
            // AlRadio
            // 
            this.AlRadio.AutoSize = true;
            this.AlRadio.Location = new System.Drawing.Point(15, 102);
            this.AlRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AlRadio.Name = "AlRadio";
            this.AlRadio.Size = new System.Drawing.Size(48, 24);
            this.AlRadio.TabIndex = 2;
            this.AlRadio.TabStop = true;
            this.AlRadio.Text = "Al";
            this.AlRadio.UseVisualStyleBackColor = true;
            this.AlRadio.Click += new System.EventHandler(this.radioClicked);
            // 
            // JoeRadio
            // 
            this.JoeRadio.AutoSize = true;
            this.JoeRadio.Location = new System.Drawing.Point(15, 66);
            this.JoeRadio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.JoeRadio.Name = "JoeRadio";
            this.JoeRadio.Size = new System.Drawing.Size(60, 24);
            this.JoeRadio.TabIndex = 1;
            this.JoeRadio.TabStop = true;
            this.JoeRadio.Text = "Joe";
            this.JoeRadio.UseVisualStyleBackColor = true;
            this.JoeRadio.Click += new System.EventHandler(this.radioClicked);
            // 
            // MinimumBetLabel
            // 
            this.MinimumBetLabel.AutoSize = true;
            this.MinimumBetLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MinimumBetLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MinimumBetLabel.Location = new System.Drawing.Point(9, 25);
            this.MinimumBetLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MinimumBetLabel.Name = "MinimumBetLabel";
            this.MinimumBetLabel.Size = new System.Drawing.Size(186, 33);
            this.MinimumBetLabel.TabIndex = 0;
            this.MinimumBetLabel.Text = "Minimum Bet";
            // 
            // Dog1
            // 
            this.Dog1.Image = ((System.Drawing.Image)(resources.GetObject("Dog1.Image")));
            this.Dog1.Location = new System.Drawing.Point(30, 35);
            this.Dog1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dog1.Name = "Dog1";
            this.Dog1.Size = new System.Drawing.Size(114, 35);
            this.Dog1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog1.TabIndex = 2;
            this.Dog1.TabStop = false;
            // 
            // Dog2
            // 
            this.Dog2.Image = ((System.Drawing.Image)(resources.GetObject("Dog2.Image")));
            this.Dog2.Location = new System.Drawing.Point(30, 106);
            this.Dog2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dog2.Name = "Dog2";
            this.Dog2.Size = new System.Drawing.Size(114, 35);
            this.Dog2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog2.TabIndex = 3;
            this.Dog2.TabStop = false;
            // 
            // Dog3
            // 
            this.Dog3.Image = ((System.Drawing.Image)(resources.GetObject("Dog3.Image")));
            this.Dog3.Location = new System.Drawing.Point(30, 189);
            this.Dog3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dog3.Name = "Dog3";
            this.Dog3.Size = new System.Drawing.Size(114, 35);
            this.Dog3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog3.TabIndex = 4;
            this.Dog3.TabStop = false;
            // 
            // Dog4
            // 
            this.Dog4.Image = ((System.Drawing.Image)(resources.GetObject("Dog4.Image")));
            this.Dog4.Location = new System.Drawing.Point(30, 268);
            this.Dog4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Dog4.Name = "Dog4";
            this.Dog4.Size = new System.Drawing.Size(114, 35);
            this.Dog4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Dog4.TabIndex = 5;
            this.Dog4.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 25;
            this.timer1.Tick += new System.EventHandler(this.timer1_tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 662);
            this.Controls.Add(this.Dog4);
            this.Controls.Add(this.Dog3);
            this.Controls.Add(this.Dog2);
            this.Controls.Add(this.Dog1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_OnLoad);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dogNumberNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.betNumeric)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dog4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label MinimumBetLabel;
        private System.Windows.Forms.RadioButton BobRadio;
        private System.Windows.Forms.RadioButton AlRadio;
        private System.Windows.Forms.RadioButton JoeRadio;
        private System.Windows.Forms.Label NameOfBettorLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown betNumeric;
        private System.Windows.Forms.Button betsButton;
        private System.Windows.Forms.NumericUpDown dogNumberNumeric;
        private System.Windows.Forms.Button Race;
        private System.Windows.Forms.Label BobLabel;
        private System.Windows.Forms.Label AlLabel;
        private System.Windows.Forms.Label JoeLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox Dog1;
        private System.Windows.Forms.PictureBox Dog2;
        private System.Windows.Forms.PictureBox Dog3;
        private System.Windows.Forms.PictureBox Dog4;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button reset;
        
    }
}

