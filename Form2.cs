using Abonați_telefonici;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Abonaţi_telefonici
{
    public partial class Form2 : Form
    {
        List<Clienti> lista2=new List<Clienti>();
        public Form2(List<Clienti> listaclienti)
        {
            InitializeComponent();
           //\\lista2 = (List<Clienti>)listaclienti;
            foreach (Clienti f in listaclienti)
                lista2.Add(f);
        }


        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void serializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Abonați_telefonici.dat",
            FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, lista2);
            fs.Close();
        }

        private void deserializareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Abonați_telefonici.dat",
            FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
            List<Clienti> lista3 = (List<Clienti>)bf.Deserialize(fs);
            foreach (Clienti f in lista3)
                MessageBox.Show(f.ToString());
            fs.Close();
        }
        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void serializareToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Abonați_telefonici.dat",
            FileMode.Create, FileAccess.Write);
            BinaryFormatter bf = new BinaryFormatter();
            bf.Serialize(fs, lista2);
            fs.Close();

        }

        private void deserealizareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FileStream fs = new FileStream("Abonați_telefonici.dat",
            FileMode.Open, FileAccess.Read);
            BinaryFormatter bf = new BinaryFormatter();
           
            List<Clienti> lista3 = (List<Clienti>)bf.Deserialize(fs);
            foreach (Clienti f in lista3)
            {
              textBox1.Text += f.ToString();
                textBox1.Text += Environment.NewLine;
            }
               
            fs.Close();
        }
    }
}
