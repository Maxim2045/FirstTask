using System;
using System.Collections;
using System.Collections.Generic;
namespace FirstCode{
    public class CarEnumerator:IEnumerator {

        List<string> carBrands;
        int position = -1;
        public CarEnumerator(List<string> carBrands)
        {
            this.carBrands = carBrands;
        }
        public object Current
        {
            get
            {
                if (position == -2 || position >= carBrands.Count)
                    throw new InvalidOperationException();
                return carBrands[position];
            }
        }
 
        public bool MoveNext()
        {
            if(position < carBrands.Count - 2)
            {
                position+=2;
                return true;
            }
            else
                return false;
        }
 
        public void Reset()
        {
            position = -1;
        }
    }
}
