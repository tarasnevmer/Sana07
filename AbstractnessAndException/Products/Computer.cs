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
        private string videoCard;
        private string processor;
        private int amountOfRAM;
        private int weight;
        private int sSDVolume;
        private int videoMemory;

        public string VideoCard {
            get {return videoCard; }
            set 
            {
               if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва відеокарти не може бути порожньою або містити лише пробіли!");
               videoCard = value;
            }
        }
        public string Processor
        {
            get { return processor; }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Назва процесору не може бути порожньою або містити лише пробіли!");
                processor = value;
            }
        }
        public int AmountOfRAM {
            get {return amountOfRAM; }
            set {
                if (value < 0)
                    throw new ArgumentException("Обсяг оперативної пам'яті не може бути від'ємним!");
                amountOfRAM = value;
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
        public int SSDVolume
        {
            get { return sSDVolume; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Обсяг SSD не може бути від'ємним!");
                sSDVolume = value;
            }
        }
        public int VideoMemory {
            get { return videoMemory; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Обсяг відеопам'яті не може бути від'ємним!");
                videoMemory = value;
            }
        }

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
