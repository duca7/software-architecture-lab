
namespace CoffeeClient
{
    partial class CoffeeForm
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
            this.gridCoffee = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtExp = new System.Windows.Forms.TextBox();
            this.txtMfg = new System.Windows.Forms.TextBox();
            this.bntAdd = new System.Windows.Forms.Button();
            this.bntUpdate = new System.Windows.Forms.Button();
            this.bntDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridCoffee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search";
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(177, 96);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(707, 22);
            this.txtKeyword.TabIndex = 1;
            // 
            // bntSearch
            // 
            this.bntSearch.Location = new System.Drawing.Point(929, 91);
            this.bntSearch.Name = "bntSearch";
            this.bntSearch.Size = new System.Drawing.Size(91, 33);
            this.bntSearch.TabIndex = 2;
            this.bntSearch.Text = "Search";
            this.bntSearch.UseVisualStyleBackColor = true;
            this.bntSearch.Click += new System.EventHandler(this.bntSearch_Click);
            // 
            // gridCoffee
            // 
            this.gridCoffee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCoffee.Location = new System.Drawing.Point(177, 157);
            this.gridCoffee.Name = "gridCoffee";
            this.gridCoffee.RowHeadersWidth = 51;
            this.gridCoffee.RowTemplate.Height = 24;
            this.gridCoffee.Size = new System.Drawing.Size(707, 195);
            this.gridCoffee.TabIndex = 3;
            this.gridCoffee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCoffee_CellContentClick);
            this.gridCoffee.SelectionChanged += new System.EventHandler(this.gridCoffee_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(88, 395);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Code";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 451);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 499);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = " Description";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(88, 545);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 17);
            this.label5.TabIndex = 7;
            this.label5.Text = "Price";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 600);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 8;
            this.label6.Text = "Exp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(88, 643);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(31, 17);
            this.label7.TabIndex = 9;
            this.label7.Text = "Mfg";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(177, 390);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(707, 22);
            this.txtCode.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(177, 451);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(707, 22);
            this.txtName.TabIndex = 11;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(177, 499);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(707, 22);
            this.txtDescription.TabIndex = 12;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(177, 545);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(707, 22);
            this.txtPrice.TabIndex = 13;
            // 
            // txtExp
            // 
            this.txtExp.Location = new System.Drawing.Point(177, 597);
            this.txtExp.Name = "txtExp";
            this.txtExp.Size = new System.Drawing.Size(707, 22);
            this.txtExp.TabIndex = 14;
            // 
            // txtMfg
            // 
            this.txtMfg.Location = new System.Drawing.Point(177, 643);
            this.txtMfg.Name = "txtMfg";
            this.txtMfg.Size = new System.Drawing.Size(707, 22);
            this.txtMfg.TabIndex = 15;
            // 
            // bntAdd
            // 
            this.bntAdd.Location = new System.Drawing.Point(929, 390);
            this.bntAdd.Name = "bntAdd";
            this.bntAdd.Size = new System.Drawing.Size(91, 62);
            this.bntAdd.TabIndex = 16;
            this.bntAdd.Text = "ADD";
            this.bntAdd.UseVisualStyleBackColor = true;
            this.bntAdd.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // bntUpdate
            // 
            this.bntUpdate.Location = new System.Drawing.Point(929, 505);
            this.bntUpdate.Name = "bntUpdate";
            this.bntUpdate.Size = new System.Drawing.Size(91, 57);
            this.bntUpdate.TabIndex = 17;
            this.bntUpdate.Text = "UPDATE";
            this.bntUpdate.UseVisualStyleBackColor = true;
            this.bntUpdate.Click += new System.EventHandler(this.bntUpdate_Click);
            // 
            // bntDelete
            // 
            this.bntDelete.Location = new System.Drawing.Point(929, 613);
            this.bntDelete.Name = "bntDelete";
            this.bntDelete.Size = new System.Drawing.Size(91, 52);
            this.bntDelete.TabIndex = 18;
            this.bntDelete.Text = "DELETE";
            this.bntDelete.UseVisualStyleBackColor = true;
            this.bntDelete.Click += new System.EventHandler(this.bntDelete_Click);
            // 
            // CoffeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 710);
            this.Controls.Add(this.bntDelete);
            this.Controls.Add(this.bntUpdate);
            this.Controls.Add(this.bntAdd);
            this.Controls.Add(this.txtMfg);
            this.Controls.Add(this.txtExp);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gridCoffee);
            this.Controls.Add(this.bntSearch);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label1);
            this.Name = "CoffeeForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.CoffeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridCoffee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Button bntSearch;
        private System.Windows.Forms.DataGridView gridCoffee;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtExp;
        private System.Windows.Forms.TextBox txtMfg;
        private System.Windows.Forms.Button bntAdd;
        private System.Windows.Forms.Button bntUpdate;
        private System.Windows.Forms.Button bntDelete;
    }
}

