
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
            this.closeButton = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // manButton
            // 
            this.manButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.manButton.FlatAppearance.BorderSize = 0;
            this.manButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.manButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.manButton.Location = new System.Drawing.Point(21, 230);
            this.manButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.manButton.Name = "manButton";
            this.manButton.Size = new System.Drawing.Size(235, 66);
            this.manButton.TabIndex = 0;
            this.manButton.Text = "Менеджер";
            this.manButton.UseVisualStyleBackColor = false;
            this.manButton.Click += new System.EventHandler(this.manButton_Click);
            // 
            // accButton
            // 
            this.accButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.accButton.FlatAppearance.BorderSize = 0;
            this.accButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accButton.Font = new System.Drawing.Font("Montserrat", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.accButton.Location = new System.Drawing.Point(304, 228);
            this.accButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.accButton.Name = "accButton";
            this.accButton.Size = new System.Drawing.Size(235, 68);
            this.accButton.TabIndex = 1;
            this.accButton.Text = "Бухгалтер";
            this.accButton.UseVisualStyleBackColor = false;
            this.accButton.Click += new System.EventHandler(this.accButton_Click);
            // 
            // selButton
            // 
            this.selButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.selButton.FlatAppearance.BorderSize = 0;
            this.selButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selButton.Font = new System.Drawing.Font("Montserrat", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.selButton.Location = new System.Drawing.Point(581, 230);
            this.selButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.selButton.Name = "selButton";
            this.selButton.Size = new System.Drawing.Size(235, 66);
            this.selButton.TabIndex = 2;
            this.selButton.Text = "Продавец-консультант";
            this.selButton.UseVisualStyleBackColor = false;
            this.selButton.Click += new System.EventHandler(this.selButton_Click_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(840, 502);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.BackColor = System.Drawing.Color.PapayaWhip;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.Location = new System.Drawing.Point(804, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(35, 32);
            this.closeButton.TabIndex = 7;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // DirectorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 502);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.selButton);
            this.Controls.Add(this.accButton);
            this.Controls.Add(this.manButton);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DirectorForm";
            this.Text = "DirectorForm";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button manButton;
        private System.Windows.Forms.Button accButton;
        private System.Windows.Forms.Button selButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label closeButton;
    }
}