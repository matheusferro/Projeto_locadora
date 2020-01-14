using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_cliente : UserControl
    {
        public uc_cliente()
        {
            InitializeComponent();
        }

        private void Uc_cliente_Load(object sender, EventArgs e)
        {
            try
            {
                ClienteDAO cdao = new ClienteDAO();
                dataGridView1.DataSource = cdao.mostra_cliente();
            }
            catch (Exception)
            {

            }

        }

        private void Btn_cadastra_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente objc = new Cliente
                {
                    cliente_nome = txt_nome.Text,
                    cliente_tel = txt_tel.Text,
                    cliente_sexo = txt_sexo.Text,
                    cliente_email = txt_email.Text,
                    cliente_endereco = txt_endereco.Text,
                    cliente_complemento = txt_complemento.Text,
                    cliente_bairro = txt_bairro.Text,
                    cliente_cidade = txt_cidade.Text,
                    cliente_uf = txt_uf.Text,
                    cliente_dt_nasc = Convert.ToDateTime(txt_dt_nasc.Text),
                    cliente_dt_cad = Convert.ToDateTime(txt_dt_cad.Text)
                };

                ClienteDAO cdao = new ClienteDAO();
                cdao.cadastro_cliente(objc);
                Uc_cliente_Load(null, null);
            }
            catch (Exception t)
            {
                MessageBox.Show("" + t);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_tel.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_sexo.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_email.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_endereco.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_complemento.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            txt_bairro.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            txt_cidade.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
            txt_uf.Text = dataGridView1.CurrentRow.Cells[9].Value.ToString();
            txt_dt_nasc.Text = dataGridView1.CurrentRow.Cells[10].Value.ToString();
            txt_dt_cad.Text = dataGridView1.CurrentRow.Cells[11].Value.ToString();

        }

        private void Btn_altera_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja alterar o cliente de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
                , "Alterar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    Cliente objc = new Cliente
                    {
                        cliente_id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                        cliente_nome = txt_nome.Text,
                        cliente_tel = txt_tel.Text,
                        cliente_sexo = txt_sexo.Text,
                        cliente_email = txt_email.Text,
                        cliente_endereco = txt_endereco.Text,
                        cliente_complemento = txt_complemento.Text,
                        cliente_bairro = txt_bairro.Text,
                        cliente_cidade = txt_cidade.Text,
                        cliente_uf = txt_uf.Text,
                        cliente_dt_nasc = Convert.ToDateTime(txt_dt_nasc.Text),
                        cliente_dt_cad = Convert.ToDateTime(txt_dt_cad.Text)
                    };

                    ClienteDAO cdao = new ClienteDAO();
                    cdao.altera_cliente(objc);
                    MessageBox.Show("alterado");
                    Uc_cliente_Load(null, null);
                }
                catch (Exception)
                {

                    MessageBox.Show("Erro, complete os campos corretamente.");
                }
            }
            else
            {
                MessageBox.Show("Alteração cancelada");
            }

        }

        private void Btn_exclui_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o cliente de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
                , "Exclusão", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Cliente objc = new Cliente
                {
                    cliente_id = (int)dataGridView1.CurrentRow.Cells[0].Value
                };
                ClienteDAO cdao = new ClienteDAO();
                cdao.deleta_cliente(objc);
                MessageBox.Show("Deletado");
                Uc_cliente_Load(null, null);

            }
            else
            {
                MessageBox.Show("exclusão cancelada");
            }
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Cliente c = new Cliente();
            //    c.cliente_nome = txt_nome.Text;
            //    ClienteDAO cdao = new ClienteDAO();
            //    dataGridView1.DataSource = cdao.busca(c);
            //}
            //catch (Exception y)
            //{
            //    MessageBox.Show(y + "");
            //}
        }
    }
}
