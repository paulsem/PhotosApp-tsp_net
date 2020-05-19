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


namespace WindowsFormsApp1
{
    
    public partial class Form1 : Form
    {
        InterfacePhotosAppClient client = new InterfacePhotosAppClient();
        public Form1()
        {
            InitializeComponent();

            if (textBoxPath.Text.Length > 0)
            {
                String path = Convert.ToString(textBoxPath.Text);
                if (client.checkPath(path) == false)
                {
                    List<string> aux = client.getDetails(path);
                    Details(aux[0], aux[1], aux[2], Convert.ToDateTime(aux[3]), aux[4]);
                }
            }
        }

        public void Details(String path, String locatie, String anotimp, DateTime data, string persons)
        {
            detailsBox.Items.Clear();
            detailsBox.Items.Add("Path: " + path);
            detailsBox.Items.Add("Locatie: " + locatie);
            detailsBox.Items.Add("Anotimp: " + anotimp);
            detailsBox.Items.Add("Data: " + data);
            detailsBox.Items.Add("Persoane: " + persons);
        }

        public void Paths(String path)
        {
            searchView.Items.Add(path);
        }

        public void displayImages(List<string> paths)
        {
            panelImages.Controls.Clear();
            int x = 20;
            int y = 20;
            int maxHeight = -1;
            
            foreach (var image in paths)
            {
                
                    PictureBox pic = new PictureBox();
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic.Image = Image.FromFile(image);
                    pic.Location = new Point(x, y);
                    x += pic.Width + 10;
                    maxHeight = Math.Max(pic.Height, maxHeight);
                    if (x > this.ClientSize.Width - 100)
                    {
                        x = 20;
                        y += maxHeight + 10;
                    }
                    this.panelImages.Controls.Add(pic);
                
            }
        }

 

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            detailsBox.Items.Clear();
            string path = Convert.ToString(textBox1.Text);
            textBoxPath.Clear();
            locationBox.Clear();
            PersoaneBox.Clear();

            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {

                Bitmap bmp = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = bmp;
                textBox1.Text = open.FileName;
                textBoxPath.Text = open.FileName;


                if (client.checkPath(textBoxPath.Text) == false)
                {
                    List<string> aux = client.getDetails(textBoxPath.Text);
                    locationBox.Text = aux[1];
                    anotimpBox.Text = aux[2];
                    dateTimePicker1.Value = Convert.ToDateTime(aux[3]);
                    PersoaneBox.Text = aux[4];
                    Details(aux[0], aux[1], aux[2], Convert.ToDateTime(aux[3]), aux[4]);


                }
            }
  
        }



        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();


            string filePath = open.InitialDirectory;
            searchView.Items.Add(filePath);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            detailsBox.Items.Clear();
            string path = Convert.ToString(textBoxPath.Text);
            string locatie = Convert.ToString(locationBox.Text);
            string anotimp = Convert.ToString(anotimpBox.Text);
            DateTime data = Convert.ToDateTime(dateTimePicker1.Value);
            string persoana = Convert.ToString(PersoaneBox.Text);
            string[] persons = persoana.Split(' ');


            if (client.checkPath(path) == false)
            {
                List<string> aux = client.getDetails(path);
                Details(aux[0], aux[1], aux[2], Convert.ToDateTime(aux[3]), aux[4]);
            }
            else
            {
                Details(path, locatie, anotimp, data, persoana);
                client.insertNewImage(path, locatie, anotimp, data, persons);
            }
            MessageBox.Show("Imaginea a fost adaugata in baza de date !");

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string search = searchText.Text;
            if (search.Length > 0)
            {
                List<string> aux = client.getPaths(search);
                searchView.Items.Clear();
                displayImages(aux);
                foreach (var x in aux)
                {
                    Paths(x);
                }
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            detailsBox.Items.Clear();
            string path = Convert.ToString(textBox1.Text);
            textBoxPath.Clear();
            locationBox.Clear();
            PersoaneBox.Clear();
            if (client.checkPath(path) == false)
            {
                List<string> aux = client.getDetails(path);

                textBoxPath.Text = aux[0];
                locationBox.Text = aux[1];
                anotimpBox.Text = aux[2];
                dateTimePicker1.Value = Convert.ToDateTime(aux[3]);
                PersoaneBox.Text = aux[4];
                Details(aux[0], aux[1], aux[2], Convert.ToDateTime(aux[3]), aux[4]);
            }
            else
            {
                MessageBox.Show("Imaginea nu exista in baza de date");
            }


        }

        private void updateDetalii_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            if (client.checkPath(path) == false)
            {
                List<string> aux = client.getDetails(path);
                Details(aux[0], aux[1], aux[2], Convert.ToDateTime(aux[3]), aux[4]);
                string locatie = Convert.ToString(locationBox.Text);
                string anotimp = Convert.ToString(anotimpBox.Text);
                DateTime data = Convert.ToDateTime(dateTimePicker1.Value);
                string persoana = Convert.ToString(PersoaneBox.Text);
                string[] persons = persoana.Split(' ');
                client.updateDetails(path, locatie, anotimp, data, persons);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            string path = textBox1.Text;
            client.deleteDetails(path);
            MessageBox.Show("Poza stearsa cu succes");
            detailsBox.Items.Clear();
        }

        private void videoBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();


            open.Filter = "All Media Files|*.wav;*.aac;*.wma;*.wmv;*.avi;*.mpg;*.mpeg;*.m1v;*.mp2;*.mp3;*.mpa;*.mpe;*.m3u;*.mp4;*.mov;*.3g2;*.3gp2;*.3gp;*.3gpp;*.m4a;*.cda;*.aif;*.aifc;*.aiff;*.mid;*.midi;*.rmi;*.mkv;*.WAV;*.AAC;*.WMA;*.WMV;*.AVI;*.MPG;*.MPEG;*.M1V;*.MP2;*.MP3;*.MPA;*.MPE;*.M3U;*.MP4;*.MOV;*.3G2;*.3GP2;*.3GP;*.3GPP;*.M4A;*.CDA;*.AIF;*.AIFC;*.AIFF;*.MID;*.MIDI;*.RMI;*.MKV";
            if (open.ShowDialog() == DialogResult.OK)
            {

                /*Bitmap bmp = new Bitmap(open.FileName);
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.Image = bmp;*/
                textBox1.Text = open.FileName;
                textBoxPath.Text = open.FileName;


                if (client.checkPath(textBoxPath.Text) == false)
                {
                    List<string> aux = client.getDetails(textBoxPath.Text);
                    locationBox.Text = aux[1];
                    anotimpBox.Text = aux[2];
                    dateTimePicker1.Value = Convert.ToDateTime(aux[3]);
                    PersoaneBox.Text = aux[4];
                    Details(aux[0], aux[1], aux[2], Convert.ToDateTime(aux[3]), aux[4]);


                }
            }

        }

    }
}
