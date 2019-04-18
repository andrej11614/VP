namespace Lab_04
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.lblime = new System.Windows.Forms.Label();
            this.txtime = new System.Windows.Forms.TextBox();
            this.lblkategorija = new System.Windows.Forms.Label();
            this.txtkategorija = new System.Windows.Forms.TextBox();
            this.lblcena = new System.Windows.Forms.Label();
            this.txtcena = new System.Windows.Forms.TextBox();
            this.btnotkazi = new System.Windows.Forms.Button();
            this.btndodadi = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lbldostapno = new System.Windows.Forms.Label();
            this.txtdostapno = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblime
            // 
            this.lblime.AutoSize = true;
            this.lblime.Location = new System.Drawing.Point(12, 20);
            this.lblime.Name = "lblime";
            this.lblime.Size = new System.Drawing.Size(29, 13);
            this.lblime.TabIndex = 0;
            this.lblime.Text = "Име";
            // 
            // txtime
            // 
            this.txtime.Location = new System.Drawing.Point(13, 37);
            this.txtime.Name = "txtime";
            this.txtime.Size = new System.Drawing.Size(300, 20);
            this.txtime.TabIndex = 1;
            this.txtime.Validating += new System.ComponentModel.CancelEventHandler(this.txtime_Validating);
            // 
            // lblkategorija
            // 
            this.lblkategorija.AutoSize = true;
            this.lblkategorija.Location = new System.Drawing.Point(13, 71);
            this.lblkategorija.Name = "lblkategorija";
            this.lblkategorija.Size = new System.Drawing.Size(62, 13);
            this.lblkategorija.TabIndex = 2;
            this.lblkategorija.Text = "Категорија";
            // 
            // txtkategorija
            // 
            this.txtkategorija.Location = new System.Drawing.Point(12, 87);
            this.txtkategorija.Name = "txtkategorija";
            this.txtkategorija.Size = new System.Drawing.Size(300, 20);
            this.txtkategorija.TabIndex = 3;
            this.txtkategorija.Validating += new System.ComponentModel.CancelEventHandler(this.txtkategorija_Validating);
            // 
            // lblcena
            // 
            this.lblcena.AutoSize = true;
            this.lblcena.Location = new System.Drawing.Point(12, 124);
            this.lblcena.Name = "lblcena";
            this.lblcena.Size = new System.Drawing.Size(33, 13);
            this.lblcena.TabIndex = 4;
            this.lblcena.Text = "Цена";
            // 
            // txtcena
            // 
            this.txtcena.Location = new System.Drawing.Point(12, 140);
            this.txtcena.Name = "txtcena";
            this.txtcena.Size = new System.Drawing.Size(150, 20);
            this.txtcena.TabIndex = 5;
            this.txtcena.Validating += new System.ComponentModel.CancelEventHandler(this.txtcena_Validating);
            // 
            // btnotkazi
            // 
            this.btnotkazi.CausesValidation = false;
            this.btnotkazi.Location = new System.Drawing.Point(150, 237);
            this.btnotkazi.Name = "btnotkazi";
            this.btnotkazi.Size = new System.Drawing.Size(75, 23);
            this.btnotkazi.TabIndex = 7;
            this.btnotkazi.Text = "Откажи";
            this.btnotkazi.UseVisualStyleBackColor = true;
            this.btnotkazi.Click += new System.EventHandler(this.btnotkazi_Click);
            // 
            // btndodadi
            // 
            this.btndodadi.Location = new System.Drawing.Point(238, 237);
            this.btndodadi.Name = "btndodadi";
            this.btndodadi.Size = new System.Drawing.Size(75, 23);
            this.btndodadi.TabIndex = 8;
            this.btndodadi.Text = "Додади";
            this.btndodadi.UseVisualStyleBackColor = true;
            this.btndodadi.Click += new System.EventHandler(this.btndodadi_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // lbldostapno
            // 
            this.lbldostapno.AutoSize = true;
            this.lbldostapno.Location = new System.Drawing.Point(10, 180);
            this.lbldostapno.Name = "lbldostapno";
            this.lbldostapno.Size = new System.Drawing.Size(57, 13);
            this.lbldostapno.TabIndex = 8;
            this.lbldostapno.Text = "Достапно";
            // 
            // txtdostapno
            // 
            this.txtdostapno.Location = new System.Drawing.Point(12, 196);
            this.txtdostapno.Name = "txtdostapno";
            this.txtdostapno.Size = new System.Drawing.Size(150, 20);
            this.txtdostapno.TabIndex = 6;
            this.txtdostapno.Validating += new System.ComponentModel.CancelEventHandler(this.txtdostapno_Validating);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(327, 268);
            this.Controls.Add(this.txtdostapno);
            this.Controls.Add(this.lbldostapno);
            this.Controls.Add(this.btndodadi);
            this.Controls.Add(this.btnotkazi);
            this.Controls.Add(this.txtcena);
            this.Controls.Add(this.lblcena);
            this.Controls.Add(this.txtkategorija);
            this.Controls.Add(this.lblkategorija);
            this.Controls.Add(this.txtime);
            this.Controls.Add(this.lblime);
            this.Name = "Form2";
            this.Text = "Нов продукт";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblime;
        private System.Windows.Forms.TextBox txtime;
        private System.Windows.Forms.Label lblkategorija;
        private System.Windows.Forms.TextBox txtkategorija;
        private System.Windows.Forms.Label lblcena;
        private System.Windows.Forms.TextBox txtcena;
        private System.Windows.Forms.Button btnotkazi;
        private System.Windows.Forms.Button btndodadi;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox txtdostapno;
        private System.Windows.Forms.Label lbldostapno;
    }
}