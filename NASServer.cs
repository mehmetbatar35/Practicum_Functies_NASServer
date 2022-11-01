using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practicum_Functies_NASServer
{
    internal class NASServer
    {

        public Harddisk Harddisk1 { get; set; } = new Harddisk();
        public Harddisk Harddisk2 { get; set; } = new Harddisk();
        public bool RaidSet { get; set; }


        public string GetDescription()
        {
            string overview = "NAS server overview" + Environment.NewLine;
            overview += "-------------------" + Environment.NewLine;
            overview += " Harddisk 1:" + Environment.NewLine;
            overview += "  Model :" + Harddisk1.Model + Environment.NewLine;
            overview += "  Grootte :" + Harddisk1.Size + Environment.NewLine;
            overview += " Harddisk 2:" + Environment.NewLine;
            overview += "  Model :" + Harddisk2.Model + Environment.NewLine;
            overview += "  Grootte :" + Harddisk2.Size + Environment.NewLine;


            return overview;
        }
        public string CheckRaid(bool isDetail)
        {


            string overview = "NAS - RAID controle" + Environment.NewLine;
            overview += "-------------------" + Environment.NewLine;

            if (RaidSet)
            {
                if (isDetail)
                {
                    if (Harddisk1.Size == Harddisk2.Size)
                    {
                        overview += "RAID configuratie is OK. Disk grootte is " + Harddisk1.Size;
                    }
                    else
                    {
                        overview += "RAID configuratie is niet optimaal. Disk grootte is ";

                        if (Harddisk1.Size < Harddisk2.Size)
                        {
                            overview += Harddisk1.Size;
                        }
                        else
                        {
                            overview += Harddisk2.Size;
                        }
                    }
                }
                else
                {
                    overview += "RAID ondersteuning voorzien";
                }

            }
            else
            {
                overview += "Geen RAID ondersteuning voorzien";
            }
      
            return overview;

        }
    }
}
