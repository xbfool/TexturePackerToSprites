using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Extractor
{
    public partial class Form1 : Form
    {
        string xmlPath;
        string rgbPath;
        string alphaPath;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                xmlPath = openFileDialog1.FileName;
                XMLPath.Text = xmlPath;
            }
        }

        private void RGBFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                rgbPath = openFileDialog1.FileName;
                RGBPath.Text = rgbPath;
            }
        }

        private void AlphaFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                alphaPath = openFileDialog1.FileName;
                AlphaPath.Text = alphaPath;
            }
        }

        private void ToSprites_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                //do something
            }
        }
    }
}
