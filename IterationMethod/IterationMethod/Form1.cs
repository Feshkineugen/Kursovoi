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


            int n = int.Parse(textBox5.Text); // �������� ���������������� �������� ���������� "n"

            double[] initialValues = new double[n]; // ������ ��� �������� ��������� �������� ����������
            double[] previousValues = new double[n]; // ������ ��� �������� ���������� �������� ����������
            int iterations = 0; // ������� ��������

            // ������������� ��������� �������� ����������
            for (int i = 0; i < n; i++)
            {
                initialValues[i] = double.Parse(Interaction.InputBox("������� ��������� �������� ��� ���������� " + (i + 1))); ;

            }
            bool reachedAccuracy = false;
            do
            {
                // ����������� ������� �������� ���������� � ������ previousValues
                Array.Copy(initialValues, previousValues, n);

                // ������ ����� �������� ���������� �� ������ ���������� �������� � ��������� �������
                for (int i = 0; i < n; i++)
                {
                    initialValues[i] = 0; 
                    // ������ ������ �������� ���������� �� ������ ���������� �������� � ��������� �������
                }

                // �������� ������� ���������� � ������ �������, ���� ���������

                iterations++; // ���������� �������� ��������

            } while (!reachedAccuracy && iterations < maxIterations);

            // ����� ������������� ������� ������� ���������
            string result = "������������ ������� ������� ���������:\n";
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
