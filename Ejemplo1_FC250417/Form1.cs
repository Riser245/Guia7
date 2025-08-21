namespace Ejemplo1_FC250417
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            Sumar sumar = new Sumar();
            txtResultado.Text = sumar.operar(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text)).ToString();
        }

        private void btnResta_Click(object sender, EventArgs e)
        {
            Restar resta = new Restar();
            txtResultado.Text = resta.operar(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text)).ToString();
        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            Multiplicar multiplica = new Multiplicar();
            txtResultado.Text = multiplica.operar(int.Parse(txtVal1.Text), int.Parse(txtVal2.Text)).ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtVal1.Clear();
            txtVal2.Clear();
            txtResultado.Clear();
        }
    }
}