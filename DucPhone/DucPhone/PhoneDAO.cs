using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Configuration;

namespace DucPhone
{
    class PhoneDAO
    {
        public List<Phone> SelectAll()
        {
            List<Phone> phones = new List<Phone>();
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Phone";
            SqlCommand com = new SqlCommand(strCom, con);
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Phone phone = new Phone()
                {
                    Code = (int)dr["Code"],
                    Name = (String)dr["Name"],
                    Color = (String)dr["Color"],
                    Price = (int)dr["Price"],
                    Quantity = (int)dr["Quantity"]
                };
                phones.Add(phone);
            }
            return phones;
        }

        public Phone SelectByCode(int code)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Phone WHERE Code=@Code";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Code", code));
            SqlDataReader dr = com.ExecuteReader();
            if (dr.Read())
            {
                Phone phone = new Phone()
                {
                    Code = (int)dr["Code"],
                    Name = (String)dr["Name"],
                    Color = (String)dr["Color"],
                    Price = (int)dr["Price"],
                    Quantity = (int)dr["Quantity"]
                };
                return phone;
            }
            return null;
        }

        public List<Phone> SelectByKeyword(String keyword)
        {
            List<Phone> phones = new List<Phone>();
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "SELECT * FROM Phone WHERE Name Like @Keyword";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Keyword", "%" + keyword + "%"));
            SqlDataReader dr = com.ExecuteReader();
            while (dr.Read())
            {
                Phone phone = new Phone()
                {
                    Code = (int)dr["Code"],
                    Name = (String)dr["Name"],
                    Color = (String)dr["Color"],
                    Price = (int)dr["Price"],
                    Quantity = (int)dr["Quantity"]
                };
                phones.Add(phone);
            }
            return phones;
        }

        public bool Insert(Phone newPhone)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "INSERT INTO Phone VALUES(@Name, @Color, @Price, @Quantity)";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Name", newPhone.Name));
            com.Parameters.Add(new SqlParameter("@Color", newPhone.Color));
            com.Parameters.Add(new SqlParameter("@Price", newPhone.Price));
            com.Parameters.Add(new SqlParameter("@Quantity", newPhone.Quantity));
            try { return com.ExecuteNonQuery() > 0; }
            catch { return false; }
        }

        public bool Update(Phone newPhone)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "UPDATE Phone SET Name=@Name, Color=@Color, Price=@Price, Quantity=@Quantity WHERE Code=@Code";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Code", newPhone.Code));
            com.Parameters.Add(new SqlParameter("@Name", newPhone.Name));
            com.Parameters.Add(new SqlParameter("@Color", newPhone.Color));
            com.Parameters.Add(new SqlParameter("@Price", newPhone.Price));
            com.Parameters.Add(new SqlParameter("@Quantity", newPhone.Quantity));
            try { return com.ExecuteNonQuery() > 0; }
            catch { return false; }
        }

        public bool Delete(int code)
        {
            String strCon = ConfigurationManager.ConnectionStrings["strCon"].ConnectionString;
            SqlConnection con = new SqlConnection(strCon);
            con.Open();
            String strCom = "DELETE FROM Phone WHERE Code=@Code";
            SqlCommand com = new SqlCommand(strCom, con);
            com.Parameters.Add(new SqlParameter("@Code", code));
            try { return com.ExecuteNonQuery() > 0; }
            catch { return false; }
        }
    }
}
