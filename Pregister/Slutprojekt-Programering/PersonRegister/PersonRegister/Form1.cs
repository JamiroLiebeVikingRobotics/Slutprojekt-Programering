using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonRegister
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

                
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        
            
        }

        private void searchPersonBox_Click(object sender, EventArgs e)
        {
            searchForm newform = new searchForm();
            newform.Show();
        }

        private void toListBtn_Click(object sender, EventArgs e)
        {
            listForm newform = new listForm();
            newform.Show();
        }
    }
}
