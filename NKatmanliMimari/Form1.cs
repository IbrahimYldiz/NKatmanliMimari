using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccessLayer;
using EntityLayer;
using LogicLayer;

namespace NKatmanliMimari
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            List<EntityPersonel> PerList = LogicPersonel.LLPersonelList();
            dataGridView1.DataSource = PerList;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.Name1 = TxtName.Text;
            ent.SurName1 = TxtSurName.Text;
            ent.City1 = TxtCity.Text;
            ent.Duty1 = TxtDuty.Text;
            ent.Money1 = short.Parse(TxtMoney.Text);
            LogicPersonel.LLPersonelAdd(ent);
            
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelID1 = Convert.ToInt32(TxtID.Text);
            LogicPersonel.LLPersonelDelete(ent.PersonelID1);
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            EntityPersonel ent = new EntityPersonel();
            ent.PersonelID1 = Convert.ToInt32(TxtID.Text);
            ent.Name1 = TxtName.Text;
            ent.SurName1 = TxtSurName.Text;
            ent.City1 = TxtCity.Text;
            ent.Duty1 = TxtDuty.Text;
            ent.Money1 = short.Parse(TxtMoney.Text);
            LogicPersonel.LLPersonelUpdate(ent);
        }
    }
}
