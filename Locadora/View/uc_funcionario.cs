using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_funcionario : UserControl
    {
        public uc_funcionario()
        {
            InitializeComponent();
        }
        public bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txtnome_funcionario.Text) || string.IsNullOrEmpty(txtdata.Text) || string.IsNullOrEmpty(txt_tel.Text))
            {
                MessageBox.Show("Preencha todos os campos", "Campos em branco", MessageBoxButtons.OK);
                return false;

            }
            else
            {
                return true;
            }

        }


        private void uc_funcionario_Load(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO fdao = new FuncionarioDAO();
                dgv_funcionario.DataSource = fdao.lista_funcionario();
                CargoDAO cdao = new CargoDAO();
                cb_cargo.DataSource = cdao.lista_cargo();
                cb_cargo.DisplayMember = "tb_cargo_nome";
                cb_cargo.ValueMember = "tb_cargo_id";
            }
            catch (Exception) { }
        }

        private void Dgv_funcionario_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtnome_funcionario.Text = dgv_funcionario.CurrentRow.Cells[1].Value.ToString();
            txt_tel.Text = dgv_funcionario.CurrentRow.Cells[2].Value.ToString();
            txtdata.Text = dgv_funcionario.CurrentRow.Cells[3].Value.ToString();
            cb_cargo.Text = dgv_funcionario.CurrentRow.Cells[4].Value.ToString();
        }

        private void Btn_altera_funcionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaCampos())
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (MessageBox.Show("Deseja alterar o funcionário de ID:" + dgv_funcionario.CurrentRow.Cells[0].Value.ToString() + " ??"
                        , "Alterar funcionário", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Funcionario objf = new Funcionario
                        {
                            funcionarioid = (int)dgv_funcionario.CurrentRow.Cells[0].Value,
                            funcionarionome = txtnome_funcionario.Text,
                            funcionariotel = txt_tel.Text,
                            dt_contrato = Convert.ToDateTime(txtdata.Text),
                            id_cargo = (int)cb_cargo.SelectedValue
                        };
                        FuncionarioDAO fdao = new FuncionarioDAO();
                        fdao.altera_funcionario_pqp(objf);
                        MessageBox.Show("Funcionario alterado");
                        uc_funcionario_Load(null, null);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar o funcionario");
            }
        }

        private void Btn_cad_funcionario_Click(object sender, EventArgs e)
        {

            if (verificaCampos())
            {
                try
                {
                    Funcionario objf = new Funcionario
                    {
                        funcionarionome = txtnome_funcionario.Text,
                        funcionariotel = txt_tel.Text,
                        dt_contrato = Convert.ToDateTime(txtdata.Text),
                        id_cargo = (int)cb_cargo.SelectedValue
                    };
                    FuncionarioDAO fdao = new FuncionarioDAO();
                    fdao.cadastra_funcionario(objf);
                    MessageBox.Show("Funcionario cadastrado");
                    uc_funcionario_Load(null, null);
                }
                catch (Exception) { }
            }
        }

        private void Btn_exclui_funcionario_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir o funcionário de ID:" + dgv_funcionario.CurrentRow.Cells[0].Value.ToString() + " ??"
                            , "EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Funcionario objf = new Funcionario
                    {
                        funcionarioid = (int)dgv_funcionario.CurrentRow.Cells[0].Value
                    };
                    FuncionarioDAO fdao = new FuncionarioDAO();
                    fdao.exclui_funcionario_pqp(objf);
                    MessageBox.Show("Funcionario exluído!");
                    uc_funcionario_Load(null, null);

                }
                else
                {
                    MessageBox.Show("Exclusão cancelada !");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro.");
            }
        }

        private void Cb_cargo_Click(object sender, EventArgs e)
        {
            try
            {
                CargoDAO cdao = new CargoDAO();
                cb_cargo.DataSource = cdao.lista_cargo();
                cb_cargo.DisplayMember = "tb_cargo_nome";
                cb_cargo.ValueMember = "tb_cargo_id";
            }
            catch (Exception)
            {

            }
        }

        private void Txtnome_funcionario_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Funcionario f = new Funcionario();
            //    f.funcionarionome = txtnome_funcionario.Text;
            //    FuncionarioDAO fdao = new FuncionarioDAO();
            //    dgv_funcionario.DataSource = fdao.busca(f);
            //}
            //catch (Exception )
            //{
            //}
        }
    }
}
