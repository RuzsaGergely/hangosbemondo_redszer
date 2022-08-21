using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Media;

namespace Hangosbemondo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private List<Hang> hanganyagok = new List<Hang>();

        private void btn_sorrend_fel_Click(object sender, EventArgs e)
        {
            if(lb_sorrend.SelectedIndex != 0)
            {
                var felette = lb_sorrend.Items[lb_sorrend.SelectedIndex - 1];
                var mostani = lb_sorrend.Items[lb_sorrend.SelectedIndex];
                lb_sorrend.Items[lb_sorrend.SelectedIndex] = felette;
                lb_sorrend.Items[lb_sorrend.SelectedIndex - 1] = mostani;
            }
        }

        private void btn_sorrend_le_Click(object sender, EventArgs e)
        {
            if (lb_sorrend.SelectedIndex != lb_sorrend.Items.Count - 1)
            {
                var alatta = lb_sorrend.Items[lb_sorrend.SelectedIndex + 1];
                var mostani = lb_sorrend.Items[lb_sorrend.SelectedIndex];
                lb_sorrend.Items[lb_sorrend.SelectedIndex] = alatta;
                lb_sorrend.Items[lb_sorrend.SelectedIndex + 1] = mostani;
            }
        }

        private void btn_sorrend_torol_Click(object sender, EventArgs e)
        {
            lb_sorrend.Items.Remove(lb_sorrend.SelectedItem);
        }

        private void btn_hozzaad_Click(object sender, EventArgs e)
        {
            lb_sorrend.Items.Add(cb_hozzaadasi_lista.SelectedItem);
        }

        private void Indulas(string Fajl)
        {
            hanganyagok.Clear();
            cb_hozzaadasi_lista.Items.Clear();
            foreach (var item in File.ReadAllLines(Fajl))
            {
                hanganyagok.Add(new Hang(item));
            }

            lb_sorrend.DisplayMember = "Megjelenitesi_nev";
            lb_sorrend.ValueMember = "Eleresiut";

            cb_hozzaadasi_lista.DisplayMember = "Megjelenitesi_nev";
            cb_hozzaadasi_lista.ValueMember = "Eleresiut";
            foreach (var item in hanganyagok)
            {
                cb_hozzaadasi_lista.Items.Add(item);
            }
        }

        private void btn_lejatszas_Click(object sender, EventArgs e)
        {
            SoundPlayer aktualis_hang;
            foreach (Hang item in lb_sorrend.Items)
            {
                aktualis_hang = new SoundPlayer(item.Eleresiut);
                aktualis_hang.PlaySync();
            }
        }

        private void összeállításMentéseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void összeállításBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void konfigurációsFájlBetöltéseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ofd_konfig.Filter = "Szöveges állományok (*.txt)|*.txt|Minden fájl (*.*)|*.*";
            ofd_konfig.Title = "Konfigurációs fájl megnyitása";
            if (ofd_konfig.ShowDialog() == DialogResult.OK)
            {
                Indulas(ofd_konfig.FileName);
                MessageBox.Show("Sikeres betöltés!", "Siker", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cb_hozzaadasi_lista.SelectedIndex = 0;
            }
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.F1)
            {
                btn_lejatszas_Click(null, null);
            }
        }
    }
}
