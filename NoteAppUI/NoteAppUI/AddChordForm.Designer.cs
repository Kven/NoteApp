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
			this.gridPictureBox = new System.Windows.Forms.PictureBox();
			this.nameInputTextBox = new System.Windows.Forms.TextBox();
			this.beginFretInputTextBox = new System.Windows.Forms.TextBox();
			this.nameLabel = new System.Windows.Forms.Label();
			this.beginFretLabel = new System.Windows.Forms.Label();
			this.addChordButton = new System.Windows.Forms.Button();
			this.cancelButton = new System.Windows.Forms.Button();
			this.nameOnBoxLabel = new System.Windows.Forms.Label();
			this.beginFretOnBoxLabel = new System.Windows.Forms.Label();
			this.clearButton = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).BeginInit();
			this.SuspendLayout();
			// 
			// gridPictureBox
			// 
			this.gridPictureBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.gridPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.gridPictureBox.Location = new System.Drawing.Point(60, 136);
			this.gridPictureBox.Name = "gridPictureBox";
			this.gridPictureBox.Size = new System.Drawing.Size(294, 313);
			this.gridPictureBox.TabIndex = 2;
			this.gridPictureBox.TabStop = false;
			this.gridPictureBox.Paint += new System.Windows.Forms.PaintEventHandler(this.NoteBox_Paint);
			this.gridPictureBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteBox_MouseDown);
			// 
			// nameInputTextBox
			// 
			this.nameInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nameInputTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameInputTextBox.Location = new System.Drawing.Point(166, 49);
			this.nameInputTextBox.Name = "nameInputTextBox";
			this.nameInputTextBox.Size = new System.Drawing.Size(100, 24);
			this.nameInputTextBox.TabIndex = 3;
			this.nameInputTextBox.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
			// 
			// beginFretInputTextBox
			// 
			this.beginFretInputTextBox.BackColor = System.Drawing.Color.WhiteSmoke;
			this.beginFretInputTextBox.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.beginFretInputTextBox.Location = new System.Drawing.Point(166, 89);
			this.beginFretInputTextBox.Name = "beginFretInputTextBox";
			this.beginFretInputTextBox.Size = new System.Drawing.Size(24, 24);
			this.beginFretInputTextBox.TabIndex = 4;
			this.beginFretInputTextBox.TextChanged += new System.EventHandler(this.BeginInput_TextChanged);
			// 
			// nameLabel
			// 
			this.nameLabel.AutoSize = true;
			this.nameLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameLabel.Location = new System.Drawing.Point(12, 53);
			this.nameLabel.Name = "nameLabel";
			this.nameLabel.Size = new System.Drawing.Size(153, 20);
			this.nameLabel.TabIndex = 5;
			this.nameLabel.Text = "Название аккорда:";
			// 
			// beginFretLabel
			// 
			this.beginFretLabel.AutoSize = true;
			this.beginFretLabel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.beginFretLabel.Location = new System.Drawing.Point(41, 89);
			this.beginFretLabel.Name = "beginFretLabel";
			this.beginFretLabel.Size = new System.Drawing.Size(124, 20);
			this.beginFretLabel.TabIndex = 6;
			this.beginFretLabel.Text = "Начальный лад:";
			// 
			// addChordButton
			// 
			this.addChordButton.BackColor = System.Drawing.Color.Transparent;
			this.addChordButton.FlatAppearance.BorderSize = 0;
			this.addChordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.addChordButton.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.addChordButton.Location = new System.Drawing.Point(289, 66);
			this.addChordButton.Name = "addChordButton";
			this.addChordButton.Size = new System.Drawing.Size(99, 33);
			this.addChordButton.TabIndex = 7;
			this.addChordButton.Text = "Добавить";
			this.addChordButton.UseVisualStyleBackColor = false;
			this.addChordButton.Click += new System.EventHandler(this.AddChord_Click);
			// 
			// cancelButton
			// 
			this.cancelButton.BackColor = System.Drawing.Color.Transparent;
			this.cancelButton.FlatAppearance.BorderSize = 0;
			this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.cancelButton.Font = new System.Drawing.Font("Century Gothic", 9F);
			this.cancelButton.Location = new System.Drawing.Point(328, 12);
			this.cancelButton.Name = "cancelButton";
			this.cancelButton.Size = new System.Drawing.Size(75, 28);
			this.cancelButton.TabIndex = 8;
			this.cancelButton.Text = "Отменить";
			this.cancelButton.UseVisualStyleBackColor = false;
			this.cancelButton.Click += new System.EventHandler(this.Сancel_Click);
			// 
			// nameOnBoxLabel
			// 
			this.nameOnBoxLabel.AutoSize = true;
			this.nameOnBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.nameOnBoxLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.nameOnBoxLabel.Location = new System.Drawing.Point(190, 163);
			this.nameOnBoxLabel.Name = "nameOnBoxLabel";
			this.nameOnBoxLabel.Size = new System.Drawing.Size(0, 21);
			this.nameOnBoxLabel.TabIndex = 9;
			// 
			// beginFretOnBoxLabel
			// 
			this.beginFretOnBoxLabel.AutoSize = true;
			this.beginFretOnBoxLabel.BackColor = System.Drawing.Color.WhiteSmoke;
			this.beginFretOnBoxLabel.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.beginFretOnBoxLabel.Location = new System.Drawing.Point(105, 195);
			this.beginFretOnBoxLabel.Name = "beginFretOnBoxLabel";
			this.beginFretOnBoxLabel.Size = new System.Drawing.Size(0, 21);
			this.beginFretOnBoxLabel.TabIndex = 10;
			// 
			// clearButton
			// 
			this.clearButton.BackColor = System.Drawing.Color.Transparent;
			this.clearButton.FlatAppearance.BorderSize = 0;
			this.clearButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.clearButton.Font = new System.Drawing.Font("Century Gothic", 10F);
			this.clearButton.Location = new System.Drawing.Point(151, 455);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(97, 33);
			this.clearButton.TabIndex = 11;
			this.clearButton.Text = "Очистить";
			this.clearButton.UseVisualStyleBackColor = false;
			this.clearButton.Click += new System.EventHandler(this.Clear_Click);
			// 
			// AddChordForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Gray;
			this.ClientSize = new System.Drawing.Size(415, 500);
			this.Controls.Add(this.clearButton);
			this.Controls.Add(this.beginFretOnBoxLabel);
			this.Controls.Add(this.nameOnBoxLabel);
			this.Controls.Add(this.cancelButton);
			this.Controls.Add(this.addChordButton);
			this.Controls.Add(this.beginFretLabel);
			this.Controls.Add(this.nameLabel);
			this.Controls.Add(this.beginFretInputTextBox);
			this.Controls.Add(this.nameInputTextBox);
			this.Controls.Add(this.gridPictureBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "AddChordForm";
			this.ShowIcon = false;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Создание аккорда";
			this.Load += new System.EventHandler(this.AddChordForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.gridPictureBox)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox gridPictureBox;
        private System.Windows.Forms.TextBox nameInputTextBox;
        private System.Windows.Forms.TextBox beginFretInputTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label beginFretLabel;
        private System.Windows.Forms.Button addChordButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Label nameOnBoxLabel;
        private System.Windows.Forms.Label beginFretOnBoxLabel;
		private System.Windows.Forms.Button clearButton;
	}
}