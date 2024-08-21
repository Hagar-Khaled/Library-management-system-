namespace ADOproj
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form6 show = new Form6();
            //this.Close();
            this.Hide();
            show.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 Add = new Form2();
            this.Hide();
            Add.Show(); 


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 AddM = new Form3();
            //this.Close();
            this.Hide();
            AddM.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 borrow = new Form4();
            this.Hide();
            borrow.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form7 ss = new Form7();
            this.Hide();
            ss.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form5 nn = new Form5();
            this.Hide();
            nn.Show();
        }
    }
}