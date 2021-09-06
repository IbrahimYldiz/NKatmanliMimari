using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntityLayer;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class DalPersonel
    {
        public static List<EntityPersonel> PersonelList()
        {
            SqlCommand komut1 = new SqlCommand("Select * From TblPersonelInfo", Baglanti.blg);
            if (komut1.Connection.State!= ConnectionState.Open)
            {
                komut1.Connection.Open();
            }
            SqlDataReader dr = komut1.ExecuteReader();
            List<EntityPersonel> degerler = new List<EntityPersonel>();
            while (dr.Read())
            {
                EntityPersonel ent = new EntityPersonel();
                ent.PersonelID1 = int.Parse(dr["ID"].ToString());
                ent.Name1 = dr["Name"].ToString();
                ent.SurName1 = dr["SurName"].ToString();
                ent.City1 = dr["City"].ToString();
                ent.Duty1 = dr["Duty"].ToString();
                ent.Money1 = short.Parse(dr["Money"].ToString());
                degerler.Add(ent);
            }
            dr.Close();
            return degerler;
     
            
            
        }
        public static int PersonelAdd1(EntityPersonel P)
        {

            SqlCommand komut2 = new SqlCommand("insert into TblPersonelInfo(Name,SurName,City,Duty,Money) values(@p1,@p2,@p3,@p4,@p5)", Baglanti.blg);
            if (komut2.Connection.State != ConnectionState.Open)
            {
                komut2.Connection.Open();
            }
            komut2.Parameters.AddWithValue("@p1", P.Name1);
            komut2.Parameters.AddWithValue("@p2", P.SurName1);
            komut2.Parameters.AddWithValue("@p3", P.City1);
            komut2.Parameters.AddWithValue("@p4", P.Duty1);
            komut2.Parameters.AddWithValue("@p5", P.Money1);
            return komut2.ExecuteNonQuery();
        }
        public static bool PersonelDelete(int p)
        {
            SqlCommand komut3 = new SqlCommand("Delete From TblPersonelInfo where ID=@p1", Baglanti.blg);
            if (komut3.Connection.State != ConnectionState.Open)
            {
                komut3.Connection.Open();
            }
            komut3.Parameters.AddWithValue("@p1", p);
            return komut3.ExecuteNonQuery()>0;
        }
        public static bool PersonelUpdate(EntityPersonel ent)
        {
            SqlCommand komut4 = new SqlCommand("Update TblPersonelInfo set Name=@p1,SurName=@p2,City=@p3,Duty=@p4,Money=@p5 where ID=@p6", Baglanti.blg);
            if (komut4.Connection.State != ConnectionState.Open)
            {
                komut4.Connection.Open();
            }
            komut4.Parameters.AddWithValue("@p1", ent.Name1);
            komut4.Parameters.AddWithValue("@p2", ent.SurName1);
            komut4.Parameters.AddWithValue("@p3", ent.City1);
            komut4.Parameters.AddWithValue("@p4", ent.Duty1);
            komut4.Parameters.AddWithValue("@p5", ent.Money1);
            komut4.Parameters.AddWithValue("@p6", ent.PersonelID1);
            return komut4.ExecuteNonQuery() > 0;
        }

    }
    
}
