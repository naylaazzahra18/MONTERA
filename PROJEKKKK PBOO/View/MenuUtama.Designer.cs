namespace PROJEKKKK_PBOO
{
    partial class MenuUtama
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuUtama));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            btnMonitoringAyam = new Button();
            btnPrediksiAyam = new Button();
            btnPrediksiTelur = new Button();
            btnMonitoringTelur = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(214, 25);
            label1.Name = "label1";
            label1.Size = new Size(481, 48);
            label1.TabIndex = 0;
            label1.Text = "Sistem Monitoring dan Prediksi Persentase \r\nHasil Panen Telur serta Jumlah Ayam Sakit";
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Location = new Point(30, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(202, 194);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(718, 86);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(202, 194);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // btnMonitoringAyam
            // 
            btnMonitoringAyam.BackColor = Color.White;
            btnMonitoringAyam.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMonitoringAyam.Location = new Point(255, 99);
            btnMonitoringAyam.Name = "btnMonitoringAyam";
            btnMonitoringAyam.Size = new Size(192, 147);
            btnMonitoringAyam.TabIndex = 3;
            btnMonitoringAyam.Text = "Monitoring\r\n Ayam ";
            btnMonitoringAyam.UseVisualStyleBackColor = false;
            btnMonitoringAyam.Click += btnMonitoringAyam_Click;
            // 
            // btnPrediksiAyam
            // 
            btnPrediksiAyam.BackColor = Color.White;
            btnPrediksiAyam.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrediksiAyam.Location = new Point(255, 309);
            btnPrediksiAyam.Name = "btnPrediksiAyam";
            btnPrediksiAyam.Size = new Size(203, 141);
            btnPrediksiAyam.TabIndex = 5;
            btnPrediksiAyam.Text = "Prediksi Ayam ";
            btnPrediksiAyam.UseVisualStyleBackColor = false;
            btnPrediksiAyam.Click += btnPrediksiAyam_Click;
            // 
            // btnPrediksiTelur
            // 
            btnPrediksiTelur.BackColor = Color.White;
            btnPrediksiTelur.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnPrediksiTelur.Location = new Point(477, 309);
            btnPrediksiTelur.Name = "btnPrediksiTelur";
            btnPrediksiTelur.Size = new Size(197, 141);
            btnPrediksiTelur.TabIndex = 6;
            btnPrediksiTelur.Text = "Prediksi Telur ";
            btnPrediksiTelur.UseVisualStyleBackColor = false;
            btnPrediksiTelur.Click += btnPrediksiTelur_Click;
            // 
            // btnMonitoringTelur
            // 
            btnMonitoringTelur.BackColor = Color.White;
            btnMonitoringTelur.Font = new Font("Stencil", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnMonitoringTelur.Location = new Point(477, 99);
            btnMonitoringTelur.Name = "btnMonitoringTelur";
            btnMonitoringTelur.Size = new Size(192, 147);
            btnMonitoringTelur.TabIndex = 7;
            btnMonitoringTelur.Text = "Monitoring\r\n Telur";
            btnMonitoringTelur.UseVisualStyleBackColor = false;
            btnMonitoringTelur.Click += btnMonitoringTelur_Click;
            // 
            // MenuUtama
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Linen;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(951, 611);
            Controls.Add(btnMonitoringTelur);
            Controls.Add(btnPrediksiTelur);
            Controls.Add(btnPrediksiAyam);
            Controls.Add(btnMonitoringAyam);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(label1);
            Name = "MenuUtama";
            Text = "MenuUtama";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Button btnMonitoringAyam;
        private Button btnPrediksiAyam;
        private Button btnPrediksiTelur;
        private Button btnMonitoringTelur;
        private Panel panelUtama;
    }
}