using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer
{
    public class EntityPersonel
    {
        private int PersonelID;
        private string Name;
        string SurName;
        string City;
        string Duty;
        short Money;

        public int PersonelID1 { get => PersonelID; set => PersonelID = value; }
        public string Name1 { get => Name; set => Name = value; }
        public string SurName1 { get => SurName; set => SurName = value; }
        public string City1 { get => City; set => City = value; }
        public string Duty1 { get => Duty; set => Duty = value; }
        public short Money1 { get => Money; set => Money = value; }
    }
}
