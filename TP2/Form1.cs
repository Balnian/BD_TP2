using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataSet Data;
        private void Form1_Load(object sender, EventArgs e)
        {
            recherche();
        }

        private void TB_Recherche_TextChanged(object sender, EventArgs e)
        {
            recherche();
        }

        private void recherche()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();
            
            try
            {
                if (!String.IsNullOrWhiteSpace( TB_Recherche.Text))
                {
                    dico.Add("@Terme", "%"+TB_Recherche.Text+"%");
                    Data = DAL_Inventaire.Query("select * from Inventaire where DescriptionInventaire like @Terme", dico);
                }
                else
                {
                    Data = DAL_Inventaire.Query("select * from Inventaire");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            DGV_Inventaire.AutoGenerateColumns = true;
            DGV_Inventaire.DataSource = Data;
            DGV_Inventaire.DataMember = "Inventaire";
        }

        private void listerInventaireBasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListeInventaireBas inv = new ListeInventaireBas();
            inv.Show();
        }
    }
}
