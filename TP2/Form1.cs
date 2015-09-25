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

        #region Variables

        private DataSet Data;

        #endregion

        #region Form Load
        private void Form1_Load(object sender, EventArgs e)
        {
            recherche();
        }
        #endregion

        #region Recherche
        private void TB_Recherche_TextChanged(object sender, EventArgs e)
        {
            recherche();
        }
        #endregion

        #region ToolStripMenu
        private void listerInventaireBasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ListerBas();
        }

        

        private void ajouterToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ajouter();
        }

        

        private void suppressionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            supprimer();
        }

        

        private void modifierToolStripMenuItem_Click(object sender, EventArgs e)
        {
            modifier();
        }

        

        private void rafraichirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            recherche();
        }

        private void DGV_Inventaire_DoubleClick(object sender, EventArgs e)
        {
            modifier();
        }

        private void ajouterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ajouter();

        }
        #endregion

        #region Context Menu
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            TSMI_Modifier.Enabled = TSMI_Supprimer.Enabled = DGV_Inventaire.SelectedRows.Count > 0;
        }

        private void TSMI_Modifier_Click(object sender, EventArgs e)
        {
            modifier();
        }

        private void TSMI_Lister_Click(object sender, EventArgs e)
        {
            ListerBas();
        }

        private void TSMI_Supprimer_Click(object sender, EventArgs e)
        {
            supprimer();
        }
        #endregion

        #region Fonctions

        /// <summary>
        /// Fait une recherche avec les termes du TB_Recherche
        /// </summary>
        private void recherche()
        {
            Dictionary<String, Object> dico = new Dictionary<String, Object>();

            try
            {
                if (!String.IsNullOrWhiteSpace(TB_Recherche.Text))
                {
                    dico.Add("@Terme", "%" + TB_Recherche.Text + "%");
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

        /// <summary>
        /// Crée une fenêtre qui affiche les éléments ayant atteind leur minimum ou plus bas
        /// </summary>
        private void ListerBas()
        {
            ListeInventaireBas inv = new ListeInventaireBas();
            inv.Show();
        }

        /// <summary>
        /// Crée une fenêtre qui permet la création d'un élément d'inventaire. Puis rafraichie l'affichage dans le DGV_Inventaire
        /// </summary>
        private void ajouter()
        {
            Ajout aj = new Ajout();
            aj.ShowDialog();
            recherche();
        }

        /// <summary>
        /// Supprime tous les éléments sélectionnés dans le DGV_Inventaire.
        /// Affiche un avertissement avant la suppression.
        /// Puis rafraichie l'affichage dans le DGV_Inventaire
        /// </summary>
        private void supprimer()
        {
            if (DGV_Inventaire.SelectedRows.Count > 0)
            {
                Dictionary<String, Object> dico;
                if (MessageBox.Show("Êtes-vous sur de vouloir supprimer " + ((DGV_Inventaire.SelectedRows.Count > 1) ? ("les " + DGV_Inventaire.SelectedRows.Count.ToString() + " éléments sélectionnés") : "l'élément sélectionné") + "?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    foreach (DataGridViewRow row in DGV_Inventaire.SelectedRows)
                    {
                        dico = new Dictionary<String, Object>();
                        try
                        {

                            dico.Add("@Id", row.Cells["IdInventaire"].Value);
                            int count = 0;
                            if ((count = DAL_Inventaire.NonQuery("delete from Inventaire where IdInventaire = @Id", dico)) != 1)
                            {
                                MessageBox.Show("Une erreur ses produite: " + count.ToString() + " éléments ont été modifiés", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }

                        }
                        catch (Exception ex)
                        {

                            MessageBox.Show(ex.Message);
                        }
                    }
                recherche();
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        /// <summary>
        /// Crée une fenêtre qui permet la modification des éléments sélectionner dans le DGV_Inventaire.
        /// Puis rafraichie l'affichage dans le DGV_Inventaire
        /// </summary>
        private void modifier()
        {
            if (DGV_Inventaire.SelectedRows.Count > 0)
            {
                Dictionary<String, Object> dico;

                foreach (DataGridViewRow row in DGV_Inventaire.SelectedRows)
                {
                    dico = new Dictionary<String, Object>();
                    Modifier mod = new Modifier((int)row.Cells["IdFournisseur"].Value);
                    mod.ShowDialog();
                }
                recherche();
            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        #endregion
    }
}
