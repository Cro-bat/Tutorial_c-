using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Tuto
{
    class ItalianChef : Chef
    {
        public void MakePasta()
        {
            Console.WriteLine("The Chef makes pasta");
        }

        public override void MakeSpecialDish()
        {
            Console.WriteLine("The Chef makes pizza");
        }
    }
}
