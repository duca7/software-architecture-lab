using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PhoneSite
{
    public partial class PhoneForm : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                List<Phone> phones = new PhoneBUS().GetAll();
                gvPhones.DataSource = phones;
                gvPhones.DataBind();
            }
        }

        protected void gvPhones_SelectedIndexChanged(object sender, EventArgs e)
        {
            int code = int.Parse(gvPhones.SelectedRow.Cells[1].Text.Trim());
            Phone phone = new PhoneBUS().GetDetails(code);
            if(phone != null)
            {
                txtCode.Text = phone.Code.ToString();
                txtName.Text = phone.Name;
                txtColor.Text = phone.Color;
                txtPrice.Text = phone.Price.ToString();
                txtQuantity.Text = phone.Quantity.ToString();
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            String keyword = txtKeyword.Text.Trim();
            List<Phone> phones = new PhoneBUS().Search(keyword);
            gvPhones.DataSource = phones;
            gvPhones.DataBind();
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            Phone newPhone = new Phone()
            {
                
                Name = txtName.Text.Trim(),
                Color = txtColor.Text.Trim(),
                Price = int.Parse(txtPrice.Text.Trim()),
                Quantity = int.Parse(txtQuantity.Text.Trim())
            };
            bool result = new PhoneBUS().AddNew(newPhone);
            if (result)
            {
                List<Phone> phones = new PhoneBUS().GetAll();
                gvPhones.DataSource = phones;
                gvPhones.DataBind();
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
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
                gvPhones.DataSource = phones;
                gvPhones.DataBind();
            }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            int code = int.Parse(txtCode.Text.Trim());
            bool result = new PhoneBUS().Delete(code);
            if (result) 
            {
                List<Phone> phones = new PhoneBUS().GetAll();
                gvPhones.DataSource = phones;
                gvPhones.DataBind();
            }
        }
    }
}