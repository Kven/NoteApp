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
			this.listOfChords = new System.Windows.Forms.ListBox();
			this.addItemButton = new System.Windows.Forms.Button();
			this.deleteItemButton = new System.Windows.Forms.Button();
			this.noteBox = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.noteBox)).BeginInit();
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
			// listOfChords
			// 
			this.listOfChords.FormattingEnabled = true;
			this.listOfChords.Location = new System.Drawing.Point(12, 12);
			this.listOfChords.Name = "listOfChords";
			this.listOfChords.Size = new System.Drawing.Size(140, 472);
			this.listOfChords.TabIndex = 1;
			// 
			// addItemButton
			// 
			this.addItemButton.Location = new System.Drawing.Point(177, 331);
			this.addItemButton.Name = "addItemButton";
			this.addItemButton.Size = new System.Drawing.Size(115, 23);
			this.addItemButton.TabIndex = 2;
			this.addItemButton.Text = "Добавить аккорд";
			this.addItemButton.UseVisualStyleBackColor = true;
			this.addItemButton.Click += new System.EventHandler(this.Add_chord_Click);
			// 
			// deleteItemButton
			// 
			this.deleteItemButton.Location = new System.Drawing.Point(177, 372);
			this.deleteItemButton.Name = "deleteItemButton";
			this.deleteItemButton.Size = new System.Drawing.Size(115, 23);
			this.deleteItemButton.TabIndex = 3;
			this.deleteItemButton.Text = "Удалить аккорд";
			this.deleteItemButton.UseVisualStyleBackColor = true;
			this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
			// 
			// noteBox
			// 
			this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.noteBox.Location = new System.Drawing.Point(177, 65);
			this.noteBox.Name = "noteBox";
			this.noteBox.Size = new System.Drawing.Size(215, 222);
			this.noteBox.TabIndex = 4;
			this.noteBox.TabStop = false;
			this.noteBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NoteBox_Paint);
			this.noteBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteBox_MouseDown);
			// 
			// LookChordsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.noteBox);
			this.Controls.Add(this.deleteItemButton);
			this.Controls.Add(this.addItemButton);
			this.Controls.Add(this.listOfChords);
			this.Controls.Add(this.back);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LookChordsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.LookChordsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.noteBox)).EndInit();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox listOfChords;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.PictureBox noteBox;
    }
}