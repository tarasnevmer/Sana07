using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractnessAndException.Products
{
    public class Screen : Product
    {
        private float displayDiagonal;
        private string displayResolution;
        private string typeMatrix;
        private int uptadeFrequency;
        public float DisplayDiagonal {
            get { return displayDiagonal; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Діагональ монітору не може бути від'ємним!");
                displayDiagonal = value;
            }
        }
        public string DisplayResolution {
            get { return displayResolution; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Роздільна здатність дисплея не може бути порожньою або містити лише пробіли!");
                displayResolution = value;
            }
        }
        public string TypeMatrix {
            get { return typeMatrix; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Тип матриці не може бути порожньою або містити лише пробіли!");
                typeMatrix = value;
            }
        }
        public int UpdateFrequency {
            get { return uptadeFrequency; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Частота оновлення монітору не може бути від'ємним!");
                uptadeFrequency = value;
            }
        }

        public Screen(string name, decimal price, int count, float displayDiagonal, 
            string displayResolution, string typeMatrix, int updateFrequency)
            : base (name, price, count)
        { 
            DisplayDiagonal = displayDiagonal;
            DisplayResolution = displayResolution;
            TypeMatrix = typeMatrix;
            UpdateFrequency = updateFrequency;
            
        }

        public override string Display()
        {
            return $"Назва: {Name}\n" +
                $"Діагональ дисплея: {DisplayDiagonal}\n" +
                $"Роздільна здатність дисплея: {DisplayResolution}\n" +
                $"Тип матриці: {TypeMatrix}\n" +
                $"Частота оновлення: {UpdateFrequency} Гц\n" +
                $"Кількість: {Count}\n" +
                $"Ціна: {Price} грн.\n\n";
        }

    }
}
