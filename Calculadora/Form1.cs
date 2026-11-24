using System;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        // Variables solicitadas en el Paso 5 de la guía
        double primerNumero;
        double segundoNumero;
        double resultado;
        string operacion;
        bool limpiarPantalla = false;

        public Form1()
        {
            InitializeComponent();
        }

        // Paso 6: Método común para los botones numéricos
        private void AgregarNumero(string numero)
        {
            if (txtPantalla.Text == "0" || limpiarPantalla)
            {
                txtPantalla.Clear();
                limpiarPantalla = false;
            }
            txtPantalla.Text += numero;
        }

        private void BotonNumero_Click(object sender, EventArgs e)
        {
            Button boton = (Button)sender;
            AgregarNumero(boton.Text);
        }

        // Paso 7: Selección de operaciones con validación (Paso 10)
        private void btnSumar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = "+";
                limpiarPantalla = true;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido primero.");
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = "-";
                limpiarPantalla = true;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido primero.");
            }
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = "×";
                limpiarPantalla = true;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido primero.");
            }
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            if (double.TryParse(txtPantalla.Text, out primerNumero))
            {
                operacion = "÷";
                limpiarPantalla = true;
            }
            else
            {
                MessageBox.Show("Ingrese un número válido primero.");
            }
        }

        // Paso 8: Botón Igual con switch y control de errores
        private void btnIgual_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(operacion))
            {
                return;
            }

            if (limpiarPantalla || !double.TryParse(txtPantalla.Text, out segundoNumero))
            {
                MessageBox.Show("Ingrese el segundo número para completar la operación.");
                return;
            }

            switch (operacion)
            {
                case "+":
                    resultado = primerNumero + segundoNumero;
                    break;
                case "-":
                    resultado = primerNumero - segundoNumero;
                    break;
                case "×":
                    resultado = primerNumero * segundoNumero;
                    break;
                case "÷":
                    if (segundoNumero == 0)
                    {
                        MessageBox.Show("No es posible dividir para cero.");
                        txtPantalla.Clear();
                        primerNumero = 0;
                        segundoNumero = 0;
                        operacion = "";
                        return;
                    }
                    resultado = primerNumero / segundoNumero;
                    break;
            }

            txtPantalla.Text = resultado.ToString();
            operacion = "";
            limpiarPantalla = true;
        }

        // Paso 9: Botón Limpiar (C)
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtPantalla.Clear();
            primerNumero = 0;
            segundoNumero = 0;
            resultado = 0;
            operacion = "";
            limpiarPantalla = false;
        }
    }
}