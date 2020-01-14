using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_locacao : UserControl
    {
        public uc_locacao()
        {
            InitializeComponent();
        }

        private void Uc_locacao_Load(object sender, EventArgs e)
        {
            try
            {
                LocacaoDAO ldao = new LocacaoDAO();
                dataGridView1.DataSource = ldao.lista_locacao();

                FuncionarioDAO fdao = new FuncionarioDAO();
                cb_funcionario.DataSource = fdao.lista_funcionario();
                cb_funcionario.DisplayMember = "Nome";
                cb_funcionario.ValueMember = "Id";

                ClienteDAO cdao = new ClienteDAO();
                cb_cliente.DataSource = cdao.mostra_cliente();
                cb_cliente.DisplayMember = "Nome";
                cb_cliente.ValueMember = "ID";

                AutomovelDAO adao = new AutomovelDAO();
                cb_carro.DataSource = adao.lista_auto();
                cb_carro.DisplayMember = "Veiculo";
                cb_carro.ValueMember = "ID";
            }
            catch (Exception)
            {
            }

        }

        public bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txt_tipo.Text) || string.IsNullOrEmpty(txt_valor.Text) || string.IsNullOrEmpty(txt_inicio.Text) ||
                string.IsNullOrEmpty(txt_fim.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                try
                {
                    Locacao objl = new Locacao
                    {
                        locacao_tipo = txt_tipo.Text,
                        locacao_valor = double.Parse(txt_valor.Text),
                        locacao_dt_inicio = Convert.ToDateTime(txt_inicio.Text),
                        locacao_dt_fim = Convert.ToDateTime(txt_fim.Text),
                        automovel = (int)cb_carro.SelectedValue,
                        cliente = (int)cb_carro.SelectedValue,
                        funcionario = (int)cb_funcionario.SelectedValue
                       
                    };
                    LocacaoDAO ldao = new LocacaoDAO();
                    ldao.cadastra_locacao(objl);
                    Uc_locacao_Load(null, null);
                }
                catch (Exception t)
                {
                    MessageBox.Show("Erro: " + t);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos.");
            }
        }

        private void Txtfuncionario_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!verificaCampos())
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (MessageBox.Show("Deseja alterar o dado de locação de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
                        , "Alterar Locação", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Locacao objl = new Locacao
                        {
                            locacao_id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                            locacao_tipo = txt_tipo.Text,
                            locacao_valor = double.Parse(txt_valor.Text),
                            locacao_dt_inicio = Convert.ToDateTime(txt_inicio.Text),
                            locacao_dt_fim = Convert.ToDateTime(txt_fim.Text),
                            automovel = (int)cb_carro.SelectedValue,
                            cliente = (int)cb_carro.SelectedValue,
                            funcionario = (int)cb_funcionario.SelectedValue
                        };
                        LocacaoDAO ldao = new LocacaoDAO();
                        ldao.altera(objl);
                        Uc_locacao_Load(null, null);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar o funcionario");
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_tipo.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_valor.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_inicio.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_fim.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            cb_carro.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cb_cliente.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            cb_funcionario.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void Cb_funcionario_Click(object sender, EventArgs e)
        {
            try
            {
                FuncionarioDAO fdao = new FuncionarioDAO();
                cb_funcionario.DataSource = fdao.lista_funcionario();
                cb_funcionario.DisplayMember = "Nome";
                cb_funcionario.ValueMember = "Id";
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void Cb_cliente_Click(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO cdao = new ClienteDAO();
                cb_cliente.DataSource = cdao.mostra_cliente();
                cb_cliente.DisplayMember = "Nome";
                cb_cliente.ValueMember = "ID";
            }
            catch (Exception)
            {
            }
        }

        private void Cb_carro_Click(object sender, EventArgs e)
        {
            try
            {
                AutomovelDAO adao = new AutomovelDAO();
                cb_carro.DataSource = adao.lista_auto();
                cb_carro.DisplayMember = "Veiculo";
                cb_carro.ValueMember = "ID";
            }
            catch (Exception)
            {
            }
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Deseja excluir a locação de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
                            , "EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    Locacao objl = new Locacao
                    {
                        locacao_id = (int)dataGridView1.CurrentRow.Cells[0].Value
                    };
                    LocacaoDAO ldao = new LocacaoDAO();
                    ldao.exclui(objl);

                    Uc_locacao_Load(null, null);

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
    }
}
