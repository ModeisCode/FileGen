namespace FileGen
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            topControlPanel = new Panel();
            addNewAlbumBtn = new Button();
            panel1 = new Panel();
            refreshAlbumsBtn = new Button();
            albumListBox = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            openSelectedAlbumBtn = new Button();
            topControlPanel.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // topControlPanel
            // 
            topControlPanel.BackColor = SystemColors.ActiveCaption;
            topControlPanel.BorderStyle = BorderStyle.FixedSingle;
            topControlPanel.Controls.Add(addNewAlbumBtn);
            topControlPanel.Dock = DockStyle.Top;
            topControlPanel.Location = new Point(0, 0);
            topControlPanel.Name = "topControlPanel";
            topControlPanel.Size = new Size(1211, 104);
            topControlPanel.TabIndex = 0;
            // 
            // addNewAlbumBtn
            // 
            addNewAlbumBtn.Location = new Point(160, 3);
            addNewAlbumBtn.Name = "addNewAlbumBtn";
            addNewAlbumBtn.Size = new Size(100, 94);
            addNewAlbumBtn.TabIndex = 0;
            addNewAlbumBtn.Text = "Add new album";
            addNewAlbumBtn.UseVisualStyleBackColor = true;
            addNewAlbumBtn.Click += addNewAlbumBtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(openSelectedAlbumBtn);
            panel1.Controls.Add(refreshAlbumsBtn);
            panel1.Controls.Add(albumListBox);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 104);
            panel1.Name = "panel1";
            panel1.Size = new Size(202, 422);
            panel1.TabIndex = 1;
            // 
            // refreshAlbumsBtn
            // 
            refreshAlbumsBtn.Location = new Point(11, 195);
            refreshAlbumsBtn.Name = "refreshAlbumsBtn";
            refreshAlbumsBtn.Size = new Size(171, 23);
            refreshAlbumsBtn.TabIndex = 1;
            refreshAlbumsBtn.Text = "refresh albums";
            refreshAlbumsBtn.UseVisualStyleBackColor = true;
            refreshAlbumsBtn.Click += refreshAlbumsBtn_Click;
            // 
            // albumListBox
            // 
            albumListBox.FormattingEnabled = true;
            albumListBox.ItemHeight = 15;
            albumListBox.Location = new Point(11, 5);
            albumListBox.Name = "albumListBox";
            albumListBox.Size = new Size(171, 184);
            albumListBox.TabIndex = 0;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Location = new Point(220, 110);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(970, 404);
            flowLayoutPanel1.TabIndex = 2;
            // 
            // openSelectedAlbumBtn
            // 
            openSelectedAlbumBtn.Location = new Point(87, 224);
            openSelectedAlbumBtn.Name = "openSelectedAlbumBtn";
            openSelectedAlbumBtn.Size = new Size(95, 39);
            openSelectedAlbumBtn.TabIndex = 2;
            openSelectedAlbumBtn.Text = "Open Album";
            openSelectedAlbumBtn.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1211, 526);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            Controls.Add(topControlPanel);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            topControlPanel.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel topControlPanel;
        private Button addNewAlbumBtn;
        private Panel panel1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button refreshAlbumsBtn;
        private ListBox albumListBox;
        private Button openSelectedAlbumBtn;
    }
}
