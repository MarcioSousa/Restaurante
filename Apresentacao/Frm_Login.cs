using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Apresentacao
{
    public partial class Frm_Login : Form
    {
        public Frm_Login()
        {
            Thread t = new Thread(new ThreadStart(Splash));
            t.Start();
            InitializeComponent();

            ////////////////////////////////////////////////
            //COLOCA AQUI O CARREGAMENTO DO BANCO DE DADOS//
            ////////////////////////////////////////////////

            string str = string.Empty;
            for (int i = 0; i < 40000; i++)
            {
                str += i.ToString();
            }

            t.Abort();
        }

        private void Frm_Login_Load(object sender, EventArgs e)
        {
            lblVersao.Text = "Versão " + Application.ProductVersion;
            lblInt.Visible = false;
        }
        void Splash()
        {
            SplashScreen.SplashForm splashForm = new SplashScreen.SplashForm();
            SplashScreen.SplashForm frm = splashForm;
            frm.AppName = "CadFácil Sistemas";
            frm.Icon = Properties.Resources.logo;
            frm.ShowIcon = true;
            frm.ShowInTaskbar = true;
            Application.Run(frm);
        }
    }
}
