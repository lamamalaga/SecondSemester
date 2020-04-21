using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRLibrary
{
    public enum MedicineWithRecipe
    {
        Yes,
        No
    }

    public class Medicine
    {
        public string Name { get;  set; }
        public string ArticleNumber { get; private set; }
        public string Manufacturer { get; set; }
        public double Price { get; set; }
        public int Count { get; set; }
        public MedicineWithRecipe SaleWithRecipe { get; set; }

        public Medicine(string name, string articleNumber, string manufacturer, MedicineWithRecipe saleWithRecipe)
        {
            Name = name;
            ArticleNumber = articleNumber;
            Manufacturer = manufacturer;
            SaleWithRecipe = saleWithRecipe;
        }

        public override string ToString()
        {
            return  $"{Name} {ArticleNumber}";
        }

        public void PrintInfo()
        {
            Console.WriteLine(this);

            var saleWithRecipe = " ";

            switch (SaleWithRecipe)
            {
                case MedicineWithRecipe.Yes:
                    saleWithRecipe = "Да";
                    break;
                case MedicineWithRecipe.No:
                    saleWithRecipe = "Нет";
                    break;
            }

            Console.WriteLine($"Продажа с рецептом: {saleWithRecipe}, " +
                $"Производитель: {Manufacturer}, Цена: {Price} руб., Количество на скаладе: {Count}.");
        }
    }
}
