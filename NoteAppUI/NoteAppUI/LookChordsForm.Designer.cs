namespace NoteAppUI
{
    partial class LookChordsForm
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
            this.BrowseChord = new System.Windows.Forms.ListBox();
            this.add_chord = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
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
            this.back.Click += new System.EventHandler(this.Back_Click);
            // 
            // BrowseChord
            // 
            this.BrowseChord.FormattingEnabled = true;
            this.BrowseChord.Location = new System.Drawing.Point(56, 80);
            this.BrowseChord.Name = "BrowseChord";
            this.BrowseChord.Size = new System.Drawing.Size(140, 368);
            this.BrowseChord.TabIndex = 1;
            // 
            // add_chord
            // 
            this.add_chord.Location = new System.Drawing.Point(260, 126);
            this.add_chord.Name = "add_chord";
            this.add_chord.Size = new System.Drawing.Size(75, 23);
            this.add_chord.TabIndex = 2;
            this.add_chord.Text = "Тест 1";
            this.add_chord.UseVisualStyleBackColor = true;
            this.add_chord.Click += new System.EventHandler(this.Add_chord_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(260, 190);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // LookChordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 500);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.add_chord);
            this.Controls.Add(this.BrowseChord);
            this.Controls.Add(this.back);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "LookChordsForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox BrowseChord;
        private System.Windows.Forms.Button add_chord;
        private System.Windows.Forms.Button button1;
    }
}