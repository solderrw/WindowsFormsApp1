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
    public partial class SimpleWindowsFormWithButton : Form
    {
        
       Button button1;

        // Метод-конструктор нашего класса
        public SimpleWindowsFormWithButton()
        {
            // Указываем заголовок окна
            this.Text = "Форма с командной кнопкой";

            // Добавляем кнопку в коллекцию элементов управления формы
            // Хотя на кнопке написано: "Нажми меня!",
            // пока при нажатии ничего не происходит!
            button1 = new Button();
            button1.Text = "Нажми меня!";
            button1.Top = 100;
            button1.Left = 100;
            button1.Height = 50;
            button1.Width = 70;
            this.Controls.Add(button1);
        }

        
    }
}

