namespace FileGen
{
    partial class AlbumGenerator
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
            panel1 = new Panel();
            albumIcon = new PictureBox();
            albumTextBox = new TextBox();
            label1 = new Label();
            albumDate = new DateTimePicker();
            albumDescription = new RichTextBox();
            AlbumState = new ComboBox();
            albumBackgroundPath = new TextBox();
            FinishBtn = new Button();
            label2 = new Label();
            addStarCB = new CheckBox();
            albumBackgroundImagePath = new TextBox();
            passwordTextBox = new TextBox();
            isPrivateCB = new CheckBox();
            albumFolderPath = new TextBox();
            saveFileDialog1 = new SaveFileDialog();
            AlbumPathSelectBtn = new Button();
            openFileDialog1 = new OpenFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)albumIcon).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(albumIcon);
            panel1.Location = new Point(14, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(147, 135);
            panel1.TabIndex = 0;
            // 
            // albumIcon
            // 
            albumIcon.Location = new Point(7, 7);
            albumIcon.Name = "albumIcon";
            albumIcon.Size = new Size(133, 119);
            albumIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            albumIcon.TabIndex = 0;
            albumIcon.TabStop = false;
            // 
            // albumTextBox
            // 
            albumTextBox.BackColor = SystemColors.ScrollBar;
            albumTextBox.BorderStyle = BorderStyle.FixedSingle;
            albumTextBox.Font = new Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            albumTextBox.Location = new Point(217, 50);
            albumTextBox.MaxLength = 100;
            albumTextBox.Name = "albumTextBox";
            albumTextBox.Size = new Size(250, 22);
            albumTextBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(217, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 15);
            label1.TabIndex = 2;
            label1.Text = "Album Name";
            // 
            // albumDate
            // 
            albumDate.Location = new Point(217, 91);
            albumDate.Name = "albumDate";
            albumDate.Size = new Size(250, 23);
            albumDate.TabIndex = 3;
            // 
            // albumDescription
            // 
            albumDescription.BackColor = SystemColors.ScrollBar;
            albumDescription.BorderStyle = BorderStyle.None;
            albumDescription.Location = new Point(217, 139);
            albumDescription.MaxLength = 700;
            albumDescription.Name = "albumDescription";
            albumDescription.Size = new Size(250, 142);
            albumDescription.TabIndex = 4;
            albumDescription.Text = "";
            // 
            // AlbumState
            // 
            AlbumState.BackColor = SystemColors.ScrollBar;
            AlbumState.FormattingEnabled = true;
            AlbumState.Location = new Point(217, 304);
            AlbumState.Name = "AlbumState";
            AlbumState.Size = new Size(250, 23);
            AlbumState.TabIndex = 5;
            // 
            // albumBackgroundPath
            // 
            albumBackgroundPath.BackColor = SystemColors.ScrollBar;
            albumBackgroundPath.BorderStyle = BorderStyle.FixedSingle;
            albumBackgroundPath.Location = new Point(217, 343);
            albumBackgroundPath.Name = "albumBackgroundPath";
            albumBackgroundPath.Size = new Size(250, 23);
            albumBackgroundPath.TabIndex = 6;
            // 
            // FinishBtn
            // 
            FinishBtn.BackColor = Color.SpringGreen;
            FinishBtn.Cursor = Cursors.Hand;
            FinishBtn.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FinishBtn.ForeColor = SystemColors.ControlText;
            FinishBtn.Location = new Point(362, 567);
            FinishBtn.Name = "FinishBtn";
            FinishBtn.Size = new Size(117, 47);
            FinishBtn.TabIndex = 7;
            FinishBtn.Text = "Finish!";
            FinishBtn.UseVisualStyleBackColor = false;
            FinishBtn.Click += FinishBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Cursor = Cursors.Hand;
            label2.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(35, 159);
            label2.Name = "label2";
            label2.Size = new Size(110, 16);
            label2.TabIndex = 8;
            label2.Text = "Add Album Icon";
            label2.Click += label2_Click;
            // 
            // addStarCB
            // 
            addStarCB.AutoSize = true;
            addStarCB.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            addStarCB.Location = new Point(397, 532);
            addStarCB.Name = "addStarCB";
            addStarCB.Size = new Size(82, 20);
            addStarCB.TabIndex = 9;
            addStarCB.Text = "Add star";
            addStarCB.UseVisualStyleBackColor = true;
            // 
            // albumBackgroundImagePath
            // 
            albumBackgroundImagePath.Location = new Point(14, 189);
            albumBackgroundImagePath.Name = "albumBackgroundImagePath";
            albumBackgroundImagePath.ReadOnly = true;
            albumBackgroundImagePath.Size = new Size(147, 23);
            albumBackgroundImagePath.TabIndex = 10;
            // 
            // passwordTextBox
            // 
            passwordTextBox.Location = new Point(217, 493);
            passwordTextBox.Name = "passwordTextBox";
            passwordTextBox.PasswordChar = '*';
            passwordTextBox.Size = new Size(250, 23);
            passwordTextBox.TabIndex = 11;
            // 
            // isPrivateCB
            // 
            isPrivateCB.AutoSize = true;
            isPrivateCB.Font = new Font("Verdana", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            isPrivateCB.Location = new Point(281, 532);
            isPrivateCB.Name = "isPrivateCB";
            isPrivateCB.Size = new Size(89, 20);
            isPrivateCB.TabIndex = 12;
            isPrivateCB.Text = "Is private";
            isPrivateCB.UseVisualStyleBackColor = true;
            // 
            // albumFolderPath
            // 
            albumFolderPath.Location = new Point(217, 386);
            albumFolderPath.Name = "albumFolderPath";
            albumFolderPath.Size = new Size(250, 23);
            albumFolderPath.TabIndex = 13;
            // 
            // AlbumPathSelectBtn
            // 
            AlbumPathSelectBtn.Location = new Point(114, 377);
            AlbumPathSelectBtn.Name = "AlbumPathSelectBtn";
            AlbumPathSelectBtn.Size = new Size(97, 39);
            AlbumPathSelectBtn.TabIndex = 14;
            AlbumPathSelectBtn.Text = "Album Path";
            AlbumPathSelectBtn.UseVisualStyleBackColor = true;
            AlbumPathSelectBtn.Click += AlbumPathSelectBtn_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // AlbumGenerator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SkyBlue;
            ClientSize = new Size(490, 626);
            Controls.Add(AlbumPathSelectBtn);
            Controls.Add(albumFolderPath);
            Controls.Add(isPrivateCB);
            Controls.Add(passwordTextBox);
            Controls.Add(albumBackgroundImagePath);
            Controls.Add(addStarCB);
            Controls.Add(label2);
            Controls.Add(FinishBtn);
            Controls.Add(albumBackgroundPath);
            Controls.Add(AlbumState);
            Controls.Add(albumDescription);
            Controls.Add(albumDate);
            Controls.Add(label1);
            Controls.Add(albumTextBox);
            Controls.Add(panel1);
            Name = "AlbumGenerator";
            Text = "AlbumGenerator";
            Load += AlbumGenerator_Load;
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)albumIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox albumIcon;
        private TextBox albumTextBox;
        private Label label1;
        private DateTimePicker albumDate;
        private RichTextBox albumDescription;
        private ComboBox AlbumState;
        private TextBox albumBackgroundPath;
        private Button FinishBtn;
        private Label label2;
        private CheckBox addStarCB;
        private TextBox albumBackgroundImagePath;
        private TextBox passwordTextBox;
        private CheckBox isPrivateCB;
        private TextBox albumFolderPath;
        private SaveFileDialog saveFileDialog1;
        private Button AlbumPathSelectBtn;
        private OpenFileDialog openFileDialog1;
    }
}