using ImageMagick;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;


namespace Extractor
{

    public partial class Form1 : Form
    {
        string xmlPath;
        string rgbPath;
        string alphaPath;
        string folderPath;
        SpriteSheet sheet;
        public Form1()
        {
            InitializeComponent();
            sheet = new SpriteSheet();
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
                FolderLabel.Text = folderBrowserDialog1.SelectedPath;
                folderPath = FolderLabel.Text;
                //do something
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            load_xml();
            crop_images();
        }

        private void crop_images()
        {

            foreach (var s in sheet.sprites)
            {
                using (MagickImage image_a = new MagickImage(alphaPath))
                {
                    using (MagickImage image_rgb = new MagickImage(rgbPath))
                    {
                        var g = new ImageMagick.MagickGeometry(s.x, s.y, s.w, s.h);
                        image_a.Crop(g);
                       
                        image_rgb.Crop(g);
                        image_rgb.Composite(image_a, CompositeOperator.CopyAlpha);
                        image_rgb.Write(folderPath + "/" + s.n);
                        
                    }
                }
                //return;
            }
        }
        private void load_xml()
        {
            XmlDataDocument xmldoc = new XmlDataDocument();
            XmlNodeList xmlnode;
            int i = 0;
            FileStream fs = new FileStream(xmlPath, FileMode.Open, FileAccess.Read);
            xmldoc.Load(fs);
            xmlnode = xmldoc.GetElementsByTagName("sprite");
            for (i = 0; i <= xmlnode.Count - 1; i++)
            {
                var sprite = new Sprite();

                string n = xmlnode[i].Attributes.GetNamedItem("n").Value;
                string x = xmlnode[i].Attributes.GetNamedItem("x").Value;
                string y = xmlnode[i].Attributes.GetNamedItem("y").Value;
                string w = xmlnode[i].Attributes.GetNamedItem("w").Value;
                string h = xmlnode[i].Attributes.GetNamedItem("h").Value;
                string px = xmlnode[i].Attributes.GetNamedItem("pX").Value;
                string py = xmlnode[i].Attributes.GetNamedItem("pY").Value;

                sprite.n = n;
                sprite.x = int.Parse(x);
                sprite.y = int.Parse(y);
                sprite.w = int.Parse(w);
                sprite.h = int.Parse(h);
                sprite.px = float.Parse(px);
                sprite.py = float.Parse(py);

                sheet.sprites.Add(sprite);
            }
        }
    }

    struct Sprite
    {
        public string n;
        public int x;
        public int y;
        public int w;
        public int h;
        public float px;
        public float py;
    }

    class SpriteSheet
    {
        public int w;
        public int h;
        public List<Sprite> sprites;

        public SpriteSheet()
        {
            sprites = new List<Sprite>();
        }
    }


}
