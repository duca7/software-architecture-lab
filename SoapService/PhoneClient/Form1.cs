using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhoneClient
{
    public partial class Form1 : Form
    {
        gearhost.PhoneService phoneService = new gearhost.PhoneService();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            List<gearhost.Phone> phones = phoneService.GetAll().ToList();
            gridPhone.DataSource = phones;
        }

        private void gridPhone_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = gridPhone.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int code = int.Parse(gridPhone.SelectedRows[0].Cells["Code"].Value.ToString());
                gearhost.Phone phone = phoneService.GetDetails(code);
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

        
        private void bntUpdate_Click(object sender, EventArgs e)
        {
            gearhost.Phone newPhone = new gearhost.Phone()
            {
                Code = int.Parse(txtCode.Text.Trim()),
                Name = txtName.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };
            bool result = phoneService.Update(newPhone);
            if (result)
            {
                List<gearhost.Phone> phones = phoneService.GetAll().ToList();
                gridPhone.DataSource = phones;
            }
            else
            {
                MessageBox.Show("Sorry Something Wrong");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<gearhost.Phone> phones = phoneService.Search(keyword).ToList();
            gridPhone.DataSource = phones;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            gearhost.Phone newPhone = new gearhost.Phone()
            {
                Code = int.Parse(txtCode.Text.Trim()),
                Name = txtName.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };
            bool result = phoneService.AddNew(newPhone);
            if (result)
            {
                List<gearhost.Phone> phones = phoneService.GetAll().ToList();
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
                bool result = phoneService.Delete(code);
                if (result)
                {
                    List<gearhost.Phone> phones = phoneService.GetAll().ToList();
                    gridPhone.DataSource = phones;
                }
                else
                {
                    MessageBox.Show("Sorry Something Wrong");
                }

            }
        }
    }
}
