namespace rentAcar
{
    partial class Modifica
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
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Denumire = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Pret = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Descriere = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonModifica = new System.Windows.Forms.Button();
            this.textBoxDenumire = new System.Windows.Forms.TextBox();
            this.textBoxPret = new System.Windows.Forms.TextBox();
            this.textBoxDescriere = new System.Windows.Forms.TextBox();
            this.buttonSalveaza = new System.Windows.Forms.Button();
            this.buttonSterge = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.meniuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // meniuPic
            // 
            this.meniuPic.Location = new System.Drawing.Point(13, 288);
            this.meniuPic.Name = "meniuPic";
            this.meniuPic.Size = new System.Drawing.Size(205, 223);
            this.meniuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meniuPic.TabIndex = 0;
            this.meniuPic.TabStop = false;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.Denumire,
            this.Pret,
            this.Descriere});
            this.listView1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(13, 12);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(813, 258);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ItemActivate += new System.EventHandler(this.listView1_ItemActivate);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "#";
            // 
            // Denumire
            // 
            this.Denumire.Text = "Models";
            this.Denumire.Width = 234;
            // 
            // Pret
            // 
            this.Pret.Text = "Price/day";
            this.Pret.Width = 94;
            // 
            // Descriere
            // 
            this.Descriere.Text = "Details";
            this.Descriere.Width = 395;
            // 
            // buttonModifica
            // 
            this.buttonModifica.Location = new System.Drawing.Point(718, 298);
            this.buttonModifica.Name = "buttonModifica";
            this.buttonModifica.Size = new System.Drawing.Size(84, 35);
            this.buttonModifica.TabIndex = 2;
            this.buttonModifica.Text = "Edit";
            this.buttonModifica.UseVisualStyleBackColor = true;
            this.buttonModifica.Click += new System.EventHandler(this.buttonModifica_Click);
            // 
            // textBoxDenumire
            // 
            this.textBoxDenumire.Location = new System.Drawing.Point(616, 357);
            this.textBoxDenumire.Name = "textBoxDenumire";
            this.textBoxDenumire.Size = new System.Drawing.Size(186, 22);
            this.textBoxDenumire.TabIndex = 3;
            this.textBoxDenumire.Visible = false;
            // 
            // textBoxPret
            // 
            this.textBoxPret.Location = new System.Drawing.Point(616, 403);
            this.textBoxPret.Name = "textBoxPret";
            this.textBoxPret.Size = new System.Drawing.Size(186, 22);
            this.textBoxPret.TabIndex = 4;
            this.textBoxPret.Visible = false;
            // 
            // textBoxDescriere
            // 
            this.textBoxDescriere.Location = new System.Drawing.Point(616, 441);
            this.textBoxDescriere.Name = "textBoxDescriere";
            this.textBoxDescriere.Size = new System.Drawing.Size(186, 22);
            this.textBoxDescriere.TabIndex = 5;
            this.textBoxDescriere.Visible = false;
            // 
            // buttonSalveaza
            // 
            this.buttonSalveaza.Location = new System.Drawing.Point(718, 476);
            this.buttonSalveaza.Name = "buttonSalveaza";
            this.buttonSalveaza.Size = new System.Drawing.Size(84, 35);
            this.buttonSalveaza.TabIndex = 6;
            this.buttonSalveaza.Text = "Save";
            this.buttonSalveaza.UseVisualStyleBackColor = true;
            this.buttonSalveaza.Visible = false;
            this.buttonSalveaza.Click += new System.EventHandler(this.buttonSalveaza_Click);
            // 
            // buttonSterge
            // 
            this.buttonSterge.Location = new System.Drawing.Point(616, 298);
            this.buttonSterge.Name = "buttonSterge";
            this.buttonSterge.Size = new System.Drawing.Size(84, 35);
            this.buttonSterge.TabIndex = 7;
            this.buttonSterge.Text = "Delete";
            this.buttonSterge.UseVisualStyleBackColor = true;
            this.buttonSterge.Click += new System.EventHandler(this.buttonSterge_Click);
            // 
            // Modifica
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 523);
            this.Controls.Add(this.buttonSterge);
            this.Controls.Add(this.buttonSalveaza);
            this.Controls.Add(this.textBoxDescriere);
            this.Controls.Add(this.textBoxPret);
            this.Controls.Add(this.textBoxDenumire);
            this.Controls.Add(this.buttonModifica);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.meniuPic);
            this.Name = "Modifica";
            this.Text = "rentAcar - Edit Cars";
            this.Load += new System.EventHandler(this.Modifica_Load);
            ((System.ComponentModel.ISupportInitialize)(this.meniuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox meniuPic;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader Denumire;
        private System.Windows.Forms.ColumnHeader Pret;
        private System.Windows.Forms.ColumnHeader Descriere;
        private System.Windows.Forms.Button buttonModifica;
        private System.Windows.Forms.TextBox textBoxDenumire;
        private System.Windows.Forms.TextBox textBoxPret;
        private System.Windows.Forms.TextBox textBoxDescriere;
        private System.Windows.Forms.Button buttonSalveaza;
        private System.Windows.Forms.Button buttonSterge;
    }
}