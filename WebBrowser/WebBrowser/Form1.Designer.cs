namespace WebBrowser
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.btatras = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btIR = new System.Windows.Forms.Button();
            this.btFavs = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.btFavs);
            this.panel1.Controls.Add(this.btIR);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.btatras);
            this.panel1.Location = new System.Drawing.Point(1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(796, 56);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel1_Paint);
            // 
            // webBrowser1
            // 
            this.webBrowser1.Location = new System.Drawing.Point(1, 55);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(796, 386);
            this.webBrowser1.TabIndex = 1;
            // 
            // btatras
            // 
            this.btatras.Location = new System.Drawing.Point(8, 17);
            this.btatras.Name = "btatras";
            this.btatras.Size = new System.Drawing.Size(55, 21);
            this.btatras.TabIndex = 0;
            this.btatras.Text = "Atras";
            this.btatras.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 18);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(456, 20);
            this.textBox1.TabIndex = 1;
            // 
            // btIR
            // 
            this.btIR.Location = new System.Drawing.Point(537, 18);
            this.btIR.Name = "btIR";
            this.btIR.Size = new System.Drawing.Size(75, 20);
            this.btIR.TabIndex = 2;
            this.btIR.Text = "Ir";
            this.btIR.UseVisualStyleBackColor = true;
            // 
            // btFavs
            // 
            this.btFavs.Location = new System.Drawing.Point(671, 0);
            this.btFavs.Name = "btFavs";
            this.btFavs.Size = new System.Drawing.Size(125, 20);
            this.btFavs.TabIndex = 3;
            this.btFavs.Text = "Agregar Favoritos";
            this.btFavs.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(671, 26);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(124, 21);
            this.comboBox1.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.webBrowser1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Web  Browser";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btFavs;
        private System.Windows.Forms.Button btIR;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btatras;
    }
}

