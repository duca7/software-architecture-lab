using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeClient
{
    public partial class CoffeeForm : Form
    {
        gearhost.CoffeeService coffeeService = new gearhost.CoffeeService();
        public CoffeeForm()
        {
            InitializeComponent();
        }

        private void CoffeeForm_Load(object sender, EventArgs e)
        {
            List<gearhost.Coffee> coffees = coffeeService.GetAll().ToList();
            gridCoffee.DataSource = coffees;
        }

        private void gridCoffee_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = gridCoffee.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int code = int.Parse(gridCoffee.SelectedRows[0].Cells["Code"].Value.ToString());
                gearhost.Coffee coffee = coffeeService.GetDetails(code);
                if (coffee != null)
                {
                    txtCode.Text = coffee.Code.ToString();
                    txtName.Text = coffee.Name;
                    txtDescription.Text = coffee.Description;
                    txtPrice.Text = coffee.Price.ToString();
                    txtExp.Text = coffee.Exp.ToString();
                    txtMfg.Text = coffee.Mfg.ToString();
                }
            }
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<gearhost.Coffee> coffees = coffeeService.Search(keyword).ToList();
            gridCoffee.DataSource = coffees;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            gearhost.Coffee newCoffee = new gearhost.Coffee()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Exp = txtExp.Text.Trim(),
                Mfg = txtMfg.Text.Trim()
            };
            bool result = coffeeService.AddNew(newCoffee);
            if (result)
            {
                List<gearhost.Coffee> coffees = coffeeService.GetAll().ToList();
                gridCoffee.DataSource = coffees;
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
                bool result = coffeeService.Delete(code);
                if (result)
                {
                    List<gearhost.Coffee> coffees = coffeeService.GetAll().ToList();
                    gridCoffee.DataSource = coffees;
                }
                else
                {
                    MessageBox.Show("Sorry Something Wrong");
                }

            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            gearhost.Coffee newCoffee = new gearhost.Coffee()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Exp = txtExp.Text.Trim(),
                Mfg = txtMfg.Text.Trim()
            };
            bool result = coffeeService.Update(newCoffee);
            if (result)
            {
                List<gearhost.Coffee> coffees = coffeeService.GetAll().ToList();
                gridCoffee.DataSource = coffees;
            }
            else
            {
                MessageBox.Show("Sorry Something Wrong");
            }
        }
    }
}
