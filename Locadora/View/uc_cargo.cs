using Locadora.Controle;
using Locadora.DAO;
using System;
using System.Windows.Forms;

namespace Locadora.View
{
    public partial class uc_cargo : UserControl
    {
        public uc_cargo()
        {
            InitializeComponent();
        }

        private void btn_cad_cargo_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtcargo.Text))
            {
                MessageBox.Show("Preencha o campo.");
            }
            else
            {
                try
                {
                    Cargo objc = new Cargo
                    {
                        cargo_nome = txtcargo.Text
                    };
                    CargoDAO cdao = new CargoDAO();
                    cdao.cadastra_cargo(objc);

                    uc_cargo_Load(null, null);
                }
                catch (Exception)
                {
                    MessageBox.Show("Erro ao alterar.");
                }
            }
        }
        private void btn_altera_cargo_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("TEM CERTEZA QUE DESEJA ALTERAR O CARGO DE ID: " + dgv_cargo.CurrentRow.Cells[0].Value + " ??"
                    , "Alterar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    if (string.IsNullOrEmpty(txtcargo.Text))
                    {
                        MessageBox.Show("Erro ao alterar o cargo, preencha todos os campos");
                    }
                    else
                    {
                        Cargo cobj = new Cargo
                        {
                            cargoid = (int)dgv_cargo.CurrentRow.Cells[0].Value,
                            cargo_nome = txtcargo.Text
                        };
                        CargoDAO cdao = new CargoDAO();
                        cdao.altera_cargo(cobj);
                        uc_cargo_Load(null, null);
                    }

                }
                else
                {
                    MessageBox.Show("Alteração cancelada.");
                }

            }
            catch (Exception)
            {
            }
        }
        private void uc_cargo_Load(object sender, EventArgs e)
        {
            try
            {
                CargoDAO cdao = new CargoDAO();
                dgv_cargo.DataSource = cdao.lista_cargo();
            }
            catch (Exception)
            {
            }

        }

        private void dgv_cargo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            txtcargo.Text = dgv_cargo.CurrentRow.Cells[1].Value.ToString();
        }

        private void btn_exclui_cargo_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Tem certeza que deseja excluir o cargo de id:" + dgv_cargo.CurrentRow.Cells[0].Value.ToString() + " ??",
                "Exclusão segura", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                try
                {
                    Cargo cobj = new Cargo
                    {
                        cargoid = (int)dgv_cargo.CurrentRow.Cells[0].Value
                    };
                    CargoDAO cdao = new CargoDAO();
                    cdao.exclui_cargo(cobj);
                    MessageBox.Show("Cargo excluído com sucesso.");
                    uc_cargo_Load(null, null);

                }
                catch (Exception)
                {
                    MessageBox.Show("erro na exclusão ");
                }
            }
            else
            {
                MessageBox.Show("Exclusão cancelada");
            }
        }
    }
}
