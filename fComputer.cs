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
            if (Computer == null)
                switch (cbIsLaptop.Checked)
                {
                    case true:
                        Computer = new Laptop();
                        break;
                    case false:
                        Computer = new Computer();
                        break;
                }
            // Assign form fields to the new Computer/Laptop
            if (Computer != null && Computer.Processor == null)
            {
                Computer.Processor = tbProcessor.Text.Trim();
                Computer.Ram = tbRam.Text.Trim();
                Computer.Drive = tbDrive.Text.Trim();
                Computer.VideoCard = tbVideoCard.Text.Trim();
                Computer.SoundCard = tbSoundCard.Text.Trim();
                Computer.NetworkCard = tbNetworkCard.Text.Trim();
                Computer.OperatingSystem = tbOS.Text.Trim();
            }
            else
            {
                var processor = Computer.Processor;
                var ram = Computer.Ram;
                var drive = Computer.Drive;
                var videoCard = Computer.VideoCard;
                var soundCard = Computer.SoundCard;
                var networkCard = Computer.NetworkCard;
                var operatingSystem = Computer.OperatingSystem;

                if (cbIsLaptop.Checked && !(Computer is Laptop))
                {
                    Computer = new Laptop();
                    Computer.Processor = processor;
                    Computer.Ram = ram;
                    Computer.Drive = drive;
                    Computer.VideoCard = videoCard;
                    Computer.SoundCard = soundCard;
                    Computer.NetworkCard = networkCard;
                    Computer.OperatingSystem = operatingSystem;
                }

                else if (!cbIsLaptop.Checked && (Computer is Laptop))
                {
                    Computer = new Computer();
                    Computer.Processor = processor;
                    Computer.Ram = ram;
                    Computer.Drive = drive;
                    Computer.VideoCard = videoCard;
                    Computer.SoundCard = soundCard;
                    Computer.NetworkCard = networkCard;
                    Computer.OperatingSystem = operatingSystem;
                }
                else
                {
                    Computer.Processor = tbProcessor.Text.Trim();
                    Computer.Ram = tbRam.Text.Trim();
                    Computer.Drive = tbDrive.Text.Trim();
                    Computer.VideoCard = tbVideoCard.Text.Trim();
                    Computer.SoundCard = tbSoundCard.Text.Trim();
                    Computer.NetworkCard = tbNetworkCard.Text.Trim();
                    Computer.OperatingSystem = tbOS.Text.Trim();
                }
            }

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