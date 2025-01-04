
namespace SqlConnection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
    
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlconnection = new SqlConnection("Data Source=.;Initial Catalog=Dbc#giriþ;Integrated Security=True;Trust Server Certificate=True");
        }
    }
}
