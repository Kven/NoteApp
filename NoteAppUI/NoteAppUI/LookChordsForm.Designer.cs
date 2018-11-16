﻿namespace NoteAppUI
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
			this.chordName = new System.Windows.Forms.Label();
			this.chordBegin = new System.Windows.Forms.Label();
			this.New = new System.Windows.Forms.Button();
			this.Open = new System.Windows.Forms.Button();
			this.Save = new System.Windows.Forms.Button();
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
			this.listOfChords.SelectedIndexChanged += new System.EventHandler(this.ListOfChords_SelectedIndexChanged);
			// 
			// addItemButton
			// 
			this.addItemButton.Location = new System.Drawing.Point(177, 395);
			this.addItemButton.Name = "addItemButton";
			this.addItemButton.Size = new System.Drawing.Size(115, 23);
			this.addItemButton.TabIndex = 2;
			this.addItemButton.Text = "Добавить аккорд";
			this.addItemButton.UseVisualStyleBackColor = true;
			this.addItemButton.Click += new System.EventHandler(this.Add_chord_Click);
			// 
			// deleteItemButton
			// 
			this.deleteItemButton.Location = new System.Drawing.Point(177, 435);
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
			this.noteBox.Location = new System.Drawing.Point(177, 110);
			this.noteBox.Name = "noteBox";
			this.noteBox.Size = new System.Drawing.Size(215, 222);
			this.noteBox.TabIndex = 4;
			this.noteBox.TabStop = false;
			this.noteBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NoteBox_Paint);
			// 
			// chordName
			// 
			this.chordName.AutoSize = true;
			this.chordName.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chordName.Location = new System.Drawing.Point(267, 87);
			this.chordName.Name = "chordName";
			this.chordName.Size = new System.Drawing.Size(0, 17);
			this.chordName.TabIndex = 5;
			// 
			// chordBegin
			// 
			this.chordBegin.AutoSize = true;
			this.chordBegin.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chordBegin.Location = new System.Drawing.Point(192, 130);
			this.chordBegin.Name = "chordBegin";
			this.chordBegin.Size = new System.Drawing.Size(0, 17);
			this.chordBegin.TabIndex = 6;
			// 
			// New
			// 
			this.New.Location = new System.Drawing.Point(177, 15);
			this.New.Name = "New";
			this.New.Size = new System.Drawing.Size(75, 23);
			this.New.TabIndex = 7;
			this.New.Text = "Новый ";
			this.New.UseVisualStyleBackColor = true;
			this.New.Click += new System.EventHandler(this.New_Click);
			// 
			// Open
			// 
			this.Open.Location = new System.Drawing.Point(177, 58);
			this.Open.Name = "Open";
			this.Open.Size = new System.Drawing.Size(75, 23);
			this.Open.TabIndex = 8;
			this.Open.Text = "Открыть";
			this.Open.UseVisualStyleBackColor = true;
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// Save
			// 
			this.Save.Location = new System.Drawing.Point(270, 58);
			this.Save.Name = "Save";
			this.Save.Size = new System.Drawing.Size(75, 23);
			this.Save.TabIndex = 9;
			this.Save.Text = "Сохранить";
			this.Save.UseVisualStyleBackColor = true;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// LookChordsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.Save);
			this.Controls.Add(this.Open);
			this.Controls.Add(this.New);
			this.Controls.Add(this.chordBegin);
			this.Controls.Add(this.chordName);
			this.Controls.Add(this.noteBox);
			this.Controls.Add(this.deleteItemButton);
			this.Controls.Add(this.addItemButton);
			this.Controls.Add(this.listOfChords);
			this.Controls.Add(this.back);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "LookChordsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Просмотр библиотеки";
			this.Load += new System.EventHandler(this.LookChordsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.noteBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ListBox listOfChords;
        private System.Windows.Forms.Button addItemButton;
        private System.Windows.Forms.Button deleteItemButton;
        private System.Windows.Forms.PictureBox noteBox;
		private System.Windows.Forms.Label chordName;
		private System.Windows.Forms.Label chordBegin;
		private System.Windows.Forms.Button New;
		private System.Windows.Forms.Button Open;
		private System.Windows.Forms.Button Save;
	}
}