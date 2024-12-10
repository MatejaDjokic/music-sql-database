namespace MusicSqlDatabase
{
    partial class NewPlaylistForm
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
            playlistNameGroupBox = new GroupBox();
            playlistNameTextBox = new TextBox();
            playlistDesctiptionGroupBox = new GroupBox();
            playlistDescriptionTextBox = new TextBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            cancelButton = new Button();
            addPlaylistButton = new Button();
            playlistNameGroupBox.SuspendLayout();
            playlistDesctiptionGroupBox.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // playlistNameGroupBox
            // 
            playlistNameGroupBox.Controls.Add(playlistNameTextBox);
            playlistNameGroupBox.Location = new Point(12, 12);
            playlistNameGroupBox.Name = "playlistNameGroupBox";
            playlistNameGroupBox.Size = new Size(241, 60);
            playlistNameGroupBox.TabIndex = 0;
            playlistNameGroupBox.TabStop = false;
            playlistNameGroupBox.Text = "Ime ";
            // 
            // playlistNameTextBox
            // 
            playlistNameTextBox.Location = new Point(6, 22);
            playlistNameTextBox.Name = "playlistNameTextBox";
            playlistNameTextBox.Size = new Size(229, 23);
            playlistNameTextBox.TabIndex = 0;
            playlistNameTextBox.TextChanged += PlaylistNameTextBoxTextChanged;
            // 
            // playlistDesctiptionGroupBox
            // 
            playlistDesctiptionGroupBox.Controls.Add(playlistDescriptionTextBox);
            playlistDesctiptionGroupBox.Location = new Point(12, 78);
            playlistDesctiptionGroupBox.Name = "playlistDesctiptionGroupBox";
            playlistDesctiptionGroupBox.Size = new Size(241, 59);
            playlistDesctiptionGroupBox.TabIndex = 0;
            playlistDesctiptionGroupBox.TabStop = false;
            playlistDesctiptionGroupBox.Text = "Opis";
            // 
            // playlistDescriptionTextBox
            // 
            playlistDescriptionTextBox.Location = new Point(6, 22);
            playlistDescriptionTextBox.Name = "playlistDescriptionTextBox";
            playlistDescriptionTextBox.Size = new Size(229, 23);
            playlistDescriptionTextBox.TabIndex = 1;
            playlistDescriptionTextBox.TextChanged += PlaylistDescriptionTextBoxTextChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(cancelButton, 0, 0);
            tableLayoutPanel1.Controls.Add(addPlaylistButton, 1, 0);
            tableLayoutPanel1.Location = new Point(12, 143);
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
            addPlaylistButton.Text = "Dodaj";
            addPlaylistButton.UseVisualStyleBackColor = true;
            addPlaylistButton.Click += AddPlaylistButtonClick;
            // 
            // NewPlaylistForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(265, 194);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(playlistDesctiptionGroupBox);
            Controls.Add(playlistNameGroupBox);
            MaximizeBox = false;
            MaximumSize = new Size(281, 233);
            MinimumSize = new Size(281, 233);
            Name = "NewPlaylistForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dodaj Plejlistu";
            playlistNameGroupBox.ResumeLayout(false);
            playlistNameGroupBox.PerformLayout();
            playlistDesctiptionGroupBox.ResumeLayout(false);
            playlistDesctiptionGroupBox.PerformLayout();
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox playlistNameGroupBox;
        private TextBox playlistNameTextBox;
        private GroupBox playlistDesctiptionGroupBox;
        private TextBox playlistDescriptionTextBox;
        private TableLayoutPanel tableLayoutPanel1;
        private Button cancelButton;
        private Button addPlaylistButton;
    }
}