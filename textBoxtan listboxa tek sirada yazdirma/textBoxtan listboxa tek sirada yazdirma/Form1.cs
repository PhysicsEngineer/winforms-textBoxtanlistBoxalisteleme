namespace textBoxtan_listboxa_tek_sirada_yazdirma
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text + " " + textBox2.Text + " " + 
                textBox3.Text + " " + textBox4.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add(textBox8.Text);
            listBox2.Items.Add(textBox7.Text);
            listBox2.Items.Add(textBox6.Text);
            listBox2.Items.Add(textBox5.Text);
        }
    }
}