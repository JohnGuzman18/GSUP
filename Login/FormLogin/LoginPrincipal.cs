using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Configuration;
using ClassLibrary1;

namespace Login
{
    public partial class LoginPrincipal : Form
    {
        public LoginPrincipal()
        {
            InitializeComponent();
        }

        public void connection()
        {
            Class1  class1 = new Class1();
            string user = txtuser.Text; string Password = txtpass.Text;
            class1.logins(user, Password);

            
        }




        /*Aqui creamos el metodo de logins, para asi validar con un try catch, que el usuario
        y contraseña es correcto*/
        public void logins()
        {
            try
            {
                string connection = ConfigurationManager.ConnectionStrings["connection"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(connection))
                {
                    conexion.Open();
                    string consult = "SELECT LoginName, password FROM Users WHERE LoginName='" + txtuser.Text + "'AND password='" + txtpass.Text + "'";

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
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }









        //Declaracion para mover el login:
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);



         //Cuando el usuario le de click al cuadro del "usuario", este se borre
        private void txtuser_Enter(object sender, EventArgs e)
        {
            if(txtuser.Text == "Example@mail.com")
            {
                txtuser.Text = "";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        private void txtuser_Leave(object sender, EventArgs e)
        {
            if(txtuser.Text == "")
            {
                txtuser.Text = "Example@mail.com";
                txtuser.ForeColor = Color.LightGray;
            }
        }

        //Cuando el usuario le de click al cuadro del "Contraseña", este se borre
        private void txtpass_Enter(object sender, EventArgs e)
        {
            if(txtpass.Text == "Password")
            {
                txtpass.Text = "";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = true;     // esta linea sirve para que la contraseña este oculta
            }
               
        }

        private void txtpass_Leave(object sender, EventArgs e)
        {
            if( txtpass.Text == "")
            {
                txtpass.Text = "Password";
                txtpass.ForeColor = Color.LightGray;
                txtpass.UseSystemPasswordChar = false;
            }
        }


        //para cerrar la app
        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        // para minimizarlo
        private void btnminimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture(); SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            connection();
        }
    }
}