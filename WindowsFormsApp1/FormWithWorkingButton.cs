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
    public partial class FormWithWorkingButton : Form
    {
        Button mrButton;
        // Метод-конструктор нашего класса
        public FormWithWorkingButton()
        {
            // Указываем заголовок окна
            this.Text = "Форма с работающей кнопкой!";
            // Добавляем кнопку и привязываем ее к обработчику события
            mrButton = new Button();
            mrButton.Text = "Нажми меня";
            mrButton.Top = 100;
            mrButton.Left = 100;
            mrButton.Height = 50;
            mrButton.Width = 70;
            mrButton.Click += new System.EventHandler(mrButton_Click);
            this.Controls.Add(mrButton);
        }

        

        // Обработчик события, срабатывающий при нажатии кнопки
        void mrButton_Click(object sender, EventArgs e)
        {
            // Изменяем текст
            mrButton.Text = "Кнопка была нажата!";
        }
    }
}

