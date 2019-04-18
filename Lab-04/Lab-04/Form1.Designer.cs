namespace Lab_04
{
    partial class Form1
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
            this.lbprodukti = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnisprazniprodukti = new System.Windows.Forms.Button();
            this.gbdetali = new System.Windows.Forms.GroupBox();
            this.lblime = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            this.lblkategorija = new System.Windows.Forms.Label();
            this.txtkategorija = new System.Windows.Forms.TextBox();
            this.lblcena = new System.Windows.Forms.Label();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.btndodadikosnicka = new System.Windows.Forms.Button();
            this.numkolicina = new System.Windows.Forms.NumericUpDown();
            this.btnizbrisikosnicka = new System.Windows.Forms.Button();
            this.btndodadiprodukt = new System.Windows.Forms.Button();
            this.btnizbrisiprodukt = new System.Windows.Forms.Button();
            this.lbkosnicka = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblvkupno = new System.Windows.Forms.Label();
            this.tbvkupno = new System.Windows.Forms.TextBox();
            this.btnispraznikosnicka = new System.Windows.Forms.Button();
            this.gbdetali.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numkolicina)).BeginInit();
            this.SuspendLayout();
            // 
            // lbprodukti
            // 
            this.lbprodukti.FormattingEnabled = true;
            this.lbprodukti.Location = new System.Drawing.Point(12, 41);
            this.lbprodukti.Name = "lbprodukti";
            this.lbprodukti.Size = new System.Drawing.Size(252, 368);
            this.lbprodukti.TabIndex = 0;
            this.lbprodukti.SelectedIndexChanged += new System.EventHandler(this.lbprodukti_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Листа на продукти";
            // 
            // btnisprazniprodukti
            // 
            this.btnisprazniprodukti.Location = new System.Drawing.Point(12, 415);
            this.btnisprazniprodukti.Name = "btnisprazniprodukti";
            this.btnisprazniprodukti.Size = new System.Drawing.Size(249, 23);
            this.btnisprazniprodukti.TabIndex = 2;
            this.btnisprazniprodukti.Text = "Испразни ја листата со продукти?";
            this.btnisprazniprodukti.UseVisualStyleBackColor = true;
            this.btnisprazniprodukti.Click += new System.EventHandler(this.btnisprazniprodukti_Click);
            // 
            // gbdetali
            // 
            this.gbdetali.Controls.Add(this.txtcena);
            this.gbdetali.Controls.Add(this.lblcena);
            this.gbdetali.Controls.Add(this.txtkategorija);
            this.gbdetali.Controls.Add(this.lblkategorija);
            this.gbdetali.Controls.Add(this.txtime);
            this.gbdetali.Controls.Add(this.lblime);
            this.gbdetali.Location = new System.Drawing.Point(270, 41);
            this.gbdetali.Name = "gbdetali";
            this.gbdetali.Size = new System.Drawing.Size(269, 184);
            this.gbdetali.TabIndex = 3;
            this.gbdetali.TabStop = false;
            this.gbdetali.Text = "Детали за продуктот";
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Location = new System.Drawing.Point(6, 30);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(29, 13);
            this.lblime.TabIndex = 0;
            this.lblime.Text = "Име";
            // 
            // txtime
            // 
            this.txtime.Enabled = false;
            this.txtime.Location = new System.Drawing.Point(6, 46);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(257, 20);
            this.txtime.TabIndex = 1;
            // 
            // lblkategorija
            // 
            this.lblkategorija.AutoSize = true;
            this.lblkategorija.Location = new System.Drawing.Point(6, 81);
            this.lblkategorija.Name = "lblkategorija";
            this.lblkategorija.Size = new System.Drawing.Size(62, 13);
            this.lblkategorija.TabIndex = 2;
            this.lblkategorija.Text = "Категорија";
            // 
            // txtkategorija
            // 
            this.txtkategorija.Enabled = false;
            this.txtkategorija.Location = new System.Drawing.Point(6, 97);
            this.txtkategorija.Name = "txtkategorija";
            this.txtkategorija.Size = new System.Drawing.Size(257, 20);
            this.txtkategorija.TabIndex = 3;
            // 
            // lblcena
            // 
            this.lblcena.AutoSize = true;
            this.lblcena.Location = new System.Drawing.Point(6, 130);
            this.lblcena.Name = "lblcena";
            this.lblcena.Size = new System.Drawing.Size(33, 13);
            this.lblcena.TabIndex = 4;
            this.lblcena.Text = "Цена";
            // 
            // txtcena
            // 
            this.txtcena.Enabled = false;
            this.txtcena.Location = new System.Drawing.Point(6, 147);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(129, 20);
            this.txtcena.TabIndex = 5;
            // 
            // btndodadikosnicka
            // 
            this.btndodadikosnicka.Location = new System.Drawing.Point(270, 234);
            this.btndodadikosnicka.Name = "btndodadikosnicka";
            this.btndodadikosnicka.Size = new System.Drawing.Size(167, 23);
            this.btndodadikosnicka.TabIndex = 4;
            this.btndodadikosnicka.Text = "Додади во кошничка>>";
            this.btndodadikosnicka.UseVisualStyleBackColor = true;
            this.btndodadikosnicka.Click += new System.EventHandler(this.btndodadikosnicka_Click);
            // 
            // numkolicina
            // 
            this.numkolicina.Location = new System.Drawing.Point(455, 234);
            this.numkolicina.Name = "numkolicina";
            this.numkolicina.Size = new System.Drawing.Size(84, 20);
            this.numkolicina.TabIndex = 5;
            // 
            // btnizbrisikosnicka
            // 
            this.btnizbrisikosnicka.Location = new System.Drawing.Point(270, 283);
            this.btnizbrisikosnicka.Name = "btnizbrisikosnicka";
            this.btnizbrisikosnicka.Size = new System.Drawing.Size(269, 23);
            this.btnizbrisikosnicka.TabIndex = 6;
            this.btnizbrisikosnicka.Text = "Избриши од кошничка";
            this.btnizbrisikosnicka.UseVisualStyleBackColor = true;
            this.btnizbrisikosnicka.Click += new System.EventHandler(this.btnizbrisikosnicka_Click);
            // 
            // btndodadiprodukt
            // 
            this.btndodadiprodukt.Location = new System.Drawing.Point(270, 329);
            this.btndodadiprodukt.Name = "btndodadiprodukt";
            this.btndodadiprodukt.Size = new System.Drawing.Size(269, 23);
            this.btndodadiprodukt.TabIndex = 7;
            this.btndodadiprodukt.Text = "Додади нов продукт";
            this.btndodadiprodukt.UseVisualStyleBackColor = true;
            this.btndodadiprodukt.Click += new System.EventHandler(this.btndodadiprodukt_Click);
            // 
            // btnizbrisiprodukt
            // 
            this.btnizbrisiprodukt.Location = new System.Drawing.Point(270, 375);
            this.btnizbrisiprodukt.Name = "btnizbrisiprodukt";
            this.btnizbrisiprodukt.Size = new System.Drawing.Size(269, 23);
            this.btnizbrisiprodukt.TabIndex = 8;
            this.btnizbrisiprodukt.Text = "Избриши продукт";
            this.btnizbrisiprodukt.UseVisualStyleBackColor = true;
            this.btnizbrisiprodukt.Click += new System.EventHandler(this.btnizbrisiprodukt_Click);
            // 
            // lbkosnicka
            // 
            this.lbkosnicka.FormattingEnabled = true;
            this.lbkosnicka.Location = new System.Drawing.Point(558, 41);
            this.lbkosnicka.Name = "lbkosnicka";
            this.lbkosnicka.Size = new System.Drawing.Size(230, 316);
            this.lbkosnicka.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(558, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Кошничка";
            // 
            // lblvkupno
            // 
            this.lblvkupno.AutoSize = true;
            this.lblvkupno.Location = new System.Drawing.Point(555, 380);
            this.lblvkupno.Name = "lblvkupno";
            this.lblvkupno.Size = new System.Drawing.Size(43, 13);
            this.lblvkupno.TabIndex = 11;
            this.lblvkupno.Text = "Вкупно";
            // 
            // tbvkupno
            // 
            this.tbvkupno.Location = new System.Drawing.Point(604, 377);
            this.tbvkupno.Name = "tbvkupno";
            this.tbvkupno.ReadOnly = true;
            this.tbvkupno.Size = new System.Drawing.Size(184, 20);
            this.tbvkupno.TabIndex = 12;
            // 
            // btnispraznikosnicka
            // 
            this.btnispraznikosnicka.Location = new System.Drawing.Point(558, 415);
            this.btnispraznikosnicka.Name = "btnispraznikosnicka";
            this.btnispraznikosnicka.Size = new System.Drawing.Size(230, 23);
            this.btnispraznikosnicka.TabIndex = 13;
            this.btnispraznikosnicka.Text = "Испразни ја кошничката?";
            this.btnispraznikosnicka.UseVisualStyleBackColor = true;
            this.btnispraznikosnicka.Click += new System.EventHandler(this.btnispraznikosnicka_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnispraznikosnicka);
            this.Controls.Add(this.tbvkupno);
            this.Controls.Add(this.lblvkupno);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbkosnicka);
            this.Controls.Add(this.btnizbrisiprodukt);
            this.Controls.Add(this.btndodadiprodukt);
            this.Controls.Add(this.btnizbrisikosnicka);
            this.Controls.Add(this.numkolicina);
            this.Controls.Add(this.btndodadikosnicka);
            this.Controls.Add(this.gbdetali);
            this.Controls.Add(this.btnisprazniprodukti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbprodukti);
            this.Name = "Form1";
            this.Text = "Потрошувачка кошничка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gbdetali.ResumeLayout(false);
            this.gbdetali.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numkolicina)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbprodukti;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnisprazniprodukti;
        private System.Windows.Forms.GroupBox gbdetali;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.Label lblcena;
        private System.Windows.Forms.TextBox txtkategorija;
        private System.Windows.Forms.Label lblkategorija;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.Label lblime;
        private System.Windows.Forms.Button btndodadikosnicka;
        private System.Windows.Forms.NumericUpDown numkolicina;
        private System.Windows.Forms.Button btnizbrisikosnicka;
        private System.Windows.Forms.Button btndodadiprodukt;
        private System.Windows.Forms.Button btnizbrisiprodukt;
        private System.Windows.Forms.ListBox lbkosnicka;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblvkupno;
        private System.Windows.Forms.TextBox tbvkupno;
        private System.Windows.Forms.Button btnispraznikosnicka;
    }
}

