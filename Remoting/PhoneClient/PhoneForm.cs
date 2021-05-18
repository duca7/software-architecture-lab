using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PhoneShared;

namespace PhoneClient
{
    public partial class PhoneForm : Form
    {
        const String url = "tcp://10.104.23.139:6969/sellphone";
        IPhoneBUS phoneBUS = (IPhoneBUS)Activator.GetObject(typeof(IPhoneBUS), url);
        public PhoneForm()
        {
            InitializeComponent();
        }

        private void PhoneForm_Load(object sender, EventArgs e)
        {
            List<Phone> phones = phoneBUS.GetAll();
            gridPhone.DataSource = phones;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Phone> phones = phoneBUS.Search(keyword);
            gridPhone.DataSource = phones;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };
            bool result = phoneBUS.AddNew(newPhone);
            if (result)
            {
                List<Phone> phones = phoneBUS.GetAll();
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
            bool result = phoneBUS.Update(newPhone);
            if (result)
            {
                List<Phone> phones = phoneBUS.GetAll();
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
                bool result = phoneBUS.Delete(code);
                if (result)
                {
                    List<Phone> phones = phoneBUS.GetAll();
                    gridPhone.DataSource = phones;
                }
                else
                {
                    MessageBox.Show("Sorry Something Wrong");
                }

            }
        }

        private void gridPhone_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowCount = gridPhone.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int code = int.Parse(gridPhone.SelectedRows[0].Cells["Code"].Value.ToString());
                Phone phone = phoneBUS.GetDetails(code);
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
                Phone phone = phoneBUS.GetDetails(code);
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
    }
}
