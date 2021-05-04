using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CoffeeShared;

namespace CoffeeClient
{
    public partial class CoffeeForm : Form
    {
        const String url = "tcp://ip_server:6969/coffee";
        ICoffeeBUS coffeeBUS = (ICoffeeBUS)Activator.GetObject(typeof(ICoffeeBUS), url);

        public CoffeeForm()
        {
            InitializeComponent();
        }

        private void CoffeeForm_Load(object sender, EventArgs e)
        {
            List<Coffee> coffees = coffeeBUS.GetAll();
            gridCoffee.DataSource = coffees;
        }

        private void bntSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Coffee> coffees = coffeeBUS.Search(keyword);
            gridCoffee.DataSource = coffees;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            Coffee newCoffee = new Coffee()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Exp = txtExp.Text.Trim(),
                Mfg = txtMfg.Text.Trim()
            };

            bool result = coffeeBUS.AddNew(newCoffee);
            if (result)
            {
                List<Coffee> coffees =  coffeeBUS.GetAll();
                gridCoffee.DataSource = coffees;
            }
            else
            {
                MessageBox.Show("SORRY BABY!");
            }
        }

        private void bntUpdate_Click(object sender, EventArgs e)
        {
            Coffee newCoffee = new Coffee()
            {
                Code = 0,
                Name = txtName.Text.Trim(),
                Description = txtDescription.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Exp = txtExp.Text.Trim(),
                Mfg = txtMfg.Text.Trim()
            };

            bool result = coffeeBUS.Update(newCoffee);
            if (result)
            {
                List<Coffee> coffees = coffeeBUS.GetAll();
                gridCoffee.DataSource = coffees;
            }
            else
            {
                MessageBox.Show("SORRY BABY!");
            }
        }

        private void bntDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("ARE YOU SURE ?", "CONFIRMATION", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                int code = int.Parse(txtCode.Text);
                bool result =  coffeeBUS.Delete(code);
                if (result)
                {
                    List<Coffee> coffees = coffeeBUS.GetAll();
                    gridCoffee.DataSource = coffees;
                }
                else
                {
                    MessageBox.Show("SORRY BABY!");
                }
            }
        }

        private void gridCoffee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedRowCount = gridCoffee.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (gridCoffee.SelectedRows.Count > 0)
            {
                int code = int.Parse(gridCoffee.SelectedRows[0].Cells["Code"].Value.ToString());
                Coffee coffee =  coffeeBUS.GetDetails(code);
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

        private void gridCoffee_SelectionChanged(object sender, EventArgs e)
        {
            int selectedRowCount = gridCoffee.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (gridCoffee.SelectedRows.Count > 0)
            {
                int code = int.Parse(gridCoffee.SelectedRows[0].Cells["Code"].Value.ToString());
                Coffee coffee = coffeeBUS.GetDetails(code);
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
    }
}
