using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CafeProgramOOP
{
    public class Meal : Food // Yemek
    {
        public Meal(string name, double price, bool iscold) : base(name, price)
        {
            this.isCold = iscold;
        }

        public bool isCold { get; set; }

        public override string PrintFoodType()
        {
            return nameof(Meal);
        }
    }
}