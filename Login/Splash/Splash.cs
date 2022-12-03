using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
            circlebar.Value = 0;
        }

        
        private void timer1_Tick(object sender, EventArgs e)
        {
            
            circlebar.Value += 1;
            circlebar.Text = circlebar.Value.ToString() + "%";
            if (circlebar.Value == 100)
            {
                timer1.Enabled = false;
                this.Hide();
                LoginPrincipal log = new LoginPrincipal();
                log.Show();
            }
        }
    }
}
