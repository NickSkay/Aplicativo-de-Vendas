
namespace APP_Vendas_Dev
{
    partial class vendas
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vendas));
            this.lv_produtos = new System.Windows.Forms.ListView();
            this.col_produto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_qnt = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col_vu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_produtos = new System.Windows.Forms.TextBox();
            this.txt_qntd = new System.Windows.Forms.TextBox();
            this.txt_vu = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_inserir = new System.Windows.Forms.Button();
            this.btn_print = new System.Windows.Forms.Button();
            this.btn_remover = new System.Windows.Forms.Button();
            this.btn_limpar = new System.Windows.Forms.Button();
            this.label_total = new System.Windows.Forms.Label();
            this.btn_calcular = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.txt_data = new System.Windows.Forms.TextBox();
            this.txt_nome = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // lv_produtos
            // 
            this.lv_produtos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col_produto,
            this.col_qnt,
            this.col_vu});
            this.lv_produtos.FullRowSelect = true;
            this.lv_produtos.HideSelection = false;
            this.lv_produtos.Location = new System.Drawing.Point(45, 197);
            this.lv_produtos.MultiSelect = false;
            this.lv_produtos.Name = "lv_produtos";
            this.lv_produtos.Size = new System.Drawing.Size(414, 97);
            this.lv_produtos.TabIndex = 0;
            this.lv_produtos.UseCompatibleStateImageBehavior = false;
            this.lv_produtos.View = System.Windows.Forms.View.Details;
            // 
            // col_produto
            // 
            this.col_produto.Text = "Produto";
            this.col_produto.Width = 250;
            // 
            // col_qnt
            // 
            this.col_qnt.Text = "Quantidade";
            this.col_qnt.Width = 70;
            // 
            // col_vu
            // 
            this.col_vu.Text = "Valor unitário";
            this.col_vu.Width = 80;
            // 
            // txt_produtos
            // 
            this.txt_produtos.Location = new System.Drawing.Point(12, 102);
            this.txt_produtos.Name = "txt_produtos";
            this.txt_produtos.Size = new System.Drawing.Size(248, 20);
            this.txt_produtos.TabIndex = 1;
            // 
            // txt_qntd
            // 
            this.txt_qntd.Location = new System.Drawing.Point(277, 102);
            this.txt_qntd.Name = "txt_qntd";
            this.txt_qntd.Size = new System.Drawing.Size(100, 20);
            this.txt_qntd.TabIndex = 2;
            // 
            // txt_vu
            // 
            this.txt_vu.Location = new System.Drawing.Point(394, 102);
            this.txt_vu.Name = "txt_vu";
            this.txt_vu.Size = new System.Drawing.Size(100, 20);
            this.txt_vu.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Produtos";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quantidade";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(391, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Valor unitário";
            // 
            // btn_inserir
            // 
            this.btn_inserir.Location = new System.Drawing.Point(402, 146);
            this.btn_inserir.Name = "btn_inserir";
            this.btn_inserir.Size = new System.Drawing.Size(92, 32);
            this.btn_inserir.TabIndex = 7;
            this.btn_inserir.Text = "Inserir Item";
            this.btn_inserir.UseVisualStyleBackColor = true;
            this.btn_inserir.Click += new System.EventHandler(this.btn_inserir_Click);
            // 
            // btn_print
            // 
            this.btn_print.Location = new System.Drawing.Point(12, 325);
            this.btn_print.Name = "btn_print";
            this.btn_print.Size = new System.Drawing.Size(92, 32);
            this.btn_print.TabIndex = 8;
            this.btn_print.Text = "Imprimir";
            this.btn_print.UseVisualStyleBackColor = true;
            this.btn_print.Click += new System.EventHandler(this.btn_print_Click);
            // 
            // btn_remover
            // 
            this.btn_remover.Location = new System.Drawing.Point(414, 325);
            this.btn_remover.Name = "btn_remover";
            this.btn_remover.Size = new System.Drawing.Size(92, 32);
            this.btn_remover.TabIndex = 9;
            this.btn_remover.Text = "Remover item";
            this.btn_remover.UseVisualStyleBackColor = true;
            this.btn_remover.Click += new System.EventHandler(this.btn_remover_Click);
            // 
            // btn_limpar
            // 
            this.btn_limpar.Location = new System.Drawing.Point(316, 325);
            this.btn_limpar.Name = "btn_limpar";
            this.btn_limpar.Size = new System.Drawing.Size(92, 32);
            this.btn_limpar.TabIndex = 10;
            this.btn_limpar.Text = "Limpar lista";
            this.btn_limpar.UseVisualStyleBackColor = true;
            this.btn_limpar.Click += new System.EventHandler(this.btn_limpar_Click);
            // 
            // label_total
            // 
            this.label_total.AutoSize = true;
            this.label_total.Location = new System.Drawing.Point(414, 306);
            this.label_total.Name = "label_total";
            this.label_total.Size = new System.Drawing.Size(0, 13);
            this.label_total.TabIndex = 11;
            // 
            // btn_calcular
            // 
            this.btn_calcular.Location = new System.Drawing.Point(110, 325);
            this.btn_calcular.Name = "btn_calcular";
            this.btn_calcular.Size = new System.Drawing.Size(92, 32);
            this.btn_calcular.TabIndex = 12;
            this.btn_calcular.Text = "Calcular preço";
            this.btn_calcular.UseVisualStyleBackColor = true;
            this.btn_calcular.Click += new System.EventHandler(this.btn_calcular_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(355, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "TOTAL R$";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Número";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(172, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(30, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Data";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(274, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(84, 13);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nome do cliente";
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(11, 36);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(126, 20);
            this.txt_numero.TabIndex = 17;
            // 
            // txt_data
            // 
            this.txt_data.Location = new System.Drawing.Point(173, 36);
            this.txt_data.Name = "txt_data";
            this.txt_data.Size = new System.Drawing.Size(87, 20);
            this.txt_data.TabIndex = 18;
            // 
            // txt_nome
            // 
            this.txt_nome.Location = new System.Drawing.Point(277, 36);
            this.txt_nome.Name = "txt_nome";
            this.txt_nome.Size = new System.Drawing.Size(217, 20);
            this.txt_nome.TabIndex = 19;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Document = this.printDocument1;
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 369);
            this.Controls.Add(this.txt_nome);
            this.Controls.Add(this.txt_data);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btn_calcular);
            this.Controls.Add(this.label_total);
            this.Controls.Add(this.btn_limpar);
            this.Controls.Add(this.btn_remover);
            this.Controls.Add(this.btn_print);
            this.Controls.Add(this.btn_inserir);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_vu);
            this.Controls.Add(this.txt_qntd);
            this.Controls.Add(this.txt_produtos);
            this.Controls.Add(this.lv_produtos);
            this.MaximizeBox = false;
            this.Name = "vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_produtos;
        private System.Windows.Forms.ColumnHeader col_produto;
        private System.Windows.Forms.ColumnHeader col_qnt;
        private System.Windows.Forms.ColumnHeader col_vu;
        private System.Windows.Forms.TextBox txt_produtos;
        private System.Windows.Forms.TextBox txt_qntd;
        private System.Windows.Forms.TextBox txt_vu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_inserir;
        private System.Windows.Forms.Button btn_print;
        private System.Windows.Forms.Button btn_remover;
        private System.Windows.Forms.Button btn_limpar;
        private System.Windows.Forms.Label label_total;
        private System.Windows.Forms.Button btn_calcular;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.TextBox txt_data;
        private System.Windows.Forms.TextBox txt_nome;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}

