using System;
using System.Windows.Forms;
using lab2_2lib;

namespace lab2_5
{
    public partial class fComputer : Form
    {
        public IComputer Computer;

        public fComputer(IComputer computer)
        {
            Computer = computer;
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Computer.Processor = tbProcessor.Text.Trim();
            Computer.Ram = tbRam.Text.Trim();
            Computer.Drive = tbDrive.Text.Trim();
            Computer.VideoCard = tbVideoCard.Text.Trim();
            Computer.SoundCard = tbSoundCard.Text.Trim();
            Computer.NetworkCard = tbNetworkCard.Text.Trim();
            Computer.OperatingSystem = tbOS.Text.Trim();

            DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void fComputer_Load(object sender, EventArgs e)
        {
            if (Computer == null) return;
            tbProcessor.Text = Computer.Processor;
            tbRam.Text = Computer.Ram;
            tbDrive.Text = Computer.Drive;
            tbVideoCard.Text = Computer.VideoCard;
            tbSoundCard.Text = Computer.SoundCard;
            tbNetworkCard.Text = Computer.NetworkCard;
            tbOS.Text = Computer.OperatingSystem;
        }
    }
}
