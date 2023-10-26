using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AtividadePraticaPolimorfismo
{
    public partial class Form1 : Form
    {
        formaGeometrica fg = new formaGeometrica();
        formaGeometria2 fg2 = new formaGeometria2();

        int Base, Altura;

        private void entrada()
        {
            Base = int.Parse(txtBoxBase.Text);
            Altura = int.Parse(txtBoxAltura.Text);
        }

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            entrada();

            double Area = fg2.CalculaArea(Base, Altura);
            txtBoxArea.Text = Area.ToString();
        }

        private void btnRetangulo_Click(object sender, EventArgs e)
        {
            entrada();
            double Area = fg.CalculaArea(Base, Altura);
            txtBoxArea.Text = Area.ToString();
        }
    }
}
