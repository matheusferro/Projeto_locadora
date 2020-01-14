using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_marca : UserControl
    {
        public uc_marca()
        {
            InitializeComponent();
        }

        #region Cadastra marca
        private void btn_cad_marca_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmarca.Text))
                {

                }
                else
                {
                    Marca m = new Marca
                    {
                        marca_nome = txtmarca.Text
                    };
                    MarcaDAO mdao = new MarcaDAO();
                    mdao.cadastra_marca(m);
                    MessageBox.Show("Marca cadastrada com sucesso.");
                    uc_marca_Load(null, null);
                }

            }
            catch (Exception t)
            {

                MessageBox.Show("Erro ao cadastrar marca. Verifique se os campos estão preenchidos corretamente." + t);
            }

        }
        #endregion

        #region altera marca
        private void btn_altera_marca_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR A MARCA DE ID: " + dgv_marca.CurrentRow.Cells[0].Value + " ??"
                    , "Alteração", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtmarca.Text))
                    {
                        MessageBox.Show("Erro ao alterar a marca, preencha todos os campos");
                    }
                    else
                    {
                        Marca m = new Marca
                        {
                            marca_id = (int)dgv_marca.CurrentRow.Cells[0].Value,
                            marca_nome = txtmarca.Text
                        };
                        MarcaDAO mdao = new MarcaDAO();
                        mdao.altera_marca(m);
                        MessageBox.Show("Marca alterada com sucesso.");
                        dgv_marca.DataSource = mdao.mostra_marca();
                    }

                }
                else
                {
                    MessageBox.Show("Alteração cancelada.");
                }

            }
            catch (Exception t)
            {
                MessageBox.Show("Erro ao alterar marca. Verifique se os campos foram preenchidos." + t);
            }
        }

        #endregion

        #region exclui marca
        private void btn_exclui_marca_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA EXLUIR A MARCA DE ID: " + dgv_marca.CurrentRow.Cells[0].Value + " ??"
                    , "EXCLUSÃO SEGURA", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Marca m = new Marca
                    {
                        marca_id = (int)dgv_marca.CurrentRow.Cells[0].Value
                    };
                    MarcaDAO mdao = new MarcaDAO();
                    mdao.exclui_marca(m);
                    MessageBox.Show("Marca deletada com sucesso.");
                    uc_marca_Load(null, null);
                }
                else
                {
                    MessageBox.Show("Exclusão cancelada.");
                }

            }
            catch (Exception t)
            {
                MessageBox.Show("Erro ao deletar marca. Verifique se uma marca foi selecionada." + t);
            }
        }
        #endregion

        private void uc_marca_Load(object sender, EventArgs e)
        {
            try
            {
                MarcaDAO mdao = new MarcaDAO();
                dgv_marca.DataSource = mdao.mostra_marca();

            }
            catch (Exception) { }
        }

        private void dgv_marca_DoubleClick(object sender, EventArgs e)
        {
            txtmarca.Text = dgv_marca.CurrentRow.Cells[1].Value.ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


    }
}
