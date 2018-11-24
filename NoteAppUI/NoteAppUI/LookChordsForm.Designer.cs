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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LookChordsForm));
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
			this.back.Location = new System.Drawing.Point(376, 12);
			this.back.Name = "back";
			this.back.Size = new System.Drawing.Size(27, 20);
			this.back.TabIndex = 0;
			this.back.UseVisualStyleBackColor = true;
			this.back.Click += new System.EventHandler(this.Back_Click);
			// 
			// listOfChords
			// 
			this.listOfChords.BackColor = System.Drawing.Color.WhiteSmoke;
			this.listOfChords.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.listOfChords.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.listOfChords.ForeColor = System.Drawing.Color.Black;
			this.listOfChords.FormattingEnabled = true;
			this.listOfChords.ItemHeight = 16;
			this.listOfChords.Location = new System.Drawing.Point(24, 27);
			this.listOfChords.Name = "listOfChords";
			this.listOfChords.Size = new System.Drawing.Size(140, 290);
			this.listOfChords.TabIndex = 1;
			this.listOfChords.SelectedIndexChanged += new System.EventHandler(this.ListOfChords_SelectedIndexChanged);
			// 
			// addItemButton
			// 
			this.addItemButton.BackColor = System.Drawing.Color.Transparent;
			this.addItemButton.FlatAppearance.BorderSize = 0;
			this.addItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addItemButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.addItemButton.ForeColor = System.Drawing.Color.Black;
			this.addItemButton.Image = ((System.Drawing.Image)(resources.GetObject("addItemButton.Image")));
			this.addItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addItemButton.Location = new System.Drawing.Point(247, 323);
			this.addItemButton.Name = "addItemButton";
			this.addItemButton.Size = new System.Drawing.Size(156, 34);
			this.addItemButton.TabIndex = 2;
			this.addItemButton.Text = "Добавить аккорд";
			this.addItemButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addItemButton.UseVisualStyleBackColor = false;
			this.addItemButton.Click += new System.EventHandler(this.Add_chord_Click);
			// 
			// deleteItemButton
			// 
			this.deleteItemButton.BackColor = System.Drawing.Color.Transparent;
			this.deleteItemButton.FlatAppearance.BorderSize = 0;
			this.deleteItemButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteItemButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.deleteItemButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteItemButton.Image")));
			this.deleteItemButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deleteItemButton.Location = new System.Drawing.Point(243, 363);
			this.deleteItemButton.Name = "deleteItemButton";
			this.deleteItemButton.Size = new System.Drawing.Size(160, 34);
			this.deleteItemButton.TabIndex = 3;
			this.deleteItemButton.Text = "  Удалить аккорд";
			this.deleteItemButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.deleteItemButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.deleteItemButton.UseVisualStyleBackColor = false;
			this.deleteItemButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
			// 
			// noteBox
			// 
			this.noteBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.noteBox.Location = new System.Drawing.Point(176, 70);
			this.noteBox.Name = "noteBox";
			this.noteBox.Size = new System.Drawing.Size(215, 222);
			this.noteBox.TabIndex = 4;
			this.noteBox.TabStop = false;
			this.noteBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NoteBox_Paint);
			// 
			// chordName
			// 
			this.chordName.AutoSize = true;
			this.chordName.BackColor = System.Drawing.Color.BurlyWood;
			this.chordName.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chordName.Location = new System.Drawing.Point(267, 87);
			this.chordName.Name = "chordName";
			this.chordName.Size = new System.Drawing.Size(0, 20);
			this.chordName.TabIndex = 5;
			// 
			// chordBegin
			// 
			this.chordBegin.AutoSize = true;
			this.chordBegin.BackColor = System.Drawing.Color.Moccasin;
			this.chordBegin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.chordBegin.Location = new System.Drawing.Point(192, 130);
			this.chordBegin.Name = "chordBegin";
			this.chordBegin.Size = new System.Drawing.Size(0, 20);
			this.chordBegin.TabIndex = 6;
			// 
			// New
			// 
			this.New.BackColor = System.Drawing.Color.Transparent;
			this.New.FlatAppearance.BorderSize = 0;
			this.New.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.New.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.New.ForeColor = System.Drawing.Color.Black;
			this.New.Image = ((System.Drawing.Image)(resources.GetObject("New.Image")));
			this.New.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.New.Location = new System.Drawing.Point(12, 422);
			this.New.Name = "New";
			this.New.Size = new System.Drawing.Size(225, 52);
			this.New.TabIndex = 7;
			this.New.Text = "Создать новую библиотеку";
			this.New.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.New.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.New.UseVisualStyleBackColor = false;
			this.New.Click += new System.EventHandler(this.New_Click);
			// 
			// Open
			// 
			this.Open.BackColor = System.Drawing.Color.Transparent;
			this.Open.FlatAppearance.BorderSize = 0;
			this.Open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Open.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.Open.Image = ((System.Drawing.Image)(resources.GetObject("Open.Image")));
			this.Open.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Open.Location = new System.Drawing.Point(12, 378);
			this.Open.Name = "Open";
			this.Open.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Open.Size = new System.Drawing.Size(225, 52);
			this.Open.TabIndex = 8;
			this.Open.Text = "            Открыть библиотеку";
			this.Open.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Open.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Open.UseVisualStyleBackColor = false;
			this.Open.Click += new System.EventHandler(this.Open_Click);
			// 
			// Save
			// 
			this.Save.BackColor = System.Drawing.Color.Transparent;
			this.Save.FlatAppearance.BorderSize = 0;
			this.Save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Save.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.Save.Image = ((System.Drawing.Image)(resources.GetObject("Save.Image")));
			this.Save.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.Save.Location = new System.Drawing.Point(12, 334);
			this.Save.Name = "Save";
			this.Save.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Save.Size = new System.Drawing.Size(225, 52);
			this.Save.TabIndex = 9;
			this.Save.Text = "     Сохранить библиотеку";
			this.Save.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Save.UseVisualStyleBackColor = false;
			this.Save.Click += new System.EventHandler(this.Save_Click);
			// 
			// LookChordsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
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
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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