namespace Singleton
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ApplySettings()
        {
            var settings = AppSettings.Instance;

            this.Text = settings.Title;
            this.BackColor = settings.BackgroundColor;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ApplySettings();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var settings = AppSettings.Instance;

            settings.Title = "Changed Title";
            settings.BackgroundColor = Color.Yellow;

            ApplySettings();
        }
    }
}
