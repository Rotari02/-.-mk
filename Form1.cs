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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

using System.Drawing.Design;
using Abonați_telefonici;
using System.Drawing.Printing;

namespace Abonaţi_telefonici
{

    public partial class Form1 : Form
    {
        double[] vect = new double[30];
        int nrElem = 0;
        bool vb = false;
        Graphics gr;
        const int marg = 10;
        Color culoare = Color.Blue;
        Font font = new Font(FontFamily.GenericSansSerif, 10);

        List<TipAbonament> listaTipAbonament = new List<TipAbonament>();
        List<Plati> listaPlati = new List<Plati>();
        List<Clienti> listaClienti = new List<Clienti>();
        TipAbonament abonament;
        Clienti client;
        //    public partial class Form1 : Form
        //{
        public Form1()
        {
            InitializeComponent();
            //gr = panel1.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            if (tbNumeAbonament.Text == "")
                errorProvider1.SetError(tbNumeAbonament, "Introduceti numele abonamentului!");
            else
            if (tbPretAbonament.Text == "")
                errorProvider1.SetError(tbPretAbonament, "Introduceti pretul abonamentului!");
            else
             if (tbMinuteIncluse.Text == "")
                errorProvider1.SetError(tbMinuteIncluse, "Introduceti minutele incluse!");
            else
             if (tbTraficDateIncluse.Text == "")
                errorProvider1.SetError(tbTraficDateIncluse, "Introduceti traficul de date inclus!");
            else
             if (tbSMSIncluse.Text == "")
                errorProvider1.SetError(tbSMSIncluse, "Introduceti SMS-urile incluse!");
            else
             if (tbMinuteInternationale.Text == "")
                errorProvider1.SetError(tbMinuteInternationale, "Introduceti minutele internationale!");
            else
             if (tbRoaming.Text == "")
                errorProvider1.SetError(tbRoaming, "Introduceti roaming-ul!");

            else
            {

                errorProvider1.Clear();
                try
                {
                    string NumeAbonament = tbNumeAbonament.Text;
                    double PretAbonamentf = Convert.ToDouble(tbPretAbonament.Text);
                    int MinuteIncluse = Convert.ToInt32(tbMinuteIncluse.Text);
                    int TraficDateInclus = Convert.ToInt32(tbTraficDateIncluse.Text);
                    int SMSIncluse = Convert.ToInt32(tbSMSIncluse.Text);
                    int MinuteInternationale = Convert.ToInt32(tbMinuteInternationale.Text);
                    int Roaming = Convert.ToInt32(tbRoaming.Text);

                    abonament = new TipAbonament(NumeAbonament, PretAbonamentf, MinuteIncluse, TraficDateInclus, SMSIncluse, MinuteInternationale, Roaming);
                    MessageBox.Show(abonament.ToString());
                    listaTipAbonament.Add(abonament);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNumeAbonament.Clear();
                    tbPretAbonament.Clear();
                    tbMinuteIncluse.Clear();
                    tbTraficDateIncluse.Clear();
                    tbSMSIncluse.Clear();
                    tbMinuteInternationale.Clear();
                    tbRoaming.Clear();
                }


            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (tbNumeClient.Text == "")
                errorProvider1.SetError(tbNumeClient, "Introduceti numele clientului!");
            else
              if (tbAdresa.Text == "")
                errorProvider1.SetError(tbAdresa, "Introduceti adresa!");
            else
              if (tbNumarTelefon.Text == "")
                errorProvider1.SetError(tbNumarTelefon, "Introduceti nr. de telefon!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    string NumeClient = tbNumeClient.Text;
                    string Adresa = tbAdresa.Text;
                    string NumarTelefon = tbNumarTelefon.Text;

                    client = new Clienti(NumeClient, Adresa, NumarTelefon);
                    MessageBox.Show(client.ToString());
                    listaClienti.Add(client);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbNumeClient.Clear();
                    tbAdresa.Clear();
                    tbNumarTelefon.Clear();
                }
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (tbIdPlata.Text == "")
                errorProvider1.SetError(tbIdPlata, "Introduceti ID-ul platii!");
            else
     if (tbSumaPlata.Text == "")
                errorProvider1.SetError(tbSumaPlata, "Introduceti suma de plata!");
            else
     if (tbDataPlata.Text == "")
                errorProvider1.SetError(tbDataPlata, "Introduceti data platii!");
            else
            {
                errorProvider1.Clear();
                try
                {
                    int IdPlata = Convert.ToInt32(tbIdPlata.Text);
                    float SumaPlata = (float)Convert.ToDouble(tbSumaPlata.Text);
                    string DataPlataS = tbDataPlata.Text;
                    DateTime data = Convert.ToDateTime(tbDataPlata.Text);


                    Plati plata = new Plati(IdPlata, SumaPlata, data);
                    MessageBox.Show(plata.ToString());
                    listaPlati.Add(plata);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    tbIdPlata.Clear();
                    tbSumaPlata.Clear();
                    tbDataPlata.Clear();
                }
            }

        }

        private void generToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Abonați_telefonici.txt");
            sw.WriteLine(tbNumeAbonament.Text);
            sw.WriteLine(tbPretAbonament.Text);
            sw.WriteLine(tbMinuteIncluse.Text);
            sw.WriteLine(tbTraficDateIncluse.Text);
            sw.WriteLine(tbSMSIncluse.Text);
            sw.WriteLine(tbMinuteInternationale.Text);
            sw.WriteLine(tbRoaming.Text);

            sw.WriteLine(tbIdPlata.Text);
            sw.WriteLine(tbSumaPlata.Text);
            sw.WriteLine(tbDataPlata.Text);

            sw.WriteLine(tbNumeClient.Text);
            sw.WriteLine(tbAdresa.Text);
            sw.WriteLine(tbNumarTelefon.Text);
            sw.Close();

                  /*  StreamWriter sw1 = new StreamWriter("preturiAbonamente.txt");
                      string pretAbonamentS = tbPretAbonament.Text;
                      string[] vectPretAbonamentS = pretAbonamentS.Split(',');
                      int[] vectPretAbonmanet = new int[pretAbonamentS.Length];
            for (int i = 0; i < pretAbonamentS.Length; i++)
            {
                vectPretAbonmanet[i] = Convert.ToInt32(pretAbonamentS[i]);
                sw1.WriteLine(vectPretAbonmanet[i]);
            }*/

                 // sw1.Close();
        }

        private void afisareInformatiiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("Abonați_telefonici.txt");
            tbNumeAbonament.Text = sr.ReadLine();
            tbPretAbonament.Text = sr.ReadLine();
            tbMinuteIncluse.Text = sr.ReadLine();
            tbTraficDateIncluse.Text = sr.ReadLine();
            tbSMSIncluse.Text = sr.ReadLine();
            tbMinuteInternationale.Text = sr.ReadLine();
            tbRoaming.Text = sr.ReadLine();

            tbIdPlata.Text = sr.ReadLine();
            tbSumaPlata.Text = sr.ReadLine();
            tbDataPlata.Text = sr.ReadLine();

            tbNumeClient.Text = sr.ReadLine();
            tbAdresa.Text = sr.ReadLine();
            tbNumarTelefon.Text = sr.ReadLine();
            //panel1.Invalidate();
            sr.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2(listaClienti);
            frm.ShowDialog();
        }


        private void tbNumarTelefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbPretAbonament_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == ',' || e.KeyChar == '.' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbRoaming_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8)
                e.Handled = false;
            else
                e.Handled = true;
        }

        private void tbDataPlata_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8 || e.KeyChar == '/' || e.KeyChar == '-')
                e.Handled = false;
            else
                e.Handled = true;

        }

        private void tbNumeClient_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= '0' && e.KeyChar <= '9')
                e.Handled = true;
            else e.Handled = false;
        }
        private void pd_print(object sender, PrintPageEventArgs e)
        {
            gr = e.Graphics;
            if (vb == true)
            {
                Rectangle rec = new Rectangle(e.PageBounds.X + marg,
                    e.PageBounds.Y + 2 * marg,
                    e.PageBounds.Width - 2 * marg,
                    e.PageBounds.Height - 3 * marg);
                Pen pen = new Pen(Color.Red, 3);
                gr.DrawRectangle(pen, rec);

                double latime = rec.Width / nrElem / 2;
                double distanta = (rec.Width - nrElem * latime) / (nrElem + 1);
                double vMax = vect.Max();

                Brush br = new SolidBrush(culoare);

                Rectangle[] recs = new Rectangle[nrElem];
                for (int i = 0; i < nrElem; i++)
                {
                    recs[i] = new Rectangle((int)(rec.Location.X + (i + 1) * distanta + i * latime),
                        (int)(rec.Location.Y + rec.Height - (vect[i] / vMax) * rec.Height),
                        (int)latime,
                        (int)((vect[i] / vMax) * rec.Height));
                    //gr.DrawRectangle(pen, recs[i]);
                    //gr.FillRectangle(br, recs[i]);
                    //gr.FillEllipse(br, recs[i]);
                    gr.DrawString(vect[i].ToString(),
                        font,
                        br, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y - font.Height)));

                }
                gr.FillRectangles(br, recs);
                for (int i = 0; i < nrElem - 1; i++)
                    gr.DrawLine(pen, new Point((int)(recs[i].Location.X + latime / 2),
                        (int)(recs[i].Location.Y)),
                        new Point((int)(recs[i + 1].Location.X + latime / 2),
                        (int)(recs[i + 1].Location.Y)));
            }
        }
        private void printareToolStripMenuItem_Click(object sender, EventArgs e)
        {
          /* PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(pd_print);
            PrintPreviewDialog dlg = new PrintPreviewDialog();
            dlg.Document = pd;
            dlg.ShowDialog();*/
            /*printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.ShowDialog();*/
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
              StringReader sr = new StringReader("Abonați_telefonici.txt");
              //e.Graphics.DrawString("Welcome to spykerTech", new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 20));
              e.Graphics.DrawString(sr.ReadLine(), new Font("Arial", 20, FontStyle.Regular), Brushes.Black, new Point(20, 20));
  
        }

    }












}

