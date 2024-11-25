
namespace Lab01
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_productName = new System.Windows.Forms.Label();
            this.lbl_productPrice = new System.Windows.Forms.Label();
            this.cb_productCode = new System.Windows.Forms.ComboBox();
            this.lbl_productID = new System.Windows.Forms.Label();
            this.btn_order = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.txtbox_quantity = new System.Windows.Forms.TextBox();
            this.lbl_price = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_TotalPrice = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(9, 10);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(88, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(199, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Legend Motor Company";
            // 
            // lbl_productName
            // 
            this.lbl_productName.AutoSize = true;
            this.lbl_productName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productName.Location = new System.Drawing.Point(23, 136);
            this.lbl_productName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productName.Name = "lbl_productName";
            this.lbl_productName.Size = new System.Drawing.Size(135, 17);
            this.lbl_productName.TabIndex = 2;
            this.lbl_productName.Text = "Product Information:";
            // 
            // lbl_productPrice
            // 
            this.lbl_productPrice.AutoSize = true;
            this.lbl_productPrice.Location = new System.Drawing.Point(39, 174);
            this.lbl_productPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productPrice.Name = "lbl_productPrice";
            this.lbl_productPrice.Size = new System.Drawing.Size(43, 13);
            this.lbl_productPrice.TabIndex = 3;
            this.lbl_productPrice.Text = "Price: $";
            // 
            // cb_productCode
            // 
            this.cb_productCode.FormattingEnabled = true;
            this.cb_productCode.Items.AddRange(new object[] {
            "A0001",
            "A0002",
            "B0001",
            "B0002"});
            this.cb_productCode.Location = new System.Drawing.Point(208, 149);
            this.cb_productCode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cb_productCode.Name = "cb_productCode";
            this.cb_productCode.Size = new System.Drawing.Size(92, 21);
            this.cb_productCode.TabIndex = 5;
            this.cb_productCode.SelectedIndexChanged += new System.EventHandler(this.cb_productCode_SelectedIndexChanged);
            // 
            // lbl_productID
            // 
            this.lbl_productID.AutoSize = true;
            this.lbl_productID.Location = new System.Drawing.Point(39, 160);
            this.lbl_productID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_productID.Name = "lbl_productID";
            this.lbl_productID.Size = new System.Drawing.Size(41, 13);
            this.lbl_productID.TabIndex = 4;
            this.lbl_productID.Text = "Name: ";
            // 
            // btn_order
            // 
            this.btn_order.Location = new System.Drawing.Point(224, 290);
            this.btn_order.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_order.Name = "btn_order";
            this.btn_order.Size = new System.Drawing.Size(56, 19);
            this.btn_order.TabIndex = 6;
            this.btn_order.Text = "Order";
            this.btn_order.UseVisualStyleBackColor = true;
            this.btn_order.Click += new System.EventHandler(this.btn_order_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(102, 289);
            this.btn_cancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(56, 19);
            this.btn_cancel.TabIndex = 7;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // txtbox_quantity
            // 
            this.txtbox_quantity.Location = new System.Drawing.Point(216, 174);
            this.txtbox_quantity.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbox_quantity.Name = "txtbox_quantity";
            this.txtbox_quantity.Size = new System.Drawing.Size(76, 20);
            this.txtbox_quantity.TabIndex = 8;
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Location = new System.Drawing.Point(89, 174);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(0, 13);
            this.lbl_price.TabIndex = 10;
            // 
            // lbl_Name
            // 
            this.lbl_Name.AutoSize = true;
            this.lbl_Name.Location = new System.Drawing.Point(84, 160);
            this.lbl_Name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(0, 13);
            this.lbl_Name.TabIndex = 11;
            // 
            // lbl_TotalPrice
            // 
            this.lbl_TotalPrice.AutoSize = true;
            this.lbl_TotalPrice.Location = new System.Drawing.Point(208, 232);
            this.lbl_TotalPrice.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_TotalPrice.Name = "lbl_TotalPrice";
            this.lbl_TotalPrice.Size = new System.Drawing.Size(61, 13);
            this.lbl_TotalPrice.TabIndex = 12;
            this.lbl_TotalPrice.Text = "TotalPrice: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(258, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Created by Lam Yun Sang 230686837 on 6/11/2024";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(591, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Build project";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 496);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_TotalPrice);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.txtbox_quantity);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.btn_order);
            this.Controls.Add(this.cb_productCode);
            this.Controls.Add(this.lbl_productID);
            this.Controls.Add(this.lbl_productPrice);
            this.Controls.Add(this.lbl_productName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.Text = "LMC e commerce";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_productName;
        private System.Windows.Forms.Label lbl_productPrice;
        private System.Windows.Forms.ComboBox cb_productCode;
        private System.Windows.Forms.Label lbl_productID;
        private System.Windows.Forms.Button btn_order;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.TextBox txtbox_quantity;
        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_TotalPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

