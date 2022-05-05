using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aula71_ExercicioIMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double peso = double.Parse(txtPeso.Text);
            double altura = double.Parse(txtAltura.Text);

            IMC imc = new IMC();

            imc.Peso = peso;
            imc.Altura = altura;

            lblResultado.Text = imc.CalculoIMC().ToString("F2");

            if (imc.CalculoIMC() < 16)
                lblResultado2.Text = "Magreza Grau III";
            else if (imc.CalculoIMC() >= 16 && imc.CalculoIMC() <= 16.9)
                lblResultado2.Text = "Magreza Grau II";
            else if (imc.CalculoIMC() >= 17 && imc.CalculoIMC() <= 18.4)
                lblResultado2.Text = "Magreza Grau I";
            else if (imc.CalculoIMC() >= 18.5 && imc.CalculoIMC() <= 24.9)
                lblResultado2.Text = "Normal";
            else if (imc.CalculoIMC() >= 25.0 && imc.CalculoIMC() <= 29.9)
                lblResultado2.Text = "Pré-Obesidade";
            else if (imc.CalculoIMC() >= 30 && imc.CalculoIMC() <= 34.9)
                lblResultado2.Text = "Obesidade Moderada (Grau I)";
            else if (imc.CalculoIMC() >= 35 && imc.CalculoIMC() <= 39.9)
                lblResultado2.Text = "Obesidade Severa (Grau II)";
            else if (imc.CalculoIMC() > 40.0)
                lblResultado2.Text = "Obesidade Muito Severa (Grau III)";
        }
    }
}
