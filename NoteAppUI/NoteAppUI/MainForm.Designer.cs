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
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// ShowChordsButton
			// 
			this.ShowChordsButton.BackColor = System.Drawing.Color.Transparent;
			this.ShowChordsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.ShowChordsButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
			this.ShowChordsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShowChordsButton.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.ShowChordsButton.ForeColor = System.Drawing.Color.Black;
			this.ShowChordsButton.Location = new System.Drawing.Point(108, 241);
			this.ShowChordsButton.Name = "ShowChordsButton";
			this.ShowChordsButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.ShowChordsButton.Size = new System.Drawing.Size(200, 40);
			this.ShowChordsButton.TabIndex = 1;
			this.ShowChordsButton.Text = "Просмотреть аккорды";
			this.ShowChordsButton.UseVisualStyleBackColor = false;
			this.ShowChordsButton.Click += new System.EventHandler(this.ShowChordsButton_Click);
			// 
			// ShowMelodysButton
			// 
			this.ShowMelodysButton.BackColor = System.Drawing.Color.Transparent;
			this.ShowMelodysButton.Enabled = false;
			this.ShowMelodysButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ShowMelodysButton.Font = new System.Drawing.Font("Century Gothic", 11F);
			this.ShowMelodysButton.Location = new System.Drawing.Point(108, 299);
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
			this.MainTitle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.MainTitle.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainTitle.ForeColor = System.Drawing.Color.Black;
			this.MainTitle.Location = new System.Drawing.Point(22, 138);
			this.MainTitle.Name = "MainTitle";
			this.MainTitle.Size = new System.Drawing.Size(370, 38);
			this.MainTitle.TabIndex = 3;
			this.MainTitle.Text = "Библиотека Аккордов";
			// 
			// CloseButton
			// 
			this.CloseButton.FlatAppearance.BorderSize = 0;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.Location = new System.Drawing.Point(366, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(37, 31);
			this.CloseButton.TabIndex = 4;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.CloseButton);
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
		private System.Windows.Forms.Button CloseButton;
	}
}

