using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractnessAndException.Products
{
    public class Monitor : Product
    {
        public float DisplayDiagonal { get; set; }
        public string DisplayResolution { get; set; }
        public string TypeMatrix { get; set; }
        public int UpdateFrequency { get; set; }

        public Monitor(string name, decimal price, int count, float displayDiagonal, 
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
                $"Ціна: {Price}";
        }

    }
}
