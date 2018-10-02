namespace NoteAppUI
{
    partial class Look_chords
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
            this.back = new System.Windows.Forms.Button();
            this.browser = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // back
            // 
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.Image = global::NoteAppUI.Properties.Resources.back_arrow;
            this.back.Location = new System.Drawing.Point(372, 12);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(31, 28);
            this.back.TabIndex = 0;
            this.back.UseVisualStyleBackColor = true;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // browser
            // 
            this.browser.FormattingEnabled = true;
            this.browser.Location = new System.Drawing.Point(50, 32);
            this.browser.Name = "browser";
            this.browser.Size = new System.Drawing.Size(316, 433);
            this.browser.TabIndex = 1;
            // 
            // Look_chords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 500);
            this.Controls.Add(this.browser);
            this.Controls.Add(this.back);
            this.Name = "Look_chords";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ChordsLib";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox browser;
    }
}