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

namespace _3.Příklady_z_aritmetiky
{
    public partial class Form1 : Form
    {
        int NumberOfExercises = 0; // proměnná pro počet příkladů
        int SuccessfulExercises = 0; // proměnná pro počet úspěšných příkladů
        int FailedExercises = 0; // proměnná pro počet neúspěšných příkladů
        int Result = 0; // proměnná pro výsledek

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExercise_Click(object sender, EventArgs e)// kliknutí na tlačítko generuj příklad / pokračovat
        {
            Random random = new Random(); // vytvoření třídy random pro generování příkladů
            int min = Convert.ToInt32(numericUpDownMinimum.Value); // načtení hodnoty pro minimální číslo v příkladu z numericupdown
            int max = Convert.ToInt32(numericUpDownMaximum.Value); // načtení hodnoty pro maximální číslo v příkladu z numericupdown

            int x = random.Next(min, max); // náhodné vygenerování prvního čísla příkladu v zadaném rozmezí min max
            int y = random.Next(min, max); // náhodné vygenerování druhého čísla příkladu v zadaném rozmězí min max

            int ResultN = 0; // proměnná pro dočasný výsledek

            if (comboBoxOperation.Text == "Podíl") // pokud je vybrána operace podíl
            {
                bool repeat = true; // proměnná bool pro cyklus
                while (repeat) // cyklus pro repetetivní generování čísel dokud nebude podíl bez zbytku
                {
                    x = random.Next(min, max); // vygenerování prvního čísla příkladu v rozmezí min max
                    y = random.Next(min, max); // vygenerování druhého čísla příkladu v rozmezí min max
                    if(x != 0 && y != 0) // pokud se první a zároveň druhé číslo nerovná nule
                    {
                        if((x % y) == 0) // pokud je podíl prvního a druhého čísla bez zbytku
                        {
                            repeat = false; // změní se proměnná pro opakované procházení cyklu a cyklus se tím ukončí
                        }
                    }
                }
            }
            if(NumberOfExercises == 0) // pokud je počet příkladů nula, neboli se generuje první příklad
            {
                buttonExercise.Text = "Zkontrolovat"; // text se změní na kontrolovat
            } else // pokud již byl nějaký příklad generovaný  dojde ke kontrole výsledku
            {
                if(Result == Convert.ToInt32(numericUpDownResult.Value)) // pokud se výsledek rovná zadanému výsledku
                {
                    SuccessfulExercises++; // zvyšíme počet úspěšně vypočítaných příkladů
                }
                else // pokud je výsledek špatný
                {
                    FailedExercises++; // zvýšení počtu špatných výsledků
                    textBoxFailedExercises.Text += labelExercise.Text + Convert.ToString(numericUpDownResult.Value) + "\r\n"; // zapsaní do textboxu špatného příkladu s výsledkem
                }
                labelNumberOfExercises.Text = "Počet příkladů: " + Convert.ToString(NumberOfExercises); // vypsání počtu příkladů
                labelSuccessfulExercises.Text = "Správné odpovědi: " + Convert.ToString(SuccessfulExercises); // vypsání počtu správných výsledků
                labelFailedExercises.Text = "Špatné odpovědi: " + Convert.ToString(FailedExercises); // vypsání špatných příkladů
                labelPercentageExercises.Text = "Úspěšnost: " + Convert.ToString(Math.Round(((float)SuccessfulExercises / (float)NumberOfExercises) * 100,2)) + "%"; // vypsaní procentuální úspěšnosti na 2 desetinná místa
            }
            switch (comboBoxOperation.Text) // rozdělení podle vybrané operace
            {
                case "Podíl": // při vybrání podílu
                    ResultN = x / y; // výpočet správného výsledku
                    labelExercise.Text = Convert.ToString(x) + " : " + Convert.ToString(y) + " = ";// zapsání příkladu
                    break;
                case "Součet":
                    ResultN = x + y;// výpočet správného výsledku
                    labelExercise.Text = Convert.ToString(x) + " + " + Convert.ToString(y) + " = ";// zapsání příkladu
                    break;
                case "Součin":
                    ResultN = x * y;// výpočet správného výsledku
                    labelExercise.Text = Convert.ToString(x) + " * " + Convert.ToString(y) + " = ";// zapsání příkladu
                    break;
                case "Rozdíl":
                    ResultN = x - y;// výpočet správného výsledku
                    labelExercise.Text = Convert.ToString(x) + " - " + Convert.ToString(y) + " = "; // zapsání příkladu
                    break;
            }
            numericUpDownResult.Location = new Point(labelExercise.Size.Width + labelExercise.Location.X, numericUpDownResult.Location.Y); // přemístění numericu pro zadání výsledku hned za příklad podle jeho délky
            NumberOfExercises++; // zvýšení počtu příkladů
            Result = ResultN; // přepsání správného výsledku novým správným výsledkem
        }

        private void buttonClearFailedExercises_Click(object sender, EventArgs e) // kliknutí na tlačítko vymazat špatné příklady
        {
            textBoxFailedExercises.Clear();
        }

        private void buttonLoadFailedExercises_Click(object sender, EventArgs e) // kliknutí tlačítko načíst špatně vypočítané příklady
        {
            OpenFileDialog LoadDialog = new OpenFileDialog(); // vytvoření dialogu
            LoadDialog.Title = "Načíst data"; // nadpis dialogu
            LoadDialog.Filter = "Textové soubory (*.txt)|*.txt"; // spodní text dialogu a filtr pro vstupní soubory
            textBoxFailedExercises.Clear(); // vyčištění textboxu se špatnými výsledky
            if(LoadDialog.ShowDialog() == DialogResult.OK) // po úspěšném uzavření dialogu
            {
                using (StreamReader sr = new StreamReader(LoadDialog.FileName)) // stream pro načtení souboru s cestou z dialogu
                {
                    string line = ""; // proměnná pro řádek
                    while ((line = sr.ReadLine()) != null) // cyklus který se opakuje dokud je dostupný řádek
                    {
                        textBoxFailedExercises.Text += line + "\r\n"; // vypsání načtených příkladů
                    }
                    sr.Close(); // uzavření streamu
                }
            }
        }

        private void buttonSaveFailedExercises_Click(object sender, EventArgs e) // kliknutí na tlačítko uložit špatné příklady
        {
            SaveFileDialog SaveDialog = new SaveFileDialog(); // vytvaření dialogu
            SaveDialog.Title = "Uložit data"; // nadpis dialogu
            SaveDialog.Filter = "Textové soubory (*.txt)|*.txt"; // spodní text dialogu a filtr pro formáty ukládání
            if (SaveDialog.ShowDialog() == DialogResult.OK) // po úspěšném uzavření dialogu
            {
                using (StreamWriter sw = new StreamWriter(SaveDialog.FileName)) // otevření streamu pro uložení dat s cestou z dialogu
                {
                    foreach (string line in textBoxFailedExercises.Lines) // cyklus, který projde všechny řádky v textboxu
                    {
                        sw.WriteLine(line); // uložení řádku
                    }
                    sw.Close(); // uzavření streamu
                }
            }
        }
    }
}
