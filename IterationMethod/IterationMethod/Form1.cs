using Microsoft.VisualBasic;

namespace IterationMethod
{
    public partial class Form1 : Form
    {



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string equationSystem = textBox1.Text;
            double accuracy = double.Parse(textBox2.Text);
            int maxIterations = int.Parse(textBox3.Text);


            int n = int.Parse(textBox5.Text); // ѕолучаем пользовательское значение переменной "n"

            double[] initialValues = new double[n]; // ћассив дл€ хранени€ начальных значений переменных
            double[] previousValues = new double[n]; // ћассив дл€ хранени€ предыдущих значений переменных
            int iterations = 0; // —четчик итераций

            // »нициализаци€ начальных значений переменных
            for (int i = 0; i < n; i++)
            {
                initialValues[i] = double.Parse(Interaction.InputBox("¬ведите начальное значение дл€ переменной " + (i + 1))); ;

            }
            bool reachedAccuracy = false;
            do
            {
                //  опирование текущих значений переменных в массив previousValues
                Array.Copy(initialValues, previousValues, n);

                // –асчет новых значений переменных на основе предыдущих значений и уравнений системы
                for (int i = 0; i < n; i++)
                {
                    initialValues[i] = 0; 
                    // –асчет нового значени€ переменной на основе предыдущих значений и уравнений системы
                }

                // ѕроверка услови€ сходимости и других условий, если требуетс€

                iterations++; // ”величение счетчика итераций

            } while (!reachedAccuracy && iterations < maxIterations);

            // ¬ывод приближенного решени€ системы уравнений
            string result = "ѕриближенное решение системы уравнений:\n";
            for (int i = 0; i < n; i++)
            {
                result += "X" + (i + 1) + " = " + initialValues[i] + "\n";
            }

            MessageBox.Show(result);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
