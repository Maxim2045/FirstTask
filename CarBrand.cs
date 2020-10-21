using System;
using System.Collections;
using System.Collections.Generic;
namespace FirstCode{
     class CarBrand  : IEnumerable {
        List<string> carBrands =new List<string>(){ "Audi", "BMW", "Cadillac", "Daewoo", "Ford", "GMC", 
                               "Honda", "Infinity", "Jeep", "Kia", "Lanf Rover",
                               "Mazda", "Mercedes-Benz", "Nissan", "Opel", "Porshe" ,
                               "Rolls-Royce","Skoda", "Tesla", "Toyota","Volkswagen"};
              
        public string this[int i]{
      get { return carBrands[i]; }
      set { carBrands[i] = value; }
        }
        public IEnumerator GetEnumerator() {
            return carBrands.GetEnumerator();
        }
    }
}