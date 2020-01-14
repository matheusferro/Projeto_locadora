using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_modelo : UserControl
    {
        public uc_modelo()
        {
            InitializeComponent();
        }

        private void btn_cad_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmodelo.Text))
                {
                    MessageBox.Show("Erro ao cadastrar o modelo, verifique se todos campos estão preenchidos!!!");
                }
                else
                {
                    Modelo mod = new Modelo
                    {
                        modelo_desc = txtmodelo.Text
                    };
                    ModeloDAO mdao = new ModeloDAO();
                    mdao.cadastra_modelo(mod);
                    MessageBox.Show("Modelo cadastrado com sucesso!");
                    uc_modelo_Load(null, null);
                }

            }
            catch (Exception)
            {

                MessageBox.Show("Erro ao cadastrar o modelo, verifique se todos campos estão preenchidos!");
            }


        }

        private void uc_modelo_Load(object sender, EventArgs e)
        {
            try
            {
                ModeloDAO mdao = new ModeloDAO();
                dgvmodelo.DataSource = mdao.lista_modelo();
            }
            catch (Exception) { }
        }

        private void btn_altera_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(txtmodelo.Text))
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (MessageBox.Show("Deseja alterar o modelo de ID:" + dgvmodelo.CurrentRow.Cells[0].Value.ToString() + " ??"
                        , "Alterar modelo", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Modelo mobj = new Modelo
                        {
                            modelo_id = (int)dgvmodelo.CurrentRow.Cells[0].Value,
                            modelo_desc = txtmodelo.Text
                        };
                        ModeloDAO mdao = new ModeloDAO();
                        mdao.altera_modelo(mobj);
                        MessageBox.Show("Modelo alterado com sucesso!");
                        uc_modelo_Load(null, null);
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar o modelo");
            }
        }

        private void btn_exclui_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o modelo de ID: " + dgvmodelo.CurrentRow.Cells[0].Value.ToString() + " ??",
                    "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Modelo objm = new Modelo
                    {
                        modelo_id = (int)dgvmodelo.CurrentRow.Cells[0].Value
                    };
                    ModeloDAO mdao = new ModeloDAO();
                    mdao.deleta_modelo(objm);
                    MessageBox.Show("Excluido com sucesso!!");
                    uc_modelo_Load(null, null);
                }
            }
            catch (Exception)
            {
            }
        }

        private void dgvmodelo_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtmodelo.Text = dgvmodelo.CurrentRow.Cells[1].Value.ToString();
        }

        private void Txtmodelo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
