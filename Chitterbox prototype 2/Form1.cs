namespace Chitterbox_prototype_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {

        }

        private async void rjButton3_Click(object sender, EventArgs e)
        {
            rjButton2.Visible = false;
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I want help to fix my broadband";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "RIght away big guy";
        }

        private async void rjButton4_Click(object sender, EventArgs e)
        {
            rjButton2.Visible = false;
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help connecting devices";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "RIght away big guy";
        }

        private async void rjButton5_Click(object sender, EventArgs e)
        {
            rjButton2.Visible = false;
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help setting up a hub";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "RIght away big guy";
        }

        private async void rjButton6_Click(object sender, EventArgs e)
        {
            rjButton2.Visible = false;
            rjButton3.Visible = false;
            rjButton4.Visible = false;
            rjButton5.Visible = false;
            rjButton6.Visible = false;

            pictureBox4.Visible = true;
            textBox2.Visible = true;
            textBox2.Text = "I need help reseting my hub";

            await Task.Delay(1000);

            pictureBox5.Visible = true;
            textBox3.Visible = true;
            textBox3.Text = "RIght away big guy";
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }
    }
}