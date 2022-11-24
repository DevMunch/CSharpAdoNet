using AdoNet; 
using AppConfiguration;

namespace AdoNetWindow
{
    public partial class Form1 : Form
    {
        MsSql msql;
        string ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            ConfigurationMgr instance = ConfigurationMgr.Instance();
            MessageBox.Show(instance.Connection.State.ToString());
            instance.Connection.Close();
        }
    }
}