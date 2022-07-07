﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Media;


namespace TestF 
{
    public partial class Form1 : Form
    {
        public Form1()
        {           
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {           
                try
                {
                    pictureBox1.Image = new Bitmap(ofd.FileName);
                }
                catch
                {
                    MessageBox.Show("Неможливо відкрити обраний файл", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Title = "Save image to...";
                sfd.OverwritePrompt = true;
                sfd.CheckPathExists = true;
                sfd.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*";
                sfd.ShowHelp = true;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        pictureBox1.Image.Save(sfd.FileName);
                    }
                    catch 
                    {
                        MessageBox.Show("Неможливо зберегти зображення", "Помилка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        public Bitmap CutImage(Bitmap src, Rectangle rect)
        {
            Bitmap bmp = new Bitmap(src.Width, src.Height);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawImage(src, 0,0, rect, GraphicsUnit.Pixel);
            return bmp;
        }

        private void button3_Click(object sender, EventArgs e)
        {          
            Image img_2 = pictureBox1.Image;          

            img_2.Save("image.bmp", ImageFormat.Bmp);

            using (Bitmap src = new Bitmap(img_2, pictureBox1.Width, pictureBox1.Height))
            {
                Rectangle cloneRect = new Rectangle(0, 25, 100, 50);
                System.Drawing.Imaging.PixelFormat format = img_2.PixelFormat;
                Bitmap ClonedImage = src.Clone(cloneRect, format);
                pictureBox2.Image = ClonedImage;
            }
        }
          
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Image img = pictureBox1.Image; 
            label1.Text = e.X.ToString();
            label2.Text = e.Y.ToString();
        }

        public static byte[] ToByteArrayImg(Image image)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, ImageFormat.Bmp);
                return ms.ToArray();
            }
        }     

        private void button4_Click(object sender, EventArgs e)
        {
            string pathNew = @"C:\Users\Andre\Desktop\TestProject\TestF\TestF\bin\Debug\ImgBinNew.dat";

            Image img_pb2 = pictureBox2.Image;

            Bitmap src = new Bitmap(img_pb2, img_pb2.Width, img_pb2.Height);          
            src.Save(@"C:\Users\Andre\Desktop\TestProject\TestF\TestF\bin\Debug\img.bmp", ImageFormat.Bmp);
        
            byte[] b_img = ToByteArrayImg(src);
            byte[] b_img_h = new byte[10054];
            byte[] b_color_yellow = new byte[400];

            for (int i = 0; i < b_img_h.Length; i++)
            {
                b_img_h[i] = b_img[i];
            }

            b_img = b_img.Skip(b_img_h.Length).ToArray();

            for (int i = 0; i < b_color_yellow.Length; i++)
            {
                if (i % 4 == 0)
                {
                    b_color_yellow[i] = 0x00;
                }
                else
                {
                    b_color_yellow[i] = 0xff;
                }
            }
          
            listBox1.Items.Add(pathNew.Length);                    

            using (BinaryWriter bW = new BinaryWriter(File.Open(pathNew, FileMode.OpenOrCreate)))
            {
                for (int i = 0; i < b_img_h.Length; i++)
                {
                    bW.Write(b_img_h[i]);                
                }

                bW.Seek(22, SeekOrigin.Begin);
                bW.Write(51);            
                                              
                for (int i = 0; i < b_color_yellow.Length; i++)
                {
                    bW.Seek(10054+i, SeekOrigin.Begin);
                    bW.Write(b_color_yellow[i]);
                }
            
                for (int i = 0; i < b_img.Length; i++)
                {
                    bW.Write(b_img[i]);
                }
      
                bW.Seek(0, SeekOrigin.Begin);
                bW.Write('R');
                bW.Write('I');
                bW.Write('M');
                bW.Write('G');
                bW.Write(src.Width);
                bW.Write(src.Height);
                bW.Write(Math.PI / 2);
                bW.Seek(20468, SeekOrigin.Begin);
                bW.Write('E');
                bW.Write('N');
                bW.Write('D');

                bW.Close();
            }

        }

    }
}
