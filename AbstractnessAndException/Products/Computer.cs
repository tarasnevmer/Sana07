using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractnessAndException.Products
{
    public class Computer: Product
    {
        public string VideoCard {get;set;}
        public string Processor { get;set;}
        public int AmountOfRAM { get;set;}
        public int Weight {get; set;}
        public int SSDVolume { get; set;}
        public int VideoMemory { get; set;}

        public Computer(string name, decimal price, int count, string videoCard, 
            string processor, int amountOfRAM, int weight, int sSDVolume, 
            int videoMemory) : base (name, price, count)
        {
            VideoCard = videoCard;
            Processor = processor;
            AmountOfRAM = amountOfRAM;
            Weight = weight;
            SSDVolume = sSDVolume;
            VideoMemory = videoMemory;
        }

        public override string Display()
        {
            return $"Назва: {Name}\n" +
                $"Відеокарта: {VideoCard}\n" +
                $"Процесор: {Processor}\n" +
                $"Обсяг оперативної пам'яті: {AmountOfRAM}\n" +
                $"Вага: {Weight} кг\n" +
                $"Обсяг SSD: {SSDVolume} ГБ\n" +
                $"Обсяг відеопам'яті: {VideoMemory} ГБ\n" +
                $"Кількість: {Count}\n" +
                $"Ціна: {Price} грн.\n\n";
        }
    }
}
