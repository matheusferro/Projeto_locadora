namespace Locadora.View
{
    partial class uc_cliente
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
            this.btn_cadastra = new System.Windows.Forms.Button();
            this.btn_exclui = new System.Windows.Forms.Button();
            this.btn_altera = new System.Windows.Forms.Button();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.txt_uf = new System.Windows.Forms.TextBox();
            this.txt_cidade = new System.Windows.Forms.TextBox();
            this.txt_bairro = new System.Windows.Forms.TextBox();
            this.txt_complemento = new System.Windows.Forms.TextBox();
            this.txt_endereco = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_sexo = new System.Windows.Forms.TextBox();
            this.txt_tel = new System.Windows.Forms.TextBox();
            this.txt_dt_cad = new System.Windows.Forms.DateTimePicker();
            this.txt_dt_nasc = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 231);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1025, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // btn_cadastra
            // 
            this.btn_cadastra.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cadastra.FlatAppearance.BorderSize = 0;
            this.btn_cadastra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cadastra.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_cadastra.Location = new System.Drawing.Point(865, 24);
            this.btn_cadastra.Name = "btn_cadastra";
            this.btn_cadastra.Size = new System.Drawing.Size(116, 33);
            this.btn_cadastra.TabIndex = 1;
            this.btn_cadastra.Text = "Cadastrar";
            this.btn_cadastra.UseVisualStyleBackColor = false;
            this.btn_cadastra.Click += new System.EventHandler(this.Btn_cadastra_Click);
            // 
            // btn_exclui
            // 
            this.btn_exclui.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exclui.FlatAppearance.BorderSize = 0;
            this.btn_exclui.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exclui.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_exclui.Location = new System.Drawing.Point(865, 134);
            this.btn_exclui.Name = "btn_exclui";
            this.btn_exclui.Size = new System.Drawing.Size(116, 33);
            this.btn_exclui.TabIndex = 2;
            this.btn_exclui.Text = "Excluir";
            this.btn_exclui.UseVisualStyleBackColor = false;
            this.btn_exclui.Click += new System.EventHandler(this.Btn_exclui_Click);
            // 
            // btn_altera
            // 
            this.btn_altera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_altera.FlatAppearance.BorderSize = 0;
            this.btn_altera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altera.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btn_altera.Location = new System.Drawing.Point(865, 77);
            this.btn_altera.Name = "btn_altera";
            this.btn_altera.Size = new System.Drawing.Size(116, 33);
            this.btn_altera.TabIndex = 3;
            this.btn_altera.Text = "Alterar";
            this.btn_altera.UseVisualStyleBackColor = false;
            this.btn_altera.Click += new System.EventHandler(this.Btn_altera_Click);
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(81, 63);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(114, 27);
            this.txt_nome.TabIndex = 4;
            this.txt_nome.TextChanged += new System.EventHandler(this.Txt_nome_TextChanged);
            // 
            // txt_uf
            // 
            this.txt_uf.Location = new System.Drawing.Point(716, 63);
            this.txt_uf.Name = "txt_uf";
            this.txt_uf.Size = new System.Drawing.Size(49, 27);
            this.txt_uf.TabIndex = 7;
            // 
            // txt_cidade
            // 
            this.txt_cidade.Location = new System.Drawing.Point(534, 63);
            this.txt_cidade.Name = "txt_cidade";
            this.txt_cidade.Size = new System.Drawing.Size(128, 27);
            this.txt_cidade.TabIndex = 8;
            // 
            // txt_bairro
            // 
            this.txt_bairro.Location = new System.Drawing.Point(731, 101);
            this.txt_bairro.Name = "txt_bairro";
            this.txt_bairro.Size = new System.Drawing.Size(120, 27);
            this.txt_bairro.TabIndex = 9;
            // 
            // txt_complemento
            // 
            this.txt_complemento.Location = new System.Drawing.Point(146, 143);
            this.txt_complemento.Name = "txt_complemento";
            this.txt_complemento.Size = new System.Drawing.Size(95, 27);
            this.txt_complemento.TabIndex = 10;
            // 
            // txt_endereco
            // 
            this.txt_endereco.Location = new System.Drawing.Point(548, 101);
            this.txt_endereco.Name = "txt_endereco";
            this.txt_endereco.Size = new System.Drawing.Size(114, 27);
            this.txt_endereco.TabIndex = 11;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(270, 101);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(168, 27);
            this.txt_email.TabIndex = 12;
            // 
            // txt_sexo
            // 
            this.txt_sexo.Location = new System.Drawing.Point(68, 98);
            this.txt_sexo.Name = "txt_sexo";
            this.txt_sexo.Size = new System.Drawing.Size(127, 27);
            this.txt_sexo.TabIndex = 13;
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(298, 63);
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(140, 27);
            this.txt_tel.TabIndex = 14;
            // 
            // txt_dt_cad
            // 
            this.txt_dt_cad.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_dt_cad.Location = new System.Drawing.Point(730, 143);
            this.txt_dt_cad.Name = "txt_dt_cad";
            this.txt_dt_cad.Size = new System.Drawing.Size(121, 27);
            this.txt_dt_cad.TabIndex = 15;
            // 
            // txt_dt_nasc
            // 
            this.txt_dt_nasc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txt_dt_nasc.Location = new System.Drawing.Point(435, 141);
            this.txt_dt_nasc.Name = "txt_dt_nasc";
            this.txt_dt_nasc.Size = new System.Drawing.Size(121, 27);
            this.txt_dt_nasc.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 21);
            this.label1.TabIndex = 17;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(209, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Telefone:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(12, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Sexo:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(209, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Email:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(128, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Complemento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(455, 104);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 21);
            this.label6.TabIndex = 22;
            this.label6.Text = "Endereco:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(254, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(175, 21);
            this.label7.TabIndex = 23;
            this.label7.Text = "data de nascimento:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(571, 146);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(154, 21);
            this.label8.TabIndex = 24;
            this.label8.Text = "data de cadastro:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(668, 104);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 21);
            this.label9.TabIndex = 25;
            this.label9.Text = "Bairro:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(455, 66);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(73, 21);
            this.label10.TabIndex = 26;
            this.label10.Text = "Cidade:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(678, 66);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 21);
            this.label11.TabIndex = 27;
            this.label11.Text = "UF:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.Black;
            this.label12.Location = new System.Drawing.Point(3, 6);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(83, 25);
            this.label12.TabIndex = 28;
            this.label12.Text = "Cliente";
            // 
            // uc_cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_dt_nasc);
            this.Controls.Add(this.txt_dt_cad);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.txt_sexo);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_endereco);
            this.Controls.Add(this.txt_complemento);
            this.Controls.Add(this.txt_bairro);
            this.Controls.Add(this.txt_cidade);
            this.Controls.Add(this.txt_uf);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.btn_altera);
            this.Controls.Add(this.btn_exclui);
            this.Controls.Add(this.btn_cadastra);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "uc_cliente";
            this.Size = new System.Drawing.Size(1025, 576);
            this.Load += new System.EventHandler(this.Uc_cliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_cadastra;
        private System.Windows.Forms.Button btn_altera;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Windows.Forms.TextBox txt_uf;
        private System.Windows.Forms.TextBox txt_cidade;
        private System.Windows.Forms.TextBox txt_bairro;
        private System.Windows.Forms.TextBox txt_complemento;
        private System.Windows.Forms.TextBox txt_endereco;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_sexo;
        private System.Windows.Forms.TextBox txt_tel;
        private System.Windows.Forms.DateTimePicker txt_dt_cad;
        private System.Windows.Forms.DateTimePicker txt_dt_nasc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.Button btn_exclui;
    }
}
