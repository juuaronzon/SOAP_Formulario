using System;
using System.Linq;
using System.Windows.Forms;

namespace FORMSOAP

{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SOAP.TipoCambio client = new SOAP.TipoCambio();

            var respuesta = client.TipoCambioDia();

            txt_1.Text=(respuesta.CambioDolar.First().fecha);

            txt_2.Text=(respuesta.CambioDolar.First().referencia).ToString();
        }
    }
}
