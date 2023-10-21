﻿namespace Universities
{
    partial class FormUniversity
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
            mainTableLayoutPanel = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            labelName = new Label();
            labelCity = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            labelUniversity = new Label();
            pictureBox = new PictureBox();
            splitContainer1 = new SplitContainer();
            buttonSave = new Button();
            buttonCancel = new Button();
            mainTableLayoutPanel.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // mainTableLayoutPanel
            // 
            mainTableLayoutPanel.ColumnCount = 1;
            mainTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.Controls.Add(tableLayoutPanel2, 0, 0);
            mainTableLayoutPanel.Controls.Add(pictureBox, 0, 1);
            mainTableLayoutPanel.Controls.Add(splitContainer1, 0, 2);
            mainTableLayoutPanel.Dock = DockStyle.Fill;
            mainTableLayoutPanel.Location = new Point(0, 0);
            mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            mainTableLayoutPanel.RowCount = 3;
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 96F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainTableLayoutPanel.Size = new Size(800, 450);
            mainTableLayoutPanel.TabIndex = 0;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.2418137F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.75819F));
            tableLayoutPanel2.Controls.Add(labelName, 0, 1);
            tableLayoutPanel2.Controls.Add(labelCity, 0, 2);
            tableLayoutPanel2.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel2.Controls.Add(textBox2, 1, 2);
            tableLayoutPanel2.Controls.Add(labelUniversity, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Size = new Size(794, 90);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Location = new Point(3, 30);
            labelName.Name = "labelName";
            labelName.Size = new Size(59, 15);
            labelName.TabIndex = 0;
            labelName.Text = "Название";
            // 
            // labelCity
            // 
            labelCity.AutoSize = true;
            labelCity.Location = new Point(3, 60);
            labelCity.Name = "labelCity";
            labelCity.Size = new Size(40, 15);
            labelCity.TabIndex = 1;
            labelCity.Text = "Город";
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Location = new Point(259, 33);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(532, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Location = new Point(259, 63);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(532, 23);
            textBox2.TabIndex = 3;
            // 
            // labelUniversity
            // 
            labelUniversity.AutoSize = true;
            labelUniversity.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            labelUniversity.Location = new Point(259, 0);
            labelUniversity.Name = "labelUniversity";
            labelUniversity.Size = new Size(129, 25);
            labelUniversity.TabIndex = 4;
            labelUniversity.Text = "Университет";
            labelUniversity.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pictureBox
            // 
            pictureBox.Dock = DockStyle.Fill;
            pictureBox.Location = new Point(3, 99);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(794, 308);
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 413);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(buttonSave);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(buttonCancel);
            splitContainer1.Size = new Size(794, 34);
            splitContainer1.SplitterDistance = 384;
            splitContainer1.TabIndex = 2;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // buttonSave
            // 
            buttonSave.Dock = DockStyle.Fill;
            buttonSave.Location = new Point(0, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(384, 34);
            buttonSave.TabIndex = 0;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            // 
            // buttonCancel
            // 
            buttonCancel.Dock = DockStyle.Fill;
            buttonCancel.Location = new Point(0, 0);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(406, 34);
            buttonCancel.TabIndex = 0;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormUniversity
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mainTableLayoutPanel);
            Name = "FormUniversity";
            Text = "FormUniversity";
            mainTableLayoutPanel.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel mainTableLayoutPanel;
        private TableLayoutPanel tableLayoutPanel2;
        private Label labelName;
        private Label labelCity;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label labelUniversity;
        private PictureBox pictureBox;
        private SplitContainer splitContainer1;
        private Button buttonSave;
        private Button buttonCancel;
    }
}