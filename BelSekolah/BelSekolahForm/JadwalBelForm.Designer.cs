﻿namespace BelSekolah.BelSekolahForm
{
    partial class JadwalBelForm
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JadwalBelForm));
            AddButton = new Button();
            panel3 = new Panel();
            JadwalHariGrid = new DataGridView();
            MainPanel = new Panel();
            JadwalKhususGrid = new DataGridView();
            HariCombo = new ComboBox();
            SaveButton = new Button();
            TambahKhususButton = new Button();
            TambahNormalButton = new Button();
            JadwalKhususRadio = new RadioButton();
            JadwalNormalRadio = new RadioButton();
            panel5 = new Panel();
            InsertUpdateLabel = new Label();
            JadwalNormalGrid = new DataGridView();
            contextMenuStrip1 = new ContextMenuStrip(components);
            deleteToolStripMenuItem = new ToolStripMenuItem();
            contextMenuStrip2 = new ContextMenuStrip(components);
            editToolStripMenuItem = new ToolStripMenuItem();
            deleteToolStripMenuItem1 = new ToolStripMenuItem();
            panel2 = new Panel();
            JamLabel = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalHariGrid).BeginInit();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalKhususGrid).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalNormalGrid).BeginInit();
            contextMenuStrip1.SuspendLayout();
            contextMenuStrip2.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            AddButton.BackColor = Color.Goldenrod;
            AddButton.BackgroundImageLayout = ImageLayout.Zoom;
            AddButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            AddButton.ForeColor = Color.White;
            AddButton.Image = (Image)resources.GetObject("AddButton.Image");
            AddButton.Location = new Point(9, 278);
            AddButton.Margin = new Padding(4, 4, 4, 4);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(136, 49);
            AddButton.TabIndex = 2;
            AddButton.Text = "Add";
            AddButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            AddButton.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel3.BackColor = Color.LightGray;
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(AddButton);
            panel3.Controls.Add(JadwalHariGrid);
            panel3.Location = new Point(13, 89);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(1898, 339);
            panel3.TabIndex = 3;
            // 
            // JadwalHariGrid
            // 
            JadwalHariGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JadwalHariGrid.BackgroundColor = SystemColors.Control;
            JadwalHariGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JadwalHariGrid.Location = new Point(6, 6);
            JadwalHariGrid.Margin = new Padding(4, 4, 4, 4);
            JadwalHariGrid.Name = "JadwalHariGrid";
            JadwalHariGrid.ReadOnly = true;
            JadwalHariGrid.RowHeadersWidth = 51;
            JadwalHariGrid.RowTemplate.Height = 29;
            JadwalHariGrid.Size = new Size(1884, 264);
            JadwalHariGrid.TabIndex = 2;
            // 
            // MainPanel
            // 
            MainPanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            MainPanel.BackColor = Color.LightGray;
            MainPanel.BorderStyle = BorderStyle.FixedSingle;
            MainPanel.Controls.Add(JadwalKhususGrid);
            MainPanel.Controls.Add(HariCombo);
            MainPanel.Controls.Add(SaveButton);
            MainPanel.Controls.Add(TambahKhususButton);
            MainPanel.Controls.Add(TambahNormalButton);
            MainPanel.Controls.Add(JadwalKhususRadio);
            MainPanel.Controls.Add(JadwalNormalRadio);
            MainPanel.Controls.Add(panel5);
            MainPanel.Controls.Add(JadwalNormalGrid);
            MainPanel.Location = new Point(17, 435);
            MainPanel.Margin = new Padding(4, 4, 4, 4);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1894, 366);
            MainPanel.TabIndex = 4;
            // 
            // JadwalKhususGrid
            // 
            JadwalKhususGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            JadwalKhususGrid.BackgroundColor = SystemColors.Control;
            JadwalKhususGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JadwalKhususGrid.Location = new Point(868, 160);
            JadwalKhususGrid.Margin = new Padding(4, 4, 4, 4);
            JadwalKhususGrid.MultiSelect = false;
            JadwalKhususGrid.Name = "JadwalKhususGrid";
            JadwalKhususGrid.ReadOnly = true;
            JadwalKhususGrid.RowHeadersWidth = 51;
            JadwalKhususGrid.RowTemplate.Height = 29;
            JadwalKhususGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            JadwalKhususGrid.Size = new Size(1006, 49);
            JadwalKhususGrid.TabIndex = 14;
            // 
            // HariCombo
            // 
            HariCombo.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            HariCombo.FormattingEnabled = true;
            HariCombo.Location = new Point(11, 60);
            HariCombo.Margin = new Padding(4, 4, 4, 4);
            HariCombo.Name = "HariCombo";
            HariCombo.Size = new Size(188, 40);
            HariCombo.TabIndex = 13;
            // 
            // SaveButton
            // 
            SaveButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            SaveButton.BackColor = Color.LimeGreen;
            SaveButton.BackgroundImageLayout = ImageLayout.Zoom;
            SaveButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            SaveButton.ForeColor = Color.White;
            SaveButton.Location = new Point(1717, 303);
            SaveButton.Margin = new Padding(4, 4, 4, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(158, 46);
            SaveButton.TabIndex = 12;
            SaveButton.Text = "Save";
            SaveButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            SaveButton.UseVisualStyleBackColor = false;
            // 
            // TambahKhususButton
            // 
            TambahKhususButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TambahKhususButton.BackColor = Color.Goldenrod;
            TambahKhususButton.BackgroundImageLayout = ImageLayout.Zoom;
            TambahKhususButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TambahKhususButton.ForeColor = Color.White;
            TambahKhususButton.Location = new Point(868, 253);
            TambahKhususButton.Margin = new Padding(4, 4, 4, 4);
            TambahKhususButton.Name = "TambahKhususButton";
            TambahKhususButton.Size = new Size(136, 49);
            TambahKhususButton.TabIndex = 10;
            TambahKhususButton.Text = "Tambah";
            TambahKhususButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            TambahKhususButton.UseVisualStyleBackColor = false;
            // 
            // TambahNormalButton
            // 
            TambahNormalButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            TambahNormalButton.BackColor = Color.Goldenrod;
            TambahNormalButton.BackgroundImageLayout = ImageLayout.Zoom;
            TambahNormalButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            TambahNormalButton.ForeColor = Color.White;
            TambahNormalButton.Location = new Point(16, 253);
            TambahNormalButton.Margin = new Padding(4, 4, 4, 4);
            TambahNormalButton.Name = "TambahNormalButton";
            TambahNormalButton.Size = new Size(136, 49);
            TambahNormalButton.TabIndex = 9;
            TambahNormalButton.Text = "Tambah";
            TambahNormalButton.TextImageRelation = TextImageRelation.TextBeforeImage;
            TambahNormalButton.UseVisualStyleBackColor = false;
            // 
            // JadwalKhususRadio
            // 
            JadwalKhususRadio.AutoSize = true;
            JadwalKhususRadio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            JadwalKhususRadio.Location = new Point(868, 118);
            JadwalKhususRadio.Margin = new Padding(4, 4, 4, 4);
            JadwalKhususRadio.Name = "JadwalKhususRadio";
            JadwalKhususRadio.Size = new Size(175, 34);
            JadwalKhususRadio.TabIndex = 7;
            JadwalKhususRadio.TabStop = true;
            JadwalKhususRadio.Text = "Jadwal Khusus";
            JadwalKhususRadio.UseVisualStyleBackColor = true;
            // 
            // JadwalNormalRadio
            // 
            JadwalNormalRadio.AutoSize = true;
            JadwalNormalRadio.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            JadwalNormalRadio.Location = new Point(11, 118);
            JadwalNormalRadio.Margin = new Padding(4, 4, 4, 4);
            JadwalNormalRadio.Name = "JadwalNormalRadio";
            JadwalNormalRadio.Size = new Size(180, 34);
            JadwalNormalRadio.TabIndex = 6;
            JadwalNormalRadio.TabStop = true;
            JadwalNormalRadio.Text = "Jadwal Normal";
            JadwalNormalRadio.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.BackColor = Color.Silver;
            panel5.BorderStyle = BorderStyle.FixedSingle;
            panel5.Controls.Add(InsertUpdateLabel);
            panel5.Dock = DockStyle.Top;
            panel5.Location = new Point(0, 0);
            panel5.Margin = new Padding(4, 4, 4, 4);
            panel5.Name = "panel5";
            panel5.Size = new Size(1892, 52);
            panel5.TabIndex = 5;
            // 
            // InsertUpdateLabel
            // 
            InsertUpdateLabel.AutoSize = true;
            InsertUpdateLabel.Font = new Font("Segoe UI Semibold", 16F, FontStyle.Bold, GraphicsUnit.Point);
            InsertUpdateLabel.Location = new Point(6, 2);
            InsertUpdateLabel.Margin = new Padding(4, 0, 4, 0);
            InsertUpdateLabel.Name = "InsertUpdateLabel";
            InsertUpdateLabel.Size = new Size(289, 45);
            InsertUpdateLabel.TabIndex = 6;
            InsertUpdateLabel.Text = "Tambah Data Baru";
            // 
            // JadwalNormalGrid
            // 
            JadwalNormalGrid.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            JadwalNormalGrid.BackgroundColor = SystemColors.Control;
            JadwalNormalGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            JadwalNormalGrid.Location = new Point(16, 160);
            JadwalNormalGrid.Margin = new Padding(4, 4, 4, 4);
            JadwalNormalGrid.MultiSelect = false;
            JadwalNormalGrid.Name = "JadwalNormalGrid";
            JadwalNormalGrid.ReadOnly = true;
            JadwalNormalGrid.RowHeadersWidth = 51;
            JadwalNormalGrid.RowTemplate.Height = 29;
            JadwalNormalGrid.SelectionMode = DataGridViewSelectionMode.CellSelect;
            JadwalNormalGrid.Size = new Size(844, 49);
            JadwalNormalGrid.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { deleteToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(156, 40);
            // 
            // deleteToolStripMenuItem
            // 
            deleteToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem.Image = Properties.Resources.delete;
            deleteToolStripMenuItem.ImageAlign = ContentAlignment.MiddleLeft;
            deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            deleteToolStripMenuItem.Size = new Size(155, 36);
            deleteToolStripMenuItem.Text = "Delete";
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem, deleteToolStripMenuItem1 });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(151, 76);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            editToolStripMenuItem.Image = Properties.Resources.pencil;
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(150, 36);
            editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem1
            // 
            deleteToolStripMenuItem1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            deleteToolStripMenuItem1.Image = Properties.Resources.delete;
            deleteToolStripMenuItem1.Name = "deleteToolStripMenuItem1";
            deleteToolStripMenuItem1.Size = new Size(150, 36);
            deleteToolStripMenuItem1.Text = "Delete";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = Color.LightGray;
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(JamLabel);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(pictureBox1);
            panel2.Location = new Point(13, 13);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1898, 68);
            panel2.TabIndex = 5;
            // 
            // JamLabel
            // 
            JamLabel.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            JamLabel.AutoSize = true;
            JamLabel.Font = new Font("Segoe UI Semibold", 16.2F, FontStyle.Bold, GraphicsUnit.Point);
            JamLabel.Location = new Point(1744, 11);
            JamLabel.Margin = new Padding(4, 0, 4, 0);
            JamLabel.Name = "JamLabel";
            JamLabel.Size = new Size(144, 45);
            JamLabel.TabIndex = 5;
            JamLabel.Text = "00:00:00";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Yi Baiti", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(59, 18);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(243, 33);
            label1.TabIndex = 3;
            label1.Text = "Aplikasi Bel Sekolah";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.bell;
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(13, 11);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(38, 45);
            pictureBox1.TabIndex = 4;
            pictureBox1.TabStop = false;
            // 
            // JadwalBelForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 814);
            Controls.Add(panel2);
            Controls.Add(MainPanel);
            Controls.Add(panel3);
            Margin = new Padding(4, 4, 4, 4);
            Name = "JadwalBelForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "JadwalBelForm";
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)JadwalHariGrid).EndInit();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalKhususGrid).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)JadwalNormalGrid).EndInit();
            contextMenuStrip1.ResumeLayout(false);
            contextMenuStrip2.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button AddButton;
        private Panel panel3;
        private Button TambahKhususButton;
        private Panel MainPanel;
        private DataGridView JadwalNormalGrid;
        private Panel panel5;
        private RadioButton JadwalKhususRadio;
        private RadioButton JadwalNormalRadio;
        private Button SaveButton;
        private Button TambahNormalButton;
        private Label InsertUpdateLabel;
        private DataGridView JadwalHariGrid;
        private ComboBox HariCombo;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem deleteToolStripMenuItem1;
        private DataGridView JadwalKhususGrid;
        private Panel panel2;
        private Label JamLabel;
        private Label label1;
        private PictureBox pictureBox1;
    }
}