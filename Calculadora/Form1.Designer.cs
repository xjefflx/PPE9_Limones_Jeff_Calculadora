namespace Calculadora
{
    partial class Form1
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
            txtPantalla = new TextBox();
            btn7 = new Button();
            btn8 = new Button();
            btn9 = new Button();
            btnDividir = new Button();
            btn4 = new Button();
            btn5 = new Button();
            btn6 = new Button();
            btnMultiplicar = new Button();
            btn1 = new Button();
            btn2 = new Button();
            btn3 = new Button();
            btnRestar = new Button();
            btn0 = new Button();
            btnLimpiar = new Button();
            btnIgual = new Button();
            btnSumar = new Button();
            SuspendLayout();
            // 
            // txtPantalla
            // 
            txtPantalla.BackColor = Color.WhiteSmoke;
            txtPantalla.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            txtPantalla.ForeColor = Color.Black;
            txtPantalla.Location = new Point(20, 20);
            txtPantalla.Name = "txtPantalla";
            txtPantalla.ReadOnly = true;
            txtPantalla.Size = new Size(300, 50);
            txtPantalla.TabIndex = 0;
            txtPantalla.TextAlign = HorizontalAlignment.Right;
            // 
            // btn7
            // 
            btn7.BackColor = Color.Gainsboro;
            btn7.Font = new Font("Segoe UI", 16F);
            btn7.Location = new Point(20, 90);
            btn7.Name = "btn7";
            btn7.Size = new Size(68, 60);
            btn7.TabIndex = 1;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = false;
            btn7.Click += BotonNumero_Click;
            // 
            // btn8
            // 
            btn8.BackColor = Color.Gainsboro;
            btn8.Font = new Font("Segoe UI", 16F);
            btn8.Location = new Point(97, 90);
            btn8.Name = "btn8";
            btn8.Size = new Size(68, 60);
            btn8.TabIndex = 2;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = false;
            btn8.Click += BotonNumero_Click;
            // 
            // btn9
            // 
            btn9.BackColor = Color.Gainsboro;
            btn9.Font = new Font("Segoe UI", 16F);
            btn9.Location = new Point(174, 90);
            btn9.Name = "btn9";
            btn9.Size = new Size(68, 60);
            btn9.TabIndex = 3;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = false;
            btn9.Click += BotonNumero_Click;
            // 
            // btnDividir
            // 
            btnDividir.BackColor = Color.LightSteelBlue;
            btnDividir.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnDividir.Location = new Point(252, 90);
            btnDividir.Name = "btnDividir";
            btnDividir.Size = new Size(68, 60);
            btnDividir.TabIndex = 4;
            btnDividir.Text = "÷";
            btnDividir.UseVisualStyleBackColor = false;
            btnDividir.Click += btnDividir_Click;
            // 
            // btn4
            // 
            btn4.BackColor = Color.Gainsboro;
            btn4.Font = new Font("Segoe UI", 16F);
            btn4.Location = new Point(20, 160);
            btn4.Name = "btn4";
            btn4.Size = new Size(68, 60);
            btn4.TabIndex = 5;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = false;
            btn4.Click += BotonNumero_Click;
            // 
            // btn5
            // 
            btn5.BackColor = Color.Gainsboro;
            btn5.Font = new Font("Segoe UI", 16F);
            btn5.Location = new Point(97, 160);
            btn5.Name = "btn5";
            btn5.Size = new Size(68, 60);
            btn5.TabIndex = 6;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = false;
            btn5.Click += BotonNumero_Click;
            // 
            // btn6
            // 
            btn6.BackColor = Color.Gainsboro;
            btn6.Font = new Font("Segoe UI", 16F);
            btn6.Location = new Point(174, 160);
            btn6.Name = "btn6";
            btn6.Size = new Size(68, 60);
            btn6.TabIndex = 7;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = false;
            btn6.Click += BotonNumero_Click;
            // 
            // btnMultiplicar
            // 
            btnMultiplicar.BackColor = Color.LightSteelBlue;
            btnMultiplicar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnMultiplicar.Location = new Point(252, 160);
            btnMultiplicar.Name = "btnMultiplicar";
            btnMultiplicar.Size = new Size(68, 60);
            btnMultiplicar.TabIndex = 8;
            btnMultiplicar.Text = "×";
            btnMultiplicar.UseVisualStyleBackColor = false;
            btnMultiplicar.Click += btnMultiplicar_Click;
            // 
            // btn1
            // 
            btn1.BackColor = Color.Gainsboro;
            btn1.Font = new Font("Segoe UI", 16F);
            btn1.Location = new Point(20, 230);
            btn1.Name = "btn1";
            btn1.Size = new Size(68, 60);
            btn1.TabIndex = 9;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = false;
            btn1.Click += BotonNumero_Click;
            // 
            // btn2
            // 
            btn2.BackColor = Color.Gainsboro;
            btn2.Font = new Font("Segoe UI", 16F);
            btn2.Location = new Point(97, 230);
            btn2.Name = "btn2";
            btn2.Size = new Size(68, 60);
            btn2.TabIndex = 10;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = false;
            btn2.Click += BotonNumero_Click;
            // 
            // btn3
            // 
            btn3.BackColor = Color.Gainsboro;
            btn3.Font = new Font("Segoe UI", 16F);
            btn3.Location = new Point(174, 230);
            btn3.Name = "btn3";
            btn3.Size = new Size(68, 60);
            btn3.TabIndex = 11;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = false;
            btn3.Click += BotonNumero_Click;
            // 
            // btnRestar
            // 
            btnRestar.BackColor = Color.LightSteelBlue;
            btnRestar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnRestar.Location = new Point(252, 230);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(68, 60);
            btnRestar.TabIndex = 12;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = false;
            btnRestar.Click += btnRestar_Click;
            // 
            // btn0
            // 
            btn0.BackColor = Color.Gainsboro;
            btn0.Font = new Font("Segoe UI", 16F);
            btn0.Location = new Point(20, 300);
            btn0.Name = "btn0";
            btn0.Size = new Size(68, 60);
            btn0.TabIndex = 13;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = false;
            btn0.Click += BotonNumero_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.IndianRed;
            btnLimpiar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(97, 300);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(68, 60);
            btnLimpiar.TabIndex = 14;
            btnLimpiar.Text = "C";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnIgual
            // 
            btnIgual.BackColor = Color.RoyalBlue;
            btnIgual.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnIgual.ForeColor = Color.White;
            btnIgual.Location = new Point(174, 300);
            btnIgual.Name = "btnIgual";
            btnIgual.Size = new Size(68, 60);
            btnIgual.TabIndex = 15;
            btnIgual.Text = "=";
            btnIgual.UseVisualStyleBackColor = false;
            btnIgual.Click += btnIgual_Click;
            // 
            // btnSumar
            // 
            btnSumar.BackColor = Color.LightSteelBlue;
            btnSumar.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            btnSumar.Location = new Point(252, 300);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(68, 60);
            btnSumar.TabIndex = 16;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = false;
            btnSumar.Click += btnSumar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(340, 385);
            Controls.Add(btnSumar);
            Controls.Add(btnIgual);
            Controls.Add(btnLimpiar);
            Controls.Add(btn0);
            Controls.Add(btnRestar);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(btnMultiplicar);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnDividir);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(txtPantalla);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Calculadora - Jeff Limones";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPantalla;
        private Button btn7;
        private Button btn8;
        private Button btn9;
        private Button btnDividir;
        private Button btn4;
        private Button btn5;
        private Button btn6;
        private Button btnMultiplicar;
        private Button btn1;
        private Button btn2;
        private Button btn3;
        private Button btnRestar;
        private Button btn0;
        private Button btnLimpiar;
        private Button btnIgual;
        private Button btnSumar;
    }
}