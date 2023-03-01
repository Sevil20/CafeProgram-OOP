using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgramOOP
{
    public class Drink : Food // Icki
    {
        public Drink(string name, double price, byte size) : base(name, price)
        {
            this.Size = size;
        }

        private byte size;

        public byte Size
        {
            get { return size; }
            set
            {
                if (value <= 0)
                    size = 1;
                else if (value > 3)
                    size = 3;
                else
                    size = value;
            }
        }

        public override string PrintFoodType()
        {
            return nameof(Drink);
        }
    }
}
