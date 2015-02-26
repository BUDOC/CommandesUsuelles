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



namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string NomFic = "";

        private void ouvrirFichierToolStripMenuItem1_Click_1(object sender, EventArgs e) //ouvrir un fichier avec openDialog
        {
            this.label1.Text = NomFic;
            if (this.rep != "")
            {
                this.openFileDialog1.InitialDirectory = rep;
            }
            int size = -1;
            DialogResult result = openFileDialog1.ShowDialog(); // Show the dialog.
            if (result == DialogResult.OK) // Test result.
            {
                NomFic = openFileDialog1.FileName;
                string file = openFileDialog1.FileName;
                try
                {
                    string text = File.ReadAllText(file);
                    this.textBox1.Text = File.ReadAllText(file);
                    this.richTextBox1.Text = File.ReadAllText(file);
                    size = text.Length;
                }
                catch (IOException)
                {
                }
            }
            this.label1.Text = NomFic;

        }

        private void scrollToolStripMenuItem_Click(object sender, EventArgs e) //lire un textbox ligne par ligne
        {
            int max = this.textBox1.Lines.Count() - 1;
            //   MessageBox.Show(max.ToString());
            for (int i = 0; i <= max - 1; i++)
            {
                this.label1.Text = this.textBox1.Lines[i];
            }

        }

        private void enregisterSousToolStripMenuItem_Click(object sender, EventArgs e) //enregistrer un fichier avec saveDialog
        {
            saveFileDialog1.Filter = "txt files (*.txt)|*.txt";

            if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK
                && saveFileDialog1.FileName.Length > 0)
            {

                richTextBox1.SaveFile(saveFileDialog1.FileName,
                    RichTextBoxStreamType.PlainText);
            }
        }
        public string rep = "";
        private void sélectionnerUnDossierToolStripMenuItem_Click(object sender, EventArgs e) //sélectionner un dossier
        {
            this.folderBrowserDialog1.Description = "Selectionner le répertoire par defaut.";
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {
                rep = folderBrowserDialog1.SelectedPath;
                this.label1.Text = rep;
            }
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ecritureDansUnFichierPrédéterminéToolStripMenuItem_Click(object sender, EventArgs e) // Génnére du texte dans un fichier désigné par son nom
        {
            string nomfic = "H:\\c#\\READ_Write_Text_Files\\Texte.txt";
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(nomfic)) //sans @ =fichier dans répertoire courant
   
          //  using (System.IO.StreamWriter file = new System.IO.StreamWriter(@"H:\c#\READ_Write_Text_Files\Texte.txt")) 
               
            {
                if (File.Exists(nomfic))
                {
                    
                    // demande validation d'écrasement
                    const string message = "Voulez-vous écraser ce fichier?";
                    const string caption = "le fichier existe";
                    var result = MessageBox.Show(message, caption,
                                                 MessageBoxButtons.YesNo,
                                                 MessageBoxIcon.Question);

                    // If the no button was pressed ...
                    if (result == DialogResult.No)
                    {
                        // cancel the closure of the form.
                     //   MessageBox.Show("Vous avez répondu non");
                        return;
                    }
                }

                string line = "";
                for (int i = 0; i < 30; i++)
                {
                    line = "ligne n° " + i.ToString();
                    file.WriteLine(line);
                }
            }
            MessageBox.Show("30 lignes ont été ecrite dans le fichier Texte.txt");
        }

        private void lectureDansUnFichierPrédertiméToolStripMenuItem_Click(object sender, EventArgs e) //lecture d'un fichier texte a partir de son nom
        {

            string text = System.IO.File.ReadAllText(@"H:\c#\READ_Write_Text_Files\Texte.txt");
            this.textBox1.Text = text;
        }

        private void réperoireDeLapplicationToolStripMenuItem_Click(object sender, EventArgs e) //répertoire le l'application
        {
            string exeDir = Application.StartupPath;

            MessageBox.Show("Le répertoire de l'application est " + exeDir);
        }

        private void importerUnFichierTexteLigneParLigneToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int counter = 0;
            string line;
            this.textBox1.Clear();
            // Read the file and display it line by line.
            System.IO.StreamReader file = new System.IO.StreamReader(@"H:\c#\READ_Write_Text_Files\Texte.txt");
            int l = 0;
            while ((line = file.ReadLine()) != null)
            {
               this.textBox1.AppendText (line+"\n");
           
                counter++;
            }

            file.Close();
            MessageBox.Show("nb lignes:"+ counter +" dans le fichier Texte.txt ");
        }
    }
}
