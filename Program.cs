using System;

namespace FirstCode
{
    class Program
    {
        static void Main(string[] args)
        {
            CarBrand carBrand = new CarBrand();
            carBrand[7]="Автоваз";
            foreach(var brand in carBrand)
            {
                Console.WriteLine(brand);
            }       
           
           // Console.WriteLine("Hello World!");
        }
    }
}
