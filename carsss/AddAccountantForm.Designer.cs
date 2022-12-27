
namespace carsss
{
    partial class AddAccountantForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.condition = new System.Windows.Forms.ComboBox();
            this.marka = new System.Windows.Forms.ComboBox();
            this.priceField = new System.Windows.Forms.TextBox();
            this.yearField = new System.Windows.Forms.TextBox();
            this.saveAccountant = new System.Windows.Forms.Button();
            this.colorField = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.condition);
            this.panel1.Controls.Add(this.marka);
            this.panel1.Controls.Add(this.priceField);
            this.panel1.Controls.Add(this.yearField);
            this.panel1.Controls.Add(this.saveAccountant);
            this.panel1.Controls.Add(this.colorField);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(295, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 270);
            this.panel1.TabIndex = 16;
            // 
            // condition
            // 
            this.condition.FormattingEnabled = true;
            this.condition.Items.AddRange(new object[] {
            "Б/У",
            "Новый"});
            this.condition.Location = new System.Drawing.Point(106, 115);
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
            this.marka.Location = new System.Drawing.Point(106, 23);
            this.marka.Name = "marka";
            this.marka.Size = new System.Drawing.Size(76, 21);
            this.marka.TabIndex = 14;
            // 
            // priceField
            // 
            this.priceField.Location = new System.Drawing.Point(106, 151);
            this.priceField.Margin = new System.Windows.Forms.Padding(2);
            this.priceField.Name = "priceField";
            this.priceField.Size = new System.Drawing.Size(76, 20);
            this.priceField.TabIndex = 1;
            // 
            // yearField
            // 
            this.yearField.Location = new System.Drawing.Point(106, 87);
            this.yearField.Margin = new System.Windows.Forms.Padding(2);
            this.yearField.Name = "yearField";
            this.yearField.Size = new System.Drawing.Size(76, 20);
            this.yearField.TabIndex = 3;
            // 
            // saveAccountant
            // 
            this.saveAccountant.Location = new System.Drawing.Point(40, 204);
            this.saveAccountant.Margin = new System.Windows.Forms.Padding(2);
            this.saveAccountant.Name = "saveAccountant";
            this.saveAccountant.Size = new System.Drawing.Size(124, 30);
            this.saveAccountant.TabIndex = 12;
            this.saveAccountant.Text = "сохранить";
            this.saveAccountant.UseVisualStyleBackColor = true;
            this.saveAccountant.Click += new System.EventHandler(this.saveAccountant_Click);
            // 
            // colorField
            // 
            this.colorField.Location = new System.Drawing.Point(106, 55);
            this.colorField.Margin = new System.Windows.Forms.Padding(2);
            this.colorField.Name = "colorField";
            this.colorField.Size = new System.Drawing.Size(76, 20);
            this.colorField.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(31, 59);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(30, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "цвет";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "марка";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 91);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "год";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 155);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "цена";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 123);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "состояние";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(298, 56);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 25);
            this.label6.TabIndex = 17;
            this.label6.Text = "Новая накаладная";
            // 
            // AddAccountantForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Name = "AddAccountantForm";
            this.Text = "AddAccountantForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.ComboBox marka;
        private System.Windows.Forms.TextBox priceField;
        private System.Windows.Forms.TextBox yearField;
        private System.Windows.Forms.Button saveAccountant;
        private System.Windows.Forms.TextBox colorField;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label6;
    }
}