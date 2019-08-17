namespace rentAcar
{
    partial class Home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.button_AdaugaMasina = new System.Windows.Forms.Button();
            this.button_lista = new System.Windows.Forms.Button();
            this.button_Modifica = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_AdaugaMasina
            // 
            this.button_AdaugaMasina.Location = new System.Drawing.Point(66, 265);
            this.button_AdaugaMasina.Name = "button_AdaugaMasina";
            this.button_AdaugaMasina.Size = new System.Drawing.Size(119, 54);
            this.button_AdaugaMasina.TabIndex = 0;
            this.button_AdaugaMasina.Text = "Add cars";
            this.button_AdaugaMasina.UseVisualStyleBackColor = true;
            this.button_AdaugaMasina.Click += new System.EventHandler(this.button_AdaugaMeniu_Click);
            // 
            // button_lista
            // 
            this.button_lista.Location = new System.Drawing.Point(282, 265);
            this.button_lista.Name = "button_lista";
            this.button_lista.Size = new System.Drawing.Size(119, 54);
            this.button_lista.TabIndex = 1;
            this.button_lista.Text = "Show cars";
            this.button_lista.UseVisualStyleBackColor = true;
            this.button_lista.Click += new System.EventHandler(this.button_lista_Click);
            // 
            // button_Modifica
            // 
            this.button_Modifica.Location = new System.Drawing.Point(66, 403);
            this.button_Modifica.Name = "button_Modifica";
            this.button_Modifica.Size = new System.Drawing.Size(119, 54);
            this.button_Modifica.TabIndex = 6;
            this.button_Modifica.Text = "Edit cars";
            this.button_Modifica.UseVisualStyleBackColor = true;
            this.button_Modifica.Click += new System.EventHandler(this.button_Modifica_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(282, 403);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 54);
            this.button1.TabIndex = 5;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(66, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 221);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(453, 496);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button_Modifica);
            this.Controls.Add(this.button_lista);
            this.Controls.Add(this.button_AdaugaMasina);
            this.Name = "Home";
            this.Text = "rentAcar";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button_AdaugaMasina;
        private System.Windows.Forms.Button button_lista;
        private System.Windows.Forms.Button button_Modifica;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}