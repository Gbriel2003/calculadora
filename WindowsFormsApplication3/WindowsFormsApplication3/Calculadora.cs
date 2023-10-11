using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Calculadora : Form
    {
        double primero;
        double segundo;
        string operacion;

        public Calculadora()
        {
            InitializeComponent();
        }

        Clases.Clasesuma obj = new Clases.Clasesuma();
        Clases.Claseresta obj1 = new Clases.Claseresta();
        Clases.Clasemulti obj2 = new Clases.Clasemulti();
        Clases.Clasedivi obj3 = new Clases.Clasedivi();


        private void button7_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "8";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            segundo = double.Parse(textopantalla.Text);

            double suma;
            double resta;
            double multiplicacion;
            double division;

            switch (operacion)
            {
                case "+":
                    suma = obj.sumar((primero), (segundo));
                    textopantalla.Text = suma.ToString();
                    break;
                case "-":
                    resta = obj1.restar((primero), (segundo));
                    textopantalla.Text = resta.ToString();
                    break;
                case "*":
                    multiplicacion = obj2.multiplicar((primero), (segundo));
                    textopantalla.Text = multiplicacion.ToString();
                    break;
                case "/":
                    division = obj3.dividir((primero), (segundo));
                    textopantalla.Text = division.ToString();
                    break;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            operacion = "+";
            primero = double.Parse(textopantalla.Text);
            textopantalla.Clear();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "0";
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "1";
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "2";
        }

        private void boton3_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "3";
        }

        private void boton4_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "4";
        }

        private void boton5_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "5";
        }

        private void boton6_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "6";
        }

        private void boton7_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "7";
        }

        private void boton9_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + "9";
        }

        private void botonpunto_Click(object sender, EventArgs e)
        {
            textopantalla.Text = textopantalla.Text + ".";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void botonresta_Click(object sender, EventArgs e)
        {
            operacion = "-";
            primero = double.Parse(textopantalla.Text);
            textopantalla.Clear();
        }

        private void botonmulti_Click(object sender, EventArgs e)
        {
            operacion = "*";
            primero = double.Parse(textopantalla.Text);
            textopantalla.Clear();
        }

        private void botondivi_Click(object sender, EventArgs e)
        {
            operacion = "/";
            primero = double.Parse(textopantalla.Text);
            textopantalla.Clear();
        }

        private void botonlimpiar_Click(object sender, EventArgs e)
        {
            textopantalla.Clear();
        }

        private void botonborrar_Click(object sender, EventArgs e)
        {
            if (textopantalla.Text.Length == 1)
                textopantalla.Text = "";
            else
                textopantalla.Text = textopantalla.Text.Substring(0, textopantalla.Text.Length - 1);
        }
    }
}
