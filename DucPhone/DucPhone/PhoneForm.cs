using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DucPhone
{
    public partial class PhoneForm : Form
    {
        public PhoneForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Phone> phones = new PhoneBUS().GetAll();
            gridPhone.DataSource = phones;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };
            bool result = new PhoneBUS().AddNew(newPhone);
            if (result)
            {
                List<Phone> phones = new PhoneBUS().GetAll();
                gridPhone.DataSource = phones;
            }
            else
            {
                MessageBox.Show("Sorry Something Wrong");
            }
        }

    

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone()
            {
                Code = int.Parse(txtCode.Text.Trim()),
                Name = txtName.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };
            bool result = new PhoneBUS().Update(newPhone);
            if (result)
            {
                List<Phone> phones = new PhoneBUS().GetAll();
                gridPhone.DataSource = phones;
            }
            else
            {
                MessageBox.Show("Sorry Something Wrong");
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are You Sure?", "COMFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int code = int.Parse(txtCode.Text);
                bool result = new PhoneBUS().Delete(code);
                if (result)
                {
                    List<Phone> phones = new PhoneBUS().GetAll();
                    gridPhone.DataSource = phones;
                }
                else
                {
                    MessageBox.Show("Sorry Something Wrong");
                }
                
            }

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtColor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {

        }

     

        private void gridPhone_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowCount = gridPhone.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int code = int.Parse(gridPhone.SelectedRows[0].Cells["Code"].Value.ToString());
                Phone phone = new PhoneBUS().GetDetails(code);
                if (phone != null)
                {
                    txtCode.Text = phone.Code.ToString();
                    txtName.Text = phone.Name;
                    txtColor.Text = phone.Color;
                    txtPrice.Text = phone.Price.ToString();
                    txtQuantity.Text = phone.Quantity.ToString();
                }
            }
        }

        private void gridPhone_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = gridPhone.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int code = int.Parse(gridPhone.SelectedRows[0].Cells["Code"].Value.ToString());
                Phone phone = new PhoneBUS().GetDetails(code);
                if (phone != null)
                {
                    txtCode.Text = phone.Code.ToString();
                    txtName.Text = phone.Name;
                    txtColor.Text = phone.Color;
                    txtPrice.Text = phone.Price.ToString();
                    txtQuantity.Text = phone.Quantity.ToString();
                }
            }
        }


        private void button1_Click_1(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Phone> phones = new PhoneBUS().Search(keyword);
            gridPhone.DataSource = phones;
        }
    }
}
