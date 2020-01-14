namespace Locadora.View
{
    partial class uc_modelo
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
            this.btn_exclui_modelo = new System.Windows.Forms.Button();
            this.btn_altera_modelo = new System.Windows.Forms.Button();
            this.btn_cad_modelo = new System.Windows.Forms.Button();
            this.lbl_nome_modelo = new System.Windows.Forms.Label();
            this.txtmodelo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvmodelo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodelo)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exclui_modelo
            // 
            this.btn_exclui_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_exclui_modelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exclui_modelo.FlatAppearance.BorderSize = 0;
            this.btn_exclui_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exclui_modelo.ForeColor = System.Drawing.Color.Linen;
            this.btn_exclui_modelo.Location = new System.Drawing.Point(865, 134);
            this.btn_exclui_modelo.Name = "btn_exclui_modelo";
            this.btn_exclui_modelo.Size = new System.Drawing.Size(116, 33);
            this.btn_exclui_modelo.TabIndex = 12;
            this.btn_exclui_modelo.Text = "Excluir";
            this.btn_exclui_modelo.UseVisualStyleBackColor = false;
            this.btn_exclui_modelo.Click += new System.EventHandler(this.btn_exclui_modelo_Click);
            // 
            // btn_altera_modelo
            // 
            this.btn_altera_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_altera_modelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera_modelo.FlatAppearance.BorderSize = 0;
            this.btn_altera_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altera_modelo.ForeColor = System.Drawing.Color.Linen;
            this.btn_altera_modelo.Location = new System.Drawing.Point(865, 77);
            this.btn_altera_modelo.Name = "btn_altera_modelo";
            this.btn_altera_modelo.Size = new System.Drawing.Size(116, 33);
            this.btn_altera_modelo.TabIndex = 11;
            this.btn_altera_modelo.Text = "Alterar";
            this.btn_altera_modelo.UseVisualStyleBackColor = false;
            this.btn_altera_modelo.Click += new System.EventHandler(this.btn_altera_modelo_Click);
            // 
            // btn_cad_modelo
            // 
            this.btn_cad_modelo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_cad_modelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_modelo.FlatAppearance.BorderSize = 0;
            this.btn_cad_modelo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_modelo.ForeColor = System.Drawing.Color.Linen;
            this.btn_cad_modelo.Location = new System.Drawing.Point(865, 24);
            this.btn_cad_modelo.Name = "btn_cad_modelo";
            this.btn_cad_modelo.Size = new System.Drawing.Size(116, 33);
            this.btn_cad_modelo.TabIndex = 10;
            this.btn_cad_modelo.Text = "Cadastrar";
            this.btn_cad_modelo.UseVisualStyleBackColor = false;
            this.btn_cad_modelo.Click += new System.EventHandler(this.btn_cad_modelo_Click);
            // 
            // lbl_nome_modelo
            // 
            this.lbl_nome_modelo.AutoSize = true;
            this.lbl_nome_modelo.ForeColor = System.Drawing.Color.Black;
            this.lbl_nome_modelo.Location = new System.Drawing.Point(127, 105);
            this.lbl_nome_modelo.Name = "lbl_nome_modelo";
            this.lbl_nome_modelo.Size = new System.Drawing.Size(149, 21);
            this.lbl_nome_modelo.TabIndex = 9;
            this.lbl_nome_modelo.Text = "Nome do modelo:";
            // 
            // txtmodelo
            // 
            this.txtmodelo.Location = new System.Drawing.Point(284, 102);
            this.txtmodelo.Name = "txtmodelo";
            this.txtmodelo.Size = new System.Drawing.Size(119, 27);
            this.txtmodelo.TabIndex = 8;
            this.txtmodelo.TextChanged += new System.EventHandler(this.Txtmodelo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(255, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Modelo dos automóveis";
            // 
            // dgvmodelo
            // 
            this.dgvmodelo.AllowUserToAddRows = false;
            this.dgvmodelo.AllowUserToDeleteRows = false;
            this.dgvmodelo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvmodelo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvmodelo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgvmodelo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvmodelo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvmodelo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvmodelo.Location = new System.Drawing.Point(0, 231);
            this.dgvmodelo.Name = "dgvmodelo";
            this.dgvmodelo.Size = new System.Drawing.Size(1025, 345);
            this.dgvmodelo.TabIndex = 13;
            this.dgvmodelo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvmodelo_CellDoubleClick);
            // 
            // uc_modelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.dgvmodelo);
            this.Controls.Add(this.btn_exclui_modelo);
            this.Controls.Add(this.btn_altera_modelo);
            this.Controls.Add(this.btn_cad_modelo);
            this.Controls.Add(this.lbl_nome_modelo);
            this.Controls.Add(this.txtmodelo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "uc_modelo";
            this.Size = new System.Drawing.Size(1025, 576);
            this.Load += new System.EventHandler(this.uc_modelo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvmodelo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_altera_modelo;
        private System.Windows.Forms.Button btn_cad_modelo;
        private System.Windows.Forms.Label lbl_nome_modelo;
        private System.Windows.Forms.TextBox txtmodelo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvmodelo;
        public System.Windows.Forms.Button btn_exclui_modelo;
    }
}
