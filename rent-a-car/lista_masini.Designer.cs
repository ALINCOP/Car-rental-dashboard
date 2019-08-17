namespace rentAcar
{
    partial class lista_masini
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
            this.meniuPic = new System.Windows.Forms.PictureBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comentariu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.textBox_TEST = new System.Windows.Forms.TextBox();
            this.buttonCauta = new System.Windows.Forms.Button();
            this.buttonLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meniuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // meniuPic
            // 
            this.meniuPic.Location = new System.Drawing.Point(579, 266);
            this.meniuPic.Name = "meniuPic";
            this.meniuPic.Size = new System.Drawing.Size(302, 239);
            this.meniuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meniuPic.TabIndex = 0;
            this.meniuPic.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.index,
            this.Denumire,
            this.Pret,
            this.comentariu});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(868, 248);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // index
            // 
            this.index.Text = "#";
            // 
            // Denumire
            // 
            this.Denumire.Text = "Models";
            this.Denumire.Width = 242;
            // 
            // Pret
            // 
            this.Pret.Text = "Price/day";
            this.Pret.Width = 100;
            // 
            // comentariu
            // 
            this.comentariu.Text = "Details";
            this.comentariu.Width = 465;
            // 
            // textBox_TEST
            // 
            this.textBox_TEST.Location = new System.Drawing.Point(12, 280);
            this.textBox_TEST.Multiline = true;
            this.textBox_TEST.Name = "textBox_TEST";
            this.textBox_TEST.Size = new System.Drawing.Size(236, 36);
            this.textBox_TEST.TabIndex = 2;
            // 
            // buttonCauta
            // 
            this.buttonCauta.Location = new System.Drawing.Point(254, 280);
            this.buttonCauta.Name = "buttonCauta";
            this.buttonCauta.Size = new System.Drawing.Size(129, 36);
            this.buttonCauta.TabIndex = 3;
            this.buttonCauta.Text = "Search";
            this.buttonCauta.UseVisualStyleBackColor = true;
            this.buttonCauta.Click += new System.EventHandler(this.buttonCauta_Click);
            // 
            // buttonLista
            // 
            this.buttonLista.Location = new System.Drawing.Point(12, 343);
            this.buttonLista.Name = "buttonLista";
            this.buttonLista.Size = new System.Drawing.Size(129, 36);
            this.buttonLista.TabIndex = 4;
            this.buttonLista.Text = "View Cars";
            this.buttonLista.UseVisualStyleBackColor = true;
            this.buttonLista.Click += new System.EventHandler(this.buttonLista_Click);
            // 
            // lista_masini
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(893, 517);
            this.Controls.Add(this.buttonLista);
            this.Controls.Add(this.buttonCauta);
            this.Controls.Add(this.textBox_TEST);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.meniuPic);
            this.Name = "lista_masini";
            this.Text = "Cars for rent";
            this.Load += new System.EventHandler(this.lista_meniuri_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meniuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox meniuPic;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader index;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader comentariu;
        private System.Windows.Forms.TextBox textBox_TEST;
        private System.Windows.Forms.Button buttonCauta;
        private System.Windows.Forms.Button buttonLista;
    }
}