namespace Locadora.View
{
    partial class uc_funcionario
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
            this.btn_exclui_funcionario = new System.Windows.Forms.Button();
            this.btn_altera_funcionario = new System.Windows.Forms.Button();
            this.btn_cad_funcionario = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnome_funcionario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_cargo = new System.Windows.Forms.ComboBox();
            this.txt_tel = new System.Windows.Forms.MaskedTextBox();
            this.dgv_funcionario = new System.Windows.Forms.DataGridView();
            this.txtdata = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exclui_funcionario
            // 
            this.btn_exclui_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exclui_funcionario.FlatAppearance.BorderSize = 0;
            this.btn_exclui_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exclui_funcionario.ForeColor = System.Drawing.Color.Linen;
            this.btn_exclui_funcionario.Location = new System.Drawing.Point(865, 134);
            this.btn_exclui_funcionario.Name = "btn_exclui_funcionario";
            this.btn_exclui_funcionario.Size = new System.Drawing.Size(116, 33);
            this.btn_exclui_funcionario.TabIndex = 12;
            this.btn_exclui_funcionario.Text = "Excluir";
            this.btn_exclui_funcionario.UseVisualStyleBackColor = false;
            this.btn_exclui_funcionario.Click += new System.EventHandler(this.Btn_exclui_funcionario_Click);
            // 
            // btn_altera_funcionario
            // 
            this.btn_altera_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_altera_funcionario.FlatAppearance.BorderSize = 0;
            this.btn_altera_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altera_funcionario.ForeColor = System.Drawing.Color.Linen;
            this.btn_altera_funcionario.Location = new System.Drawing.Point(865, 77);
            this.btn_altera_funcionario.Name = "btn_altera_funcionario";
            this.btn_altera_funcionario.Size = new System.Drawing.Size(116, 33);
            this.btn_altera_funcionario.TabIndex = 11;
            this.btn_altera_funcionario.Text = "Alterar";
            this.btn_altera_funcionario.UseVisualStyleBackColor = false;
            this.btn_altera_funcionario.Click += new System.EventHandler(this.Btn_altera_funcionario_Click);
            // 
            // btn_cad_funcionario
            // 
            this.btn_cad_funcionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cad_funcionario.FlatAppearance.BorderSize = 0;
            this.btn_cad_funcionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_funcionario.ForeColor = System.Drawing.Color.Linen;
            this.btn_cad_funcionario.Location = new System.Drawing.Point(865, 24);
            this.btn_cad_funcionario.Name = "btn_cad_funcionario";
            this.btn_cad_funcionario.Size = new System.Drawing.Size(116, 33);
            this.btn_cad_funcionario.TabIndex = 10;
            this.btn_cad_funcionario.Text = "Cadastrar";
            this.btn_cad_funcionario.UseVisualStyleBackColor = false;
            this.btn_cad_funcionario.Click += new System.EventHandler(this.Btn_cad_funcionario_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(17, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nome:";
            // 
            // txtnome_funcionario
            // 
            this.txtnome_funcionario.Location = new System.Drawing.Point(85, 65);
            this.txtnome_funcionario.Name = "txtnome_funcionario";
            this.txtnome_funcionario.Size = new System.Drawing.Size(267, 27);
            this.txtnome_funcionario.TabIndex = 8;
            this.txtnome_funcionario.TextChanged += new System.EventHandler(this.Txtnome_funcionario_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Funcionários";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(446, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 21);
            this.label3.TabIndex = 14;
            this.label3.Text = "Telefone:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(446, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 21);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cargo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(186, 21);
            this.label5.TabIndex = 16;
            this.label5.Text = "Data de contratação:";
            // 
            // cb_cargo
            // 
            this.cb_cargo.BackColor = System.Drawing.SystemColors.Window;
            this.cb_cargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cb_cargo.FormattingEnabled = true;
            this.cb_cargo.Location = new System.Drawing.Point(516, 111);
            this.cb_cargo.Name = "cb_cargo";
            this.cb_cargo.Size = new System.Drawing.Size(162, 29);
            this.cb_cargo.TabIndex = 19;
            this.cb_cargo.Click += new System.EventHandler(this.Cb_cargo_Click);
            // 
            // txt_tel
            // 
            this.txt_tel.Location = new System.Drawing.Point(532, 65);
            this.txt_tel.Mask = "(99) 00000-0000";
            this.txt_tel.Name = "txt_tel";
            this.txt_tel.Size = new System.Drawing.Size(146, 27);
            this.txt_tel.TabIndex = 20;
            // 
            // dgv_funcionario
            // 
            this.dgv_funcionario.AllowUserToAddRows = false;
            this.dgv_funcionario.AllowUserToDeleteRows = false;
            this.dgv_funcionario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_funcionario.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_funcionario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_funcionario.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_funcionario.Location = new System.Drawing.Point(0, 231);
            this.dgv_funcionario.Name = "dgv_funcionario";
            this.dgv_funcionario.ReadOnly = true;
            this.dgv_funcionario.Size = new System.Drawing.Size(1025, 345);
            this.dgv_funcionario.TabIndex = 22;
            this.dgv_funcionario.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_funcionario_CellClick);
            // 
            // txtdata
            // 
            this.txtdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtdata.Location = new System.Drawing.Point(209, 108);
            this.txtdata.Name = "txtdata";
            this.txtdata.Size = new System.Drawing.Size(143, 27);
            this.txtdata.TabIndex = 23;
            this.txtdata.Value = new System.DateTime(2019, 4, 29, 10, 22, 41, 0);
            // 
            // uc_funcionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.Controls.Add(this.txtdata);
            this.Controls.Add(this.dgv_funcionario);
            this.Controls.Add(this.txt_tel);
            this.Controls.Add(this.cb_cargo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_exclui_funcionario);
            this.Controls.Add(this.btn_altera_funcionario);
            this.Controls.Add(this.btn_cad_funcionario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnome_funcionario);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "uc_funcionario";
            this.Size = new System.Drawing.Size(1025, 576);
            this.Load += new System.EventHandler(this.uc_funcionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_funcionario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_altera_funcionario;
        private System.Windows.Forms.Button btn_cad_funcionario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnome_funcionario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_cargo;
        private System.Windows.Forms.MaskedTextBox txt_tel;
        private System.Windows.Forms.DataGridView dgv_funcionario;
        private System.Windows.Forms.DateTimePicker txtdata;
        public System.Windows.Forms.Button btn_exclui_funcionario;
    }
}
