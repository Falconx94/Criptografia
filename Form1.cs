using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Criptografia
{
    public partial class Form1 : Form
    {
        string cadenaOriginal;
        string clave = "hail"; // Reemplaza "miclave" por la clave que desees utilizar
        public Form1()
        {
            InitializeComponent();
        }
        #region Botones
        private void Btn_Rijndael_Click(object sender, EventArgs e)
        {
            Rijndael();
        }
        #endregion
        #region Funciones
        public void Rijndael()
        {
            cadenaOriginal = TxB_Texto.Text;
            if (cadenaOriginal.Length >= clave.Length)
            {
                string subcadena = cadenaOriginal.Substring(0, clave.Length);
                string cadenaEncriptada = "";

                for (int i = 0; i < clave.Length; i++)
                {
                    int asciiCadena = (int)subcadena[i];
                    int asciiClave = (int)clave[i];
                    int asciiResultado = asciiCadena ^ asciiClave;
                    cadenaEncriptada += BitConverter.ToString(new byte[] { (byte)asciiResultado });

                }
                TxB_Resultado_Rinjdael.Text = cadenaEncriptada;
            }
            else
            {
                MessageBox.Show("La longitud de la palabra debe ser mayor o igual que la longitud de la clave.", "Error de encriptación", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
    }
}
