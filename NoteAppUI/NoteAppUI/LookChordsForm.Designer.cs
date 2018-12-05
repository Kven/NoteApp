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
			this.backButton = new System.Windows.Forms.Button();
			this.ListOfChordNamesListBox = new System.Windows.Forms.ListBox();
			this.addChordButton = new System.Windows.Forms.Button();
			this.deleteChordButton = new System.Windows.Forms.Button();
			this.gridPictureBox = new System.Windows.Forms.PictureBox();
			this.chordNameLabel = new System.Windows.Forms.Label();
			this.chordBeginFretLabel = new System.Windows.Forms.Label();
			this.createNewLibraryButton = new System.Windows.Forms.Button();
			this.openLibraryButton = new System.Windows.Forms.Button();
			this.saveLibraryButton = new System.Windows.Forms.Button();
			this.nameOfCurrentLibraryLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// backButton
			// 
			this.backButton.FlatAppearance.BorderSize = 0;
			this.backButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.backButton.Image = global::NoteAppUI.Properties.Resources.back_arrow;
			this.backButton.Location = new System.Drawing.Point(376, 12);
			this.backButton.Name = "backButton";
			this.backButton.Size = new System.Drawing.Size(27, 20);
			this.backButton.TabIndex = 0;
			this.backButton.UseVisualStyleBackColor = true;
			this.backButton.Click += new System.EventHandler(this.Back_Click);
			// 
			// ListOfChordNamesListBox
			// 
			this.ListOfChordNamesListBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ListOfChordNamesListBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.ListOfChordNamesListBox.Font = new System.Drawing.Font("Century Gothic", 12F);
			this.ListOfChordNamesListBox.ForeColor = System.Drawing.Color.Black;
			this.ListOfChordNamesListBox.FormattingEnabled = true;
			this.ListOfChordNamesListBox.ItemHeight = 21;
			this.ListOfChordNamesListBox.Location = new System.Drawing.Point(24, 27);
			this.ListOfChordNamesListBox.Name = "ListOfChordNamesListBox";
			this.ListOfChordNamesListBox.Size = new System.Drawing.Size(140, 275);
			this.ListOfChordNamesListBox.TabIndex = 1;
			this.ListOfChordNamesListBox.SelectedIndexChanged += new System.EventHandler(this.ListOfChords_SelectedIndexChanged);
			// 
			// addChordButton
			// 
			this.addChordButton.BackColor = System.Drawing.Color.Transparent;
			this.addChordButton.FlatAppearance.BorderSize = 0;
			this.addChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addChordButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.addChordButton.ForeColor = System.Drawing.Color.Black;
			this.addChordButton.Image = ((System.Drawing.Image)(resources.GetObject("addChordButton.Image")));
			this.addChordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.addChordButton.Location = new System.Drawing.Point(247, 339);
			this.addChordButton.Name = "addChordButton";
			this.addChordButton.Size = new System.Drawing.Size(156, 43);
			this.addChordButton.TabIndex = 2;
			this.addChordButton.Text = "   Добавить аккорд";
			this.addChordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.addChordButton.UseVisualStyleBackColor = false;
			this.addChordButton.Click += new System.EventHandler(this.Add_chord_Click);
			// 
			// deleteChordButton
			// 
			this.deleteChordButton.BackColor = System.Drawing.Color.Transparent;
			this.deleteChordButton.FlatAppearance.BorderSize = 0;
			this.deleteChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.deleteChordButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.deleteChordButton.Image = ((System.Drawing.Image)(resources.GetObject("deleteChordButton.Image")));
			this.deleteChordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.deleteChordButton.Location = new System.Drawing.Point(247, 388);
			this.deleteChordButton.Name = "deleteChordButton";
			this.deleteChordButton.Size = new System.Drawing.Size(160, 39);
			this.deleteChordButton.TabIndex = 3;
			this.deleteChordButton.Text = "   Удалить аккорд";
			this.deleteChordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.deleteChordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.deleteChordButton.UseVisualStyleBackColor = false;
			this.deleteChordButton.Click += new System.EventHandler(this.DeleteItemButton_Click);
			// 
			// gridPictureBox
			// 
			this.gridPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gridPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridPictureBox.Location = new System.Drawing.Point(184, 95);
			this.gridPictureBox.Name = "gridPictureBox";
			this.gridPictureBox.Size = new System.Drawing.Size(215, 222);
			this.gridPictureBox.TabIndex = 4;
			this.gridPictureBox.TabStop = false;
			this.gridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NoteBox_Paint);
			// 
			// chordNameLabel
			// 
			this.chordNameLabel.AutoSize = true;
			this.chordNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.chordNameLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
			this.chordNameLabel.Location = new System.Drawing.Point(260, 60);
			this.chordNameLabel.Name = "chordNameLabel";
			this.chordNameLabel.Size = new System.Drawing.Size(0, 25);
			this.chordNameLabel.TabIndex = 5;
			// 
			// chordBeginFretLabel
			// 
			this.chordBeginFretLabel.AutoSize = true;
			this.chordBeginFretLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.chordBeginFretLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.chordBeginFretLabel.Location = new System.Drawing.Point(190, 110);
			this.chordBeginFretLabel.Name = "chordBeginFretLabel";
			this.chordBeginFretLabel.Size = new System.Drawing.Size(0, 19);
			this.chordBeginFretLabel.TabIndex = 6;
			// 
			// createNewLibraryButton
			// 
			this.createNewLibraryButton.BackColor = System.Drawing.Color.Transparent;
			this.createNewLibraryButton.FlatAppearance.BorderSize = 0;
			this.createNewLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.createNewLibraryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.createNewLibraryButton.ForeColor = System.Drawing.Color.Black;
			this.createNewLibraryButton.Image = ((System.Drawing.Image)(resources.GetObject("createNewLibraryButton.Image")));
			this.createNewLibraryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.createNewLibraryButton.Location = new System.Drawing.Point(12, 433);
			this.createNewLibraryButton.Name = "createNewLibraryButton";
			this.createNewLibraryButton.Size = new System.Drawing.Size(225, 38);
			this.createNewLibraryButton.TabIndex = 7;
			this.createNewLibraryButton.Text = "     Создать новую";
			this.createNewLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.createNewLibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.createNewLibraryButton.UseVisualStyleBackColor = false;
			this.createNewLibraryButton.Click += new System.EventHandler(this.New_Click);
			// 
			// openLibraryButton
			// 
			this.openLibraryButton.BackColor = System.Drawing.Color.Transparent;
			this.openLibraryButton.FlatAppearance.BorderSize = 0;
			this.openLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.openLibraryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.openLibraryButton.Image = ((System.Drawing.Image)(resources.GetObject("openLibraryButton.Image")));
			this.openLibraryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.openLibraryButton.Location = new System.Drawing.Point(12, 388);
			this.openLibraryButton.Name = "openLibraryButton";
			this.openLibraryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.openLibraryButton.Size = new System.Drawing.Size(225, 39);
			this.openLibraryButton.TabIndex = 8;
			this.openLibraryButton.Text = "     Открыть библиотеку";
			this.openLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.openLibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.openLibraryButton.UseVisualStyleBackColor = false;
			this.openLibraryButton.Click += new System.EventHandler(this.Open_Click);
			// 
			// saveLibraryButton
			// 
			this.saveLibraryButton.BackColor = System.Drawing.Color.Transparent;
			this.saveLibraryButton.FlatAppearance.BorderSize = 0;
			this.saveLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.saveLibraryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.saveLibraryButton.Image = ((System.Drawing.Image)(resources.GetObject("saveLibraryButton.Image")));
			this.saveLibraryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.saveLibraryButton.Location = new System.Drawing.Point(12, 339);
			this.saveLibraryButton.Name = "saveLibraryButton";
			this.saveLibraryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.saveLibraryButton.Size = new System.Drawing.Size(225, 43);
			this.saveLibraryButton.TabIndex = 9;
			this.saveLibraryButton.Text = "     Сохранить библиотеку";
			this.saveLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.saveLibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.saveLibraryButton.UseVisualStyleBackColor = false;
			this.saveLibraryButton.Click += new System.EventHandler(this.Save_Click);
			// 
			// nameOfCurrentLibraryLabel
			// 
			this.nameOfCurrentLibraryLabel.AutoSize = true;
			this.nameOfCurrentLibraryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameOfCurrentLibraryLabel.Location = new System.Drawing.Point(181, 27);
			this.nameOfCurrentLibraryLabel.Name = "nameOfCurrentLibraryLabel";
			this.nameOfCurrentLibraryLabel.Size = new System.Drawing.Size(130, 17);
			this.nameOfCurrentLibraryLabel.TabIndex = 10;
			this.nameOfCurrentLibraryLabel.Text = "Новая библиотека";
			// 
			// LookChordsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.nameOfCurrentLibraryLabel);
			this.Controls.Add(this.saveLibraryButton);
			this.Controls.Add(this.openLibraryButton);
			this.Controls.Add(this.createNewLibraryButton);
			this.Controls.Add(this.chordBeginFretLabel);
			this.Controls.Add(this.chordNameLabel);
			this.Controls.Add(this.gridPictureBox);
			this.Controls.Add(this.deleteChordButton);
			this.Controls.Add(this.addChordButton);
			this.Controls.Add(this.ListOfChordNamesListBox);
			this.Controls.Add(this.backButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LookChordsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Просмотр библиотеки";
			this.Load += new System.EventHandler(this.LookChordsForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ListBox ListOfChordNamesListBox;
        private System.Windows.Forms.Button addChordButton;
        private System.Windows.Forms.Button deleteChordButton;
        private System.Windows.Forms.PictureBox gridPictureBox;
		private System.Windows.Forms.Label chordNameLabel;
		private System.Windows.Forms.Label chordBeginFretLabel;
		private System.Windows.Forms.Button createNewLibraryButton;
		private System.Windows.Forms.Button openLibraryButton;
		private System.Windows.Forms.Button saveLibraryButton;
        private System.Windows.Forms.Label nameOfCurrentLibraryLabel;
    }
}