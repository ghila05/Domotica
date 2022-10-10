namespace class_telecomando
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.butn_accendi = new System.Windows.Forms.Button();
            this.butn_spegni = new System.Windows.Forms.Button();
            this.butn_alzavol = new System.Windows.Forms.Button();
            this.butn_abbassavol = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labl_canale = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.butn_vaicanale = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butn_accendi
            // 
            this.butn_accendi.Location = new System.Drawing.Point(71, 20);
            this.butn_accendi.Name = "butn_accendi";
            this.butn_accendi.Size = new System.Drawing.Size(75, 23);
            this.butn_accendi.TabIndex = 0;
            this.butn_accendi.Text = "Accendi";
            this.butn_accendi.UseVisualStyleBackColor = true;
            this.butn_accendi.Click += new System.EventHandler(this.button1_Click);
            // 
            // butn_spegni
            // 
            this.butn_spegni.Location = new System.Drawing.Point(205, 20);
            this.butn_spegni.Name = "butn_spegni";
            this.butn_spegni.Size = new System.Drawing.Size(75, 23);
            this.butn_spegni.TabIndex = 1;
            this.butn_spegni.Text = "Spegni";
            this.butn_spegni.UseVisualStyleBackColor = true;
            this.butn_spegni.Click += new System.EventHandler(this.butn_spegni_Click);
            // 
            // butn_alzavol
            // 
            this.butn_alzavol.BackColor = System.Drawing.Color.Transparent;
            this.butn_alzavol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butn_alzavol.BackgroundImage")));
            this.butn_alzavol.Location = new System.Drawing.Point(30, 156);
            this.butn_alzavol.Name = "butn_alzavol";
            this.butn_alzavol.Size = new System.Drawing.Size(46, 54);
            this.butn_alzavol.TabIndex = 3;
            this.butn_alzavol.UseVisualStyleBackColor = false;
            this.butn_alzavol.Visible = false;
            this.butn_alzavol.Click += new System.EventHandler(this.butn_alzavol_Click);
            // 
            // butn_abbassavol
            // 
            this.butn_abbassavol.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("butn_abbassavol.BackgroundImage")));
            this.butn_abbassavol.Location = new System.Drawing.Point(30, 216);
            this.butn_abbassavol.Name = "butn_abbassavol";
            this.butn_abbassavol.Size = new System.Drawing.Size(45, 39);
            this.butn_abbassavol.TabIndex = 4;
            this.butn_abbassavol.UseVisualStyleBackColor = true;
            this.butn_abbassavol.Visible = false;
            this.butn_abbassavol.Click += new System.EventHandler(this.butn_abbassavol_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 5;
            this.label1.Text = "Volume: 0";
            // 
            // labl_canale
            // 
            this.labl_canale.AutoSize = true;
            this.labl_canale.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labl_canale.Location = new System.Drawing.Point(147, 81);
            this.labl_canale.Name = "labl_canale";
            this.labl_canale.Size = new System.Drawing.Size(59, 15);
            this.labl_canale.TabIndex = 6;
            this.labl_canale.Text = "Canale: 0";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(122, 174);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 7;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(119, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "inserisci canale";
            this.label2.Visible = false;
            // 
            // butn_vaicanale
            // 
            this.butn_vaicanale.Location = new System.Drawing.Point(123, 209);
            this.butn_vaicanale.Name = "butn_vaicanale";
            this.butn_vaicanale.Size = new System.Drawing.Size(75, 23);
            this.butn_vaicanale.TabIndex = 9;
            this.butn_vaicanale.UseVisualStyleBackColor = true;
            this.butn_vaicanale.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(250, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Stato: Off";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(362, 286);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.butn_vaicanale);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labl_canale);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butn_abbassavol);
            this.Controls.Add(this.butn_alzavol);
            this.Controls.Add(this.butn_accendi);
            this.Controls.Add(this.butn_spegni);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butn_accendi;
        private System.Windows.Forms.Button butn_spegni;
        private System.Windows.Forms.Button butn_alzavol;
        private System.Windows.Forms.Button butn_abbassavol;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labl_canale;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button butn_vaicanale;
        private System.Windows.Forms.Label label3;
    }
}

