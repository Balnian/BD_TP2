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
    public partial class ListeInventaireBas : Form
    {
        public ListeInventaireBas()
        {
            InitializeComponent();
        }

        private DataSet Data;

        private void ListeInventaireBas_Load(object sender, EventArgs e)
        {
            recherche();
        }
        private void recherche()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {

                Data = DAL_Inventaire.Query("select f.NomFournisseur, i.DescriptionInventaire, i.QteMaximum - i.QteStock as 'Quantitée à Commander'  from Inventaire i left join Fournisseur f on i.IdFournisseur = f.IdFournisseur  where QteStock <= QteMinimum");
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            DGV_Inventaire.AutoGenerateColumns = true;
            DGV_Inventaire.DataSource = Data;
            DGV_Inventaire.DataMember = "Inventaire";
        }
    }
}
