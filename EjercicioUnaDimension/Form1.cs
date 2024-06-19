using System;
using System.Windows.Forms;

namespace EjercicioUnaDimension
{
    public partial class MainForm : Form
    {
        private int[] numeros = new int[5]; // Arreglo de enteros con 5 elementos

        public MainForm()
        {
            InitializeComponent();

            // Inicialización de valores del arreglo
            numeros[0] = 10;
            numeros[1] = 20;
            numeros[2] = 30;
            numeros[3] = 40;
            numeros[4] = 50;

            ActualizarListBox();

        }


        private void ActualizarListBox()
        {
            listBoxNumeros.Items.Clear();
            foreach (int numero in numeros)
            {
                listBoxNumeros.Items.Add(numero);
            }
        }
        private void btnSuma_Click(object sender, EventArgs e)
        {
            // Calcular la suma de todos los elementos del arreglo
            int suma = 0;
            foreach (int numero in numeros)
            {
                suma += numero;
            }
            MessageBox.Show("La suma de todos los elementos es: " + suma, "Resultado");
        }

        private void btnMaximo_Click(object sender, EventArgs e)
        {
            // Encontrar el valor máximo en el arreglo
            int maximo = numeros[0];
            for (int i = 1; i < numeros.Length; i++)
            {
                if (numeros[i] > maximo)
                {
                    maximo = numeros[i];
                }
            }
            MessageBox.Show("El valor máximo en el arreglo es: " + maximo, "Resultado");
        }

        private ListBox listBoxNumeros;

        private void InitializeComponent()
        {
            listBoxNumeros = new ListBox();
            btnSuma = new Button();
            btnMaximo = new Button();
            SuspendLayout();
            // 
            // listBoxNumeros
            // 
            listBoxNumeros.FormattingEnabled = true;
            listBoxNumeros.ItemHeight = 15;
            listBoxNumeros.Location = new Point(24, 22);
            listBoxNumeros.Name = "listBoxNumeros";
            listBoxNumeros.Size = new Size(293, 94);
            listBoxNumeros.TabIndex = 0;
            // 
            // btnSuma
            // 
            btnSuma.Location = new Point(24, 150);
            btnSuma.Name = "btnSuma";
            btnSuma.Size = new Size(124, 23);
            btnSuma.TabIndex = 1;
            btnSuma.Text = "Suma";
            btnSuma.UseVisualStyleBackColor = true;
            // 
            // btnMaximo
            // 
            btnMaximo.Location = new Point(199, 150);
            btnMaximo.Name = "btnMaximo";
            btnMaximo.Size = new Size(118, 23);
            btnMaximo.TabIndex = 2;
            btnMaximo.Text = "Maximo";
            btnMaximo.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            ClientSize = new Size(727, 360);
            Controls.Add(btnMaximo);
            Controls.Add(btnSuma);
            Controls.Add(listBoxNumeros);
            Name = "MainForm";
            ResumeLayout(false);
        }

        private Button btnSuma;
        private Button btnMaximo;
    }
}

