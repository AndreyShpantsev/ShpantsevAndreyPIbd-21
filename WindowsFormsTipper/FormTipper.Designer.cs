namespace WindowsFormsTipper
{
    partial class FormTipper
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTipper));
            this.pictureBoxTipper = new System.Windows.Forms.PictureBox();
            this.ButtonCreateTruck = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonDown = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.ButtonCreateTipper = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipper)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxTipper
            // 
            this.pictureBoxTipper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxTipper.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxTipper.Name = "pictureBoxTipper";
            this.pictureBoxTipper.Size = new System.Drawing.Size(884, 461);
            this.pictureBoxTipper.TabIndex = 0;
            this.pictureBoxTipper.TabStop = false;
            // 
            // ButtonCreateTruck
            // 
            this.ButtonCreateTruck.Location = new System.Drawing.Point(12, 12);
            this.ButtonCreateTruck.Name = "ButtonCreateTruck";
            this.ButtonCreateTruck.Size = new System.Drawing.Size(108, 35);
            this.ButtonCreateTruck.TabIndex = 1;
            this.ButtonCreateTruck.Text = "Создать грузовик";
            this.ButtonCreateTruck.UseVisualStyleBackColor = true;
            this.ButtonCreateTruck.Click += new System.EventHandler(this.ButtonCreateTruck_Click);
            // 
            // buttonUp
            // 
            this.buttonUp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonUp.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonUp.BackgroundImage")));
            this.buttonUp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonUp.Location = new System.Drawing.Point(792, 383);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(30, 30);
            this.buttonUp.TabIndex = 2;
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonLeft.BackgroundImage")));
            this.buttonLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonLeft.Location = new System.Drawing.Point(756, 419);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(30, 30);
            this.buttonLeft.TabIndex = 3;
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonDown
            // 
            this.buttonDown.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonDown.BackgroundImage")));
            this.buttonDown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDown.Location = new System.Drawing.Point(792, 419);
            this.buttonDown.Name = "buttonDown";
            this.buttonDown.Size = new System.Drawing.Size(30, 30);
            this.buttonDown.TabIndex = 4;
            this.buttonDown.UseVisualStyleBackColor = true;
            this.buttonDown.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonRight.BackgroundImage")));
            this.buttonRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRight.Location = new System.Drawing.Point(828, 419);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(30, 30);
            this.buttonRight.TabIndex = 5;
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.buttonMove_Click);
            // 
            // ButtonCreateTipper
            // 
            this.ButtonCreateTipper.Location = new System.Drawing.Point(126, 12);
            this.ButtonCreateTipper.Name = "ButtonCreateTipper";
            this.ButtonCreateTipper.Size = new System.Drawing.Size(108, 35);
            this.ButtonCreateTipper.TabIndex = 6;
            this.ButtonCreateTipper.Text = "Создать самосвал";
            this.ButtonCreateTipper.UseVisualStyleBackColor = true;
            this.ButtonCreateTipper.Click += new System.EventHandler(this.ButtonCreateTipper_Click);
            // 
            // FormTipper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.ButtonCreateTipper);
            this.Controls.Add(this.buttonRight);
            this.Controls.Add(this.buttonDown);
            this.Controls.Add(this.buttonLeft);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.ButtonCreateTruck);
            this.Controls.Add(this.pictureBoxTipper);
            this.Name = "FormTipper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tipper";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipper)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxTipper;
        private System.Windows.Forms.Button ButtonCreateTruck;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonDown;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button ButtonCreateTipper;
    }
}

