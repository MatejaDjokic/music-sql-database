namespace MusicSqlDatabase
{
    partial class UpdateSongForm
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
            songNameGroupBox = new GroupBox();
            songNameTextBox = new TextBox();
            songYearGroupBox = new GroupBox();
            songYearTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cancelButton = new Button();
            addPlaylistButton = new Button();
            songArtistGroupBox = new GroupBox();
            artistTextBox = new TextBox();
            songNameGroupBox.SuspendLayout();
            songYearGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            songArtistGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // songNameGroupBox
            // 
            songNameGroupBox.Controls.Add(songNameTextBox);
            songNameGroupBox.Location = new Point(12, 12);
            songNameGroupBox.Name = "songNameGroupBox";
            songNameGroupBox.Size = new Size(241, 60);
            songNameGroupBox.TabIndex = 0;
            songNameGroupBox.TabStop = false;
            songNameGroupBox.Text = "Ime ";
            // 
            // playlistNameTextBox
            // 
            songNameTextBox.Location = new Point(6, 22);
            songNameTextBox.Name = "playlistNameTextBox";
            songNameTextBox.Size = new Size(229, 23);
            songNameTextBox.TabIndex = 0;
            songNameTextBox.TextChanged += SongNameTextBoxTextChanged;
            // 
            // songYearGroupBox
            // 
            songYearGroupBox.Controls.Add(songYearTextBox);
            songYearGroupBox.Location = new Point(12, 78);
            songYearGroupBox.Name = "songYearGroupBox";
            songYearGroupBox.Size = new Size(241, 59);
            songYearGroupBox.TabIndex = 0;
            songYearGroupBox.TabStop = false;
            songYearGroupBox.Text = "Godina";
            // 
            // playlistDescriptionTextBox
            // 
            songYearTextBox.Location = new Point(6, 22);
            songYearTextBox.Name = "playlistDescriptionTextBox";
            songYearTextBox.Size = new Size(229, 23);
            songYearTextBox.TabIndex = 1;
            songYearTextBox.TextChanged += SongYearTextBoxTextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cancelButton, 0, 0);
            tableLayoutPanel1.Controls.Add(addPlaylistButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 205);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(241, 38);
            tableLayoutPanel1.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = SystemColors.Control;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.FlatStyle = FlatStyle.System;
            cancelButton.Location = new Point(3, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(114, 32);
            cancelButton.TabIndex = 3;
            cancelButton.Text = "Otkazi";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButtonClick;
            // 
            // addPlaylistButton
            // 
            addPlaylistButton.Dock = DockStyle.Fill;
            addPlaylistButton.FlatStyle = FlatStyle.System;
            addPlaylistButton.Location = new Point(123, 3);
            addPlaylistButton.Name = "addPlaylistButton";
            addPlaylistButton.Size = new Size(115, 32);
            addPlaylistButton.TabIndex = 2;
            addPlaylistButton.Text = "Izmeni";
            addPlaylistButton.UseVisualStyleBackColor = true;
            addPlaylistButton.Click += AddSongButtonClick;
            // 
            // songArtistGroupBox
            // 
            songArtistGroupBox.Controls.Add(artistTextBox);
            songArtistGroupBox.Location = new Point(12, 140);
            songArtistGroupBox.Name = "songArtistGroupBox";
            songArtistGroupBox.Size = new Size(241, 59);
            songArtistGroupBox.TabIndex = 2;
            songArtistGroupBox.TabStop = false;
            songArtistGroupBox.Text = "Umetnik";
            // 
            // textBox1
            // 
            artistTextBox.Location = new Point(6, 22);
            artistTextBox.Name = "textBox1";
            artistTextBox.Size = new Size(229, 23);
            artistTextBox.TabIndex = 1;
            artistTextBox.TextChanged += SongArtirstTextBoxTextChanged;
            // 
            // UpdateSongForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 256);
            Controls.Add(songArtistGroupBox);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(songYearGroupBox);
            Controls.Add(songNameGroupBox);
            MaximizeBox = false;
            MaximumSize = new Size(281, 295);
            MinimumSize = new Size(281, 295);
            Name = "UpdateSongForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Izmeni Pesmu";
            songNameGroupBox.ResumeLayout(false);
            songNameGroupBox.PerformLayout();
            songYearGroupBox.ResumeLayout(false);
            songYearGroupBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            songArtistGroupBox.ResumeLayout(false);
            songArtistGroupBox.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox songNameGroupBox;
        private TextBox songNameTextBox;
        private GroupBox songYearGroupBox;
        private TextBox songYearTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button cancelButton;
        private Button addPlaylistButton;
        private GroupBox songArtistGroupBox;
        private TextBox artistTextBox;
    }
}