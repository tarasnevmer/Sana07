using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace AbstractnessAndException.Products
{
    public class Keyboard : Product
    {
        public string TypeOfKeyboard { get; set; }
        public string Connection { get; set; }
        public string Layout { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }

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
