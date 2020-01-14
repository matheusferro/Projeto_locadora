using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class Frm_login : Form
    {
        private int mv, mvalx, mvaly;
        public Frm_login()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Login lobj = new Login();
            string login = txt_usuario.Text;
            string senha = txt_senha.Text;
         
            LoginDAO ldao = new LoginDAO();
            
            ldao.login(login, senha, this);
           

        }
        private void Txt_senha_TextChanged(object sender, EventArgs e)
        {
            txt_senha.UseSystemPasswordChar = true;
        }

        private void Panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mv == 1)
            {
                SetDesktopLocation(MousePosition.X - mvalx, MousePosition.Y - mvaly);
            }
        }

        private void Panel1_MouseUp(object sender, MouseEventArgs e)
        {
            mv = 0;
        }

        private void Btn_sai_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                txt_senha.UseSystemPasswordChar = false;
            }
            else if (checkBox1.Checked == false)
            {
                txt_senha.UseSystemPasswordChar = true;
            }
        }

        private void Panel1_MouseDown(object sender, MouseEventArgs e)
        {
            mv = 1;
            mvalx = e.X;
            mvaly = e.Y;
        }
    }
}
