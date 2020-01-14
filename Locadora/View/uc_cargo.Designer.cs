namespace Locadora.View
{
    partial class uc_cargo
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
            this.dgv_cargo = new System.Windows.Forms.DataGridView();
            this.btn_exclui_cargo = new System.Windows.Forms.Button();
            this.btn_altera_cargo = new System.Windows.Forms.Button();
            this.btn_cad_cargo = new System.Windows.Forms.Button();
            this.lblcargo = new System.Windows.Forms.Label();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.lbl_titulo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_cargo
            // 
            this.dgv_cargo.AllowUserToAddRows = false;
            this.dgv_cargo.AllowUserToDeleteRows = false;
            this.dgv_cargo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_cargo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_cargo.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_cargo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_cargo.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_cargo.Location = new System.Drawing.Point(0, 231);
            this.dgv_cargo.Name = "dgv_cargo";
            this.dgv_cargo.ReadOnly = true;
            this.dgv_cargo.Size = new System.Drawing.Size(1025, 345);
            this.dgv_cargo.TabIndex = 0;
            this.dgv_cargo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_cargo_CellContentDoubleClick);
            // 
            // btn_exclui_cargo
            // 
            this.btn_exclui_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_exclui_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exclui_cargo.FlatAppearance.BorderSize = 0;
            this.btn_exclui_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exclui_cargo.ForeColor = System.Drawing.Color.Linen;
            this.btn_exclui_cargo.Location = new System.Drawing.Point(865, 134);
            this.btn_exclui_cargo.Name = "btn_exclui_cargo";
            this.btn_exclui_cargo.Size = new System.Drawing.Size(116, 33);
            this.btn_exclui_cargo.TabIndex = 12;
            this.btn_exclui_cargo.Text = "Excluir";
            this.btn_exclui_cargo.UseVisualStyleBackColor = false;
            this.btn_exclui_cargo.Click += new System.EventHandler(this.btn_exclui_cargo_Click);
            // 
            // btn_altera_cargo
            // 
            this.btn_altera_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_altera_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera_cargo.FlatAppearance.BorderSize = 0;
            this.btn_altera_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altera_cargo.ForeColor = System.Drawing.Color.Linen;
            this.btn_altera_cargo.Location = new System.Drawing.Point(865, 77);
            this.btn_altera_cargo.Name = "btn_altera_cargo";
            this.btn_altera_cargo.Size = new System.Drawing.Size(116, 33);
            this.btn_altera_cargo.TabIndex = 11;
            this.btn_altera_cargo.Text = "Alterar";
            this.btn_altera_cargo.UseVisualStyleBackColor = false;
            this.btn_altera_cargo.Click += new System.EventHandler(this.btn_altera_cargo_Click);
            // 
            // btn_cad_cargo
            // 
            this.btn_cad_cargo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_cad_cargo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_cargo.FlatAppearance.BorderSize = 0;
            this.btn_cad_cargo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_cargo.ForeColor = System.Drawing.Color.Linen;
            this.btn_cad_cargo.Location = new System.Drawing.Point(865, 24);
            this.btn_cad_cargo.Name = "btn_cad_cargo";
            this.btn_cad_cargo.Size = new System.Drawing.Size(116, 33);
            this.btn_cad_cargo.TabIndex = 10;
            this.btn_cad_cargo.Text = "Cadastrar";
            this.btn_cad_cargo.UseVisualStyleBackColor = false;
            this.btn_cad_cargo.Click += new System.EventHandler(this.btn_cad_cargo_Click);
            // 
            // lblcargo
            // 
            this.lblcargo.AutoSize = true;
            this.lblcargo.ForeColor = System.Drawing.Color.Black;
            this.lblcargo.Location = new System.Drawing.Point(179, 106);
            this.lblcargo.Name = "lblcargo";
            this.lblcargo.Size = new System.Drawing.Size(64, 21);
            this.lblcargo.TabIndex = 9;
            this.lblcargo.Text = "Cargo:";
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(249, 103);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(140, 27);
            this.txtcargo.TabIndex = 8;
            // 
            // lbl_titulo
            // 
            this.lbl_titulo.AutoSize = true;
            this.lbl_titulo.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.lbl_titulo.ForeColor = System.Drawing.Color.Black;
            this.lbl_titulo.Location = new System.Drawing.Point(3, 6);
            this.lbl_titulo.Name = "lbl_titulo";
            this.lbl_titulo.Size = new System.Drawing.Size(248, 25);
            this.lbl_titulo.TabIndex = 7;
            this.lbl_titulo.Text = "Cargo dos funcionários";
            // 
            // uc_cargo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_exclui_cargo);
            this.Controls.Add(this.btn_altera_cargo);
            this.Controls.Add(this.btn_cad_cargo);
            this.Controls.Add(this.lblcargo);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.lbl_titulo);
            this.Controls.Add(this.dgv_cargo);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "uc_cargo";
            this.Size = new System.Drawing.Size(1025, 576);
            this.Load += new System.EventHandler(this.uc_cargo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_cargo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_cargo;
        private System.Windows.Forms.Button btn_altera_cargo;
        private System.Windows.Forms.Button btn_cad_cargo;
        private System.Windows.Forms.Label lblcargo;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.Label lbl_titulo;
        public System.Windows.Forms.Button btn_exclui_cargo;
    }
}
