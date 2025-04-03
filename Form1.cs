using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BT2_DangThiAnhThu_31231026699
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLoadFolder_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            var result = folderBrowserDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                var path = folderBrowserDialog.SelectedPath;
                string[] files = System.IO.Directory.GetFiles(path);
                foreach (var file in files)
                {
                    if (file.EndsWith(".jpg") || file.EndsWith("png"))
                    {
                        PictureBox pictureBox = new PictureBox();
                        pictureBox.Cursor = Cursors.Hand;
                        pictureBox.Load(file);
                        pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBox.Tag = file;
                        pictureBox.Click += PictureBox_Click;
                        flowLayoutPanel1.Controls.Add(pictureBox);
                    }
                }
            }
        }

        private void PictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pictureBox)
            {
                var filePath = pictureBox.Tag.ToString();
                pictureBox1.Load(filePath);
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                label1.Text = "File " + filePath + "is loaded";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
