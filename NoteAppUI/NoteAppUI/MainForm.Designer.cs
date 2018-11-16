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
			this.Add_chord = new System.Windows.Forms.Button();
			this.Look_chords = new System.Windows.Forms.Button();
			this.melody_lib = new System.Windows.Forms.Button();
			this.MainTitle = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Add_chord
			// 
			this.Add_chord.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Add_chord.Location = new System.Drawing.Point(108, 250);
			this.Add_chord.Name = "Add_chord";
			this.Add_chord.Size = new System.Drawing.Size(200, 40);
			this.Add_chord.TabIndex = 0;
			this.Add_chord.Text = "Добавить Аккорд";
			this.Add_chord.UseVisualStyleBackColor = true;
			// 
			// Look_chords
			// 
			this.Look_chords.BackColor = System.Drawing.Color.Transparent;
			this.Look_chords.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.Look_chords.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.Look_chords.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.Look_chords.Location = new System.Drawing.Point(108, 175);
			this.Look_chords.Name = "Look_chords";
			this.Look_chords.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
			this.Look_chords.Size = new System.Drawing.Size(200, 40);
			this.Look_chords.TabIndex = 1;
			this.Look_chords.Text = "Просмотреть аккорды";
			this.Look_chords.UseVisualStyleBackColor = false;
			this.Look_chords.Click += new System.EventHandler(this.Look_chords_Click);
			// 
			// melody_lib
			// 
			this.melody_lib.Enabled = false;
			this.melody_lib.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel, ((byte)(204)));
			this.melody_lib.Location = new System.Drawing.Point(108, 325);
			this.melody_lib.Name = "melody_lib";
			this.melody_lib.Size = new System.Drawing.Size(200, 40);
			this.melody_lib.TabIndex = 2;
			this.melody_lib.Text = "Библиотека записей";
			this.melody_lib.UseVisualStyleBackColor = true;
			// 
			// MainTitle
			// 
			this.MainTitle.AutoSize = true;
			this.MainTitle.BackColor = System.Drawing.Color.Transparent;
			this.MainTitle.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.MainTitle.ForeColor = System.Drawing.SystemColors.Info;
			this.MainTitle.Location = new System.Drawing.Point(39, 91);
			this.MainTitle.Name = "MainTitle";
			this.MainTitle.Size = new System.Drawing.Size(333, 36);
			this.MainTitle.TabIndex = 3;
			this.MainTitle.Text = "Библиотека Аккордов";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.MainTitle);
			this.Controls.Add(this.melody_lib);
			this.Controls.Add(this.Look_chords);
			this.Controls.Add(this.Add_chord);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
			this.Name = "MainForm";
			this.ShowIcon = false;
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_chord;
        private System.Windows.Forms.Button Look_chords;
        private System.Windows.Forms.Button melody_lib;
        private System.Windows.Forms.Label MainTitle;
    }
}

