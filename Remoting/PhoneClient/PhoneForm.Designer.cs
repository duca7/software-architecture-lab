
namespace PhoneClient
{
    partial class PhoneForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.bntSearch = new System.Windows.Forms.Button();
            this.gridPhone = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridPhone)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(119, 111);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(109, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Code";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(197, 108);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(787, 22);
            this.txtKeyword.TabIndex = 2;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(1029, 103);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(117, 33);
            this.bntSearch.TabIndex = 3;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // gridPhone
            // 
            this.gridPhone.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridPhone.Location = new System.Drawing.Point(197, 172);
            this.gridPhone.Name = "gridPhone";
            this.gridPhone.RowHeadersWidth = 51;
            this.gridPhone.RowTemplate.Height = 24;
            this.gridPhone.Size = new System.Drawing.Size(787, 150);
            this.gridPhone.TabIndex = 4;
            this.gridPhone.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridPhone_CellContentClick);
            this.gridPhone.SelectionChanged += new System.EventHandler(this.gridPhone_SelectionChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 445);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(109, 496);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 552);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(109, 612);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(61, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Quantity";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(197, 389);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(787, 22);
            this.txtCode.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(197, 440);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(787, 22);
            this.txtName.TabIndex = 10;
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(197, 496);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(787, 22);
            this.txtColor.TabIndex = 11;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(197, 552);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(787, 22);
            this.txtPrice.TabIndex = 12;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Location = new System.Drawing.Point(197, 612);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(787, 22);
            this.txtQuantity.TabIndex = 13;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(1029, 389);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(117, 56);
            this.bntAdd.TabIndex = 14;
            this.bntAdd.Text = "ADD";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(1029, 496);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(117, 55);
            this.bntUpdate.TabIndex = 15;
            this.bntUpdate.Text = "UPDATE";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(1029, 584);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(117, 56);
            this.bntDelete.TabIndex = 16;
            this.bntDelete.Text = "DELETE";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // PhoneForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1234, 665);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.gridPhone);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "PhoneForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PhoneForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridPhone)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.DataGridView gridPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntDelete;
    }
}

