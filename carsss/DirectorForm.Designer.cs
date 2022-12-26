
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
            this.manButton.Location = new System.Drawing.Point(16, 187);
            this.manButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(176, 54);
            this.manButton.TabIndex = 0;
            this.manButton.Text = "Менеджер";
            this.manButton.UseVisualStyleBackColor = true;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            // 
            // accButton
            // 
            this.accButton.Location = new System.Drawing.Point(234, 187);
            this.accButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(176, 55);
            this.accButton.TabIndex = 1;
            this.accButton.Text = "Бухгалтер";
            this.accButton.UseVisualStyleBackColor = true;
            this.accButton.Click += new System.EventHandler(this.accButton_Click);
            // 
            // selButton
            // 
            this.selButton.Location = new System.Drawing.Point(436, 187);
            this.selButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(176, 54);
            this.selButton.TabIndex = 2;
            this.selButton.Text = "Продавец-консультант";
            this.selButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-10, -12);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(651, 420);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 408);
            this.Controls.Add(this.selButton);
            this.Controls.Add(this.accButton);
            this.Controls.Add(this.manButton);
            this.Controls.Add(this.pictureBox1);
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