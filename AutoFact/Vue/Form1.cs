namespace AutoFact
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        private void buttonClient_Click(object sender, EventArgs e)
        {
            Client FormClient = new Client();
            FormClient.ShowDialog();
        }

        private void buttonPresta_Click(object sender, EventArgs e)
        {
            Prestation FormPrestation = new Prestation();
            FormPrestation.ShowDialog();
        }

        private void buttonFact_Click(object sender, EventArgs e)
        {
            Facturation FormFacturation = new Facturation();
            FormFacturation.ShowDialog();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
