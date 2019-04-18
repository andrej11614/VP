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
    public partial class Form2 : Form
    {
        public ProductItem prod { get; set; }
        public Form2()
        {
            InitializeComponent();
        }

        private void txtime_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtime.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtime, "Внесете валидна вредност!");
            }
            else {
                e.Cancel = false;
                errorProvider1.SetError(txtime, "");

            }
        }

        private void txtkategorija_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtkategorija.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtkategorija, "Внесете валидна вредност!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtkategorija, "");

            }
        }

        private void txtcena_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcena.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtcena, "Внесете валидна вредност!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtcena, "");

            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btndodadi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            // if (this.DialogResult == System.Windows.Forms.DialogResult.OK) {
            try
            {
                Product p = new Product(txtime.Text, txtkategorija.Text, float.Parse(txtcena.Text));
                this.prod = new ProductItem(p, Int32.Parse(txtdostapno.Text));
                this.Close();
            }
            catch (Exception ex) {
                
            }
           // }
        }

        private void btnotkazi_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
        }

        private void txtdostapno_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtdostapno.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtdostapno, "Внесете валидна вредност!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtdostapno, "");

            }
        }
    }
}
