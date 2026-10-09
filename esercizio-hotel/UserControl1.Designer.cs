namespace esercizio_hotel
{
    partial class UserControl1
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

        #region Codice generato da Progettazione componenti

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare 
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserControl1));
            this.btn_invia = new System.Windows.Forms.Button();
            this.lbl_n1 = new System.Windows.Forms.Label();
            this.chk_n1 = new System.Windows.Forms.CheckBox();
            this.cmb_n1 = new System.Windows.Forms.ComboBox();
            this.lbl_n2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cmb_n2 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_n3 = new System.Windows.Forms.Label();
            this.cmb_n3 = new System.Windows.Forms.ComboBox();
            this.lbl_n4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_invia
            // 
            this.btn_invia.Location = new System.Drawing.Point(20, 281);
            this.btn_invia.Name = "btn_invia";
            this.btn_invia.Size = new System.Drawing.Size(75, 23);
            this.btn_invia.TabIndex = 0;
            this.btn_invia.Text = "INVIA";
            this.btn_invia.UseVisualStyleBackColor = true;
            this.btn_invia.Click += new System.EventHandler(this.btn_invia_Click);
            // 
            // lbl_n1
            // 
            this.lbl_n1.AutoSize = true;
            this.lbl_n1.Location = new System.Drawing.Point(14, 43);
            this.lbl_n1.Name = "lbl_n1";
            this.lbl_n1.Size = new System.Drawing.Size(232, 13);
            this.lbl_n1.TabIndex = 1;
            this.lbl_n1.Text = "Benvenuto all\'hotel, inserisci dati per unirti a noi!";
            this.lbl_n1.Click += new System.EventHandler(this.lbl_n1_Click);
            // 
            // chk_n1
            // 
            this.chk_n1.AutoSize = true;
            this.chk_n1.Location = new System.Drawing.Point(310, 175);
            this.chk_n1.Name = "chk_n1";
            this.chk_n1.Size = new System.Drawing.Size(128, 17);
            this.chk_n1.TabIndex = 3;
            this.chk_n1.Text = "parcheggio compreso";
            this.chk_n1.UseVisualStyleBackColor = true;
            // 
            // cmb_n1
            // 
            this.cmb_n1.FormattingEnabled = true;
            this.cmb_n1.Items.AddRange(new object[] {
            "2 giorni",
            "3-7 giorni",
            "7+ giorni"});
            this.cmb_n1.Location = new System.Drawing.Point(20, 89);
            this.cmb_n1.Name = "cmb_n1";
            this.cmb_n1.Size = new System.Drawing.Size(121, 21);
            this.cmb_n1.TabIndex = 4;
            this.cmb_n1.Text = "seleziona giorni";
            this.cmb_n1.SelectedIndexChanged += new System.EventHandler(this.cmb_n1_SelectedIndexChanged);
            // 
            // lbl_n2
            // 
            this.lbl_n2.AutoSize = true;
            this.lbl_n2.Location = new System.Drawing.Point(17, 73);
            this.lbl_n2.Name = "lbl_n2";
            this.lbl_n2.Size = new System.Drawing.Size(135, 13);
            this.lbl_n2.TabIndex = 5;
            this.lbl_n2.Text = "Quanti giorni vorresti stare?";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(310, 43);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(182, 112);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // cmb_n2
            // 
            this.cmb_n2.FormattingEnabled = true;
            this.cmb_n2.Items.AddRange(new object[] {
            "base",
            "media",
            "alta"});
            this.cmb_n2.Location = new System.Drawing.Point(20, 161);
            this.cmb_n2.Name = "cmb_n2";
            this.cmb_n2.Size = new System.Drawing.Size(121, 21);
            this.cmb_n2.TabIndex = 7;
            this.cmb_n2.Text = "seleziona stanza";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 142);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Che tipo di stanza vorresti prenotare?";
            // 
            // lbl_n3
            // 
            this.lbl_n3.AutoSize = true;
            this.lbl_n3.Location = new System.Drawing.Point(20, 214);
            this.lbl_n3.Name = "lbl_n3";
            this.lbl_n3.Size = new System.Drawing.Size(179, 13);
            this.lbl_n3.TabIndex = 9;
            this.lbl_n3.Text = "In quale stagione vorresti prenotare?";
            // 
            // cmb_n3
            // 
            this.cmb_n3.FormattingEnabled = true;
            this.cmb_n3.Items.AddRange(new object[] {
            "bassa stagione",
            "media stagione",
            "alta stagione"});
            this.cmb_n3.Location = new System.Drawing.Point(23, 231);
            this.cmb_n3.Name = "cmb_n3";
            this.cmb_n3.Size = new System.Drawing.Size(121, 21);
            this.cmb_n3.TabIndex = 10;
            this.cmb_n3.Text = "seleziona stagione";
            // 
            // lbl_n4
            // 
            this.lbl_n4.AutoSize = true;
            this.lbl_n4.Location = new System.Drawing.Point(307, 195);
            this.lbl_n4.Name = "lbl_n4";
            this.lbl_n4.Size = new System.Drawing.Size(185, 13);
            this.lbl_n4.TabIndex = 11;
            this.lbl_n4.Text = "C\'è un\'aggiunta di 5€/g, senza sconti.";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_n4);
            this.Controls.Add(this.cmb_n3);
            this.Controls.Add(this.lbl_n3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmb_n2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_n2);
            this.Controls.Add(this.cmb_n1);
            this.Controls.Add(this.chk_n1);
            this.Controls.Add(this.lbl_n1);
            this.Controls.Add(this.btn_invia);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(499, 307);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_invia;
        private System.Windows.Forms.Label lbl_n1;
        private System.Windows.Forms.CheckBox chk_n1;
        private System.Windows.Forms.ComboBox cmb_n1;
        private System.Windows.Forms.Label lbl_n2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox cmb_n2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_n3;
        private System.Windows.Forms.ComboBox cmb_n3;
        private System.Windows.Forms.Label lbl_n4;
    }
}
