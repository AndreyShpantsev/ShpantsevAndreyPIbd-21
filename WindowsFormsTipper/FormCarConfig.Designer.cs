namespace WindowsFormsTipper
{
    partial class FormCarConfig
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
            this.pictureBoxCar = new System.Windows.Forms.PictureBox();
            this.groupBoxCar = new System.Windows.Forms.GroupBox();
            this.labelTipper = new System.Windows.Forms.Label();
            this.labelTruck = new System.Windows.Forms.Label();
            this.panelCar = new System.Windows.Forms.Panel();
            this.labelDopColor = new System.Windows.Forms.Label();
            this.labelMainColor = new System.Windows.Forms.Label();
            this.groupBoxColor = new System.Windows.Forms.GroupBox();
            this.panelWhite = new System.Windows.Forms.Panel();
            this.panelPurple = new System.Windows.Forms.Panel();
            this.panelBlue = new System.Windows.Forms.Panel();
            this.panelAqua = new System.Windows.Forms.Panel();
            this.panelGreen = new System.Windows.Forms.Panel();
            this.panelYellow = new System.Windows.Forms.Panel();
            this.panelOrange = new System.Windows.Forms.Panel();
            this.panelRed = new System.Windows.Forms.Panel();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).BeginInit();
            this.groupBoxCar.SuspendLayout();
            this.panelCar.SuspendLayout();
            this.groupBoxColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxCar
            // 
            this.pictureBoxCar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCar.Location = new System.Drawing.Point(18, 7);
            this.pictureBoxCar.Name = "pictureBoxCar";
            this.pictureBoxCar.Size = new System.Drawing.Size(185, 143);
            this.pictureBoxCar.TabIndex = 0;
            this.pictureBoxCar.TabStop = false;
            this.pictureBoxCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.pictureBoxCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // groupBoxCar
            // 
            this.groupBoxCar.Controls.Add(this.labelTipper);
            this.groupBoxCar.Controls.Add(this.labelTruck);
            this.groupBoxCar.Location = new System.Drawing.Point(46, 12);
            this.groupBoxCar.Name = "groupBoxCar";
            this.groupBoxCar.Size = new System.Drawing.Size(207, 121);
            this.groupBoxCar.TabIndex = 1;
            this.groupBoxCar.TabStop = false;
            this.groupBoxCar.Text = "Тип кузова";
            // 
            // labelTipper
            // 
            this.labelTipper.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTipper.Location = new System.Drawing.Point(57, 72);
            this.labelTipper.Name = "labelTipper";
            this.labelTipper.Size = new System.Drawing.Size(99, 32);
            this.labelTipper.TabIndex = 1;
            this.labelTipper.Text = "Самосвал";
            this.labelTipper.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTipper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTipper_MouseDown);
            // 
            // labelTruck
            // 
            this.labelTruck.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTruck.Location = new System.Drawing.Point(60, 30);
            this.labelTruck.Name = "labelTruck";
            this.labelTruck.Size = new System.Drawing.Size(96, 30);
            this.labelTruck.TabIndex = 0;
            this.labelTruck.Text = "Грузовик";
            this.labelTruck.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelTruck.MouseDown += new System.Windows.Forms.MouseEventHandler(this.labelTruck_MouseDown);
            // 
            // panelCar
            // 
            this.panelCar.AllowDrop = true;
            this.panelCar.Controls.Add(this.labelDopColor);
            this.panelCar.Controls.Add(this.labelMainColor);
            this.panelCar.Controls.Add(this.pictureBoxCar);
            this.panelCar.Location = new System.Drawing.Point(277, 12);
            this.panelCar.Name = "panelCar";
            this.panelCar.Size = new System.Drawing.Size(219, 246);
            this.panelCar.TabIndex = 2;
            this.panelCar.DragDrop += new System.Windows.Forms.DragEventHandler(this.panelCar_DragDrop);
            this.panelCar.DragEnter += new System.Windows.Forms.DragEventHandler(this.panelCar_DragEnter);
            // 
            // labelDopColor
            // 
            this.labelDopColor.AllowDrop = true;
            this.labelDopColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelDopColor.Location = new System.Drawing.Point(40, 197);
            this.labelDopColor.Name = "labelDopColor";
            this.labelDopColor.Size = new System.Drawing.Size(143, 33);
            this.labelDopColor.TabIndex = 2;
            this.labelDopColor.Text = "Дополнительный цвет";
            this.labelDopColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelDopColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelDopColor_DragDrop);
            this.labelDopColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // labelMainColor
            // 
            this.labelMainColor.AllowDrop = true;
            this.labelMainColor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelMainColor.Location = new System.Drawing.Point(40, 163);
            this.labelMainColor.Name = "labelMainColor";
            this.labelMainColor.Size = new System.Drawing.Size(143, 30);
            this.labelMainColor.TabIndex = 1;
            this.labelMainColor.Text = "Основной цвет";
            this.labelMainColor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelMainColor.DragDrop += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragDrop);
            this.labelMainColor.DragEnter += new System.Windows.Forms.DragEventHandler(this.labelMainColor_DragEnter);
            // 
            // groupBoxColor
            // 
            this.groupBoxColor.Controls.Add(this.panelWhite);
            this.groupBoxColor.Controls.Add(this.panelPurple);
            this.groupBoxColor.Controls.Add(this.panelBlue);
            this.groupBoxColor.Controls.Add(this.panelAqua);
            this.groupBoxColor.Controls.Add(this.panelGreen);
            this.groupBoxColor.Controls.Add(this.panelYellow);
            this.groupBoxColor.Controls.Add(this.panelOrange);
            this.groupBoxColor.Controls.Add(this.panelRed);
            this.groupBoxColor.Location = new System.Drawing.Point(46, 140);
            this.groupBoxColor.Name = "groupBoxColor";
            this.groupBoxColor.Size = new System.Drawing.Size(200, 118);
            this.groupBoxColor.TabIndex = 3;
            this.groupBoxColor.TabStop = false;
            this.groupBoxColor.Text = "Выбор цвета";
            // 
            // panelWhite
            // 
            this.panelWhite.BackColor = System.Drawing.Color.White;
            this.panelWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelWhite.Location = new System.Drawing.Point(164, 69);
            this.panelWhite.Name = "panelWhite";
            this.panelWhite.Size = new System.Drawing.Size(30, 30);
            this.panelWhite.TabIndex = 8;
            this.panelWhite.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelPurple
            // 
            this.panelPurple.BackColor = System.Drawing.Color.Purple;
            this.panelPurple.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelPurple.Location = new System.Drawing.Point(108, 69);
            this.panelPurple.Name = "panelPurple";
            this.panelPurple.Size = new System.Drawing.Size(30, 30);
            this.panelPurple.TabIndex = 7;
            this.panelPurple.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelBlue
            // 
            this.panelBlue.BackColor = System.Drawing.Color.Blue;
            this.panelBlue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBlue.Location = new System.Drawing.Point(57, 69);
            this.panelBlue.Name = "panelBlue";
            this.panelBlue.Size = new System.Drawing.Size(30, 30);
            this.panelBlue.TabIndex = 6;
            this.panelBlue.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelAqua
            // 
            this.panelAqua.BackColor = System.Drawing.Color.Aqua;
            this.panelAqua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelAqua.Location = new System.Drawing.Point(6, 69);
            this.panelAqua.Name = "panelAqua";
            this.panelAqua.Size = new System.Drawing.Size(30, 30);
            this.panelAqua.TabIndex = 5;
            this.panelAqua.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelGreen
            // 
            this.panelGreen.BackColor = System.Drawing.Color.Green;
            this.panelGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelGreen.Location = new System.Drawing.Point(164, 19);
            this.panelGreen.Name = "panelGreen";
            this.panelGreen.Size = new System.Drawing.Size(30, 30);
            this.panelGreen.TabIndex = 4;
            this.panelGreen.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelYellow
            // 
            this.panelYellow.BackColor = System.Drawing.Color.Yellow;
            this.panelYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelYellow.Location = new System.Drawing.Point(108, 19);
            this.panelYellow.Name = "panelYellow";
            this.panelYellow.Size = new System.Drawing.Size(30, 30);
            this.panelYellow.TabIndex = 4;
            this.panelYellow.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelOrange
            // 
            this.panelOrange.BackColor = System.Drawing.Color.Orange;
            this.panelOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelOrange.Location = new System.Drawing.Point(57, 19);
            this.panelOrange.Name = "panelOrange";
            this.panelOrange.Size = new System.Drawing.Size(30, 30);
            this.panelOrange.TabIndex = 4;
            this.panelOrange.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // panelRed
            // 
            this.panelRed.BackColor = System.Drawing.Color.Red;
            this.panelRed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelRed.Location = new System.Drawing.Point(6, 19);
            this.panelRed.Name = "panelRed";
            this.panelRed.Size = new System.Drawing.Size(30, 30);
            this.panelRed.TabIndex = 4;
            this.panelRed.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelRed_MouseDown);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(46, 265);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(87, 46);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(154, 265);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(92, 46);
            this.buttonCancel.TabIndex = 5;
            this.buttonCancel.Text = "Отмена";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // FormCarConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(508, 323);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBoxColor);
            this.Controls.Add(this.panelCar);
            this.Controls.Add(this.groupBoxCar);
            this.Name = "FormCarConfig";
            this.Text = "Выбор машины";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCar)).EndInit();
            this.groupBoxCar.ResumeLayout(false);
            this.panelCar.ResumeLayout(false);
            this.groupBoxColor.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxCar;
        private System.Windows.Forms.GroupBox groupBoxCar;
        private System.Windows.Forms.Label labelTipper;
        private System.Windows.Forms.Label labelTruck;
        private System.Windows.Forms.Panel panelCar;
        private System.Windows.Forms.Label labelDopColor;
        private System.Windows.Forms.Label labelMainColor;
        private System.Windows.Forms.GroupBox groupBoxColor;
        private System.Windows.Forms.Panel panelWhite;
        private System.Windows.Forms.Panel panelPurple;
        private System.Windows.Forms.Panel panelBlue;
        private System.Windows.Forms.Panel panelAqua;
        private System.Windows.Forms.Panel panelGreen;
        private System.Windows.Forms.Panel panelYellow;
        private System.Windows.Forms.Panel panelOrange;
        private System.Windows.Forms.Panel panelRed;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonCancel;
    }
}