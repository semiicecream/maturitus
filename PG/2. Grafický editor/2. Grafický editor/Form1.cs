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
using System.Drawing.Imaging;

namespace _2.Grafický_editor
{
    public partial class Form1 : Form
    {
        Color barva; // proměnná pro barvu tvaru

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) // po načtení formuláře
        {
            pictureBox1.Height = Height; // velikost pictureboxu se nastaví podle rozměru okna
            pictureBox1.Width = Width;

            barva = Color.Black; // barva se nastaví na černou
            buttonBarvaVyber.ForeColor = barva; // barva se nastaví jako text tlačítka pro výběr barvy
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height); // velikost obrázku v pictureboxu podle velikosti pictureboxu
        }

        private void buttonBarvaVyber_Click(object sender, EventArgs e) // kliknutí na výběr barvy
        {
            ColorDialog colorDialog = new ColorDialog(); // vytvoření dialogu pro výběr barvy
            colorDialog.AllowFullOpen = false; // zakázat možnost otevřít dialog na celou obrazovku
            colorDialog.Color = buttonBarvaVyber.ForeColor; // barva v dialogu podle barvy tlačítka
            if(colorDialog.ShowDialog() == DialogResult.OK) // po úspěšném zavření dialogu
            {
                barva = colorDialog.Color;// barva se nastaví podle vybrané barvy
                buttonBarvaVyber.ForeColor = colorDialog.Color; // vybraná barva se nastaví jako barva textu tlačítka
            }
        }

        private void buttonSmazat_Click(object sender, EventArgs e) // kliknutí na tlačítko smazat
        {
            pictureBox1.Image = new Bitmap(pictureBox1.Width, pictureBox1.Height); // vytvoření nového obrázku v picturebox
        }

        private void buttonVykreslit_Click(object sender, EventArgs e) // kliknutí na tlačítko vykreslit
        {
            int sirka = Convert.ToInt32(textBoxSirka.Text); // načtení a konvertování hodnot z textboxů
            int vyska = Convert.ToInt32(textBoxVyska.Text);
            int souradniceX = Convert.ToInt32(textBoxSouradniceX.Text);
            int souradniceY = Convert.ToInt32(textBoxSouradniceY.Text);
            Graphics graphics = Graphics.FromImage(pictureBox1.Image); // vytvoření třídy graphics z obrázku v pictureboxu
            switch (comboBoxTvar.SelectedItem.ToString()) // rozdělení podle možností v comboboxu pro výběr tvaru
            {
                case "Elipsa": // pokud je vybrána elipsa
                    if (radioButtonObrys.Checked) // pokud je zvolen radiobutton pouze pro obrys
                    {
                        graphics.DrawEllipse(new Pen(barva), souradniceX, souradniceY, sirka, vyska); // vykreslení kružnice podle zadaných parametrů
                    } else
                    {
                        graphics.FillEllipse(new SolidBrush(barva), souradniceX, souradniceY, sirka, vyska); // vykreslení vyplněné elipsy podle parametrů
                    }
                    break;
                case "Obdélník": // pokud je zvolen obdélník
                    if (radioButtonObrys.Checked) // pokud je zvolen obrys
                    {
                        graphics.DrawRectangle(new Pen(barva), souradniceX, souradniceY, sirka, vyska); // vykreslení obrysu obdélníků dle parametrů
                    }
                    else
                    {
                        graphics.FillRectangle(new SolidBrush(barva), souradniceX, souradniceY, sirka, vyska); // vykreslení vyplněného obdélníků dle parametrů
                    }
                    break;
                case "Přímka": // pokud je zvolena přímka
                    graphics.DrawLine(new Pen(barva), sirka, vyska, souradniceX, souradniceY); // vykreslení přímky, šířka a výška zastupují souřadnice počátečního bodu
                    break;
            }
            graphics.Dispose();// uvolnění instance třídy graphics
            pictureBox1.Refresh();// obnovení pictureboxu pro zobrazení změn
        }

        private void comboBoxTvar_SelectedIndexChanged(object sender, EventArgs e) // událost při novém vybrání itemu v comboboxu
        {
            if(comboBoxTvar.SelectedItem.ToString() == "Přímka") // pokud je zvolena přímka
            {
                labelSirka.Text = "Souřadnice X(1):"; // šířka a výška se přepíší na souřadnice
                labelVyska.Text = "Souřadnice Y(1):";
            } else
            {
                labelSirka.Text = "Šířka:"; // pokud je vybrán jiný tvar, zpět se labely přepíšou na šířku a výšku
                labelVyska.Text = "Výška:";
            }
        }

        private void buttonNacist_Click(object sender, EventArgs e) // kliknutí na tlačítko načíst
        {
            OpenFileDialog openFileDialog = new OpenFileDialog(); // vytvoření dialogu
            openFileDialog.Filter = "Obrázky |*.png;*.bmp;*.jpg"; // zvolení spodního textu dialogu a filtrů pro vstupní soubory
            if(openFileDialog.ShowDialog() == DialogResult.OK) // pokud je dialog úspěšně uzavřen
            {
                pictureBox1.Image = new Bitmap(openFileDialog.FileName); // obrázek pictureboxu se změní na zvolený obrázek
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e) // kliknutí na tlačítko uložit
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog(); // vytvoření dialogu pro uložení
            saveFileDialog.Filter = "Obrázky |*.png;*.bmp;*.jpg"; // zvolení spodního textu dialogu a filtrů pro výstupní soubor
            ImageFormat format = ImageFormat.Png; // zvolení výchozího formátu
            if (saveFileDialog.ShowDialog() == DialogResult.OK) // pokud je dialog úspěšně uzavřen
            {
                string ext = Path.GetExtension(saveFileDialog.FileName); // získání přípony souboru, která byla zadána v dialogu
                switch (ext) // rozdělení podle přípony
                {
                    case ".jpg": // pokud je přípona jpg
                        format = ImageFormat.Jpeg; // formát se změní na jpeg
                        break;
                    case ".bmp":// pokud je přípona bmp
                        format = ImageFormat.Bmp; // formát se změní na bmp
                        break;
                    case ".png":// pokud je přípona png
                        format = ImageFormat.Png; // formát se změní na png
                        break;
                }
                pictureBox1.Image.Save(saveFileDialog.FileName, format); // uložení obrázku

            }
        }
    }
}
