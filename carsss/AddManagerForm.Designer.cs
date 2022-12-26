
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
            this.textBox_priceAddManager = new System.Windows.Forms.TextBox();
            this.textBox_yearAddManager = new System.Windows.Forms.TextBox();
            this.textBox_colorAddManager = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.saveButtonAddManager = new System.Windows.Forms.Button();
            this.condition = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // textBox_priceAddManager
            // 
            this.textBox_priceAddManager.Location = new System.Drawing.Point(278, 222);
            this.textBox_priceAddManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_priceAddManager.Name = "textBox_priceAddManager";
            this.textBox_priceAddManager.Size = new System.Drawing.Size(76, 20);
            this.textBox_priceAddManager.TabIndex = 1;
            // 
            // textBox_yearAddManager
            // 
            this.textBox_yearAddManager.Location = new System.Drawing.Point(278, 158);
            this.textBox_yearAddManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_yearAddManager.Name = "textBox_yearAddManager";
            this.textBox_yearAddManager.Size = new System.Drawing.Size(76, 20);
            this.textBox_yearAddManager.TabIndex = 3;
            // 
            // textBox_colorAddManager
            // 
            this.textBox_colorAddManager.Location = new System.Drawing.Point(278, 126);
            this.textBox_colorAddManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_colorAddManager.Name = "textBox_colorAddManager";
            this.textBox_colorAddManager.Size = new System.Drawing.Size(76, 20);
            this.textBox_colorAddManager.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(203, 97);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "марка";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(203, 226);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(203, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "состояние";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(203, 162);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "год";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(203, 130);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "цвет";
            // 
            // saveButtonAddManager
            // 
            this.saveButtonAddManager.Location = new System.Drawing.Point(212, 275);
            this.saveButtonAddManager.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.saveButtonAddManager.Name = "saveButtonAddManager";
            this.saveButtonAddManager.Size = new System.Drawing.Size(124, 30);
            this.saveButtonAddManager.TabIndex = 12;
            this.saveButtonAddManager.Text = "сохранить";
            this.saveButtonAddManager.UseVisualStyleBackColor = true;
            this.saveButtonAddManager.Click += new System.EventHandler(this.saveButtonAddManager_Click);
            // 
            // condition
            // 
            this.condition.FormattingEnabled = true;
            this.condition.Items.AddRange(new object[] {
            "Б/У",
            "Новый"});
            this.condition.Location = new System.Drawing.Point(278, 186);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(76, 21);
            this.condition.TabIndex = 13;
            // 
            // marka
            // 
            this.marka.FormattingEnabled = true;
            this.marka.Items.AddRange(new object[] {
            "Audi",
            "BMW",
            "Brabus",
            "Chevrolet",
            "Ferrari",
            "Porshe",
            "Mazda",
            "Mercedes"});
            this.marka.Location = new System.Drawing.Point(278, 94);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(76, 21);
            this.marka.TabIndex = 14;
            // 
            // AddManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.marka);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.saveButtonAddManager);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_colorAddManager);
            this.Controls.Add(this.textBox_yearAddManager);
            this.Controls.Add(this.textBox_priceAddManager);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AddManagerForm";
            this.Text = "AddManagerForm";
            this.Load += new System.EventHandler(this.AddManagerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_priceAddManager;
        private System.Windows.Forms.TextBox textBox_yearAddManager;
        private System.Windows.Forms.TextBox textBox_colorAddManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button saveButtonAddManager;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.ComboBox marka;
    }
}