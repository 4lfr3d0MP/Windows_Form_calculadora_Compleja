using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Numerics;
using info.lundin.math;

namespace WFCalcular
{
    public partial class Form1 : Form
    {
        double x, y, r;
        Complex z1, z2, rz;
        string fx, fxy;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonFirma_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_Mendoza.exe");
        }

        private void buttonExp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Exp(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonLog_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Log(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonResta_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            y = double.Parse(tBoxDato2.Text);
            r = x - y;
            lBoxSalida.Items.Add(r);
        }

        private void buttonMiltiplicacion_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            y = double.Parse(tBoxDato2.Text);
            r = x * y;
            lBoxSalida.Items.Add(r);
        }

        private void buttonDivision_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            y = double.Parse(tBoxDato2.Text);
            r = x / y;
            lBoxSalida.Items.Add(r);
        }

        private void buttonSen_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Sin(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonCos_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Cos(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonTan_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Tan(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonCuadrado_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Pow(x,2);
            lBoxSalida.Items.Add(r);
        }

        private void buttonCubo_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Pow(x, 3);
            lBoxSalida.Items.Add(r);
        }

        private void buttonArcSen_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Asin(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonArcCos_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Acos(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonArcTan_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Atan(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonInversa_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = 1 / x;
            lBoxSalida.Items.Add(r);
        }

        private void buttonXexpY_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            y = double.Parse(tBoxDato2.Text);
            r = Math.Pow(x, y);
            lBoxSalida.Items.Add(r);
        }

        private void buttonRaiz2_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Sqrt(x);
            lBoxSalida.Items.Add(r);
        }

        private void button2expx_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Pow(2, x);
            lBoxSalida.Items.Add(r);
        }

        private void button10expX_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Pow(10, x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonCalculadoraIng_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WFCircuito.exe");
        }

        private void buttonLog10_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            r = Math.Log10(x);
            lBoxSalida.Items.Add(r);
        }

        private void buttonSuma_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxDato1.Text);
            y = double.Parse(tBoxDato2.Text);
            r = x + y;
            lBoxSalida.Items.Add(r);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Funciones para los complejos

        private void btSumaComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);

            x = double.Parse(tBReal2.Text);
            y = double.Parse(tBImag2.Text);
            z2 = new Complex(x, y);

            rz = Complex.Add(z1, z2);
            lBComSalida.Items.Add(rz);
        }

        private void btExpCom_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Exp(z1);
            lBComSalida.Items.Add(rz);
        }

        private void btRestaComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);

            x = double.Parse(tBReal2.Text);
            y = double.Parse(tBImag2.Text);
            z2 = new Complex(x, y);

            rz = Complex.Subtract(z1, z2);
            lBComSalida.Items.Add(rz);
        }

        private void btMagnitud_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Abs(z1);
            lBComSalida.Items.Add(rz);
        }

        private void btRaiz2Comp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Sqrt(z1);
            lBComSalida.Items.Add(rz);
        }

        private void btPolarComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBoxMagPolar.Text);
            y = double.Parse(tBoxFasePolar.Text);
            rz = Complex.FromPolarCoordinates(x, y);
            lBComSalida.Items.Add(rz);
        }

        private void btReciproco_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Reciprocal(z1);
            lBComSalida.Items.Add(rz);
        }

        private void btNegComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Negate(z1);
            lBComSalida.Items.Add(rz);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("WPF_Mendoza.exe");
        }

        private void tBoxDato1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btSenComp_Click(object sender, EventArgs e)
        {

        }

        private void btArcSenComp_Click(object sender, EventArgs e)
        {
        }

        private void btCosComp_Click(object sender, EventArgs e)
        {

        }

        private void btArcTanComp_Click(object sender, EventArgs e)
        {

        }

        private void btTanComp_Click(object sender, EventArgs e)
        {

        }

        private void btMultiComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);

            x = double.Parse(tBReal2.Text);
            y = double.Parse(tBImag2.Text);
            z2 = new Complex(x, y);

            rz = Complex.Multiply(z1, z2);
            lBComSalida.Items.Add(rz);
        }

        private void btDivComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);

            x = double.Parse(tBReal2.Text);
            y = double.Parse(tBImag2.Text);
            z2 = new Complex(x, y);

            rz = Complex.Divide(z1, z2);
            lBComSalida.Items.Add(rz);
        }

        private void btLogComp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Log(z1);
            lBComSalida.Items.Add(rz);
        }

        private void btLog10Comp_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Log10(z1);
            lBComSalida.Items.Add(rz);
        }

        private void btConjugado_Click(object sender, EventArgs e)
        {
            x = double.Parse(tBReal1.Text);
            y = double.Parse(tBImag1.Text);
            z1 = new Complex(x, y);
            rz = Complex.Conjugate(z1);
            lBComSalida.Items.Add(rz);
        }

    }
}
