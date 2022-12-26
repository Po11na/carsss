
namespace carsss
{
    partial class AddManagerForm
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
            this.textBox_markAddManager = new System.Windows.Forms.TextBox();
            this.textBox_priceAddManager = new System.Windows.Forms.TextBox();
            this.textBox_condAddManager = new System.Windows.Forms.TextBox();
            this.textBox_yearAddManager = new System.Windows.Forms.TextBox();
            this.textBox_colorAddManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButtonAddManager = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox_markAddManager
            // 
            this.textBox_markAddManager.Location = new System.Drawing.Point(370, 116);
            this.textBox_markAddManager.Name = "textBox_markAddManager";
            this.textBox_markAddManager.Size = new System.Drawing.Size(100, 22);
            this.textBox_markAddManager.TabIndex = 0;
            // 
            // textBox_priceAddManager
            // 
            this.textBox_priceAddManager.Location = new System.Drawing.Point(370, 273);
            this.textBox_priceAddManager.Name = "textBox_priceAddManager";
            this.textBox_priceAddManager.Size = new System.Drawing.Size(100, 22);
            this.textBox_priceAddManager.TabIndex = 1;
            // 
            // textBox_condAddManager
            // 
            this.textBox_condAddManager.Location = new System.Drawing.Point(370, 234);
            this.textBox_condAddManager.Name = "textBox_condAddManager";
            this.textBox_condAddManager.Size = new System.Drawing.Size(100, 22);
            this.textBox_condAddManager.TabIndex = 2;
            // 
            // textBox_yearAddManager
            // 
            this.textBox_yearAddManager.Location = new System.Drawing.Point(370, 195);
            this.textBox_yearAddManager.Name = "textBox_yearAddManager";
            this.textBox_yearAddManager.Size = new System.Drawing.Size(100, 22);
            this.textBox_yearAddManager.TabIndex = 3;
            // 
            // textBox_colorAddManager
            // 
            this.textBox_colorAddManager.Location = new System.Drawing.Point(370, 155);
            this.textBox_colorAddManager.Name = "textBox_colorAddManager";
            this.textBox_colorAddManager.Size = new System.Drawing.Size(100, 22);
            this.textBox_colorAddManager.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 278);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 239);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "состояние";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(271, 200);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(271, 160);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 17);
            this.label5.TabIndex = 9;
            this.label5.Text = "цвет";
            // 
            // saveButtonAddManager
            // 
            this.saveButtonAddManager.Location = new System.Drawing.Point(283, 339);
            this.saveButtonAddManager.Name = "saveButtonAddManager";
            this.saveButtonAddManager.Size = new System.Drawing.Size(166, 37);
            this.saveButtonAddManager.TabIndex = 12;
            this.saveButtonAddManager.Text = "сохранить";
            this.saveButtonAddManager.UseVisualStyleBackColor = true;
            this.saveButtonAddManager.Click += new System.EventHandler(this.saveButtonAddManager_Click);
            // 
            // AddManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.saveButtonAddManager);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_colorAddManager);
            this.Controls.Add(this.textBox_yearAddManager);
            this.Controls.Add(this.textBox_condAddManager);
            this.Controls.Add(this.textBox_priceAddManager);
            this.Controls.Add(this.textBox_markAddManager);
            this.Name = "AddManagerForm";
            this.Text = "AddManagerForm";
            this.Load += new System.EventHandler(this.AddManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_markAddManager;
        private System.Windows.Forms.TextBox textBox_priceAddManager;
        private System.Windows.Forms.TextBox textBox_condAddManager;
        private System.Windows.Forms.TextBox textBox_yearAddManager;
        private System.Windows.Forms.TextBox textBox_colorAddManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButtonAddManager;
    }
}