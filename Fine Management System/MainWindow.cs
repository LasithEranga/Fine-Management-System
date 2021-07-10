using System;
using System.Windows.Forms;

namespace Fine_Management_System
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            homePanel.SetBounds(0,0, 930, 627);
            homePanel.Show();
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
            homePanel.Hide();
            chart.SetBounds(0, 0, 930, 627);
            chart.Show();
            pictureBox5.Image = Properties.Resources.fineX;
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            chart.Hide();
            homePanel.Show();
            pictureBox5.Image = Properties.Resources.homeBlue;
        }


        private void MainWindow_Load(object sender, EventArgs e)
        {
            ControlExtension.Draggable(this, true);
        }

    }
}
