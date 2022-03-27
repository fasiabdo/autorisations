using Autorisations;
using System;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace auto
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void customizeDesing()
        {
            //panelSubMenuRecherche.Visible = false;
            //panelPlayListSubMenu.Visible = false;
            //panelToolsSubMenu.Visible = false;
        }
        private void HideSubMenu()
        {
            //if (panelSubMenuRecherche.Visible == true)
            //    panelSubMenuRecherche.Visible = false;
            //if (panelPlayListSubMenu.Visible == true)
            //    panelPlayListSubMenu.Visible = false;
            //if (panelToolsSubMenu.Visible == true)
            //    panelToolsSubMenu.Visible = false;
        }
        private void ShowSubMenu(Panel SubMenu)
        {
            if (SubMenu.Visible == false)
            {
                HideSubMenu();
                SubMenu.Visible = true;
            }
            else
                SubMenu.Visible = false;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            customizeDesing();
            groupBox1.Enabled = false;
            dgv_fichiers.Enabled = false;
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            //ShowSubMenu(panelSubMenuRecherche);
            openChileForm(new recherche());
        }

        private void btn_inserer_Click(object sender, EventArgs e)
        {
            HideSubMenu();
            if (activeForm != null)
                activeForm.Close();
        }

        private void btn_parcourir_Click(object sender, EventArgs e)
        {
            dgv_fichiers.Rows.Clear();
            string repertoire = "";
            //OpenFileDialog openFileDialog = new OpenFileDialog();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                repertoire = folderBrowserDialog.SelectedPath;
            }
            if (repertoire != string.Empty)
            {
                lbl_chemin.Text = repertoire;
                string[] fichiers = Directory.GetFiles(repertoire);

                foreach (string str in fichiers)
                {
                    if (str.Contains(".pdf"))
                    {
                        dgv_fichiers.Rows.Add(str);
                    }
                }
            }
            groupBox1.Enabled = true;
            dgv_fichiers.Enabled = true;
        }

        private void dgv_fichiers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_fichiers.Rows.Count > 0)
            {
                string fichier = dgv_fichiers.CurrentRow.Cells[0].Value.ToString();
                axAcroPDF2.LoadFile(fichier);
            }
        }

        private void btn_ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                bool verifier = Program.verifierChamps(lblauto, lbldecision, lblnomprenom, cb_typePermis, tb__numDecision, tb_NomPrenom);
                if (verifier)
                {
                    AutorisationEntities entities = new AutorisationEntities();
                    Permi permis = (from p in entities.Permis where p.NDecision == tb__numDecision.Text select p).SingleOrDefault();
                    if (permis == null)
                    {
                        permis = new Permi();
                        permis.NDecision = tb__numDecision.Text;
                        permis.NomPrenom = tb_NomPrenom.Text;
                        permis.Autorisation = tb_NAutorisation.Text;
                        permis.Reference_Fonciers = tb_Reference.Text;
                        if (dtp_pv.Value.Hour == DateTime.Now.Hour)
                            permis.pv = null;
                        else
                            permis.pv = dtp_pv.Value;
                        permis.typePermis = cb_typePermis.GetItemText(cb_typePermis.SelectedItem);
                        string chemin = dgv_fichiers.CurrentRow.Cells[0].Value.ToString();
                        byte[] fichier = File.ReadAllBytes(chemin);
                        permis.document = fichier;
                        entities.Permis.Add(permis);
                        if (entities.SaveChanges() > 0)
                        {
                            MessageBox.Show("insertion avec succès", "Insertion");

                            foreach (Control cl in groupBox1.Controls)
                            {
                                if (cl is TextBox || cl is ComboBox)
                                    cl.Text = "";
                            }
                            dtp_pv.Value = DateTime.Now;
                            dgv_fichiers.Rows.Remove(dgv_fichiers.CurrentRow);
                            File.Delete(chemin);
                        }
                    }
                    else
                        throw new Exception("Ce numéro de décision déjà existe");
                }
                else throw new Exception("Merci de remplir les champs obligatoires");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            //using (SqlConnection cnx = new SqlConnection(strCon))
            //{
            //    cnx.Open();
            //    using(SqlCommand cmd=new SqlCommand())
            //    {
            //        cmd.Connection = cnx;
            //        cmd.CommandText = "insert into Permis values(@NDecision,@NomPrenom,@Autorisation,@Reference_fonciers,@pv,@typePermis,@document)";
            //        cmd.Parameters.AddWithValue("NDecision", tb__numDecision.Text);
            //        cmd.Parameters.AddWithValue("NomPrenom", tb_NomPrenom.Text);
            //        cmd.Parameters.AddWithValue("Autorisation", tb_NAutorisation.Text);
            //        cmd.Parameters.AddWithValue("Reference_fonciers", tb_Reference.Text);
            //        cmd.Parameters.AddWithValue("pv", dtp_pv.Value);
            //        cmd.Parameters.AddWithValue("typePermis", cb_typePermis.GetItemText(cb_typePermis.SelectedItem));
            //        cmd.Parameters.AddWithValue("document", File.ReadAllBytes(dgv_fichiers.CurrentRow.Cells[0].Value.ToString()));
            //        if (cmd.ExecuteNonQuery() > 0)
            //            MessageBox.Show("insertion ok");
            //    }
            //}
        }
        private Form activeForm;
        private void openChileForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            Form frm = new propos();
            frm.Show();
            btn_about.Enabled = false;
            frm.FormClosing += Frm_FormClosing;
        }

        private void Frm_FormClosing(object sender, FormClosingEventArgs e)
        {
            btn_about.Enabled = true;
        }
    }
}
