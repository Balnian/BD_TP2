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

        #region Form Load
        private void Ajout_Load(object sender, EventArgs e)
        {
            fillFournisseur();
            CB_Fournisseurs.SelectedItem = 0;
            enableAppliquer();
        }

        #endregion

        #region Bouton Appliquer
        private void BT_Appliquer_Click(object sender, EventArgs e)
        {
            Ajouter();
        }
        #endregion

        #region Évènement pour Changer l'état du bouton Appliquer
        private void NUD_MaxQte_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void NUD_MinQte_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void TB_Description_TextChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        #endregion

        #region Fonctions

        /// <summary>
        /// Remplie CB_Fournisseurs avec les noms des fournisseurs
        /// </summary>
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

        /// <summary>
        /// Ajoute un nouvelle éléments d'inventaire
        /// </summary>
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

        /// <summary>
        /// Change l'état du bouton appliquer les Quantités Minimum Quantités Maximum sont Max > Min  
        /// </summary>
        private void enableAppliquer()
        {
            BT_Appliquer.Enabled = 
                NUD_MinQte.Value < NUD_MaxQte.Value //Min est plus petit que Max (Min < Max)
                && !String.IsNullOrWhiteSpace(TB_Description.Text); //Description pas vide
        }

        #endregion

        

        
    }
}
