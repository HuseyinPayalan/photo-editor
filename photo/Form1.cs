using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace photo
{
    public partial class Form1 : Form
    {
        Bitmap src_img, dest_img;
        public bool yeni_eklendi = false;
        Image old_image;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.KeyPreview = true;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                toolStripMenuItem1.Text = "&File";
                editToolStripMenuItem.Text = "&Edit";
                ımageToolStripMenuItem.Text = "&Image";
                layerToolStripMenuItem.Text = "&Layer";
                typeToolStripMenuItem.Text = "&Type";
                selectToolStripMenuItem.Text = "&Select";
                filterToolStripMenuItem.Text = "Filte&r";
                viewToolStripMenuItem.Text = "&View";
                windowToolStripMenuItem.Text = "&Window";
                helpToolStripMenuItem.Text = "&Help";
                
            }
        }

        private void OriginalSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                originalSizeToolStripMenuItem.Checked = true;
                fullscreenToolStripMenuItem.Checked = false;
            }

            else
            {
                MessageBox.Show("It is already in normal size.");
            }
        }

        private void FullscreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
                fullscreenToolStripMenuItem.Checked = true;
                originalSizeToolStripMenuItem.Checked = false;
            }

            else
            {
                MessageBox.Show("It is already in fullscreen.");
            }
        }

        private void NewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void OpenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG (*.jpg; *.jpeg; *.jpe)|*.jpg;*.jpeg;*.jpe|Tüm dosyalar (*.*)|*.*";
            openFile.FilterIndex = 2;
            openFile.RestoreDirectory = true;
            openFile.CheckFileExists = false;

           if (openFile.ShowDialog() == DialogResult.OK)
           {
                StreamReader sr = new StreamReader(openFile.FileName);
                // hangi tür dosya açmak istediği yer alacak.
           }
        }

        private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*jpg; *.jpe; *jpe";
            save.Filter = "JPEG (*.jpg; *.jpeg; *.jpe)|*.jpg;*.jpeg;*.jpe";
            if (save.ShowDialog() == DialogResult.OK && save.FileName.Length > 0)
            {
                // richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);

                DialogResult kaydet = MessageBox.Show("Dosya kaydedildi.", "Dosya adresi : " + save.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (kaydet == DialogResult.OK || kaydet == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.DefaultExt = "*jpg; *.jpe; *jpe";
            save.Filter = "JPEG (*.jpg; *.jpeg; *.jpe)|*.jpg;*.jpeg;*.jpe|Tüm dosyalar (*.*)|*.*";
            if (save.ShowDialog() == DialogResult.OK && save.FileName.Length > 0)
            {
                // richTextBox1.SaveFile(save.FileName, RichTextBoxStreamType.PlainText);

                DialogResult farkli_kaydet = MessageBox.Show("Dosya kaydedildi.", "Dosya adresi : " + save.FileName, MessageBoxButtons.OK, MessageBoxIcon.Information);
                if (farkli_kaydet == DialogResult.OK || farkli_kaydet == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
        }

        private void UndoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // undo
        }

        private void RedoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // redo
        }

        private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "JPEG (*.jpg; *.jpeg; *.jpe)|*.jpg;*.jpeg;*.jpe";
            openFile.FilterIndex = 1;
            openFile.RestoreDirectory = true;
            openFile.CheckFileExists = false;


            if (openFile.ShowDialog() == DialogResult.OK)
            {
                Image image = Image.FromFile(openFile.FileName);
                main_photo_pictureBox.Image = image;
            }

            src_img = new Bitmap(main_photo_pictureBox.Image);
            dest_img = new Bitmap(main_photo_pictureBox.Image);

            yeni_eklendi = true;

           old_image = main_photo_pictureBox.Image;
        }
        private void ColorFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            timer1.Enabled = true;
            colorFilterToolStripMenuItem.Checked = true;
        }

        private void SpecialFiltersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            specialFiltersToolStripMenuItem.Checked = true;
        }

        private void BrightnessContrastToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
        }

        private void Brightness_value_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                brightness_trackBar.Value = Convert.ToInt32(brightness_value_textBox.Text);

                for (int x = 1; x < main_photo_pictureBox.Image.Width; x++)
                    for (int y = 1; y < main_photo_pictureBox.Image.Height; y++)
                    {
                        int resultR;
                        int resultG;
                        int resultB;

                        resultR = brightness_trackBar.Value + src_img.GetPixel(x, y).R;
                        resultG = brightness_trackBar.Value + src_img.GetPixel(x, y).G;
                        resultB = brightness_trackBar.Value + src_img.GetPixel(x, y).B;

                        if (resultR > 255)
                            resultR = 255;
                        if (resultR < 0)
                            resultR = 0;

                        if (resultG > 255)
                            resultG = 255;
                        if (resultG < 0)
                            resultG = 0;

                        if (resultB > 255)
                            resultB = 255;
                        if (resultB < 0)
                            resultB = 0;

                       
                        dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                    }

                main_photo_pictureBox.Image = dest_img;
            }
        }

        private void Brightness_trackBar_Scroll(object sender, EventArgs e)
        {
            brightness_value_textBox.Text = brightness_trackBar.Value.ToString();
        }

        private void Brightness_apply_button_Click(object sender, EventArgs e)
        {
            for (int x = 1; x < main_photo_pictureBox.Image.Width; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height; y++)
                {
                    int resultR;
                    int resultG;
                    int resultB;

                    resultR = brightness_trackBar.Value + src_img.GetPixel(x, y).R;
                    resultG = brightness_trackBar.Value + src_img.GetPixel(x, y).G;
                    resultB = brightness_trackBar.Value + src_img.GetPixel(x, y).B;

                    if (resultR > 255)
                        resultR = 255;
                    if (resultR < 0)
                        resultR = 0;

                    if (resultG > 255)
                        resultG = 255;
                    if (resultG < 0)
                        resultG = 0;

                    if (resultB > 255)
                        resultB = 255;
                    if (resultB < 0)
                        resultB = 0;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }

        private void Contrast_value_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                contrast_trackBar.Value = Convert.ToInt32(contrast_value_textBox.Text);

                int C = contrast_trackBar.Value;
                double F = (259.0 * (C + 255.0)) / (255.0 * (259.0 - C));

                for (int x = 1; x < main_photo_pictureBox.Image.Width; x++)
                    for (int y = 1; y < main_photo_pictureBox.Image.Height; y++)
                    {
                        double resultR;
                        double resultG;
                        double resultB;

                        resultR = F * (src_img.GetPixel(x, y).R - 128) + 128;
                        resultG = F * (src_img.GetPixel(x, y).G - 128) + 128;
                        resultB = F * (src_img.GetPixel(x, y).B - 128) + 128;

                        if (resultR > 255.0)
                            resultR = 255.0;
                        if (resultR < 0)
                            resultR = 0;

                        if (resultG > 255.0)
                            resultG = 255.0;
                        if (resultG < 0)
                            resultG = 0;

                        if (resultB > 255.0)
                            resultB = 255.0;
                        if (resultB < 0)
                            resultB = 0;


                        dest_img.SetPixel(x, y, Color.FromArgb((int)resultR, (int)resultG, (int)resultB));
                    }

                main_photo_pictureBox.Image = dest_img;
            }
        }

        private void Contrast_trackBar_Scroll(object sender, EventArgs e)
        {
            contrast_value_textBox.Text = contrast_trackBar.Value.ToString();
        }

        private void Contrast_apply_button_Click(object sender, EventArgs e)
        {
            int C = contrast_trackBar.Value;
            double F = (259.0 * (C + 255.0)) / (255.0 * (259.0 - C));

            for (int x = 0; x < main_photo_pictureBox.Image.Width; x++)
                for (int y = 0; y < main_photo_pictureBox.Image.Height; y++)
                {
                    double resultR;
                    double resultG;
                    double resultB;

                    resultR = F * (src_img.GetPixel(x, y).R - 128) + 128;
                    resultG = F * (src_img.GetPixel(x, y).G - 128) + 128;
                    resultB = F * (src_img.GetPixel(x, y).B - 128) + 128;

                    if (resultR > 255.0)
                        resultR = 255.0;
                    if (resultR < 0)
                        resultR = 0;

                    if (resultG > 255.0)
                        resultG = 255.0;
                    if (resultG < 0)
                        resultG = 0;

                    if (resultB > 255.0)
                        resultB = 255.0;
                    if (resultB < 0)
                        resultB = 0;


                    dest_img.SetPixel(x, y, Color.FromArgb((int)resultR, (int)resultG, (int)resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }
        


        // ÖZEL FİLTRELEME İŞLEMLERİ


        private void Mean_filter_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];

            kernel[0, 0] = 1; kernel[0, 1] = 1; kernel[0, 2] = 1;
            kernel[1, 0] = 1; kernel[1, 1] = 3; kernel[1, 2] = 1;
            kernel[2, 0] = 1; kernel[2, 1] = 1; kernel[2, 2] = 1;


            for (int x = 1; x < main_photo_pictureBox.Image.Width - 1; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height - 1; y++)
                {
                    int resultR = 0;
                    int resultG = 0;
                    int resultB = 0;


                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultR += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;
                            resultG += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultB += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                        }

                    resultR /= 11;
                    resultG /= 11;
                    resultB /= 11;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }

        private void Sobel_button_Click(object sender, EventArgs e)
        {
            int[,] kernelX = new int[3, 3];
            int[,] kernelY = new int[3, 3];

            kernelX[0, 0] = -1; kernelX[0, 1] = 0; kernelX[0, 2] = 1;
            kernelX[1, 0] = -2; kernelX[1, 1] = 0; kernelX[1, 2] = 2;
            kernelX[2, 0] = -1; kernelX[2, 1] = 0; kernelX[2, 2] = 1;

            kernelY[0, 0] = 1; kernelY[0, 1] = 2; kernelY[0, 2] = 1;
            kernelY[1, 0] = 0; kernelY[1, 1] = 0; kernelY[1, 2] = 0;
            kernelY[2, 0] = -1; kernelY[2, 1] = -2; kernelY[2, 2] = -1;


            for (int x = 1; x < main_photo_pictureBox.Image.Width - 1; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height - 1; y++)
                {
                    int resultR;   int resultG;   int resultB; 
                    int resultRX = 0;   int resultGX = 0;   int resultBX = 0;   
                    int resultRY = 0;   int resultGY = 0;   int resultBY = 0;   


                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultRX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;
                            resultRY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;

                            resultGX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultGY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;

                            resultBX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                            resultBY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                        }

                    resultR = Convert.ToInt32(Math.Sqrt((resultRX * resultRX) + (resultRY * resultRY)));
                    resultG = Convert.ToInt32(Math.Sqrt((resultGX * resultGX) + (resultGY * resultGY)));
                    resultB = Convert.ToInt32(Math.Sqrt((resultBX * resultBX) + (resultBY * resultBY)));

                    if (resultR > 255)
                        resultR = 255;

                    if (resultG > 255)
                        resultG = 255;

                    if (resultB > 255)
                        resultB = 255;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }

        private void Prewitt_button_Click(object sender, EventArgs e)
        {
            int[,] kernelX = new int[3, 3];
            int[,] kernelY = new int[3, 3];

            kernelX[0, 0] = -1; kernelX[0, 1] = 0; kernelX[0, 2] = 1;
            kernelX[1, 0] = -1; kernelX[1, 1] = 0; kernelX[1, 2] = 1;
            kernelX[2, 0] = -1; kernelX[2, 1] = 0; kernelX[2, 2] = 1;

            kernelY[0, 0] = 1; kernelY[0, 1] = 1; kernelY[0, 2] = 1;
            kernelY[1, 0] = 0; kernelY[1, 1] = 0; kernelY[1, 2] = 0;
            kernelY[2, 0] = -1; kernelY[2, 1] = -1; kernelY[2, 2] = -1;


            for (int x = 1; x < main_photo_pictureBox.Image.Width - 1; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height - 1; y++)
                {
                    int resultR; int resultG; int resultB;
                    int resultRX = 0; int resultGX = 0; int resultBX = 0;
                    int resultRY = 0; int resultGY = 0; int resultBY = 0;


                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultRX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;
                            resultRY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;

                            resultGX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultGY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;

                            resultBX += kernelX[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                            resultBY += kernelY[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                        }

                    resultR = Convert.ToInt32(Math.Sqrt((resultRX * resultRX) + (resultRY * resultRY)));
                    resultG = Convert.ToInt32(Math.Sqrt((resultGX * resultGX) + (resultGY * resultGY)));
                    resultB = Convert.ToInt32(Math.Sqrt((resultBX * resultBX) + (resultBY * resultBY)));

                    if (resultR > 255)
                        resultR = 255;

                    if (resultG > 255)
                        resultG = 255;

                    if (resultB > 255)
                        resultB = 255;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }

        private void Laplacian_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];

            kernel[0, 0] = -1; kernel[0, 1] = -1; kernel[0, 2] = -1;
            kernel[1, 0] = -1; kernel[1, 1] = 8; kernel[1, 2] = -1;
            kernel[2, 0] = -1; kernel[2, 1] = -1; kernel[2, 2] = -1;


            for (int x = 1; x < main_photo_pictureBox.Image.Width - 1; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height - 1; y++)
                {
                    int resultR = 0;
                    int resultG = 0;
                    int resultB = 0;


                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultR += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;
                            resultG += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultB += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                        }

                    if (resultR > 255)
                        resultR = 255;

                    if (resultR < 0)
                        resultR = 0;

                    if (resultG > 255)
                        resultG = 255;

                    if (resultG < 0)
                        resultG = 0;

                    if (resultB > 255)
                        resultB = 255;

                    if (resultB < 0)
                        resultB = 0;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }

        private void Sharpen_button_Click(object sender, EventArgs e)
        {
            int[,] kernel = new int[3, 3];

            kernel[0, 0] = -1; kernel[0, 1] = -1; kernel[0, 2] = -1;
            kernel[1, 0] = -1; kernel[1, 1] = 9; kernel[1, 2] = -1;
            kernel[2, 0] = -1; kernel[2, 1] = -1; kernel[2, 2] = -1;


            for (int x = 1; x < main_photo_pictureBox.Image.Width - 1; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height - 1; y++)
                {
                    int resultR = 0;
                    int resultG = 0;
                    int resultB = 0;


                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultR += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;
                            resultG += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultB += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                        }

                    if (resultR > 255)
                        resultR = 255;

                    if (resultR < 0)
                        resultR = 0;

                    if (resultG > 255)
                        resultG = 255;

                    if (resultG < 0)
                        resultG = 0;

                    if (resultB > 255)
                        resultB = 255;

                    if (resultB < 0)
                        resultB = 0;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }

        private void Gaussian_button_Click(object sender, EventArgs e)
        {
            double[,] kernel = new double[3, 3];

            kernel[0, 0] = 0.0275; kernel[0, 1] = 0.1102; kernel[0, 2] = 0.0275;
            kernel[1, 0] = 0.1102; kernel[1, 1] = 0.4421; kernel[1, 2] = 0.1102;
            kernel[2, 0] = 0.0275; kernel[2, 1] = 0.1102; kernel[2, 2] = 0.0275;

            for (int x = 1; x < main_photo_pictureBox.Image.Width - 1; x++)
                for (int y = 1; y < main_photo_pictureBox.Image.Height - 1; y++)
                {
                    double resultR = 0;
                    double resultG = 0;
                    double resultB = 0;


                    for (int i = 0; i < 3; i++)
                        for (int j = 0; j < 3; j++)
                        {
                            resultR += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).R;
                            resultG += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).G;
                            resultB += kernel[i, j] * src_img.GetPixel(x + i - 1, y + j - 1).B;
                        }


                    dest_img.SetPixel(x, y, Color.FromArgb((int)resultR, (int)resultG, (int)resultB));
                }

            main_photo_pictureBox.Image = dest_img;
        }



        //  TRACKBAR VE TEXTBOX GÖSTERGESİ


        private void Red_trackbar_Scroll(object sender, EventArgs e)
        {
            red_value_textBox.Text = red_trackbar.Value.ToString();
        }

        private void Red_value_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            red_trackbar.Value = Convert.ToInt32(red_value_textBox.Text);
        }

        private void Green_trackbar_Scroll(object sender, EventArgs e)
        {
            green_value_textBox.Text = green_trackbar.Value.ToString();
        }

        private void Green_value_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            green_trackbar.Value = Convert.ToInt32(green_value_textBox.Text);
        }

        private void Blue_trackbar_Scroll(object sender, EventArgs e)
        {
            blue_value_textBox.Text = blue_trackbar.Value.ToString();
        }

        private void Blue_value_textBox_KeyDown(object sender, KeyEventArgs e)
        {
            blue_trackbar.Value = Convert.ToInt32(blue_value_textBox.Text);
        }











        // RGB FİLTRELEME İŞLEMİ


        private void Timer1_Tick(object sender, EventArgs e)
        {
            for (int x = 0; x < main_photo_pictureBox.Image.Width; x++)
            {
                for (int y = 0; y < main_photo_pictureBox.Image.Height; y++)
                {
                    int resultR;
                    int resultG;
                    int resultB;

                    resultR = red_trackbar.Value + src_img.GetPixel(x, y).R;
                    resultG = green_trackbar.Value + src_img.GetPixel(x, y).G;
                    resultB = blue_trackbar.Value + src_img.GetPixel(x, y).B;

                    if (resultR > 255)
                        resultR = 255;

                    if (resultR < 0)
                        resultR = 0;

                    if (resultG > 255)
                        resultG = 255;

                    if (resultG < 0)
                        resultG = 0;

                    if (resultB > 255)
                        resultB = 255;

                    if (resultB < 0)
                        resultB = 0;


                    dest_img.SetPixel(x, y, Color.FromArgb(resultR, resultG, resultB));

                }
            }
            main_photo_pictureBox.Image = dest_img;
        }
    }
}