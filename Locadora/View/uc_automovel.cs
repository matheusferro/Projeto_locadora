using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_automovel : UserControl
    {
        public uc_automovel()
        {
            InitializeComponent();
        }

        private void Uc_automovel_Load(object sender, EventArgs e)
        {
            try
            {
                AutomovelDAO autodao = new AutomovelDAO();
                dataGridView1.DataSource = autodao.lista_auto();
                MarcaDAO marcadao = new MarcaDAO();
                cb_marca.DataSource = marcadao.mostra_marca();
                ModeloDAO modelodao = new ModeloDAO();
                cb_modelo.DataSource = modelodao.lista_modelo();

                cb_marca.DisplayMember = "Marca";
                cb_marca.ValueMember = "ID";

                cb_modelo.DisplayMember = "Modelo";
                cb_modelo.ValueMember = "ID";
            }
            catch (Exception)
            {
            }
        }

        public bool verificaCampos()
        {
            if (string.IsNullOrEmpty(txt_nome.Text) || string.IsNullOrEmpty(txt_km.Text) || string.IsNullOrEmpty(txt_cor.Text) ||
                string.IsNullOrEmpty(txt_ano_fab.Text) || string.IsNullOrEmpty(txt_status.Text) || string.IsNullOrEmpty(txt_valor_diaria.Text))
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        private void Btn_cadastro_veiculo_Click(object sender, EventArgs e)
        {
            if (verificaCampos())
            {
                try
                {
                    Automovel objauto = new Automovel
                    {
                        auto_nome = txt_nome.Text,
                        auto_km = double.Parse(txt_km.Text.ToString()),
                        auto_cor = txt_cor.Text,
                        auto_ano_fab = txt_ano_fab.Text,
                        auto_status = txt_status.Text,
                        auto_valor_d = double.Parse(txt_valor_diaria.Text.ToString()),
                        marca_id = (int)cb_marca.SelectedValue,
                        modelo_id = (int)cb_modelo.SelectedValue
                    };
                    AutomovelDAO autodao = new AutomovelDAO();
                    autodao.cadastra_veiculo(objauto);
                    MessageBox.Show("Cadastrado");
                    Uc_automovel_Load(null, null);
                }
                catch (Exception)
                { }

            }
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txt_nome.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txt_ano_fab.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txt_cor.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txt_km.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txt_valor_diaria.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txt_status.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            cb_marca.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
            cb_modelo.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
        }

        private void Btn_altera_veiculo_Click(object sender, EventArgs e)
        {

            try
            {
                if (!verificaCampos())
                {
                    MessageBox.Show("Preencha todos os campos!");
                }
                else
                {
                    if (MessageBox.Show("Deseja alterar o automóvel de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
                        , "Alterar auto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        Automovel objauto = new Automovel
                        {
                            auto_id = (int)dataGridView1.CurrentRow.Cells[0].Value,
                            auto_nome = txt_nome.Text,
                            auto_km = double.Parse(txt_km.Text.ToString()),
                            auto_cor = txt_cor.Text,
                            auto_ano_fab = txt_ano_fab.Text,
                            auto_status = txt_status.Text,
                            auto_valor_d = double.Parse(txt_valor_diaria.Text.ToString()),
                            marca_id = (int)cb_marca.SelectedValue,
                            modelo_id = (int)cb_modelo.SelectedValue
                        };
                        AutomovelDAO autodao = new AutomovelDAO();
                        autodao.altera_veiculo(objauto);
                        MessageBox.Show("Alterado");
                        Uc_automovel_Load(null, null);

                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Erro ao alterar");
            }

        }

        private void Btn_exclui_veiculo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja excluir o automóvel de ID:" + dataGridView1.CurrentRow.Cells[0].Value.ToString() + " ??"
            , "EXCLUSÃO", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                Automovel objauto = new Automovel
                {
                    auto_id = (int)dataGridView1.CurrentRow.Cells[0].Value
                };
                AutomovelDAO obja = new AutomovelDAO();
                obja.exclui_auto(objauto);
                MessageBox.Show("Exluído!");
                Uc_automovel_Load(null, null);

            }
            else
            {
                MessageBox.Show("Exclusão cancelada !");
            }
        }

        private void Cb_marca_Click(object sender, EventArgs e)
        {
            try
            {
                MarcaDAO marcadao = new MarcaDAO();
                cb_marca.DataSource = marcadao.mostra_marca();


                cb_marca.DisplayMember = "Marca";
                cb_marca.ValueMember = "ID";

            }
            catch (Exception)
            {
            }
        }

        private void Cb_modelo_Click(object sender, EventArgs e)
        {
            try
            {
                ModeloDAO modelodao = new ModeloDAO();
                cb_modelo.DataSource = modelodao.lista_modelo();
                cb_modelo.DisplayMember = "Modelo";
                cb_modelo.ValueMember = "ID";
            }
            catch (Exception)
            {
            }
        }

        private void Txt_nome_TextChanged(object sender, EventArgs e)
        {
            //try
            //{
            //    Automovel a = new Automovel();
            //    a.auto_nome = txt_nome.Text;
            //    AutomovelDAO adao = new AutomovelDAO();
            //    dataGridView1.DataSource = adao.busca(a);
            //}
            //catch (Exception y)
            //{
            //    MessageBox.Show(y + "");
            //}
        }
    }
}
