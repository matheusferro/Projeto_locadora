namespace Locadora.View
{
    partial class uc_automovel
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_cor = new System.Windows.Forms.TextBox();
            this.txt_km = new System.Windows.Forms.TextBox();
            this.txt_valor_diaria = new System.Windows.Forms.TextBox();
            this.txt_status = new System.Windows.Forms.TextBox();
            this.btn_cadastro_veiculo = new System.Windows.Forms.Button();
            this.btn_exclui_veiculo = new System.Windows.Forms.Button();
            this.btn_altera_veiculo = new System.Windows.Forms.Button();
            this.cb_marca = new System.Windows.Forms.ComboBox();
            this.cb_modelo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_ano_fab = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(15, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Automóvel";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(637, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ano de fab.:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(16, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 21);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cor:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(197, 86);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 21);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kilometragem:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(197, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(128, 21);
            this.label6.TabIndex = 6;
            this.label6.Text = "Valor da diária:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(637, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "Status:";
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(80, 83);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(106, 27);
            this.txt_nome.TabIndex = 8;
            this.txt_nome.TextChanged += new System.EventHandler(this.Txt_nome_TextChanged);
            // 
            // txt_cor
            // 
            this.txt_cor.Location = new System.Drawing.Point(64, 129);
            this.txt_cor.Name = "txt_cor";
            this.txt_cor.Size = new System.Drawing.Size(122, 27);
            this.txt_cor.TabIndex = 9;
            // 
            // txt_km
            // 
            this.txt_km.Location = new System.Drawing.Point(325, 83);
            this.txt_km.Name = "txt_km";
            this.txt_km.Size = new System.Drawing.Size(99, 27);
            this.txt_km.TabIndex = 10;
            // 
            // txt_valor_diaria
            // 
            this.txt_valor_diaria.Location = new System.Drawing.Point(331, 129);
            this.txt_valor_diaria.Name = "txt_valor_diaria";
            this.txt_valor_diaria.Size = new System.Drawing.Size(93, 27);
            this.txt_valor_diaria.TabIndex = 11;
            // 
            // txt_status
            // 
            this.txt_status.Location = new System.Drawing.Point(706, 83);
            this.txt_status.Name = "txt_status";
            this.txt_status.Size = new System.Drawing.Size(98, 27);
            this.txt_status.TabIndex = 12;
            // 
            // btn_cadastro_veiculo
            // 
            this.btn_cadastro_veiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_cadastro_veiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cadastro_veiculo.FlatAppearance.BorderSize = 0;
            this.btn_cadastro_veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastro_veiculo.ForeColor = System.Drawing.Color.Linen;
            this.btn_cadastro_veiculo.Location = new System.Drawing.Point(865, 24);
            this.btn_cadastro_veiculo.Name = "btn_cadastro_veiculo";
            this.btn_cadastro_veiculo.Size = new System.Drawing.Size(122, 38);
            this.btn_cadastro_veiculo.TabIndex = 15;
            this.btn_cadastro_veiculo.Text = "Cadastrar";
            this.btn_cadastro_veiculo.UseVisualStyleBackColor = false;
            this.btn_cadastro_veiculo.Click += new System.EventHandler(this.Btn_cadastro_veiculo_Click);
            // 
            // btn_exclui_veiculo
            // 
            this.btn_exclui_veiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_exclui_veiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exclui_veiculo.FlatAppearance.BorderSize = 0;
            this.btn_exclui_veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exclui_veiculo.ForeColor = System.Drawing.Color.Linen;
            this.btn_exclui_veiculo.Location = new System.Drawing.Point(865, 134);
            this.btn_exclui_veiculo.Name = "btn_exclui_veiculo";
            this.btn_exclui_veiculo.Size = new System.Drawing.Size(122, 38);
            this.btn_exclui_veiculo.TabIndex = 16;
            this.btn_exclui_veiculo.Text = "Excluir";
            this.btn_exclui_veiculo.UseVisualStyleBackColor = false;
            this.btn_exclui_veiculo.Click += new System.EventHandler(this.Btn_exclui_veiculo_Click);
            // 
            // btn_altera_veiculo
            // 
            this.btn_altera_veiculo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_altera_veiculo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera_veiculo.FlatAppearance.BorderSize = 0;
            this.btn_altera_veiculo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altera_veiculo.ForeColor = System.Drawing.Color.Linen;
            this.btn_altera_veiculo.Location = new System.Drawing.Point(865, 77);
            this.btn_altera_veiculo.Name = "btn_altera_veiculo";
            this.btn_altera_veiculo.Size = new System.Drawing.Size(122, 38);
            this.btn_altera_veiculo.TabIndex = 17;
            this.btn_altera_veiculo.Text = "Alterar";
            this.btn_altera_veiculo.UseVisualStyleBackColor = false;
            this.btn_altera_veiculo.Click += new System.EventHandler(this.Btn_altera_veiculo_Click);
            // 
            // cb_marca
            // 
            this.cb_marca.BackColor = System.Drawing.SystemColors.Window;
            this.cb_marca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_marca.FormattingEnabled = true;
            this.cb_marca.Location = new System.Drawing.Point(505, 81);
            this.cb_marca.Name = "cb_marca";
            this.cb_marca.Size = new System.Drawing.Size(117, 29);
            this.cb_marca.TabIndex = 19;
            this.cb_marca.Click += new System.EventHandler(this.Cb_marca_Click);
            // 
            // cb_modelo
            // 
            this.cb_modelo.BackColor = System.Drawing.SystemColors.Window;
            this.cb_modelo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_modelo.FormattingEnabled = true;
            this.cb_modelo.Location = new System.Drawing.Point(512, 127);
            this.cb_modelo.Name = "cb_modelo";
            this.cb_modelo.Size = new System.Drawing.Size(110, 29);
            this.cb_modelo.TabIndex = 20;
            this.cb_modelo.Click += new System.EventHandler(this.Cb_modelo_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(433, 86);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 21);
            this.label8.TabIndex = 21;
            this.label8.Text = "Marca:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(433, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 22;
            this.label9.Text = "Modelo:";
            // 
            // txt_ano_fab
            // 
            this.txt_ano_fab.Location = new System.Drawing.Point(750, 126);
            this.txt_ano_fab.Name = "txt_ano_fab";
            this.txt_ano_fab.Size = new System.Drawing.Size(98, 27);
            this.txt_ano_fab.TabIndex = 23;
            // 
            // uc_automovel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txt_ano_fab);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cb_modelo);
            this.Controls.Add(this.cb_marca);
            this.Controls.Add(this.btn_altera_veiculo);
            this.Controls.Add(this.btn_exclui_veiculo);
            this.Controls.Add(this.btn_cadastro_veiculo);
            this.Controls.Add(this.txt_status);
            this.Controls.Add(this.txt_valor_diaria);
            this.Controls.Add(this.txt_km);
            this.Controls.Add(this.txt_cor);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "uc_automovel";
            this.Size = new System.Drawing.Size(1025, 576);
            this.Load += new System.EventHandler(this.Uc_automovel_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_cor;
        private System.Windows.Forms.TextBox txt_km;
        private System.Windows.Forms.TextBox txt_valor_diaria;
        private System.Windows.Forms.TextBox txt_status;
        private System.Windows.Forms.Button btn_cadastro_veiculo;
        private System.Windows.Forms.Button btn_altera_veiculo;
        private System.Windows.Forms.ComboBox cb_marca;
        private System.Windows.Forms.ComboBox cb_modelo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.Button btn_exclui_veiculo;
        private System.Windows.Forms.TextBox txt_ano_fab;
    }
}
