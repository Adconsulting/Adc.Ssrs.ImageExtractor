using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using Adc.Ssrs.ImageExtractor.Properties;

namespace Adc.Ssrs.ImageExtractor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnRdl_Click(object sender, EventArgs e)
        {
            var result = ofdRdlFile.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtRdlfile.Text = ofdRdlFile.FileName;
            }
        }

        private void btnDest_Click(object sender, EventArgs e)
        {
            var result = fbdDestination.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtDestination.Text = fbdDestination.SelectedPath;
            }
        }

        private void btnExtract_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtRdlfile.Text) && !string.IsNullOrWhiteSpace(txtDestination.Text))
            {
                var document = XDocument.Load(txtRdlfile.Text);

                var images = document.Elements().First().Descendants().Where(x => x.Name.LocalName == "EmbeddedImage");
                foreach (var xElement in images)
                {
                    var filename = xElement.Attribute("Name").Value;
                    var MineType = xElement.Elements().FirstOrDefault(x => x.Name.LocalName == "MIMEType").Value;
                    var imageData = xElement.Elements().FirstOrDefault(x => x.Name.LocalName == "ImageData").Value;

                    var image = Base64ToImage(imageData);
                    var extension = "jpg";
                    if (MineType == "image/png")
                    {
                        extension = "png";
                    }
                    image.Save(string.Format(@"{0}\{1}.{2}", txtDestination.Text, filename, extension));
                }
            }
            else
            {
                MessageBox.Show(Resources.ErrorMessage, Resources.ErrorTitle, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        public Image Base64ToImage(string base64String)
        {
            // Convert Base64 String to byte[]
            var imageBytes = Convert.FromBase64String(base64String);
            var ms = new MemoryStream(imageBytes, 0,
              imageBytes.Length);

            // Convert byte[] to Image
            ms.Write(imageBytes, 0, imageBytes.Length);
            var image = Image.FromStream(ms, true);
            return image;
        }
    }
}
