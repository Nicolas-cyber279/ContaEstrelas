namespace ContaEstrelas
{
    partial class Admin
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Admin));
            this.dtGridTabela = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColNome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColEstrelas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.lblEstrelinhas = new System.Windows.Forms.Label();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCamarada = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnRemoveEstrela = new System.Windows.Forms.Button();
            this.btnAddEstrela = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblIdCamarada = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.txtIDBanir = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnBANIR = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.btnVoltar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTabela)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dtGridTabela
            // 
            this.dtGridTabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridTabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColNome,
            this.ColEstrelas});
            this.dtGridTabela.Location = new System.Drawing.Point(20, 75);
            this.dtGridTabela.Name = "dtGridTabela";
            this.dtGridTabela.Size = new System.Drawing.Size(342, 403);
            this.dtGridTabela.TabIndex = 1;
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            // 
            // ColNome
            // 
            this.ColNome.HeaderText = "Nome";
            this.ColNome.Name = "ColNome";
            // 
            // ColEstrelas
            // 
            this.ColEstrelas.HeaderText = "Estrelinhas";
            this.ColEstrelas.Name = "ColEstrelas";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtQuantidade);
            this.panel1.Controls.Add(this.lblEstrelinhas);
            this.panel1.Controls.Add(this.btnOk);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtIdCamarada);
            this.panel1.Controls.Add(this.lblNome);
            this.panel1.Controls.Add(this.btnRemoveEstrela);
            this.panel1.Controls.Add(this.btnAddEstrela);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(532, 199);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 25);
            this.label4.TabIndex = 9;
            this.label4.Text = "Adicionar Estrelas";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 25);
            this.label2.TabIndex = 8;
            this.label2.Text = "Quantidade: ";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(156, 155);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(62, 20);
            this.txtQuantidade.TabIndex = 7;
            // 
            // lblEstrelinhas
            // 
            this.lblEstrelinhas.AutoSize = true;
            this.lblEstrelinhas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstrelinhas.Location = new System.Drawing.Point(235, 71);
            this.lblEstrelinhas.Name = "lblEstrelinhas";
            this.lblEstrelinhas.Size = new System.Drawing.Size(90, 25);
            this.lblEstrelinhas.TabIndex = 6;
            this.lblEstrelinhas.Text = "Estrelas";
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(169, 116);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(49, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 112);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID: ";
            // 
            // txtIdCamarada
            // 
            this.txtIdCamarada.Location = new System.Drawing.Point(65, 117);
            this.txtIdCamarada.Name = "txtIdCamarada";
            this.txtIdCamarada.Size = new System.Drawing.Size(97, 20);
            this.txtIdCamarada.TabIndex = 3;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(15, 71);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(203, 25);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome do Camarada";
            // 
            // btnRemoveEstrela
            // 
            this.btnRemoveEstrela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnRemoveEstrela.Location = new System.Drawing.Point(394, 118);
            this.btnRemoveEstrela.Name = "btnRemoveEstrela";
            this.btnRemoveEstrela.Size = new System.Drawing.Size(126, 57);
            this.btnRemoveEstrela.TabIndex = 1;
            this.btnRemoveEstrela.Text = "Remover";
            this.btnRemoveEstrela.UseVisualStyleBackColor = false;
            this.btnRemoveEstrela.Click += new System.EventHandler(this.btnRemoveEstrela_Click);
            // 
            // btnAddEstrela
            // 
            this.btnAddEstrela.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddEstrela.Location = new System.Drawing.Point(394, 55);
            this.btnAddEstrela.Name = "btnAddEstrela";
            this.btnAddEstrela.Size = new System.Drawing.Size(126, 57);
            this.btnAddEstrela.TabIndex = 0;
            this.btnAddEstrela.Text = "Adicionar";
            this.btnAddEstrela.UseVisualStyleBackColor = false;
            this.btnAddEstrela.Click += new System.EventHandler(this.btnAddEstrela_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblIdCamarada);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtSenha);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btnCadastro);
            this.panel2.Location = new System.Drawing.Point(13, 232);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(532, 141);
            this.panel2.TabIndex = 9;
            // 
            // lblIdCamarada
            // 
            this.lblIdCamarada.AutoSize = true;
            this.lblIdCamarada.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCamarada.Location = new System.Drawing.Point(240, 19);
            this.lblIdCamarada.Name = "lblIdCamarada";
            this.lblIdCamarada.Size = new System.Drawing.Size(280, 25);
            this.lblIdCamarada.TabIndex = 9;
            this.lblIdCamarada.Text = "O ID do novo camarada é 1.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Senha: ";
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(101, 103);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(225, 20);
            this.txtSenha.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 25);
            this.label5.TabIndex = 4;
            this.label5.Text = "Nome: ";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(101, 65);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(224, 20);
            this.txtNome.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(15, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(207, 25);
            this.label6.TabIndex = 2;
            this.label6.Text = "Adicionar Camarada";
            // 
            // btnCadastro
            // 
            this.btnCadastro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(394, 66);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(126, 57);
            this.btnCadastro.TabIndex = 0;
            this.btnCadastro.Text = "Cadastrar Camarada!";
            this.btnCadastro.UseVisualStyleBackColor = false;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.txtIDBanir);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btnBANIR);
            this.panel3.Location = new System.Drawing.Point(13, 391);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(532, 141);
            this.panel3.TabIndex = 10;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(15, 60);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(44, 25);
            this.label8.TabIndex = 4;
            this.label8.Text = "ID: ";
            // 
            // txtIDBanir
            // 
            this.txtIDBanir.Location = new System.Drawing.Point(65, 65);
            this.txtIDBanir.Name = "txtIDBanir";
            this.txtIDBanir.Size = new System.Drawing.Size(136, 20);
            this.txtIDBanir.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(15, 19);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(194, 25);
            this.label9.TabIndex = 2;
            this.label9.Text = "Banir Camarada 💀";
            // 
            // btnBANIR
            // 
            this.btnBANIR.BackColor = System.Drawing.Color.Maroon;
            this.btnBANIR.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBANIR.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnBANIR.Location = new System.Drawing.Point(303, 31);
            this.btnBANIR.Name = "btnBANIR";
            this.btnBANIR.Size = new System.Drawing.Size(168, 86);
            this.btnBANIR.TabIndex = 0;
            this.btnBANIR.Text = "🔥BANIR🔥";
            this.btnBANIR.UseVisualStyleBackColor = false;
            this.btnBANIR.Click += new System.EventHandler(this.btnBANIR_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.dtGridTabela);
            this.panel4.Location = new System.Drawing.Point(580, 13);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(378, 501);
            this.panel4.TabIndex = 11;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(15, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(248, 25);
            this.label10.TabIndex = 2;
            this.label10.Text = "Ranking dos Camaradas";
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Location = new System.Drawing.Point(836, 521);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(122, 45);
            this.btnVoltar.TabIndex = 12;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(970, 578);
            this.Controls.Add(this.btnVoltar);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridTabela)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtGridTabela;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNome;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColEstrelas;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCamarada;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnRemoveEstrela;
        private System.Windows.Forms.Button btnAddEstrela;
        private System.Windows.Forms.Label lblEstrelinhas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtIDBanir;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnBANIR;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblIdCamarada;
        private System.Windows.Forms.Button btnVoltar;
    }
}