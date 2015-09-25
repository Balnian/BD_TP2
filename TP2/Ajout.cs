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
    public partial class Ajout : Form
    {
        DataSet Data;
        public Ajout()
        {
            InitializeComponent();
        }
       
        private void Ajout_Load(object sender, EventArgs e)
        {
            fillFournisseur();
            CB_Fournisseurs.SelectedItem = 0;
        }

        private void fillFournisseur()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {

                Data = DAL_Inventaire.Query("select IdFournisseur, NomFournisseur from Fournisseur");
               
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            CB_Fournisseurs.DataSource = Data.Tables["Inventaire"];
            CB_Fournisseurs.ValueMember = "IdFournisseur";
            CB_Fournisseurs.DisplayMember = "NomFournisseur";
        }

        private void BT_Appliquer_Click(object sender, EventArgs e)
        {
            Ajouter();
        }

        private void Ajouter()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            dico.Add("@Stock", (int)NUD_Stock.Value);
            dico.Add("@Max", (int)NUD_MaxQte.Value);
            dico.Add("@Min", (int)NUD_MinQte.Value);
            dico.Add("@IdFournisseur", CB_Fournisseurs.SelectedValue);
            dico.Add("@Description", TB_Description.Text);

            try
            {

                DAL_Inventaire.NonQuery("insert into Inventaire values(@Description, @IdFournisseur, @Stock, @Min, @Max)", dico);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
