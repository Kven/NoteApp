namespace NoteAppUI
{
    partial class AddChordForm
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
			this.GridPictureBox = new System.Windows.Forms.PictureBox();
			this.NameInputTextBox = new System.Windows.Forms.TextBox();
			this.BeginFretInputTextBox = new System.Windows.Forms.TextBox();
			this.NameLabel = new System.Windows.Forms.Label();
			this.BeginFretLabel = new System.Windows.Forms.Label();
			this.AddChordButton = new System.Windows.Forms.Button();
			this.NameOnBoxLabel = new System.Windows.Forms.Label();
			this.BeginFretOnBoxLabel = new System.Windows.Forms.Label();
			this.ClearButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// GridPictureBox
			// 
			this.GridPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.GridPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.GridPictureBox.Location = new System.Drawing.Point(60, 136);
			this.GridPictureBox.Name = "GridPictureBox";
			this.GridPictureBox.Size = new System.Drawing.Size(294, 313);
			this.GridPictureBox.TabIndex = 2;
			this.GridPictureBox.TabStop = false;
			this.GridPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteBox_MouseDown);
			// 
			// NameInputTextBox
			// 
			this.NameInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NameInputTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameInputTextBox.Location = new System.Drawing.Point(166, 49);
			this.NameInputTextBox.Name = "NameInputTextBox";
			this.NameInputTextBox.Size = new System.Drawing.Size(69, 24);
			this.NameInputTextBox.TabIndex = 3;
			this.NameInputTextBox.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
			// 
			// BeginFretInputTextBox
			// 
			this.BeginFretInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BeginFretInputTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BeginFretInputTextBox.Location = new System.Drawing.Point(166, 89);
			this.BeginFretInputTextBox.Name = "BeginFretInputTextBox";
			this.BeginFretInputTextBox.Size = new System.Drawing.Size(24, 24);
			this.BeginFretInputTextBox.TabIndex = 4;
			this.BeginFretInputTextBox.TextChanged += new System.EventHandler(this.BeginInput_TextChanged);
			// 
			// NameLabel
			// 
			this.NameLabel.AutoSize = true;
			this.NameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameLabel.Location = new System.Drawing.Point(12, 53);
			this.NameLabel.Name = "NameLabel";
			this.NameLabel.Size = new System.Drawing.Size(153, 20);
			this.NameLabel.TabIndex = 5;
			this.NameLabel.Text = "Название аккорда:";
			// 
			// BeginFretLabel
			// 
			this.BeginFretLabel.AutoSize = true;
			this.BeginFretLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BeginFretLabel.Location = new System.Drawing.Point(41, 89);
			this.BeginFretLabel.Name = "BeginFretLabel";
			this.BeginFretLabel.Size = new System.Drawing.Size(124, 20);
			this.BeginFretLabel.TabIndex = 6;
			this.BeginFretLabel.Text = "Начальный лад:";
			// 
			// AddChordButton
			// 
			this.AddChordButton.BackColor = System.Drawing.Color.Transparent;
			this.AddChordButton.FlatAppearance.BorderSize = 0;
			this.AddChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.AddChordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.AddChordButton.Location = new System.Drawing.Point(289, 66);
			this.AddChordButton.Name = "AddChordButton";
			this.AddChordButton.Size = new System.Drawing.Size(99, 33);
			this.AddChordButton.TabIndex = 7;
			this.AddChordButton.Text = "Добавить";
			this.AddChordButton.UseVisualStyleBackColor = false;
			this.AddChordButton.Click += new System.EventHandler(this.AddChord_Click);
			// 
			// NameOnBoxLabel
			// 
			this.NameOnBoxLabel.AutoSize = true;
			this.NameOnBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.NameOnBoxLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.NameOnBoxLabel.Location = new System.Drawing.Point(190, 163);
			this.NameOnBoxLabel.Name = "NameOnBoxLabel";
			this.NameOnBoxLabel.Size = new System.Drawing.Size(0, 21);
			this.NameOnBoxLabel.TabIndex = 9;
			// 
			// BeginFretOnBoxLabel
			// 
			this.BeginFretOnBoxLabel.AutoSize = true;
			this.BeginFretOnBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.BeginFretOnBoxLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.BeginFretOnBoxLabel.Location = new System.Drawing.Point(105, 195);
			this.BeginFretOnBoxLabel.Name = "BeginFretOnBoxLabel";
			this.BeginFretOnBoxLabel.Size = new System.Drawing.Size(0, 21);
			this.BeginFretOnBoxLabel.TabIndex = 10;
			// 
			// ClearButton
			// 
			this.ClearButton.BackColor = System.Drawing.Color.Transparent;
			this.ClearButton.FlatAppearance.BorderSize = 0;
			this.ClearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.ClearButton.Location = new System.Drawing.Point(151, 455);
			this.ClearButton.Name = "ClearButton";
			this.ClearButton.Size = new System.Drawing.Size(97, 33);
			this.ClearButton.TabIndex = 11;
			this.ClearButton.Text = "Очистить";
			this.ClearButton.UseVisualStyleBackColor = false;
			this.ClearButton.Click += new System.EventHandler(this.Clear_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.FlatAppearance.BorderSize = 0;
			this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.CancelButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.CancelButton.Location = new System.Drawing.Point(366, 12);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(37, 31);
			this.CancelButton.TabIndex = 12;
			this.CancelButton.Text = "X";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.Сancel_Click);
			// 
			// AddChordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.CancelButton);
			this.Controls.Add(this.ClearButton);
			this.Controls.Add(this.BeginFretOnBoxLabel);
			this.Controls.Add(this.NameOnBoxLabel);
			this.Controls.Add(this.AddChordButton);
			this.Controls.Add(this.BeginFretLabel);
			this.Controls.Add(this.NameLabel);
			this.Controls.Add(this.BeginFretInputTextBox);
			this.Controls.Add(this.NameInputTextBox);
			this.Controls.Add(this.GridPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddChordForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание аккорда";
			this.Load += new System.EventHandler(this.AddChordForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.GridPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox GridPictureBox;
        private System.Windows.Forms.TextBox NameInputTextBox;
        private System.Windows.Forms.TextBox BeginFretInputTextBox;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label BeginFretLabel;
        private System.Windows.Forms.Button AddChordButton;
        private System.Windows.Forms.Label NameOnBoxLabel;
        private System.Windows.Forms.Label BeginFretOnBoxLabel;
		private System.Windows.Forms.Button ClearButton;
		private System.Windows.Forms.Button CancelButton;
	}
}