namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        float num1, ans;
        int count;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btnSete_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 7;
        }

        private void btnOito_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 8;
        }

        private void btnNove_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 9;
        }

        private void btnQuatro_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 4;
        }

        private void btnCinco_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 5;
        }

        private void btnSeis_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 6;
        }

        private void btnUm_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 1;
        }

        private void btnDois_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 2;
        }

        private void btnTres_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 3;
        }

        private void btnZero_Click(object sender, EventArgs e)
        {
            txbVisor.Text = txbVisor.Text + 0;
        }

        private void btnUmSobreX_Click(object sender, EventArgs e)
        {
            txbVisor.Text = (1 / float.Parse(txbVisor.Text)).ToString();
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            int lenght = txbVisor.TextLength - 1;
            string text = txbVisor.Text;  // MessageBox.Show(lenght.ToString());
            txbVisor.Clear();
            for (int i = 0; i < lenght; i++)
                txbVisor.Text = txbVisor.Text + text[i];
        }

        int check = 1;
        private void btnMaisMenos_Click(object sender, EventArgs e)
        {
            if (txbVisor.TextLength > 0)
            {
                string text = txbVisor.Text;
                if (check == 1)
                {
                    txbVisor.Text = "-" + txbVisor.Text;
                    check = 2;
                }
                else if (check == 2)
                {
                    int lenght = txbVisor.TextLength; txbVisor.Clear();
                    for (int i = 1; i < lenght; i++) { txbVisor.Text = txbVisor.Text + text[i]; }
                    check = 1;
                }
            }
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            if (num1 == 0 && txbVisor.TextLength > 0)
            { num1 = 0; txbVisor.Clear(); }
            else if (num1 > 0 && txbVisor.TextLength > 0)
            { txbVisor.Clear(); }
        }

        private void btnSubtracao_Click(object sender, EventArgs e)
        {
            if (txbVisor.Text != "")
            {
                num1 = float.Parse(txbVisor.Text);
                txbVisor.Clear();
                txbVisor.Focus();
                count = 1;
            }
        }

        private void btnSoma_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            txbVisor.Focus();
            count = 2;
        }

        private void btnMutiplicacao_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            txbVisor.Focus();
            count = 3;
        }

        private void btnDivisao_Click(object sender, EventArgs e)
        {
            num1 = float.Parse(txbVisor.Text);
            txbVisor.Clear();
            txbVisor.Focus();
            count = 4;
        }

        private void btnIgual_Click(object sender, EventArgs e)
        {
            compute(count);
        }

        public void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = num1 - float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                case 2:
                    ans = num1 + float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                case 3:
                    ans = num1 * float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                case 4:
                    ans = num1 / float.Parse(txbVisor.Text);
                    txbVisor.Text = ans.ToString();
                    break;
                default:
                    break;
            }
        }

        private void btnRaiz_Click(object sender, EventArgs e)
        {
            double sqrt = Math.Sqrt(float.Parse(txbVisor.Text));
            txbVisor.Text = sqrt.ToString();
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            txbVisor.Clear();
            count = 0;
        }

        private void btnPorcentagem_Click(object sender, EventArgs e)
        {

        }

        private void btnXQuadrado_Click(object sender, EventArgs e)
        {
            txbVisor.Text = ((float.Parse(txbVisor.Text))* float.Parse(txbVisor.Text)).ToString();
        }

        private void btnVirgula_Click(object sender, EventArgs e)
        {
            int c = txbVisor.TextLength;
            int flag = 0;
            string text = txbVisor.Text;
            for (int i = 0; i < c; i++)
            { if (text[i].ToString() == ",") { flag = 1; break; } else { flag = 0; } }
            if (flag == 0)
            { txbVisor.Text = txbVisor.Text + ","; }
        }
    }
}