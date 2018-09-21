namespace NoteAppUI
{
    partial class MainMenu
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
            this.Look_chord = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.MainTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Add_chord
            // 
            this.Add_chord.Location = new System.Drawing.Point(143, 150);
            this.Add_chord.Name = "Add_chord";
            this.Add_chord.Size = new System.Drawing.Size(137, 57);
            this.Add_chord.TabIndex = 0;
            this.Add_chord.Text = "Добавить Аккорд";
            this.Add_chord.UseVisualStyleBackColor = true;
            // 
            // Look_chord
            // 
            this.Look_chord.Location = new System.Drawing.Point(143, 250);
            this.Look_chord.Name = "Look_chord";
            this.Look_chord.Size = new System.Drawing.Size(137, 57);
            this.Look_chord.TabIndex = 1;
            this.Look_chord.Text = "button2";
            this.Look_chord.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(143, 350);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(137, 57);
            this.button3.TabIndex = 2;
            this.button3.Text = "button3";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainTitle
            // 
            this.MainTitle.AutoSize = true;
            this.MainTitle.BackColor = System.Drawing.Color.Transparent;
            this.MainTitle.Font = new System.Drawing.Font("Mistral", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MainTitle.ForeColor = System.Drawing.SystemColors.Info;
            this.MainTitle.Location = new System.Drawing.Point(12, 53);
            this.MainTitle.Name = "MainTitle";
            this.MainTitle.Size = new System.Drawing.Size(392, 57);
            this.MainTitle.TabIndex = 3;
            this.MainTitle.Text = "Библиотека Аккордов";
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.BackgroundImage = global::NoteAppUI.Properties.Resources.back;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(410, 496);
            this.Controls.Add(this.MainTitle);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.Look_chord);
            this.Controls.Add(this.Add_chord);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Name = "MainMenu";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChordsLib";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Add_chord;
        private System.Windows.Forms.Button Look_chord;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label MainTitle;
    }
}

