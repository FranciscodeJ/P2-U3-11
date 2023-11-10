namespace Práctica_11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            for (int x = 0; x < 10; x++)      // Se declaró x dentro del for, como variable de control, y que x se amenor que 10 como condición, y que x aumente en 1 cada que se repita el ciclo, como incremento.
            {

                listBox1.Items.Add(x);                         //El ciclo que se repetirá será este procedimento para fx, y el muestreo de x y fx en sus respectivas listbox.
                double fx = x / (1.0 + x * x);
                listBox2.Items.Add(fx);
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Application.Exit(); //Comando para salir de la aplicación, al apretar el botón.
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            int x1 = 1;        //Se introduce que x1 es igual a 1
            while (x1 <= 10)      //Se declara que mientras x1 cumplar la condición se repetirá el procedimiento a continuación.
            {
                listBox1.Items.Add(x1);                      //Se mostrará los valores de x1 y fx en sus respectivas listbox.
                double fx = x1 / (1.0 + x1 * x1);            //Se guardará el valor grande del procedimiento para mostrarse.
                listBox2.Items.Add(fx);
                x1++;                                          //Se le sumará 1 a x1, y se acabará el ciclo, para volver a while.

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int x2 = 1;                                     //Se declara que x2 es igual 1.
                                                            // "do" indicará que se haga el procedimiento a continueación, y posteriormente activar el ciclo while.
            do
            {
                listBox1.Items.Add(x2);                         //Se mostrará el valor del procedimento fx y el valor inicial de x2 cada que se repita el ciclo en sus respectivas list box.
                double fx = x2 / (1.0 + x2 * x2);
                listBox2.Items.Add(fx);
                x2++;
            } while (x2 >= 10);                           //El condicional de while se activará y dependiendo si el resultado de "do" se acepta o no, dejará de activarse o permanecerá activado. 
        }
    }
}