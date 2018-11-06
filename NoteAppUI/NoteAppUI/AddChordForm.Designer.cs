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
            this.noteBox = new System.Windows.Forms.PictureBox();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.beginInput = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.beginLabel = new System.Windows.Forms.Label();
            this.addChord = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.name = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.noteBox)).BeginInit();
            this.SuspendLayout();
            // 
            // noteBox
            // 
            this.noteBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.noteBox.Location = new System.Drawing.Point(67, 134);
            this.noteBox.Name = "noteBox";
            this.noteBox.Size = new System.Drawing.Size(294, 313);
            this.noteBox.TabIndex = 2;
            this.noteBox.TabStop = false;
            this.noteBox.MouseDown += new System.Windows.Forms.MouseEventHandler(this.NoteBox_MouseDown);
            this.noteBox.MouseUp += new System.Windows.Forms.MouseEventHandler(this.NoteBox_MouseUp);
            // 
            // nameInput
            // 
            this.nameInput.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameInput.Location = new System.Drawing.Point(141, 46);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 24);
            this.nameInput.TabIndex = 3;
            this.nameInput.TextChanged += new System.EventHandler(this.NameInput_TextChanged);
            // 
            // beginInput
            // 
            this.beginInput.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginInput.Location = new System.Drawing.Point(141, 89);
            this.beginInput.Name = "beginInput";
            this.beginInput.Size = new System.Drawing.Size(100, 24);
            this.beginInput.TabIndex = 4;
            this.beginInput.Text = "1";
            this.beginInput.TextChanged += new System.EventHandler(this.BeginInput_TextChanged);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameLabel.Location = new System.Drawing.Point(12, 53);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(123, 17);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Название аккорда:";
            // 
            // beginLabel
            // 
            this.beginLabel.AutoSize = true;
            this.beginLabel.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.beginLabel.Location = new System.Drawing.Point(28, 96);
            this.beginLabel.Name = "beginLabel";
            this.beginLabel.Size = new System.Drawing.Size(107, 17);
            this.beginLabel.TabIndex = 6;
            this.beginLabel.Text = "Начальный лад:";
            // 
            // addChord
            // 
            this.addChord.Location = new System.Drawing.Point(309, 64);
            this.addChord.Name = "addChord";
            this.addChord.Size = new System.Drawing.Size(80, 33);
            this.addChord.TabIndex = 7;
            this.addChord.Text = "Добавить";
            this.addChord.UseVisualStyleBackColor = true;
            this.addChord.Click += new System.EventHandler(this.AddChord_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(328, 465);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 23);
            this.cancel.TabIndex = 8;
            this.cancel.Text = "Отменить";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.Сancel_Click);
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.name.Location = new System.Drawing.Point(190, 163);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(0, 21);
            this.name.TabIndex = 9;
            // 
            // AddChordForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 500);
            this.Controls.Add(this.name);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.addChord);
            this.Controls.Add(this.beginLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.beginInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.noteBox);
            this.Name = "AddChordForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.AddChordForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.noteBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox noteBox;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox beginInput;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label beginLabel;
        private System.Windows.Forms.Button addChord;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.Label name;
    }
}