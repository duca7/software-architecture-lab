
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
            this.gridPhone = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // gridPhone
            // 
            this.gridPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhone.Location = new System.Drawing.Point(115, 109);
            this.gridPhone.Name = "gridPhone";
            this.gridPhone.Size = new System.Drawing.Size(591, 150);
            this.gridPhone.TabIndex = 0;
            this.gridPhone.SelectionChanged += new System.EventHandler(this.gridPhone_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(115, 72);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(485, 20);
            this.txtKeyword.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 298);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(57, 346);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 400);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Color";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(115, 295);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(485, 20);
            this.txtCode.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(115, 343);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(485, 20);
            this.txtName.TabIndex = 10;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(115, 397);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(485, 20);
            this.txtColor.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(115, 443);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(485, 20);
            this.txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(115, 487);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(485, 20);
            this.txtQuantity.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(631, 72);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(631, 462);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(75, 45);
            this.bntDelete.TabIndex = 15;
            this.bntDelete.Text = "Detele";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(631, 298);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(75, 48);
            this.bntAdd.TabIndex = 15;
            this.bntAdd.Text = "Add";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(631, 382);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(75, 48);
            this.bntUpdate.TabIndex = 16;
            this.bntUpdate.Text = "Update";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gridPhone);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridPhone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button bntDelete;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntUpdate;
    }
}

