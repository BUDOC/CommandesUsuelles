namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ouvrirFichierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ouvrirFichierToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scrollToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enregisterSousToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dossiersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sélectionnerUnDossierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecritureDansUnFichierPrédéterminéToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lectureDansUnFichierPrédertiméToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitairesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.réperoireDeLapplicationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importerUnFichierTexteLigneParLigneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // folderBrowserDialog1
            // 
            this.folderBrowserDialog1.Description = "OUF";
            this.folderBrowserDialog1.SelectedPath = "c:\\";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(638, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(377, 226);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            this.openFileDialog1.InitialDirectory = "c:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(642, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "label1";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(314, 131);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(197, 231);
            this.textBox1.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ouvrirFichierToolStripMenuItem,
            this.dossiersToolStripMenuItem,
            this.utilitairesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1092, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ouvrirFichierToolStripMenuItem
            // 
            this.ouvrirFichierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.quitterToolStripMenuItem,
            this.ouvrirFichierToolStripMenuItem1,
            this.scrollToolStripMenuItem,
            this.enregisterSousToolStripMenuItem,
            this.ecritureDansUnFichierPrédéterminéToolStripMenuItem,
            this.lectureDansUnFichierPrédertiméToolStripMenuItem,
            this.importerUnFichierTexteLigneParLigneToolStripMenuItem});
            this.ouvrirFichierToolStripMenuItem.Name = "ouvrirFichierToolStripMenuItem";
            this.ouvrirFichierToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.ouvrirFichierToolStripMenuItem.Text = "Fichiers";
            // 
            // quitterToolStripMenuItem
            // 
            this.quitterToolStripMenuItem.Name = "quitterToolStripMenuItem";
            this.quitterToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.quitterToolStripMenuItem.Text = "&Quitter";
            this.quitterToolStripMenuItem.Click += new System.EventHandler(this.quitterToolStripMenuItem_Click);
            // 
            // ouvrirFichierToolStripMenuItem1
            // 
            this.ouvrirFichierToolStripMenuItem1.Name = "ouvrirFichierToolStripMenuItem1";
            this.ouvrirFichierToolStripMenuItem1.Size = new System.Drawing.Size(269, 22);
            this.ouvrirFichierToolStripMenuItem1.Text = "&Ouvrir fichier";
            this.ouvrirFichierToolStripMenuItem1.Click += new System.EventHandler(this.ouvrirFichierToolStripMenuItem1_Click_1);
            // 
            // scrollToolStripMenuItem
            // 
            this.scrollToolStripMenuItem.Name = "scrollToolStripMenuItem";
            this.scrollToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.scrollToolStripMenuItem.Text = "Scrol&l";
            this.scrollToolStripMenuItem.Click += new System.EventHandler(this.scrollToolStripMenuItem_Click);
            // 
            // enregisterSousToolStripMenuItem
            // 
            this.enregisterSousToolStripMenuItem.Name = "enregisterSousToolStripMenuItem";
            this.enregisterSousToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.enregisterSousToolStripMenuItem.Text = "Enregi&ster sous";
            this.enregisterSousToolStripMenuItem.Click += new System.EventHandler(this.enregisterSousToolStripMenuItem_Click);
            // 
            // dossiersToolStripMenuItem
            // 
            this.dossiersToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sélectionnerUnDossierToolStripMenuItem});
            this.dossiersToolStripMenuItem.Name = "dossiersToolStripMenuItem";
            this.dossiersToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.dossiersToolStripMenuItem.Text = "Dossiers";
            // 
            // sélectionnerUnDossierToolStripMenuItem
            // 
            this.sélectionnerUnDossierToolStripMenuItem.Name = "sélectionnerUnDossierToolStripMenuItem";
            this.sélectionnerUnDossierToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sélectionnerUnDossierToolStripMenuItem.Text = "Sélectionner un dossier";
            this.sélectionnerUnDossierToolStripMenuItem.Click += new System.EventHandler(this.sélectionnerUnDossierToolStripMenuItem_Click);
            // 
            // ecritureDansUnFichierPrédéterminéToolStripMenuItem
            // 
            this.ecritureDansUnFichierPrédéterminéToolStripMenuItem.Name = "ecritureDansUnFichierPrédéterminéToolStripMenuItem";
            this.ecritureDansUnFichierPrédéterminéToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.ecritureDansUnFichierPrédéterminéToolStripMenuItem.Text = "Ecriture dans un fichier prédéterminé";
            this.ecritureDansUnFichierPrédéterminéToolStripMenuItem.Click += new System.EventHandler(this.ecritureDansUnFichierPrédéterminéToolStripMenuItem_Click);
            // 
            // lectureDansUnFichierPrédertiméToolStripMenuItem
            // 
            this.lectureDansUnFichierPrédertiméToolStripMenuItem.Name = "lectureDansUnFichierPrédertiméToolStripMenuItem";
            this.lectureDansUnFichierPrédertiméToolStripMenuItem.Size = new System.Drawing.Size(272, 22);
            this.lectureDansUnFichierPrédertiméToolStripMenuItem.Text = "Lecture dans un fichier prédétermimé";
            this.lectureDansUnFichierPrédertiméToolStripMenuItem.Click += new System.EventHandler(this.lectureDansUnFichierPrédertiméToolStripMenuItem_Click);
            // 
            // utilitairesToolStripMenuItem
            // 
            this.utilitairesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.réperoireDeLapplicationToolStripMenuItem});
            this.utilitairesToolStripMenuItem.Name = "utilitairesToolStripMenuItem";
            this.utilitairesToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.utilitairesToolStripMenuItem.Text = "Utilitaires";
            // 
            // réperoireDeLapplicationToolStripMenuItem
            // 
            this.réperoireDeLapplicationToolStripMenuItem.Name = "réperoireDeLapplicationToolStripMenuItem";
            this.réperoireDeLapplicationToolStripMenuItem.Size = new System.Drawing.Size(208, 22);
            this.réperoireDeLapplicationToolStripMenuItem.Text = "Réperoire de l\'application";
            this.réperoireDeLapplicationToolStripMenuItem.Click += new System.EventHandler(this.réperoireDeLapplicationToolStripMenuItem_Click);
            // 
            // importerUnFichierTexteLigneParLigneToolStripMenuItem
            // 
            this.importerUnFichierTexteLigneParLigneToolStripMenuItem.Name = "importerUnFichierTexteLigneParLigneToolStripMenuItem";
            this.importerUnFichierTexteLigneParLigneToolStripMenuItem.Size = new System.Drawing.Size(279, 22);
            this.importerUnFichierTexteLigneParLigneToolStripMenuItem.Text = "Importer un fichier texte ligne par ligne";
            this.importerUnFichierTexteLigneParLigneToolStripMenuItem.Click += new System.EventHandler(this.importerUnFichierTexteLigneParLigneToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1092, 439);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Test sur fichiers textes";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ouvrirFichierToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scrollToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enregisterSousToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dossiersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sélectionnerUnDossierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecritureDansUnFichierPrédéterminéToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lectureDansUnFichierPrédertiméToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utilitairesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem réperoireDeLapplicationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importerUnFichierTexteLigneParLigneToolStripMenuItem;
    }
}

