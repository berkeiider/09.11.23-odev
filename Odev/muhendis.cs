using Odev;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev
{
    internal class muhendis : Personel
    {
        public string Birim;
        public string birim
        {
            get { return Birim; }
            set => Birim = value;
        }



    }
}
