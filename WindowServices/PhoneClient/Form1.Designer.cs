
namespace PhoneClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.bntSearch = new System.Windows.Forms.Button();
            this.gridPhone = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(132, 67);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(495, 20);
            this.txtKeyword.TabIndex = 1;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(681, 65);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(75, 23);
            this.bntSearch.TabIndex = 2;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // gridPhone
            // 
            this.gridPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhone.Location = new System.Drawing.Point(132, 107);
            this.gridPhone.Name = "gridPhone";
            this.gridPhone.Size = new System.Drawing.Size(495, 150);
            this.gridPhone.TabIndex = 4;
            this.gridPhone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhone_CellContentClick);
            this.gridPhone.SelectionChanged += new System.EventHandler(this.gridPhone_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 496);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantity:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(52, 447);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(52, 292);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Code:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 344);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Name:";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(132, 292);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(495, 20);
            this.txtCode.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 337);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(495, 20);
            this.txtName.TabIndex = 11;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(132, 390);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(495, 20);
            this.txtColor.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(132, 444);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(495, 20);
            this.txtPrice.TabIndex = 13;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(132, 493);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(495, 20);
            this.txtQuantity.TabIndex = 14;
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(681, 378);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 50);
            this.bntUpdate.TabIndex = 16;
            this.bntUpdate.Text = "Update";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(681, 469);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 44);
            this.bntDelete.TabIndex = 17;
            this.bntDelete.Text = "Delete";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(681, 292);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 50);
            this.bntAdd.TabIndex = 18;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 543);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridPhone);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.DataGridView gridPhone;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntAdd;
    }
}

