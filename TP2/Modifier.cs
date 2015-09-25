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
    public partial class Modifier : Form
    {
        
        public Modifier(int IdInventaire)
        {
            InitializeComponent();
            this.IdInventaire = IdInventaire;
        }

        #region Variables

        private int IdInventaire;
        private DataSet Data;
        private DataSet DataFournisseur;

        private int CurrStock;
        private int CurrMax;
        private int CurrMin;
        private int CurrFournisseur;
        private String CurrDescription;

        #endregion

        #region Form Load
        private void Modifier_Load(object sender, EventArgs e)
        {

            getData();
            enableAppliquer();

        }

        #endregion

        #region Bouton Appliquer
        private void BT_Appliquer_Click(object sender, EventArgs e)
        {
            save();
        }
        #endregion

        #region Évènement pour Changer l'état du bouton Appliquer
        private void NUD_Stock_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void NUD_MaxQte_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void NUD_MinQte_ValueChanged(object sender, EventArgs e)
        {
            enableAppliquer();
        }

        private void CB_Fournisseurs_SelectedIndexChanged(object sender, EventArgs e)
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
        /// Vas chercher les valeur relier à l'ID reçu à la construction
        /// </summary>
        private void getData()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {

                dico.Add("@IdInventaire", IdInventaire);
                Data = DAL_Inventaire.Query("select * from Inventaire where IdInventaire = @IdInventaire", dico);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            fillFournisseur();
            registerCurrentValue();
            ResetValues();
        }

        /// <summary>
        /// remet les valeur dans les controle à leur état d'origine (BD)
        /// </summary>
        private void ResetValues()
        {
            NUD_Stock.Value = CurrStock;
            NUD_MaxQte.Value = CurrMax;
            NUD_MinQte.Value = CurrMin;
            TB_Description.Text = CurrDescription;
            CB_Fournisseurs.SelectedValue = CurrFournisseur;
        }

        /// <summary>
        /// Appeler une seul fois au début enregitre les valeurs de l'enregistrement pour comparaison si elles changent
        /// </summary>
        private void registerCurrentValue()
        {
            DataRow Row = Data.Tables["Inventaire"].Rows[0];
            CurrDescription = (string)Row.ItemArray[1];
            CurrFournisseur = (int)Row.ItemArray[2];
            CurrStock = (int)Row.ItemArray[3];
            CurrMin = (int)Row.ItemArray[4];
            CurrMax = (int)Row.ItemArray[5];
        }

        /// <summary>
        /// Remplie CB_Fournisseurs avec les noms des fournisseurs
        /// </summary>
        private void fillFournisseur()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {

                DataFournisseur = DAL_Inventaire.Query("select IdFournisseur, NomFournisseur from Fournisseur");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            CB_Fournisseurs.DataSource = DataFournisseur.Tables["Inventaire"];
            CB_Fournisseurs.ValueMember = "IdFournisseur";
            CB_Fournisseurs.DisplayMember = "NomFournisseur";
        }

        /// <summary>
        /// Modifie l'enregitrement dans la Base de données
        /// </summary>
        void save()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            dico.Add("@Idinventaire", IdInventaire);
            dico.Add("@Stock", (int)NUD_Stock.Value);
            dico.Add("@Max", (int)NUD_MaxQte.Value);
            dico.Add("@Min", (int)NUD_MinQte.Value);
            dico.Add("@IdFournisseur", CB_Fournisseurs.SelectedValue);
            dico.Add("@Description", TB_Description.Text);

            try
            {

                DAL_Inventaire.NonQuery("update Inventaire set DescriptionInventaire = @Description, IdFournisseur = @IdFournisseur, QteStock = @Stock, QteMinimum = @Min, QteMaximum = @Max where IdInventaire = @Idinventaire", dico);

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Change l'état du bouton appliquer si un des champs n'est pas égale à sa valeur d'origine (BD)
        /// </summary>
        private void enableAppliquer()
        {
            BT_Appliquer.Enabled = (
                (int)NUD_Stock.Value != CurrStock 
                || (int)NUD_MinQte.Value != CurrMin 
                || (int)NUD_MaxQte.Value != CurrMax 
                || (int)CB_Fournisseurs.SelectedValue != CurrFournisseur 
                || TB_Description.Text != CurrDescription)
                && NUD_MinQte.Value < NUD_MaxQte.Value
                && !String.IsNullOrWhiteSpace(TB_Description.Text);
        }

        #endregion
    }
}
