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
			this.CloseButton = new System.Windows.Forms.Button();
			this.ListOfChordNamesListBox = new System.Windows.Forms.ListBox();
			this.AddChordButton = new System.Windows.Forms.Button();
			this.DeleteChordButton = new System.Windows.Forms.Button();
			this.GridPictureBox = new System.Windows.Forms.PictureBox();
			this.ChordNameLabel = new System.Windows.Forms.Label();
			this.ChordBeginFretLabel = new System.Windows.Forms.Label();
			this.CreateNewLibraryButton = new System.Windows.Forms.Button();
			this.OpenLibraryButton = new System.Windows.Forms.Button();
			this.SaveLibraryButton = new System.Windows.Forms.Button();
			this.NameOfCurrentLibraryLabel = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// CloseButton
			// 
			this.CloseButton.FlatAppearance.BorderSize = 0;
			this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CloseButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CloseButton.Location = new System.Drawing.Point(369, 12);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(34, 32);
			this.CloseButton.TabIndex = 0;
			this.CloseButton.Text = "X";
			this.CloseButton.UseVisualStyleBackColor = true;
			this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
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
			this.ListOfChordNamesListBox.Size = new System.Drawing.Size(140, 296);
			this.ListOfChordNamesListBox.TabIndex = 1;
			this.ListOfChordNamesListBox.SelectedIndexChanged += new System.EventHandler(this.ListOfChordNamesListBox_SelectedIndexChanged);
			// 
			// AddChordButton
			// 
			this.AddChordButton.BackColor = System.Drawing.Color.Transparent;
			this.AddChordButton.FlatAppearance.BorderSize = 0;
			this.AddChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddChordButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.AddChordButton.ForeColor = System.Drawing.Color.Black;
			this.AddChordButton.Image = ((System.Drawing.Image)(resources.GetObject("AddChordButton.Image")));
			this.AddChordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.AddChordButton.Location = new System.Drawing.Point(247, 339);
			this.AddChordButton.Name = "AddChordButton";
			this.AddChordButton.Size = new System.Drawing.Size(156, 43);
			this.AddChordButton.TabIndex = 2;
			this.AddChordButton.Text = "   Добавить аккорд";
			this.AddChordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.AddChordButton.UseVisualStyleBackColor = false;
			this.AddChordButton.Click += new System.EventHandler(this.AddChordButton_Click);
			// 
			// DeleteChordButton
			// 
			this.DeleteChordButton.BackColor = System.Drawing.Color.Transparent;
			this.DeleteChordButton.FlatAppearance.BorderSize = 0;
			this.DeleteChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteChordButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.DeleteChordButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteChordButton.Image")));
			this.DeleteChordButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.DeleteChordButton.Location = new System.Drawing.Point(247, 388);
			this.DeleteChordButton.Name = "DeleteChordButton";
			this.DeleteChordButton.Size = new System.Drawing.Size(160, 39);
			this.DeleteChordButton.TabIndex = 3;
			this.DeleteChordButton.Text = "   Удалить аккорд";
			this.DeleteChordButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.DeleteChordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.DeleteChordButton.UseVisualStyleBackColor = false;
			this.DeleteChordButton.Click += new System.EventHandler(this.DeleteChordButton_Click);
			// 
			// GridPictureBox
			// 
			this.GridPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.GridPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GridPictureBox.Location = new System.Drawing.Point(184, 95);
			this.GridPictureBox.Name = "GridPictureBox";
			this.GridPictureBox.Size = new System.Drawing.Size(215, 222);
			this.GridPictureBox.TabIndex = 4;
			this.GridPictureBox.TabStop = false;
			// 
			// ChordNameLabel
			// 
			this.ChordNameLabel.AutoSize = true;
			this.ChordNameLabel.BackColor = System.Drawing.Color.Transparent;
			this.ChordNameLabel.Font = new System.Drawing.Font("Century Gothic", 16F);
			this.ChordNameLabel.Location = new System.Drawing.Point(265, 60);
			this.ChordNameLabel.Name = "ChordNameLabel";
			this.ChordNameLabel.Size = new System.Drawing.Size(0, 25);
			this.ChordNameLabel.TabIndex = 5;
			// 
			// ChordBeginFretLabel
			// 
			this.ChordBeginFretLabel.AutoSize = true;
			this.ChordBeginFretLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ChordBeginFretLabel.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.ChordBeginFretLabel.Location = new System.Drawing.Point(190, 110);
			this.ChordBeginFretLabel.Name = "ChordBeginFretLabel";
			this.ChordBeginFretLabel.Size = new System.Drawing.Size(0, 19);
			this.ChordBeginFretLabel.TabIndex = 6;
			// 
			// CreateNewLibraryButton
			// 
			this.CreateNewLibraryButton.BackColor = System.Drawing.Color.Transparent;
			this.CreateNewLibraryButton.FlatAppearance.BorderSize = 0;
			this.CreateNewLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CreateNewLibraryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.CreateNewLibraryButton.ForeColor = System.Drawing.Color.Black;
			this.CreateNewLibraryButton.Image = ((System.Drawing.Image)(resources.GetObject("CreateNewLibraryButton.Image")));
			this.CreateNewLibraryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.CreateNewLibraryButton.Location = new System.Drawing.Point(12, 433);
			this.CreateNewLibraryButton.Name = "CreateNewLibraryButton";
			this.CreateNewLibraryButton.Size = new System.Drawing.Size(225, 38);
			this.CreateNewLibraryButton.TabIndex = 7;
			this.CreateNewLibraryButton.Text = "     Создать новую";
			this.CreateNewLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.CreateNewLibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.CreateNewLibraryButton.UseVisualStyleBackColor = false;
			this.CreateNewLibraryButton.Click += new System.EventHandler(this.CreateNewLibraryButton_Click);
			// 
			// OpenLibraryButton
			// 
			this.OpenLibraryButton.BackColor = System.Drawing.Color.Transparent;
			this.OpenLibraryButton.FlatAppearance.BorderSize = 0;
			this.OpenLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.OpenLibraryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.OpenLibraryButton.Image = ((System.Drawing.Image)(resources.GetObject("OpenLibraryButton.Image")));
			this.OpenLibraryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.OpenLibraryButton.Location = new System.Drawing.Point(12, 388);
			this.OpenLibraryButton.Name = "OpenLibraryButton";
			this.OpenLibraryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.OpenLibraryButton.Size = new System.Drawing.Size(225, 39);
			this.OpenLibraryButton.TabIndex = 8;
			this.OpenLibraryButton.Text = "     Открыть библиотеку";
			this.OpenLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.OpenLibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.OpenLibraryButton.UseVisualStyleBackColor = false;
			this.OpenLibraryButton.Click += new System.EventHandler(this.OpenLibraryButton_Click);
			// 
			// SaveLibraryButton
			// 
			this.SaveLibraryButton.BackColor = System.Drawing.Color.Transparent;
			this.SaveLibraryButton.FlatAppearance.BorderSize = 0;
			this.SaveLibraryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.SaveLibraryButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.SaveLibraryButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveLibraryButton.Image")));
			this.SaveLibraryButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
			this.SaveLibraryButton.Location = new System.Drawing.Point(12, 339);
			this.SaveLibraryButton.Name = "SaveLibraryButton";
			this.SaveLibraryButton.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.SaveLibraryButton.Size = new System.Drawing.Size(225, 43);
			this.SaveLibraryButton.TabIndex = 9;
			this.SaveLibraryButton.Text = "     Сохранить библиотеку";
			this.SaveLibraryButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.SaveLibraryButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.SaveLibraryButton.UseVisualStyleBackColor = false;
			this.SaveLibraryButton.Click += new System.EventHandler(this.SaveLibraryButton_Click);
			// 
			// NameOfCurrentLibraryLabel
			// 
			this.NameOfCurrentLibraryLabel.AutoSize = true;
			this.NameOfCurrentLibraryLabel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameOfCurrentLibraryLabel.Location = new System.Drawing.Point(181, 27);
			this.NameOfCurrentLibraryLabel.Name = "NameOfCurrentLibraryLabel";
			this.NameOfCurrentLibraryLabel.Size = new System.Drawing.Size(130, 17);
			this.NameOfCurrentLibraryLabel.TabIndex = 10;
			this.NameOfCurrentLibraryLabel.Text = "Новая библиотека";
			// 
			// LookChordsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.NameOfCurrentLibraryLabel);
			this.Controls.Add(this.SaveLibraryButton);
			this.Controls.Add(this.OpenLibraryButton);
			this.Controls.Add(this.CreateNewLibraryButton);
			this.Controls.Add(this.ChordBeginFretLabel);
			this.Controls.Add(this.ChordNameLabel);
			this.Controls.Add(this.GridPictureBox);
			this.Controls.Add(this.DeleteChordButton);
			this.Controls.Add(this.AddChordButton);
			this.Controls.Add(this.ListOfChordNamesListBox);
			this.Controls.Add(this.CloseButton);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "LookChordsForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Просмотр библиотеки";
			((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.ListBox ListOfChordNamesListBox;
        private System.Windows.Forms.Button AddChordButton;
        private System.Windows.Forms.Button DeleteChordButton;
        private System.Windows.Forms.PictureBox GridPictureBox;
		private System.Windows.Forms.Label ChordNameLabel;
		private System.Windows.Forms.Label ChordBeginFretLabel;
		private System.Windows.Forms.Button CreateNewLibraryButton;
		private System.Windows.Forms.Button OpenLibraryButton;
		private System.Windows.Forms.Button SaveLibraryButton;
        private System.Windows.Forms.Label NameOfCurrentLibraryLabel;
    }
}