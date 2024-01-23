using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractnessAndException.Products
{
    public class Keyboard : Product
    {
        private string typeOfKeyboard;
        private string connection;
        private string layout;
        private string color;
        private int weight;
        public string TypeOfKeyboard
        {
            get { return typeOfKeyboard; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Тип клавіатури не може бути порожньою або містити лише пробіли!");
                }
                typeOfKeyboard = value;
            }
        }
        public string Connection {
            get { return connection; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Під'єднання не може бути порожньою або містити лише пробіли!");
                }
                connection = value;
            }
        }
        public string Layout {
            get { return layout; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Розкладка не може бути порожньою або містити лише пробіли!");
                }
                layout = value;
            }
        }
        public string Color {
            get { return color; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Колір не може бути порожньою або містити лише пробіли!");
                }
                color = value;
            }
        }
        public int Weight {
            get { return weight; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Вага не може бути від'ємною!");
                weight = value;
            }
        }

        public Keyboard (string name, decimal price, int count,
            string typeOfKeyboard, string connection, string layout, 
            string color, int weight) : base(name, price, count)
        { 
            TypeOfKeyboard = typeOfKeyboard;
            Connection = connection;
            Layout = layout;
            Color = color;
            Weight = weight;
        }

        public override string Display()
        {
            return $"Назва: {Name}\n" +
                $"Тип клавіатури: {TypeOfKeyboard}\n" +
                $"Під'єднання: {Connection}\n" +
                $"Розкладка: {Layout}\n" +
                $"Колір: {Color}\n" +
                $"Вага: {Weight} гр.\n" +
                $"Кількість: {Count}\n" +
                $"Ціна: {Price} грн.\n\n";
        }

    }
}
