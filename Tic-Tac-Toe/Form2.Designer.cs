namespace Tic_Tac_Toe
{
    partial class Options
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Options));
            this.BoardSize = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.singlePlayerLabel = new System.Windows.Forms.Label();
            this.singlePlayerCheckBox = new System.Windows.Forms.CheckBox();
            this.ComputerStartLabel = new System.Windows.Forms.Label();
            this.ComputerStartsCheckBox = new System.Windows.Forms.CheckBox();
            this.FirstIsLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.Olabel = new System.Windows.Forms.Label();
            this.XradioButton = new System.Windows.Forms.RadioButton();
            this.OradioButton = new System.Windows.Forms.RadioButton();
            this.Player1ColorLabel = new System.Windows.Forms.Label();
            this.Player2ColorLabel = new System.Windows.Forms.Label();
            this.Reset = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.Ok = new System.Windows.Forms.Button();
            this.player1color = new System.Windows.Forms.Button();
            this.player2color = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.randomRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // BoardSize
            // 
            this.BoardSize.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BoardSize.AutoSize = true;
            this.BoardSize.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BoardSize.Location = new System.Drawing.Point(13, 12);
            this.BoardSize.Name = "BoardSize";
            this.BoardSize.Size = new System.Drawing.Size(84, 22);
            this.BoardSize.TabIndex = 0;
            this.BoardSize.Text = "Board Size";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDown1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numericUpDown1.Location = new System.Drawing.Point(123, 10);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            7,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.ReadOnly = true;
            this.numericUpDown1.Size = new System.Drawing.Size(100, 29);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numericUpDown1.Value = new decimal(new int[] {
            3,
            0,
            0,
            0});
            // 
            // singlePlayerLabel
            // 
            this.singlePlayerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singlePlayerLabel.AutoSize = true;
            this.singlePlayerLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.singlePlayerLabel.Location = new System.Drawing.Point(13, 55);
            this.singlePlayerLabel.Name = "singlePlayerLabel";
            this.singlePlayerLabel.Size = new System.Drawing.Size(101, 22);
            this.singlePlayerLabel.TabIndex = 3;
            this.singlePlayerLabel.Text = "Single Player";
            // 
            // singlePlayerCheckBox
            // 
            this.singlePlayerCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.singlePlayerCheckBox.AutoSize = true;
            this.singlePlayerCheckBox.Location = new System.Drawing.Point(208, 61);
            this.singlePlayerCheckBox.Name = "singlePlayerCheckBox";
            this.singlePlayerCheckBox.Size = new System.Drawing.Size(15, 14);
            this.singlePlayerCheckBox.TabIndex = 4;
            this.singlePlayerCheckBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.singlePlayerCheckBox.UseVisualStyleBackColor = true;
            // 
            // ComputerStartLabel
            // 
            this.ComputerStartLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerStartLabel.AutoSize = true;
            this.ComputerStartLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComputerStartLabel.Location = new System.Drawing.Point(12, 98);
            this.ComputerStartLabel.Name = "ComputerStartLabel";
            this.ComputerStartLabel.Size = new System.Drawing.Size(121, 22);
            this.ComputerStartLabel.TabIndex = 5;
            this.ComputerStartLabel.Text = "Computer Starts";
            // 
            // ComputerStartsCheckBox
            // 
            this.ComputerStartsCheckBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ComputerStartsCheckBox.AutoSize = true;
            this.ComputerStartsCheckBox.Location = new System.Drawing.Point(208, 104);
            this.ComputerStartsCheckBox.Name = "ComputerStartsCheckBox";
            this.ComputerStartsCheckBox.Size = new System.Drawing.Size(15, 14);
            this.ComputerStartsCheckBox.TabIndex = 6;
            this.ComputerStartsCheckBox.UseVisualStyleBackColor = true;
            // 
            // FirstIsLabel
            // 
            this.FirstIsLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FirstIsLabel.AutoSize = true;
            this.FirstIsLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstIsLabel.Location = new System.Drawing.Point(13, 137);
            this.FirstIsLabel.Name = "FirstIsLabel";
            this.FirstIsLabel.Size = new System.Drawing.Size(102, 22);
            this.FirstIsLabel.TabIndex = 7;
            this.FirstIsLabel.Text = "First to go is:";
            // 
            // xLabel
            // 
            this.xLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.xLabel.AutoSize = true;
            this.xLabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(35, 167);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(21, 22);
            this.xLabel.TabIndex = 8;
            this.xLabel.Text = "X";
            // 
            // Olabel
            // 
            this.Olabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Olabel.AutoSize = true;
            this.Olabel.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Olabel.Location = new System.Drawing.Point(96, 167);
            this.Olabel.Name = "Olabel";
            this.Olabel.Size = new System.Drawing.Size(21, 22);
            this.Olabel.TabIndex = 9;
            this.Olabel.Text = "O";
            // 
            // XradioButton
            // 
            this.XradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.XradioButton.AutoSize = true;
            this.XradioButton.Location = new System.Drawing.Point(20, 173);
            this.XradioButton.Name = "XradioButton";
            this.XradioButton.Size = new System.Drawing.Size(14, 13);
            this.XradioButton.TabIndex = 10;
            this.XradioButton.TabStop = true;
            this.XradioButton.UseVisualStyleBackColor = true;
            // 
            // OradioButton
            // 
            this.OradioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OradioButton.AutoSize = true;
            this.OradioButton.Location = new System.Drawing.Point(80, 173);
            this.OradioButton.Name = "OradioButton";
            this.OradioButton.Size = new System.Drawing.Size(14, 13);
            this.OradioButton.TabIndex = 11;
            this.OradioButton.TabStop = true;
            this.OradioButton.UseVisualStyleBackColor = true;
            // 
            // Player1ColorLabel
            // 
            this.Player1ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player1ColorLabel.AutoSize = true;
            this.Player1ColorLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player1ColorLabel.Location = new System.Drawing.Point(13, 205);
            this.Player1ColorLabel.Name = "Player1ColorLabel";
            this.Player1ColorLabel.Size = new System.Drawing.Size(92, 18);
            this.Player1ColorLabel.TabIndex = 12;
            this.Player1ColorLabel.Text = "Player1 Color :";
            // 
            // Player2ColorLabel
            // 
            this.Player2ColorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Player2ColorLabel.AutoSize = true;
            this.Player2ColorLabel.Font = new System.Drawing.Font("Monotype Corsiva", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Player2ColorLabel.Location = new System.Drawing.Point(14, 234);
            this.Player2ColorLabel.Name = "Player2ColorLabel";
            this.Player2ColorLabel.Size = new System.Drawing.Size(92, 18);
            this.Player2ColorLabel.TabIndex = 14;
            this.Player2ColorLabel.Text = "Player2 Color :";
            // 
            // Reset
            // 
            this.Reset.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Reset.AutoSize = true;
            this.Reset.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Reset.Location = new System.Drawing.Point(17, 269);
            this.Reset.Name = "Reset";
            this.Reset.Size = new System.Drawing.Size(45, 23);
            this.Reset.TabIndex = 17;
            this.Reset.Text = "Reset";
            this.Reset.UseVisualStyleBackColor = true;
            this.Reset.Click += new System.EventHandler(this.Reset_Click);
            // 
            // Cancel
            // 
            this.Cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Cancel.AutoSize = true;
            this.Cancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Cancel.Location = new System.Drawing.Point(173, 269);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(50, 23);
            this.Cancel.TabIndex = 18;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Ok
            // 
            this.Ok.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Ok.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Ok.Location = new System.Drawing.Point(92, 269);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(51, 23);
            this.Ok.TabIndex = 19;
            this.Ok.Text = "  Ok  ";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.UpdateGameOptions);
            // 
            // player1color
            // 
            this.player1color.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.player1color.Location = new System.Drawing.Point(123, 205);
            this.player1color.Name = "player1color";
            this.player1color.Size = new System.Drawing.Size(100, 23);
            this.player1color.TabIndex = 20;
            this.player1color.Text = "Choose";
            this.player1color.UseVisualStyleBackColor = true;
            this.player1color.Click += new System.EventHandler(this.player_color_Click);
            // 
            // player2color
            // 
            this.player2color.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.player2color.Location = new System.Drawing.Point(123, 234);
            this.player2color.Name = "player2color";
            this.player2color.Size = new System.Drawing.Size(100, 23);
            this.player2color.TabIndex = 21;
            this.player2color.Text = "Choose";
            this.player2color.UseVisualStyleBackColor = true;
            this.player2color.Click += new System.EventHandler(this.player_color_Click);
            // 
            // randomRadioButton
            // 
            this.randomRadioButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.randomRadioButton.AutoSize = true;
            this.randomRadioButton.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomRadioButton.Location = new System.Drawing.Point(133, 167);
            this.randomRadioButton.Name = "randomRadioButton";
            this.randomRadioButton.Size = new System.Drawing.Size(84, 26);
            this.randomRadioButton.TabIndex = 22;
            this.randomRadioButton.TabStop = true;
            this.randomRadioButton.Text = "Random";
            this.randomRadioButton.UseVisualStyleBackColor = true;
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(235, 304);
            this.Controls.Add(this.randomRadioButton);
            this.Controls.Add(this.player2color);
            this.Controls.Add(this.player1color);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Reset);
            this.Controls.Add(this.Player2ColorLabel);
            this.Controls.Add(this.Player1ColorLabel);
            this.Controls.Add(this.OradioButton);
            this.Controls.Add(this.XradioButton);
            this.Controls.Add(this.Olabel);
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.FirstIsLabel);
            this.Controls.Add(this.ComputerStartsCheckBox);
            this.Controls.Add(this.ComputerStartLabel);
            this.Controls.Add(this.singlePlayerCheckBox);
            this.Controls.Add(this.singlePlayerLabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.BoardSize);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(251, 343);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "  Options";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label BoardSize;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label singlePlayerLabel;
        private System.Windows.Forms.CheckBox singlePlayerCheckBox;
        private System.Windows.Forms.Label ComputerStartLabel;
        private System.Windows.Forms.CheckBox ComputerStartsCheckBox;
        private System.Windows.Forms.Label FirstIsLabel;
        private System.Windows.Forms.Label xLabel;
        private System.Windows.Forms.Label Olabel;
        private System.Windows.Forms.RadioButton XradioButton;
        private System.Windows.Forms.RadioButton OradioButton;
        private System.Windows.Forms.Label Player1ColorLabel;
        private System.Windows.Forms.Label Player2ColorLabel;
        private System.Windows.Forms.Button Reset;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button player1color;
        private System.Windows.Forms.Button player2color;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.RadioButton randomRadioButton;
    }
}