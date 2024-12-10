using System.Windows.Forms;

namespace MusicSqlDatabase
{
    partial class Frm
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
            songsTable = new DataGridView();
            tableLayoutPanel1 = new TableLayoutPanel();
            editPlaylistButton = new Button();
            deletePlaylistButton = new Button();
            addPlaylistButton = new Button();
            playListsTable = new DataGridView();
            playlistBox = new GroupBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            songBox = new GroupBox();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            editSongButton = new Button();
            deleteSongButton = new Button();
            addSongButton = new Button();
            tableLayoutPanel5 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)songsTable).BeginInit();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)playListsTable).BeginInit();
            playlistBox.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            songBox.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            SuspendLayout();
            // 
            // songsTable
            // 
            songsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            songsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            songsTable.BackgroundColor = SystemColors.Control;
            songsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            songsTable.Location = new Point(3, 3);
            songsTable.Name = "songsTable";
            songsTable.ReadOnly = true;
            songsTable.Size = new Size(526, 411);
            songsTable.TabIndex = 1;
            songsTable.CellClick += SongsTableCellClick;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.Transparent;
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Controls.Add(editPlaylistButton, 0, 0);
            tableLayoutPanel1.Controls.Add(deletePlaylistButton, 0, 0);
            tableLayoutPanel1.Controls.Add(addPlaylistButton, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 420);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(344, 54);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // editPlaylistButton
            // 
            editPlaylistButton.BackColor = SystemColors.Control;
            editPlaylistButton.Dock = DockStyle.Fill;
            editPlaylistButton.FlatStyle = FlatStyle.System;
            editPlaylistButton.Font = new Font("Segoe UI", 12F);
            editPlaylistButton.ForeColor = SystemColors.ControlText;
            editPlaylistButton.Location = new Point(228, 0);
            editPlaylistButton.Margin = new Padding(0);
            editPlaylistButton.Name = "editPlaylistButton";
            editPlaylistButton.Size = new Size(116, 54);
            editPlaylistButton.TabIndex = 2;
            editPlaylistButton.Text = "Izmeni";
            editPlaylistButton.UseVisualStyleBackColor = false;
            editPlaylistButton.Click += EditPlaylistButtonClick;
            // 
            // deletePlaylistButton
            // 
            deletePlaylistButton.BackColor = SystemColors.Control;
            deletePlaylistButton.Dock = DockStyle.Fill;
            deletePlaylistButton.FlatStyle = FlatStyle.System;
            deletePlaylistButton.Font = new Font("Segoe UI", 12F);
            deletePlaylistButton.ForeColor = SystemColors.ControlText;
            deletePlaylistButton.Location = new Point(114, 0);
            deletePlaylistButton.Margin = new Padding(0);
            deletePlaylistButton.Name = "deletePlaylistButton";
            deletePlaylistButton.Size = new Size(114, 54);
            deletePlaylistButton.TabIndex = 1;
            deletePlaylistButton.Text = "Izbrisi";
            deletePlaylistButton.UseVisualStyleBackColor = false;
            deletePlaylistButton.Click += DeletePlaylistButtonClick;
            // 
            // addPlaylistButton
            // 
            addPlaylistButton.BackColor = SystemColors.Control;
            addPlaylistButton.Dock = DockStyle.Fill;
            addPlaylistButton.FlatStyle = FlatStyle.System;
            addPlaylistButton.Font = new Font("Segoe UI", 12F);
            addPlaylistButton.ForeColor = SystemColors.ControlText;
            addPlaylistButton.Location = new Point(0, 0);
            addPlaylistButton.Margin = new Padding(0);
            addPlaylistButton.Name = "addPlaylistButton";
            addPlaylistButton.Size = new Size(114, 54);
            addPlaylistButton.TabIndex = 0;
            addPlaylistButton.Text = "Dodaj";
            addPlaylistButton.UseVisualStyleBackColor = false;
            addPlaylistButton.Click += AddPlaylistButtonClick;
            // 
            // playListsTable
            // 
            playListsTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            playListsTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            playListsTable.BackgroundColor = SystemColors.Control;
            playListsTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            playListsTable.Location = new Point(3, 3);
            playListsTable.Name = "playListsTable";
            playListsTable.ReadOnly = true;
            playListsTable.Size = new Size(344, 411);
            playListsTable.TabIndex = 2;
            playListsTable.CellClick += PlayListsTableCellClick;
            // 
            // playlistBox
            // 
            playlistBox.BackColor = SystemColors.Control;
            playlistBox.Controls.Add(tableLayoutPanel2);
            playlistBox.Dock = DockStyle.Fill;
            playlistBox.ForeColor = SystemColors.ControlText;
            playlistBox.Location = new Point(3, 3);
            playlistBox.Name = "playlistBox";
            playlistBox.Size = new Size(356, 499);
            playlistBox.TabIndex = 6;
            playlistBox.TabStop = false;
            playlistBox.Text = "Plejliste";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.BackColor = Color.Transparent;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(playListsTable, 0, 0);
            tableLayoutPanel2.Controls.Add(tableLayoutPanel1, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 19);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel2.Size = new Size(350, 477);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // songBox
            // 
            songBox.BackColor = SystemColors.Control;
            songBox.Controls.Add(tableLayoutPanel3);
            songBox.Dock = DockStyle.Fill;
            songBox.ForeColor = SystemColors.ControlText;
            songBox.Location = new Point(365, 3);
            songBox.Name = "songBox";
            songBox.Size = new Size(538, 499);
            songBox.TabIndex = 7;
            songBox.TabStop = false;
            songBox.Text = "Pesme";
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.Transparent;
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(songsTable, 0, 0);
            tableLayoutPanel3.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 19);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            tableLayoutPanel3.Size = new Size(532, 477);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.Transparent;
            tableLayoutPanel4.ColumnCount = 3;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel4.Controls.Add(editSongButton, 0, 0);
            tableLayoutPanel4.Controls.Add(deleteSongButton, 0, 0);
            tableLayoutPanel4.Controls.Add(addSongButton, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 420);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 1;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Size = new Size(526, 54);
            tableLayoutPanel4.TabIndex = 2;
            // 
            // editSongButton
            // 
            editSongButton.BackColor = SystemColors.Control;
            editSongButton.Dock = DockStyle.Fill;
            editSongButton.FlatStyle = FlatStyle.System;
            editSongButton.Font = new Font("Segoe UI", 12F);
            editSongButton.ForeColor = SystemColors.ControlText;
            editSongButton.Location = new Point(350, 0);
            editSongButton.Margin = new Padding(0);
            editSongButton.Name = "editSongButton";
            editSongButton.Size = new Size(176, 54);
            editSongButton.TabIndex = 3;
            editSongButton.Text = "Izmeni";
            editSongButton.UseVisualStyleBackColor = false;
            editSongButton.Click += EditSongButtonClick;
            // 
            // deleteSongButton
            // 
            deleteSongButton.BackColor = SystemColors.Control;
            deleteSongButton.Dock = DockStyle.Fill;
            deleteSongButton.FlatStyle = FlatStyle.System;
            deleteSongButton.Font = new Font("Segoe UI", 12F);
            deleteSongButton.ForeColor = SystemColors.ControlText;
            deleteSongButton.Location = new Point(175, 0);
            deleteSongButton.Margin = new Padding(0);
            deleteSongButton.Name = "deleteSongButton";
            deleteSongButton.Size = new Size(175, 54);
            deleteSongButton.TabIndex = 2;
            deleteSongButton.Text = "Izbriši";
            deleteSongButton.UseVisualStyleBackColor = false;
            deleteSongButton.Click += DeleteSongButtonClick;
            // 
            // addSongButton
            // 
            addSongButton.BackColor = SystemColors.Control;
            addSongButton.Dock = DockStyle.Fill;
            addSongButton.FlatStyle = FlatStyle.System;
            addSongButton.Font = new Font("Segoe UI", 12F);
            addSongButton.ForeColor = SystemColors.ControlText;
            addSongButton.Location = new Point(0, 0);
            addSongButton.Margin = new Padding(0);
            addSongButton.Name = "addSongButton";
            addSongButton.Size = new Size(175, 54);
            addSongButton.TabIndex = 1;
            addSongButton.Text = "Dodaj";
            addSongButton.UseVisualStyleBackColor = false;
            addSongButton.Click += AddSongButtonClick;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.BackColor = Color.Transparent;
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60F));
            tableLayoutPanel5.Controls.Add(playlistBox, 0, 0);
            tableLayoutPanel5.Controls.Add(songBox, 1, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(0, 0);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Size = new Size(906, 505);
            tableLayoutPanel5.TabIndex = 8;
            // 
            // Frm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(906, 505);
            Controls.Add(tableLayoutPanel5);
            ForeColor = Color.White;
            Name = "Frm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Muzika";
            ((System.ComponentModel.ISupportInitialize)songsTable).EndInit();
            tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)playListsTable).EndInit();
            playlistBox.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            songBox.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private DataGridView songsTable;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button editSongButton;
        private Button editPlaylistButton;
        private Button addPlaylistButton;
        private DataGridView playListsTable;
        private GroupBox playlistBox;
        private Button deletePlaylistButton;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox songBox;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
        private Button deleteSongButton;
        private Button addSongButton;
        private TableLayoutPanel tableLayoutPanel5;
    }
}
