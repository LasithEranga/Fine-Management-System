using System;
using System.Windows.Forms;

namespace Fine_Management_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            home.SetBounds(0,0, 894, 552);
            home.Show();
            chart.Hide();
           // settingsPanel.SetBounds(0, 0, 894, 552);
           // settingsPanel.Show();
        }

        private void pictureBox10_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            home.Hide();
            chart.SetBounds(0, 0, 894, 552);
            chart.Show();
            pictureBox5.Image = Properties.Resources.fineX;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            chart.Hide();
            home.Show();
            pictureBox5.Image = Properties.Resources.homeBlue;
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }

        private void drag(object sender, MouseEventArgs e)
        {
            
        }

        private void settingsPanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
