using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2_4
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            throw new System.NotImplementedException();
        }

        private void Form1_ResizeEnd(object sender, EventArgs e)
        {
            int buttonSize = 5 * btnAdd.Width + 2 * toolStripSeparator1.Width + 30;
            btnExit.Margin = new Padding(Width-buttonSize, 0, 0, 0);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gvPCs.AutoGenerateColumns = false;
            
            DataGridViewColumn column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Name";
            column.Name = "Назва";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Processor";
            column.Name = "Процесор";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "RAM";
            column.Name = "ОП";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "VideoCard";
            column.Name = "Відеокарта";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Drive";
            column.Name = "Диск";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "SoundCard";
            column.Name = "Звукова карта";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "NetworkCard";
            column.Name = "Мережева карта";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "OS";
            column.Name = "Операційна система";
            gvPCs.Columns.Add(column);
            
            column = new DataGridViewTextBoxColumn();
            column.DataPropertyName = "Price";
            column.Name = "Ціна";
            gvPCs.Columns.Add(column);
            
        }
    }
}