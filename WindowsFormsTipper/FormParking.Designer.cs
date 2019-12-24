﻿namespace WindowsFormsTipper
{
    partial class FormParking
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
            this.pictureBoxParking = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeTransport_Click = new System.Windows.Forms.Button();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            this.listBoxLevels = new System.Windows.Forms.ListBox();
            this.labelLevels = new System.Windows.Forms.Label();
            this.buttonChooseCar = new System.Windows.Forms.Button();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 25);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(734, 434);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(754, 271);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать транспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 299);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(809, 296);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.maskedTextBox.TabIndex = 5;
            // 
            // buttonTakeTransport_Click
            // 
            this.buttonTakeTransport_Click.Location = new System.Drawing.Point(752, 330);
            this.buttonTakeTransport_Click.Name = "buttonTakeTransport_Click";
            this.buttonTakeTransport_Click.Size = new System.Drawing.Size(119, 24);
            this.buttonTakeTransport_Click.TabIndex = 6;
            this.buttonTakeTransport_Click.Text = "Забрать";
            this.buttonTakeTransport_Click.UseVisualStyleBackColor = true;
            this.buttonTakeTransport_Click.Click += new System.EventHandler(this.buttonTakeTransport_Click_Click);
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(741, 360);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(131, 96);
            this.pictureBoxTakeCar.TabIndex = 7;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // listBoxLevels
            // 
            this.listBoxLevels.FormattingEnabled = true;
            this.listBoxLevels.Location = new System.Drawing.Point(752, 25);
            this.listBoxLevels.Name = "listBoxLevels";
            this.listBoxLevels.Size = new System.Drawing.Size(120, 95);
            this.listBoxLevels.TabIndex = 8;
            this.listBoxLevels.SelectedIndexChanged += new System.EventHandler(this.listBoxLevels_SelectedIndexChanged);
            // 
            // labelLevels
            // 
            this.labelLevels.AutoSize = true;
            this.labelLevels.Location = new System.Drawing.Point(788, 9);
            this.labelLevels.Name = "labelLevels";
            this.labelLevels.Size = new System.Drawing.Size(45, 13);
            this.labelLevels.TabIndex = 9;
            this.labelLevels.Text = "Уровни";
            // 
            // buttonChooseCar
            // 
            this.buttonChooseCar.Location = new System.Drawing.Point(752, 151);
            this.buttonChooseCar.Name = "buttonChooseCar";
            this.buttonChooseCar.Size = new System.Drawing.Size(119, 64);
            this.buttonChooseCar.TabIndex = 10;
            this.buttonChooseCar.Text = "Выбрать транспорт";
            this.buttonChooseCar.UseVisualStyleBackColor = true;
            this.buttonChooseCar.Click += new System.EventHandler(this.button_Click);
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(878, 24);
            this.menuStrip.TabIndex = 11;
            this.menuStrip.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.сохранитьToolStripMenuItem,
            this.загрузитьToolStripMenuItem});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            this.сохранитьToolStripMenuItem.Click += new System.EventHandler(this.сохранитьToolStripMenuItem_Click);
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            this.загрузитьToolStripMenuItem.Click += new System.EventHandler(this.загрузитьToolStripMenuItem_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "txt file | *.txt";
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.Filter = "txt file | *.txt";
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 468);
            this.Controls.Add(this.buttonChooseCar);
            this.Controls.Add(this.labelLevels);
            this.Controls.Add(this.listBoxLevels);
            this.Controls.Add(this.pictureBoxTakeCar);
            this.Controls.Add(this.buttonTakeTransport_Click);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBoxParking);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormParking";
            this.Text = "Парковка";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeTransport_Click;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
        private System.Windows.Forms.ListBox listBoxLevels;
        private System.Windows.Forms.Label labelLevels;
        private System.Windows.Forms.Button buttonChooseCar;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}