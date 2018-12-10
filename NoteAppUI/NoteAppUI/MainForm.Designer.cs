namespace NoteAppUI
{
    partial class MainForm
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
            this.ShowChordsButton = new System.Windows.Forms.Button();
            this.ShowMelodysButton = new System.Windows.Forms.Button();
            this.MainTitle = new System.Windows.Forms.Label();
            this.close = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ShowChordsButton
            // 
            this.ShowChordsButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowChordsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ShowChordsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ShowChordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowChordsButton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ShowChordsButton.ForeColor = System.Drawing.Color.Black;
            this.ShowChordsButton.Location = new System.Drawing.Point(108, 225);
            this.ShowChordsButton.Name = "ShowChordsButton";
            this.ShowChordsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ShowChordsButton.Size = new System.Drawing.Size(200, 40);
            this.ShowChordsButton.TabIndex = 1;
            this.ShowChordsButton.Text = "Просмотреть аккорды";
            this.ShowChordsButton.UseVisualStyleBackColor = false;
            this.ShowChordsButton.Click += new System.EventHandler(this.Look_chords_Click);
            // 
            // ShowMelodysButton
            // 
            this.ShowMelodysButton.BackColor = System.Drawing.Color.Transparent;
            this.ShowMelodysButton.Enabled = false;
            this.ShowMelodysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ShowMelodysButton.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
            this.ShowMelodysButton.Location = new System.Drawing.Point(108, 325);
            this.ShowMelodysButton.Name = "ShowMelodysButton";
            this.ShowMelodysButton.Size = new System.Drawing.Size(200, 40);
            this.ShowMelodysButton.TabIndex = 2;
            this.ShowMelodysButton.Text = "Библиотека записей";
            this.ShowMelodysButton.UseVisualStyleBackColor = false;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.Color.Transparent;
            this.MainTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTitle.ForeColor = System.Drawing.Color.Black;
            this.MainTitle.Location = new System.Drawing.Point(22, 138);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(372, 38);
            this.MainTitle.TabIndex = 3;
            this.MainTitle.Text = "Библиотека Аккордов";
            // 
            // close
            // 
            this.close.AutoSize = true;
            this.close.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.close.Location = new System.Drawing.Point(385, 9);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(18, 18);
            this.close.TabIndex = 4;
            this.close.Text = "X";
            this.close.Click += new System.EventHandler(this.Close_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(415, 500);
            this.Controls.Add(this.close);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.ShowMelodysButton);
            this.Controls.Add(this.ShowChordsButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Библиотека аккордов";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ShowChordsButton;
        private System.Windows.Forms.Button ShowMelodysButton;
        private System.Windows.Forms.Label MainTitle;
		private System.Windows.Forms.Label close;
	}
}

