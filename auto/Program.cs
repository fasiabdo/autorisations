using System;
using System.Drawing;
using System.Windows.Forms;

namespace auto
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }

        public static void customizeFilre(Panel panel)
        {
            panel.Visible = false;
        }
        public static void HideFiltrePanel(Panel panel)
        {
            if (panel.Visible == true)
                panel.Visible = false;
        }
        public static void ShowpanelFiltre(Panel panel)
        {
            if (panel.Visible == false)
            {
                HideFiltrePanel(panel);
                panel.Visible = true;
            }
            else
                panel.Visible = false;
        }
        static public bool verifierChamps(Label lblauto, Label lbldecision, Label lblnomprenom,
            ComboBox cb_typePermis, TextBox tb__numDecision, TextBox tb_NomPrenom)
        {
            bool remplir_type;
            bool remplir_decision;
            bool remplir_nom;
            if (cb_typePermis.Text == "")
            {
                lblauto.ForeColor = Color.Red;
                remplir_type = false;
            }
            else
            {
                lblauto.ForeColor = Color.Black;
                remplir_type = true;
            }
            if (tb__numDecision.Text == "")
            {
                lbldecision.ForeColor = Color.Red;
                remplir_decision = false;
            }
            else
            {
                lbldecision.ForeColor = Color.Black;
                remplir_decision = true;
            }
            if (tb_NomPrenom.Text == "")
            {
                lblnomprenom.ForeColor = Color.Red;
                remplir_nom = false;
            }
            else
            {
                lblnomprenom.ForeColor = Color.Black;
                remplir_nom = true;
            }
            return remplir_type && remplir_decision && remplir_nom;
        }
    }
}
