namespace AcuCafe
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ckbChocolate = new System.Windows.Forms.CheckBox();
            this.ckbSugar = new System.Windows.Forms.CheckBox();
            this.ckbMilk = new System.Windows.Forms.CheckBox();
            this.cmbDrinks = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblBarista = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblOrderInfo = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOrder);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.ckbChocolate);
            this.groupBox1.Controls.Add(this.ckbSugar);
            this.groupBox1.Controls.Add(this.ckbMilk);
            this.groupBox1.Controls.Add(this.cmbDrinks);
            this.groupBox1.Location = new System.Drawing.Point(16, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(490, 185);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Take Order";
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(367, 70);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(98, 90);
            this.btnOrder.TabIndex = 5;
            this.btnOrder.Text = "Process Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Drink";
            // 
            // ckbChocolate
            // 
            this.ckbChocolate.AutoSize = true;
            this.ckbChocolate.Location = new System.Drawing.Point(20, 107);
            this.ckbChocolate.Name = "ckbChocolate";
            this.ckbChocolate.Size = new System.Drawing.Size(74, 17);
            this.ckbChocolate.TabIndex = 3;
            this.ckbChocolate.Text = "Chocolate";
            this.ckbChocolate.UseVisualStyleBackColor = true;
            // 
            // ckbSugar
            // 
            this.ckbSugar.AutoSize = true;
            this.ckbSugar.Location = new System.Drawing.Point(20, 143);
            this.ckbSugar.Name = "ckbSugar";
            this.ckbSugar.Size = new System.Drawing.Size(54, 17);
            this.ckbSugar.TabIndex = 2;
            this.ckbSugar.Text = "Sugar";
            this.ckbSugar.UseVisualStyleBackColor = true;
            // 
            // ckbMilk
            // 
            this.ckbMilk.AutoSize = true;
            this.ckbMilk.Location = new System.Drawing.Point(20, 70);
            this.ckbMilk.Name = "ckbMilk";
            this.ckbMilk.Size = new System.Drawing.Size(45, 17);
            this.ckbMilk.TabIndex = 1;
            this.ckbMilk.Text = "Milk";
            this.ckbMilk.UseVisualStyleBackColor = true;
            // 
            // cmbDrinks
            // 
            this.cmbDrinks.FormattingEnabled = true;
            this.cmbDrinks.Location = new System.Drawing.Point(55, 24);
            this.cmbDrinks.Name = "cmbDrinks";
            this.cmbDrinks.Size = new System.Drawing.Size(410, 21);
            this.cmbDrinks.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.panel1);
            this.groupBox2.Location = new System.Drawing.Point(531, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(257, 414);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Barista Information";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblBarista);
            this.panel1.Location = new System.Drawing.Point(17, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(221, 368);
            this.panel1.TabIndex = 0;
            // 
            // lblBarista
            // 
            this.lblBarista.AutoSize = true;
            this.lblBarista.Location = new System.Drawing.Point(24, 20);
            this.lblBarista.Name = "lblBarista";
            this.lblBarista.Size = new System.Drawing.Size(0, 13);
            this.lblBarista.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblTotalAmount);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.lblOrderInfo);
            this.groupBox3.Location = new System.Drawing.Point(16, 226);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(489, 200);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Order Information";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Location = new System.Drawing.Point(369, 174);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(0, 13);
            this.lblTotalAmount.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Total Amount:";
            // 
            // lblOrderInfo
            // 
            this.lblOrderInfo.AutoSize = true;
            this.lblOrderInfo.Location = new System.Drawing.Point(15, 34);
            this.lblOrderInfo.Name = "lblOrderInfo";
            this.lblOrderInfo.Size = new System.Drawing.Size(0, 13);
            this.lblOrderInfo.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "AcuCafe";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ckbChocolate;
        private System.Windows.Forms.CheckBox ckbSugar;
        private System.Windows.Forms.CheckBox ckbMilk;
        private System.Windows.Forms.ComboBox cmbDrinks;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblBarista;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblOrderInfo;
    }
}

