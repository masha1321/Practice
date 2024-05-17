using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class MyCustomControl : UserControl
    {
        // Добавьте элементы управления и логику вашего компонента здесь

        public MyCustomControl()
        {
            // Инициализация компонента
            InitializeComponents();
        }

        private void InitializeComponents()
        {
            // Создайте элементы управления (например, кнопки, текстовые поля и т. д.)
            // Настройте их свойства и добавьте обработчики событий

            // Пример:
            Button myButton = new Button();
            myButton.Text = "Нажми!";
            myButton.Click += MyButton_Click;

            // Добавьте элементы на панель компонента
            Controls.Add(myButton);
        }

        private void MyButton_Click(object sender, EventArgs e)
        {
            // Обработчик события для кнопки
            MessageBox.Show("Привет, Владик Шмель!");
        }
    }
}
