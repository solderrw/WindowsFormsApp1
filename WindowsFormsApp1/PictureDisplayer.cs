using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class PictureDisplayer : Form
    {
        Bitmap image1;
        PictureBox pictureBox1;

        // Метод-конструктор нашего класса
        public PictureDisplayer()
        {
            // Указываем размеры и заголовок окна

            this.Text = "Искусство аборигенов";
            this.Size = new Size(302, 240);

            // Подготавливаем поле для размещения изображения

            pictureBox1 = new PictureBox();
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.BorderStyle = BorderStyle.Fixed3D;
            pictureBox1.ClientSize = new Size(300, 196);

            // Добавляем изображение в элемент PictureBox

            image1 = new Bitmap("H:\\Images\\Zakat.jpg");
            pictureBox1.Image = (Image)image1;

            // Добавляем PictureBox (с изображением) на форму

            this.Controls.Add(pictureBox1);
        }
        
    }
}
