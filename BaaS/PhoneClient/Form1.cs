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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            new PhoneBUS().ListenFireBase(gridPhone);
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

        private void bntSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Phone> phones = new PhoneBUS().Search(keyword);
            gridPhone.BeginInvoke(new MethodInvoker(delegate { gridPhone.DataSource = phones; }));
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
                Code = 0,
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
            DialogResult dialogResult = MessageBox.Show("Do you want to delete this", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int code = int.Parse(txtCode.Text);
                bool result = new PhoneBUS().Delete(code);
                if (result)
                {
                    MessageBox.Show("Succes");
                }
                else
                {
                    MessageBox.Show("Failed");
                }
            }


        }
    }
}
