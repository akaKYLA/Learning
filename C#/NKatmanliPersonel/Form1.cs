using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityLayer;
using DataAccesLayer;
using LogicLayer;

namespace NKatmanliPersonel
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> Perlist = LPersonel.LLPersonelListesi();
            dataGridView1.DataSource = Perlist;
            int secilenid;
        }
    }
}
