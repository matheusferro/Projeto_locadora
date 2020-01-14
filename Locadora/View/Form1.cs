using Locadora.Controle;
using Locadora.DAO;
using Locadora.View;
using System;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Locadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool s = false;

        #region Label fecha minimiza

        private void lbl_fecha_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_minimiza_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion
        private void Form1_Load(object sender, EventArgs e)
        {

            try
            {
                LoginDAO lgdao = new LoginDAO();
                Login lg = new Login();
                lg.id = int.Parse(lbl_id.Text);
                img_usuario.Image = Image.FromStream(lgdao.set_img(lg));
                img_usuario.SizeMode = PictureBoxSizeMode.StretchImage;

            }
            catch (Exception)
            {

            }


        }


        private void btn_locacao_Click(object sender, EventArgs e)
        {
            if (panel_auto.Visible == false)
            {
                panel_auto.Visible = true;
                panel_auto.BringToFront();

                sidepanel.Height = btn_locacao.Height;
                sidepanel.Top = btn_locacao.Top;

                panel_funcionario.Visible = false;
            }
            else
            {
                panel_auto.Visible = false;
            }
        }

        private void btn_funcionario_Click(object sender, EventArgs e)
        {
            if (panel_funcionario.Visible)
            {
                panel_funcionario.Visible = false;
            }
            else
            {
                panel_auto.Visible = false;
                panel_funcionario.Visible = true;
                panel_funcionario.BringToFront();
                sidepanel.Height = btn_funcionario.Height;
                sidepanel.Top = btn_funcionario.Top;
            }

        }

        private void btn_modelo_Click(object sender, EventArgs e)
        {
            uc_modelo1.BringToFront();
            panel_auto.Visible = false;

            panel_funcionario.Visible = false;
        }

        private void btn_marca_Click(object sender, EventArgs e)
        {
            uc_marca1.BringToFront();
            panel_auto.Visible = false;

            panel_funcionario.Visible = false;
        }

        private void btn_cargo_Click_1(object sender, EventArgs e)
        {
            uc_cargo2.BringToFront();
            panel_funcionario.Visible = false;
        }

        private void btn_ucfuncionario_Click(object sender, EventArgs e)
        {
            uc_funcionario1.BringToFront();
            panel_funcionario.Visible = false;
        }
        private void btn_veiculo_Click(object sender, EventArgs e)
        {
            uc_automovel1.BringToFront();
            panel_auto.Visible = false;
        }
        private void Btn_menu_locacao_Click(object sender, EventArgs e)
        {
            uc_locacao1.BringToFront();
            panel_funcionario.Visible = false;
            sidepanel.Height = btn_menu_locacao.Height;
            sidepanel.Top = btn_menu_locacao.Top;
        }


        #region mover form com o panel

        private bool mouseDown;
        private Point lastLocation;
        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            mouseDown = true;
            lastLocation = e.Location;
        }

        private void panel2_MouseMove(object sender, MouseEventArgs e)
        {
            if (mouseDown)
            {
                Location = new Point(
                    (Location.X - lastLocation.X) + e.X, (Location.Y - lastLocation.Y) + e.Y);

                Update();
            }
        }

        private void panel2_MouseUp(object sender, MouseEventArgs e)
        {
            mouseDown = false;
        }

        #endregion




        private void Img_usuario_Click_1(object sender, EventArgs e)
        {
            try
            {
                LoginDAO lgdao = new LoginDAO();
                Login lg = new Login();
                OpenFileDialog ofd = new OpenFileDialog
                {
                    InitialDirectory = "C:/Picture/"
                };
                ofd.Filter = "Image Files(*.jpg; *.jpeg; *.bmp)|*.jpg; *.jpeg; *.bmp";
                MemoryStream ms = new MemoryStream();
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    img_usuario.Image = Image.FromFile(ofd.FileName);
                    img_usuario.Image.Save(ms, img_usuario.Image.RawFormat);
                    img_usuario.SizeMode = PictureBoxSizeMode.StretchImage;
                    lg.id = int.Parse(lbl_id.Text);
                    lg.ms = ms;
                    lgdao.up_img(lg);
                    Form1_Load(null, null);
                }

            }
            catch (Exception t)
            {

                MessageBox.Show("Erro " + t);
            }
        }

        private void btn_usuario_panel_Click(object sender, EventArgs e)
        {
            sidepanel.Height = btn_usuario_panel.Height;
            sidepanel.Top = btn_usuario_panel.Top;
            uc_usuarios1.BringToFront();
        }

        private void Panel_funcionario_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            sidepanel.Height = button1.Height;
            sidepanel.Top = button1.Top;
            uc_cliente1.BringToFront();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Frm_login frmlg = new Frm_login();
            frmlg.Show();
        }

    }
}