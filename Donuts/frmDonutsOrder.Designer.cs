
namespace Donuts
{
    partial class frmDonutsOrder
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
            this.lblName = new System.Windows.Forms.Label();
            this.lblCoffee = new System.Windows.Forms.Label();
            this.lblDonuts = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbCoffee = new System.Windows.Forms.TextBox();
            this.txbDonuts = new System.Windows.Forms.TextBox();
            this.btnOrder = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(100, 49);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(39, 15);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblCoffee
            // 
            this.lblCoffee.AutoSize = true;
            this.lblCoffee.Location = new System.Drawing.Point(100, 107);
            this.lblCoffee.Name = "lblCoffee";
            this.lblCoffee.Size = new System.Drawing.Size(42, 15);
            this.lblCoffee.TabIndex = 1;
            this.lblCoffee.Text = "Coffee";
            // 
            // lblDonuts
            // 
            this.lblDonuts.AutoSize = true;
            this.lblDonuts.Location = new System.Drawing.Point(100, 164);
            this.lblDonuts.Name = "lblDonuts";
            this.lblDonuts.Size = new System.Drawing.Size(45, 15);
            this.lblDonuts.TabIndex = 2;
            this.lblDonuts.Text = "Donuts";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(254, 46);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(100, 23);
            this.txbName.TabIndex = 3;
            // 
            // txbCoffee
            // 
            this.txbCoffee.Location = new System.Drawing.Point(254, 104);
            this.txbCoffee.Name = "txbCoffee";
            this.txbCoffee.Size = new System.Drawing.Size(100, 23);
            this.txbCoffee.TabIndex = 4;
            // 
            // txbDonuts
            // 
            this.txbDonuts.Location = new System.Drawing.Point(254, 161);
            this.txbDonuts.Name = "txbDonuts";
            this.txbDonuts.Size = new System.Drawing.Size(100, 23);
            this.txbDonuts.TabIndex = 5;
            // 
            // btnOrder
            // 
            this.btnOrder.Location = new System.Drawing.Point(235, 243);
            this.btnOrder.Name = "btnOrder";
            this.btnOrder.Size = new System.Drawing.Size(75, 23);
            this.btnOrder.TabIndex = 6;
            this.btnOrder.Text = "Order";
            this.btnOrder.UseVisualStyleBackColor = true;
            this.btnOrder.Click += new System.EventHandler(this.btnOrder_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(71, 243);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmDonutsOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 305);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnOrder);
            this.Controls.Add(this.txbDonuts);
            this.Controls.Add(this.txbCoffee);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblDonuts);
            this.Controls.Add(this.lblCoffee);
            this.Controls.Add(this.lblName);
            this.Name = "frmDonutsOrder";
            this.Text = "Name";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCoffee;
        private System.Windows.Forms.Label lblDonuts;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbCoffee;
        private System.Windows.Forms.TextBox txbDonuts;
        private System.Windows.Forms.Button btnOrder;
        private System.Windows.Forms.Button button1;
    }
}