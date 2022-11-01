using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_Functies_NASServer
{
    internal class Harddisk
    {
        private int size;
        private string model;
        public int Size
        {
            get { return size; }
            set
            {
                if (value > 0)
                {
                    size = value;
                }
                else
                {
                    size = 0;
                }
            }
        }
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == "")
                {
                    model = "*****";
                }
                else
                {
                    model = value;
                }
            }
        }


    }
}
