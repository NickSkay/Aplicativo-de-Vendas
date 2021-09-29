using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace APP_Vendas_Dev
{
    public partial class vendas : Form
    {
        public vendas()
        {
            InitializeComponent();
        }

        private void clean()
        {
            txt_produtos.Clear();
            txt_qntd.Clear();
            txt_vu.Clear();

            txt_produtos.Focus();
        }

        private void btn_inserir_Click(object sender, EventArgs e)
        {


            
            string[] produtos = new string[3];
            produtos[0] = txt_produtos.Text;
            produtos[1] = txt_qntd.Text;
            produtos[2] = txt_vu.Text;

            if(txt_produtos.Text == "")
            {
                MessageBox.Show("O nome do produto não pode permanecer vazio");
                txt_produtos.Focus();
                return;
            }
            if (txt_qntd.Text == "")
            {
                MessageBox.Show("Você deve informar a quantidade do produto");
                txt_qntd.Focus();
                return;
            }
            if (txt_vu.Text == "")
            {
                MessageBox.Show("Você deve informar o preço unitário do produto");
                txt_vu.Focus();
                return;
            }

            





            ListViewItem lv = new ListViewItem(produtos);
            lv_produtos.Items.Add(lv);
            clean();


        }

        private void btn_remover_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.RemoveAt(lv_produtos.SelectedIndices[0]);
           
        }

        private void btn_limpar_Click(object sender, EventArgs e)
        {
            lv_produtos.Items.Clear();
        }

        private void btn_calcular_Click(object sender, EventArgs e)
        {
            double total = 0;
           

            foreach(ListViewItem item in lv_produtos.Items)
            {
                string valor = item.SubItems[2].Text;
                double preco = double.Parse(valor);
                string valorqt = item.SubItems[1].Text;
                double qntd = double.Parse(valorqt);
             
                total = total + (qntd * preco);

                label_total.Text = total.ToString("N2");

            


            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawImage(bmp, 0, 0);
        }

        Bitmap bmp;
        private void btn_print_Click(object sender, EventArgs e)
        {

            Graphics g = this.CreateGraphics();
            bmp = new Bitmap(this.Size.Width, this.Size.Height, g);
            Graphics mg = Graphics.FromImage(bmp);
            mg.CopyFromScreen(this.Location.X, this.Location.Y, 0, 0, this.Size);
            printPreviewDialog1.ShowDialog();


        }

       
    }
}
 