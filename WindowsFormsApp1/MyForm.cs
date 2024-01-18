using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class MyForm : Form
    {
        // Объявим элемент ListBox как поле класса:
        // нам придется обращаться к нему из разных методов
        ListBox listBox1;

        // Метод-конструктор нашего класса
        public MyForm()
        {
            InitializeComponent();
            //Размеры формы
            this.Size = new Size(400, 400);
            // Создадим элемент PictureBox, поместим в него изображение,
            // добавим его на форму
            PictureBox pictureBox1 = new PictureBox();

            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            Bitmap image1 = new Bitmap("H:\\Images\\Zakat.jpg");
            pictureBox1.ClientSize = new Size(this.Width, 150);
            pictureBox1.Image = (Image)image1;
            this.Controls.Add(pictureBox1);
            // Создаем объект Button, определяем некоторые из его свойств
            Button button1 = new System.Windows.Forms.Button();
            button1.Location = new Point(150, 160);
            button1.Size = new Size(100, 30);
            button1.Text = "Нажми меня";
            button1.Click += new System.EventHandler(button1_Click);
            this.Controls.Add(button1);

            // Создаем ListBox, определяем свойства и добавляем на форму
            listBox1 = new System.Windows.Forms.ListBox();
            listBox1.Location = new System.Drawing.Point(20, 200);
            listBox1.Size = new Size(this.Width - 40, 100); // change this line
            listBox1.Items.Add("Лес");
            listBox1.Items.Add("Степь ");
            listBox1.Items.Add("Озеро");
            listBox1.Items.Add("Море");
            listBox1.Items.Add("Океан");
            listBox1.SelectedIndex = 2;
            this.Controls.Add(listBox1);
        }

        // Обработчик события, срабатывающий при нажатии кнопки
        void button1_Click(object sender, System.EventArgs e)
        {
            // Выводим сообщение с указанием выбранного в списке пункта
            MessageBox.Show(this, "Вы выбрали " + listBox1.SelectedItem,
            "Уведомление", MessageBoxButtons.OK);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            //
            // MyForm
            //
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Name = "MyForm";
            this.ResumeLayout(false);
        }
    }
}