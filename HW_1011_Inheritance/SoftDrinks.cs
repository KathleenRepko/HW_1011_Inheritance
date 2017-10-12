using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW_1011_Inheritance
{
    class SoftDrinks : Beverages
    {
        private bool hasCaffeine;
        private bool isDiet;

        public bool HasCaffeine
        {
            get { return this.hasCaffeine; }
            set { this.hasCaffeine = hasCaffeine; }
        }


        SoftDrinks(int volume, bool isFizzy, string color, bool isClear, bool hasCaffeine, bool isDiet)
            
        {
            this.Volume = volume;
            this.isFizzy = isFizzy;
            this.Color = color;
            this.isClear = isClear;
            this.hasCaffeine = hasCaffeine;
            this.isDiet = isDiet;
        }
}
