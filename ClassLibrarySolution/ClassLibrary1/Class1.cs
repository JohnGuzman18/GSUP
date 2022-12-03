using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Data;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace ClassLibrary1
{
    public class Class1
    {
        public void logins(string user,string Password)
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    string consult = "SELECT LoginName, password FROM Users WHERE LoginName='" + user + "'AND password='" + Password + "'";

                    using (SqlCommand cmd = new SqlCommand(consult, conexion))//juntamos la consola de sql y la conexion de la base
                    {
                        //para validar los datos
                        SqlDataReader dataread = cmd.ExecuteReader();

                        if (dataread.Read())
                        {
                            MessageBox.Show("Bienvenido"); //mensage al usuario cuando entre
                        }
                        else
                        {
                            MessageBox.Show("Usuario no registrado."); //mensage por si no entra
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
