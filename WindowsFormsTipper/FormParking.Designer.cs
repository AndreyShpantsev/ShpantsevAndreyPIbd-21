namespace WindowsFormsTipper
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
            this.buttonSetTipper_Click = new System.Windows.Forms.Button();
            this.buttonSetTruck_Click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.maskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.buttonTakeTransport_Click = new System.Windows.Forms.Button();
            this.pictureBoxTakeCar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxParking
            // 
            this.pictureBoxParking.Location = new System.Drawing.Point(1, 5);
            this.pictureBoxParking.Name = "pictureBoxParking";
            this.pictureBoxParking.Size = new System.Drawing.Size(734, 454);
            this.pictureBoxParking.TabIndex = 0;
            this.pictureBoxParking.TabStop = false;
            // 
            // buttonSetTipper_Click
            // 
            this.buttonSetTipper_Click.Location = new System.Drawing.Point(757, 57);
            this.buttonSetTipper_Click.Name = "buttonSetTipper_Click";
            this.buttonSetTipper_Click.Size = new System.Drawing.Size(115, 43);
            this.buttonSetTipper_Click.TabIndex = 1;
            this.buttonSetTipper_Click.Text = "Припарковать самосвал";
            this.buttonSetTipper_Click.UseVisualStyleBackColor = true;
            this.buttonSetTipper_Click.Click += new System.EventHandler(this.buttonSetTipper_Click_Click);
            // 
            // buttonSetTruck_Click
            // 
            this.buttonSetTruck_Click.Location = new System.Drawing.Point(757, 5);
            this.buttonSetTruck_Click.Name = "buttonSetTruck_Click";
            this.buttonSetTruck_Click.Size = new System.Drawing.Size(115, 46);
            this.buttonSetTruck_Click.TabIndex = 2;
            this.buttonSetTruck_Click.Text = "Припарковать грузовик";
            this.buttonSetTruck_Click.UseVisualStyleBackColor = true;
            this.buttonSetTruck_Click.Click += new System.EventHandler(this.buttonSetTruck_Click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(761, 103);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Забрать транспорт";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(761, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Место:";
            // 
            // maskedTextBox
            // 
            this.maskedTextBox.Location = new System.Drawing.Point(809, 127);
            this.maskedTextBox.Name = "maskedTextBox";
            this.maskedTextBox.Size = new System.Drawing.Size(55, 20);
            this.maskedTextBox.TabIndex = 5;
            // 
            // buttonTakeTransport_Click
            // 
            this.buttonTakeTransport_Click.Location = new System.Drawing.Point(757, 153);
            this.buttonTakeTransport_Click.Name = "buttonTakeTransport_Click";
            this.buttonTakeTransport_Click.Size = new System.Drawing.Size(108, 24);
            this.buttonTakeTransport_Click.TabIndex = 6;
            this.buttonTakeTransport_Click.Text = "Забрать";
            this.buttonTakeTransport_Click.UseVisualStyleBackColor = true;
            this.buttonTakeTransport_Click.Click += new System.EventHandler(this.buttonTakeTransport_Click_Click);
            // 
            // pictureBoxTakeCar
            // 
            this.pictureBoxTakeCar.Location = new System.Drawing.Point(741, 183);
            this.pictureBoxTakeCar.Name = "pictureBoxTakeCar";
            this.pictureBoxTakeCar.Size = new System.Drawing.Size(131, 96);
            this.pictureBoxTakeCar.TabIndex = 7;
            this.pictureBoxTakeCar.TabStop = false;
            // 
            // FormParking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 468);
            this.Controls.Add(this.pictureBoxTakeCar);
            this.Controls.Add(this.buttonTakeTransport_Click);
            this.Controls.Add(this.maskedTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonSetTruck_Click);
            this.Controls.Add(this.buttonSetTipper_Click);
            this.Controls.Add(this.pictureBoxParking);
            this.Name = "FormParking";
            this.Text = "FormParking";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxParking)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTakeCar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxParking;
        private System.Windows.Forms.Button buttonSetTipper_Click;
        private System.Windows.Forms.Button buttonSetTruck_Click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox;
        private System.Windows.Forms.Button buttonTakeTransport_Click;
        private System.Windows.Forms.PictureBox pictureBoxTakeCar;
    }
}