using Autorisations;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace auto
{
    public partial class recherche : Form
    {
        public recherche()
        {
            InitializeComponent();
        }
        static readonly AutorisationEntities dc = new AutorisationEntities();

        //IQueryable<Permi> permisFiltres=dc.Permis;

        List<Permi> lsPermis;

        private void btn_Filtre_Click(object sender, EventArgs e)
        {
            Program.ShowpanelFiltre(panelFiltre);
        }

        private void recherche_Load(object sender, EventArgs e)
        {
            Program.customizeFilre(panelFiltre);
            panel1.Enabled = false;
            dgv_resultatRecherche.Enabled = false;
            groupBox1.Enabled = false;
        }

        private void btn_recherche_Click(object sender, EventArgs e)
        {
            try
            {
                //dc.Database.Connection.ConnectionString = $"data source={ServerClass.server};initial catalog=Autorisation;integrated security=True;MultipleActiveResultSets=True;App=EntityFramework;";
                //dc.Database.Connection.Open();
                //if (dc.Database.Connection.State == ConnectionState.Open)
                //    MessageBox.Show("ok");
                lsPermis = dc.Permis.ToList();
                string typePermis = cb_recherche_typePermis.GetItemText(cb_recherche_typePermis.SelectedItem);
                if (typePermis != "")
                {
                    lsPermis = lsPermis.Where(p => p.typePermis.Contains(typePermis)).ToList();
                }
                if (tb_recherche_nomOuPrenom.Text != "")
                {
                    lsPermis = lsPermis.Where(p => p.NomPrenom.Contains(tb_recherche_nomOuPrenom.Text)).ToList();
                }

                if (tb_recherche_NDecision.Text != "")
                {
                    lsPermis = lsPermis.Where(p => p.NDecision.Contains(tb_recherche_NDecision.Text)).ToList();
                }

                if (tb_recherche_NAutorisation.Text != "")
                {
                    lsPermis = lsPermis.Where(p => p.Autorisation.Contains(tb_recherche_NAutorisation.Text)).ToList();
                }

                dgv_resultatRecherche.DataSource = lsPermis;
                dgv_resultatRecherche.Columns["document"].Visible = false;
                string NDecision = dgv_resultatRecherche.Rows[0].Cells[0].Value.ToString();
                afficher_Informations(NDecision);
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
        private void afficher_Informations(string NDecision)
        {
            Permi permis = dc.Permis.Where(p => p.NDecision.Contains(NDecision)).FirstOrDefault();
            if (permis != null)
            {
                cb_typePermis.Text = permis.typePermis;
                tb__numDecision.Text = permis.NDecision;
                tb_NomPrenom.Text = permis.NomPrenom;
                tb_NAutorisation.Text = permis.Autorisation;
                tb_Reference.Text = permis.Reference_Fonciers;
                if (permis.pv != null)
                    dtp_pv.Value = (DateTime)permis.pv;
                fichier = permis.document;
                //donner un chemin temporaire a ce fichier
                string filePath = Path.GetTempFileName();
                File.WriteAllBytes(filePath, fichier);
                axAcroPDF2.LoadFile(filePath);
                File.Delete(filePath);
                tb_fichier.Text = "";
                //PdfiumViewer.PdfDocument pdf = PdfiumViewer.PdfDocument.Load(memStream);
                //pdfRenderer1.Load(pdf);
            }
        }
        private void cb_recherche_typePermis_SelectionChangeCommitted(object sender, EventArgs e)
        {
            panel1.Enabled = true;
            dgv_resultatRecherche.Enabled = true;
            groupBox1.Enabled = true;

        }
        public byte[] fichier;
        private void dgv_resultatRecherche_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dgv_resultatRecherche.Rows.Count > 0)
                {
                    string NDecision = dgv_resultatRecherche.CurrentRow.Cells[0].Value.ToString();
                    afficher_Informations(NDecision);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_parcourir_Click(object sender, EventArgs e)
        {
            if (btn_parcourir.Text.Contains("parcourir"))
            {
                OpenFileDialog openFile = new OpenFileDialog();
                openFile.Filter = "fichier PDF (*.pdf)|*.pdf";
                openFile.Title = "choissez une autorisation";
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string fileName = openFile.FileName;
                    tb_fichier.Text = fileName;
                    axAcroPDF2.LoadFile(fileName);
                }
                btn_parcourir.Text = "Annuler";
            }
            else
            {
                string filePath = Path.GetTempFileName();
                File.WriteAllBytes(filePath, fichier);
                axAcroPDF2.LoadFile(filePath);
                File.Delete(filePath);
                tb_fichier.Text = "";
                btn_parcourir.Text = "parcourir ...";
            }
        }

        private void btn_modifier_Click(object sender, EventArgs e)
        {
            try
            {
                bool verifier = Program.verifierChamps(lblauto, lbldecision, lblnomprenom, cb_typePermis, tb__numDecision, tb_NomPrenom);
                if (verifier)
                {
                    string NDecision = dgv_resultatRecherche.CurrentRow.Cells[0].Value.ToString();
                    Permi permis = dc.Permis.Where(p => p.NDecision.ToUpper() == NDecision.ToUpper()).SingleOrDefault();
                    if (permis != null)
                    {
                        //permis.NDecision = tb__numDecision.Text;
                        permis.NomPrenom = tb_NomPrenom.Text;
                        permis.Autorisation = tb_NAutorisation.Text;
                        permis.Reference_Fonciers = tb_Reference.Text;
                        if (dtp_pv.Value.Hour == DateTime.Now.Hour)
                            permis.pv = null;
                        else
                            permis.pv = dtp_pv.Value;
                        permis.typePermis = cb_typePermis.GetItemText(cb_typePermis.SelectedItem);
                        if (tb_fichier.Text != "")
                            permis.document = File.ReadAllBytes(tb_fichier.Text);
                        if (dc.SaveChanges() > 0)
                        {
                            MessageBox.Show("Modification avec succès", "Modification");
                            btn_recherche_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                string Ndecision = dgv_resultatRecherche.CurrentRow.Cells[0].Value.ToString();
                Permi permis = dc.Permis.Where(p => p.NDecision.ToUpper() == Ndecision.ToUpper()).SingleOrDefault();
                if (permis != null)
                {
                    if (MessageBox.Show("Voulez-vous vraiment supprimer ce permis", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        dc.Permis.Remove(permis);
                        if (dc.SaveChanges() > 0)
                        {
                            MessageBox.Show("Suppression avec succès", "Suppression");
                            btn_recherche_Click(sender, e);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void btn_telecharger_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.Filter = "(*.pdf)|*.pdf";
                savefile.FileName = tb_NomPrenom.Text;
                if (savefile.ShowDialog() == DialogResult.OK)
                {
                    using (FileStream fs = new FileStream(savefile.FileName, FileMode.CreateNew))
                    {
                        BinaryWriter writer = new BinaryWriter(fs);
                        writer.Write(fichier);
                        writer.Close();
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
        }
    }
}
