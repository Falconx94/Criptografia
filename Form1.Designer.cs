namespace Criptografia
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
            this.Btn_Rijndael = new System.Windows.Forms.Button();
            this.TxB_Texto = new System.Windows.Forms.TextBox();
            this.TxB_Clave = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxB_Resultado_Rinjdael = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Btn_Rijndael
            // 
            this.Btn_Rijndael.Location = new System.Drawing.Point(24, 174);
            this.Btn_Rijndael.Name = "Btn_Rijndael";
            this.Btn_Rijndael.Size = new System.Drawing.Size(75, 23);
            this.Btn_Rijndael.TabIndex = 0;
            this.Btn_Rijndael.Text = "RijnDael";
            this.Btn_Rijndael.UseVisualStyleBackColor = true;
            this.Btn_Rijndael.Click += new System.EventHandler(this.Btn_Rijndael_Click);
            // 
            // TxB_Texto
            // 
            this.TxB_Texto.Location = new System.Drawing.Point(47, 48);
            this.TxB_Texto.Name = "TxB_Texto";
            this.TxB_Texto.Size = new System.Drawing.Size(390, 20);
            this.TxB_Texto.TabIndex = 1;
            // 
            // TxB_Clave
            // 
            this.TxB_Clave.Location = new System.Drawing.Point(47, 105);
            this.TxB_Clave.Name = "TxB_Clave";
            this.TxB_Clave.Size = new System.Drawing.Size(390, 20);
            this.TxB_Clave.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Texto a Encriptar:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Clave de encriptado:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cifrado Rijndael:";
            // 
            // TxB_Resultado_Rinjdael
            // 
            this.TxB_Resultado_Rinjdael.Location = new System.Drawing.Point(47, 253);
            this.TxB_Resultado_Rinjdael.Name = "TxB_Resultado_Rinjdael";
            this.TxB_Resultado_Rinjdael.Size = new System.Drawing.Size(390, 20);
            this.TxB_Resultado_Rinjdael.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxB_Resultado_Rinjdael);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxB_Clave);
            this.Controls.Add(this.TxB_Texto);
            this.Controls.Add(this.Btn_Rijndael);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Btn_Rijndael;
        private System.Windows.Forms.TextBox TxB_Texto;
        private System.Windows.Forms.TextBox TxB_Clave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxB_Resultado_Rinjdael;
    }
}

