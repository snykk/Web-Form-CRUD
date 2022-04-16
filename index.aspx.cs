using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Npgsql;
using System.Configuration;
using System.Data;

namespace WebForm
{
    public partial class index : System.Web.UI.Page
    {
        protected void btnSelect_Click(object sender, EventArgs e)
        {
            try 
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;password=nova");
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Select * from mhs";
                cmd.CommandType = CommandType.Text;
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);
                cmd.Dispose();
                connection.Close();

                selectAllData.DataSource = dt;
                selectAllData.DataBind();
            }
            catch (Exception ex) {}
        }

        protected void btnInsertion_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;password=nova");
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Insert into mhs (id_user, first_name, last_name,username,gender,email,password) values (@id,@first_name,@last_name,@username,@gender,@email,@password)";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(intId.Text)));
                cmd.Parameters.Add(new NpgsqlParameter("@first_name", txtFirstname.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@last_name", txtLastname.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@username", txtUsername.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@gender", charGender.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@email", txtEmail.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@password", txtPassword.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                intId.Text = "";
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtUsername.Text = "";
                charGender.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                lblmsg.Text = "Data mahasiswa berhasil ditambahkan";
            }
            catch (Exception ex) { }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;password=nova");
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "update mhs set first_name=@first_name,last_name=@last_name,username=@username,gender=@gender,email=@email,password=@password where id_user=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(intId.Text)));
                cmd.Parameters.Add(new NpgsqlParameter("@first_name", txtFirstname.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@last_name", txtLastname.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@username", txtUsername.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@gender", charGender.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@email", txtEmail.Text));
                cmd.Parameters.Add(new NpgsqlParameter("@password", txtPassword.Text));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                intId.Text = "";
                txtFirstname.Text = "";
                txtLastname.Text = "";
                txtUsername.Text = "";
                charGender.Text = "";
                txtEmail.Text = "";
                txtPassword.Text = "";
                lblmsg.Text = "Data mahasiswa berhasil diubah";
            }
            catch (Exception ex) { }
        }

        protected void btnDelete_Click(object sender, EventArgs e)
        {
            try /* Deletion After Validations*/
            {
                NpgsqlConnection connection = new NpgsqlConnection("Server=localhost;Port=5432;Database=PBO;User Id=postgres;password=nova");
                connection.Open();
                NpgsqlCommand cmd = new NpgsqlCommand();
                cmd.Connection = connection;
                cmd.CommandText = "Delete from mhs where id_user=@id";
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.Add(new NpgsqlParameter("@id", Convert.ToInt32(txtEmployeeID.Text)));
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                connection.Close();
                txtEmployeeID.Text = "";
                lblmessage.Text = "Data mahasiswa berhasil dihapus";
            }
            catch (Exception ex) { }
        }
    }
}