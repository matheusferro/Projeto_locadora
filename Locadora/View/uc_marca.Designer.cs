namespace Locadora.View
{
    partial class uc_marca
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtmarca = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_marca = new System.Windows.Forms.DataGridView();
            this.btn_cad_marca = new System.Windows.Forms.Button();
            this.btn_altera_marca = new System.Windows.Forms.Button();
            this.btn_exclui_marca = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marca)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Marca dos automóveis";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtmarca
            // 
            this.txtmarca.Location = new System.Drawing.Point(284, 102);
            this.txtmarca.Name = "txtmarca";
            this.txtmarca.Size = new System.Drawing.Size(119, 27);
            this.txtmarca.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(127, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 21);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nome da marca:";
            // 
            // dgv_marca
            // 
            this.dgv_marca.AllowUserToAddRows = false;
            this.dgv_marca.AllowUserToDeleteRows = false;
            this.dgv_marca.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_marca.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgv_marca.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dgv_marca.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_marca.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgv_marca.Location = new System.Drawing.Point(0, 231);
            this.dgv_marca.Name = "dgv_marca";
            this.dgv_marca.ReadOnly = true;
            this.dgv_marca.Size = new System.Drawing.Size(1025, 345);
            this.dgv_marca.TabIndex = 3;
            this.dgv_marca.DoubleClick += new System.EventHandler(this.dgv_marca_DoubleClick);
            // 
            // btn_cad_marca
            // 
            this.btn_cad_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_cad_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_cad_marca.FlatAppearance.BorderSize = 0;
            this.btn_cad_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cad_marca.ForeColor = System.Drawing.Color.Linen;
            this.btn_cad_marca.Location = new System.Drawing.Point(865, 24);
            this.btn_cad_marca.Name = "btn_cad_marca";
            this.btn_cad_marca.Size = new System.Drawing.Size(116, 33);
            this.btn_cad_marca.TabIndex = 4;
            this.btn_cad_marca.Text = "Cadastrar";
            this.btn_cad_marca.UseVisualStyleBackColor = false;
            this.btn_cad_marca.Click += new System.EventHandler(this.btn_cad_marca_Click);
            // 
            // btn_altera_marca
            // 
            this.btn_altera_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_altera_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_altera_marca.FlatAppearance.BorderSize = 0;
            this.btn_altera_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_altera_marca.ForeColor = System.Drawing.Color.Linen;
            this.btn_altera_marca.Location = new System.Drawing.Point(865, 77);
            this.btn_altera_marca.Name = "btn_altera_marca";
            this.btn_altera_marca.Size = new System.Drawing.Size(116, 33);
            this.btn_altera_marca.TabIndex = 5;
            this.btn_altera_marca.Text = "Alterar";
            this.btn_altera_marca.UseVisualStyleBackColor = false;
            this.btn_altera_marca.Click += new System.EventHandler(this.btn_altera_marca_Click_1);
            // 
            // btn_exclui_marca
            // 
            this.btn_exclui_marca.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.btn_exclui_marca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exclui_marca.FlatAppearance.BorderSize = 0;
            this.btn_exclui_marca.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exclui_marca.ForeColor = System.Drawing.Color.Linen;
            this.btn_exclui_marca.Location = new System.Drawing.Point(865, 134);
            this.btn_exclui_marca.Name = "btn_exclui_marca";
            this.btn_exclui_marca.Size = new System.Drawing.Size(116, 33);
            this.btn_exclui_marca.TabIndex = 6;
            this.btn_exclui_marca.Text = "Excluir";
            this.btn_exclui_marca.UseVisualStyleBackColor = false;
            this.btn_exclui_marca.Click += new System.EventHandler(this.btn_exclui_marca_Click);
            // 
            // uc_marca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btn_exclui_marca);
            this.Controls.Add(this.btn_altera_marca);
            this.Controls.Add(this.btn_cad_marca);
            this.Controls.Add(this.dgv_marca);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtmarca);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.Name = "uc_marca";
            this.Size = new System.Drawing.Size(1025, 576);
            this.Load += new System.EventHandler(this.uc_marca_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_marca)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtmarca;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgv_marca;
        private System.Windows.Forms.Button btn_cad_marca;
        private System.Windows.Forms.Button btn_altera_marca;
        public System.Windows.Forms.Button btn_exclui_marca;
    }
}
