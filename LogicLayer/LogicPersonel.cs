using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using DataAccessLayer;

namespace LogicLayer
{
    public class LogicPersonel
    {
        public static List<EntityPersonel> LLPersonelList()
        {
            return DalPersonel.PersonelList();
            
        }
        public static int LLPersonelAdd(EntityPersonel P)
        {
            if(P.Name1 !="" && P.SurName1 !="" && P.Money1>=3500 && P.Name1.Length>=3)
            {
                return DalPersonel.PersonelAdd1(P);
            }
            else
            {
                return -1;
            }
        }
        public static bool LLPersonelDelete(int per)
        {
            if(per>=1)
            {
                return DalPersonel.PersonelDelete(per);
            }
            else
            {
                return false;
            }
        }
        public static bool LLPersonelUpdate(EntityPersonel ent)
        {
            if(ent.Name1.Length>=3 && ent.Money1>=4500)
            {
                return DalPersonel.PersonelUpdate(ent);
            }
            else
            {
                return false;
            }
        }
    }
}
