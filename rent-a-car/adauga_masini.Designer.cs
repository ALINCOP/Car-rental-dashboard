namespace rentAcar
{
    partial class adauga_masina
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
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_numeMasina = new System.Windows.Forms.TextBox();
            this.textBox_Pret = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.meniuPic = new System.Windows.Forms.PictureBox();
            this.button_save = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_Comentariu = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.meniuPic)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(469, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Model";
            // 
            // textBox_numeMasina
            // 
            this.textBox_numeMasina.Location = new System.Drawing.Point(473, 63);
            this.textBox_numeMasina.Multiline = true;
            this.textBox_numeMasina.Name = "textBox_numeMasina";
            this.textBox_numeMasina.Size = new System.Drawing.Size(158, 22);
            this.textBox_numeMasina.TabIndex = 1;
            // 
            // textBox_Pret
            // 
            this.textBox_Pret.Location = new System.Drawing.Point(473, 113);
            this.textBox_Pret.Name = "textBox_Pret";
            this.textBox_Pret.Size = new System.Drawing.Size(158, 22);
            this.textBox_Pret.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(469, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 22);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price/per day";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(25, 259);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 37);
            this.button1.TabIndex = 5;
            this.button1.Text = "Browse image";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // meniuPic
            // 
            this.meniuPic.Location = new System.Drawing.Point(25, 27);
            this.meniuPic.Name = "meniuPic";
            this.meniuPic.Size = new System.Drawing.Size(230, 203);
            this.meniuPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.meniuPic.TabIndex = 4;
            this.meniuPic.TabStop = false;
            this.meniuPic.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button_save
            // 
            this.button_save.Location = new System.Drawing.Point(473, 338);
            this.button_save.Name = "button_save";
            this.button_save.Size = new System.Drawing.Size(86, 37);
            this.button_save.TabIndex = 6;
            this.button_save.Text = "Save";
            this.button_save.UseVisualStyleBackColor = true;
            this.button_save.Click += new System.EventHandler(this.button_save_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(469, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 7;
            this.label3.Text = "Details:";
            // 
            // textBox_Comentariu
            // 
            this.textBox_Comentariu.Location = new System.Drawing.Point(473, 165);
            this.textBox_Comentariu.Multiline = true;
            this.textBox_Comentariu.Name = "textBox_Comentariu";
            this.textBox_Comentariu.Size = new System.Drawing.Size(158, 151);
            this.textBox_Comentariu.TabIndex = 8;
            // 
            // adauga_masina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 426);
            this.Controls.Add(this.textBox_Comentariu);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button_save);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.meniuPic);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox_Pret);
            this.Controls.Add(this.textBox_numeMasina);
            this.Controls.Add(this.label1);
            this.Name = "adauga_masina";
            this.RightToLeftLayout = true;
            this.Text = "rentAcar - Add Cars";
            ((System.ComponentModel.ISupportInitialize)(this.meniuPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_numeMasina;
        private System.Windows.Forms.TextBox textBox_Pret;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox meniuPic;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button_save;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_Comentariu;
    }
}