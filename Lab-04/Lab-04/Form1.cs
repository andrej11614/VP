using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btndodadiprodukt_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();

            if (f2.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
                lbprodukti.Items.Add(f2.prod);
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btndodadikosnicka_Click(object sender, EventArgs e)
        {
            if (lbprodukti.SelectedIndex == -1) return;  //nothing selected

            ProductItem tmp = lbprodukti.SelectedItem as ProductItem;

            if (numkolicina.Value > tmp.total) return;   //asking for too much

            int total = (int)numkolicina.Value;

            ProductItem pi = new ProductItem(tmp.product, total);

            tmp.total -= total;

            lbkosnicka.Items.Add(String.Format("{0} {1} x {2} = {3}", pi, pi.total, pi.product.price, pi.total*pi.product.price));

        }

        private void lbprodukti_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbprodukti.SelectedIndex == -1) return;

            ProductItem pd = lbprodukti.SelectedItem as ProductItem;

            txtime.Text = pd.product.name;

            txtkategorija.Text = pd.product.category;

            txtcena.Text = pd.product.price.ToString();

        }

        private void btnisprazniprodukti_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со продукти?", "Испразни ја листата?", MessageBoxButtons.YesNo)==DialogResult.Yes)
            lbprodukti.Items.Clear();
        }

        private void btnizbrisikosnicka_Click(object sender, EventArgs e)
        {
            if (lbkosnicka.SelectedIndex == -1) return;

            lbkosnicka.Items.RemoveAt(lbkosnicka.SelectedIndex);
        }

        private void btnizbrisiprodukt_Click(object sender, EventArgs e)
        {
            if (lbprodukti.SelectedIndex == -1) return;

            lbprodukti.Items.RemoveAt(lbprodukti.SelectedIndex);
        }

        private void btnispraznikosnicka_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Дали сте сигурни дека сакате да ја испразните листата со кошничка?", "Испразни ја листата?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                lbprodukti.Items.Clear();
        }
        public void updateVkupno() {
            int vkupno = 0;

            foreach (var li in  lbprodukti.Items) {
                ProductItem tmp = (ProductItem)li;
                
                vkupno += tmp.total * tmp.product.price;
            }

        }
    }
}
