
namespace carsss
{
    partial class DirectorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DirectorForm));
            this.manButton = new System.Windows.Forms.Button();
            this.accButton = new System.Windows.Forms.Button();
            this.selButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manButton
            // 
            this.manButton.Location = new System.Drawing.Point(21, 230);
            this.manButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(235, 66);
            this.manButton.TabIndex = 0;
            this.manButton.Text = "Менеджер";
            this.manButton.UseVisualStyleBackColor = true;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            // 
            // accButton
            // 
            this.accButton.Location = new System.Drawing.Point(312, 230);
            this.accButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(235, 68);
            this.accButton.TabIndex = 1;
            this.accButton.Text = "Бухгалтер";
            this.accButton.UseVisualStyleBackColor = true;
            this.accButton.Click += new System.EventHandler(this.accButton_Click);
            // 
            // selButton
            // 
            this.selButton.Location = new System.Drawing.Point(581, 230);
            this.selButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(235, 66);
            this.selButton.TabIndex = 2;
            this.selButton.Text = "Продавец-консультант";
            this.selButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -15);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(868, 517);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 502);
            this.Controls.Add(this.selButton);
            this.Controls.Add(this.accButton);
            this.Controls.Add(this.manButton);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button manButton;
        private System.Windows.Forms.Button accButton;
        private System.Windows.Forms.Button selButton;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}