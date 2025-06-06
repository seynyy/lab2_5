using System;
using System.IO;
using System.Text;
using System.Windows.Forms;
using lab2_2lib;

namespace lab2_5
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Don't create Computer here, let fComputer decide
            IComputer computer = null;
            var fComputer = new fComputer(computer);
            if (fComputer.ShowDialog() == DialogResult.OK)
            {
                computer = fComputer.Computer;
                bindSrcPCs.Add(computer);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvPCs.AutoGenerateColumns = false;

            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor";
            column.Name = "Процесор";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RAM";
            column.Name = "Оперативна пам'ять";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "VideoCard";
            column.Name = "Відеокарта";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Drive";
            column.Name = "Пам'ять";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SoundCard";
            column.Name = "Звукова карта";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NetworkCard";
            column.Name = "Інтернет адаптер";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OperatingSystem";
            column.Name = "Операційна система";
            gvPCs.Columns.Add(column);

            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            gvPCs.Columns.Add(column);
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var computer = bindSrcPCs.List[bindSrcPCs.Position] as IComputer;
            if (computer == null) return;

            var fComputer = new fComputer(computer);
            if (fComputer.ShowDialog() == DialogResult.OK)
            {
                computer = fComputer.Computer;
                bindSrcPCs.ResetBindings(false);
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Видалити комп'ютер?", @"Видалення комп'ютера", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Warning) == DialogResult.OK)
                bindSrcPCs.RemoveCurrent();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Очистити список комп'ютерів?", @"Очистка списку комп'ютерів",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                bindSrcPCs.Clear();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(@"Закрити програму?", @"Закриття програми", MessageBoxButtons.OKCancel,
                    MessageBoxIcon.Question) == DialogResult.OK)
                Application.Exit();
        }

        private void btnSaveAsText_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = @"Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            saveFileDialog.Title = @"Зберегти файл у текстовому форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            StreamWriter sw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                sw = new StreamWriter(saveFileDialog.FileName, false, Encoding.UTF8);
                try
                {
                    foreach (IComputer computer in bindSrcPCs.List)
                    {
                        sw.Write(computer.Processor + "\t" +
                                 computer.Ram + "\t" +
                                 computer.VideoCard + "\t" +
                                 computer.Drive + "\t" +
                                 computer.SoundCard + "\t" +
                                 computer.NetworkCard + "\t" +
                                 computer.OperatingSystem + "\t" +
                                 computer.Price.ToString("F2") + "\n");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sw.Close();
                }
            }
        }

        private void btnSaveAsBinary_Click(object sender, EventArgs e)
        {
            saveFileDialog.Filter = @"Бінарні файли (*.bin)|*.bin|Всі файли (*.*)|*.*";
            saveFileDialog.Title = @"Зберегти файл у бінарному форматі";
            saveFileDialog.InitialDirectory = Application.StartupPath;
            BinaryWriter bw;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                bw = new BinaryWriter(new FileStream(saveFileDialog.FileName, FileMode.Create));
                try
                {
                    foreach (IComputer computer in bindSrcPCs.List)
                    {
                        bw.Write(computer.Processor);
                        bw.Write(computer.Ram);
                        bw.Write(computer.VideoCard);
                        bw.Write(computer.Drive);
                        bw.Write(computer.SoundCard);
                        bw.Write(computer.NetworkCard);
                        bw.Write(computer.OperatingSystem);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    bw.Close();
                }
            }
        }

        private void btnOpenFromText_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Текстові файли (*.txt)|*.txt|Всі файли (*.*)|*.*";
            openFileDialog.Title = @"Відкрити файл у текстовому форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            StreamReader sr;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(openFileDialog.FileName, Encoding.UTF8);
                string line;
                try
                {
                    while ((line = sr.ReadLine()) != null)
                    {
                        string[] parts = line.Split('\t');
                        if (parts.Length != 8) continue;
                        // Always creates Computer, never Laptop
                        IComputer computer = new Computer
                        {
                            Processor = parts[0],
                            Ram = parts[1],
                            VideoCard = parts[2],
                            Drive = parts[3],
                            SoundCard = parts[4],
                            NetworkCard = parts[5],
                            OperatingSystem = parts[6],
                        };
                        bindSrcPCs.Add(computer);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    sr.Close();
                }
            }
        }

        private void btnOpenFromBinary_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = @"Бінарні файли (*.bin)|*.bin|Всі файли (*.*)|*.*";
            openFileDialog.Title = @"Відкрити файл у бінарному форматі";
            openFileDialog.InitialDirectory = Application.StartupPath;
            BinaryReader br;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                br = new BinaryReader(new FileStream(openFileDialog.FileName, FileMode.Open));
                try
                {
                    while (br.BaseStream.Position < br.BaseStream.Length)
                    {
                        IComputer computer = new Computer
                        {
                            Processor = br.ReadString(),
                            Ram = br.ReadString(),
                            VideoCard = br.ReadString(),
                            Drive = br.ReadString(),
                            SoundCard = br.ReadString(),
                            NetworkCard = br.ReadString(),
                            OperatingSystem = br.ReadString(),
                        };
                        bindSrcPCs.Add(computer);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, @"Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    br.Close();
                }
            }
        }
    }
}