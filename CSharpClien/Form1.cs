namespace CSharpClien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            HttpClient client = new HttpClient();
            HttpResponseMessage message = client.GetAsync("https://localhost:7198/api/Instructor").Result;
            if (message.IsSuccessStatusCode)
            {
                List<InstructorWF> instructors = message.Content.ReadAsAsync<List<InstructorWF>>().Result;
                dataGridView1.DataSource = instructors;
            }
        }
    }
}