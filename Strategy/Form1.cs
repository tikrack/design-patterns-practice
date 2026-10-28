using Strategy.Strategies;

namespace Strategy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var checkout = new CheckoutService(new NormalShipping());

            var cost = checkout.CalculateShipping(100);

            MessageBox.Show(cost.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var checkout = new CheckoutService(new ExpressShipping());

            var cost = checkout.CalculateShipping(100);

            MessageBox.Show(cost.ToString());
        }
    }
}
