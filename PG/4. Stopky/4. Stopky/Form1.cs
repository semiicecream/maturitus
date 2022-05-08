using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4.Stopky
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonStartPause_Click(object sender, EventArgs e) // kliknutí na tlačítko start/ pauza / pokračovat
        {
            if (timer.Enabled) // pokud je zapnutý timer
            {
                timer.Enabled = false; // vypnutí timeru
                buttonStartPause.Text = "Pokračovat"; // změna textu na pokračovat
            } else // pokud není zapnutý timer
            {
                timer.Enabled = true; // zapnutí timeru
                buttonStartPause.Text = "Pauza"; // změna textu na pauza
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) // kliknutí na tlačítko smazat
        {
            textBoxTimes.Clear(); // vymazaní obsahu textboxu s časy
        }

        private void timer_Tick(object sender, EventArgs e) // událost timeru tick
        {
            string[] time = labelTime.Text.Split(':'); // rozdělení času z labelu do pole string podle úseků
            time[2] = Convert.ToString(Convert.ToInt16(time[2]) + 10); // přidání destiny vteřiny k času
            if(Convert.ToInt16(time[2]) == 60) // pokud je desetin sekund 60 => vteřina
            {
                time[2] = "00"; // přepíše text u desetin na 00
                time[1] = Convert.ToString(Convert.ToInt16(time[1]) + 1); // počet vteřin se zvětší o jedna
                if(Convert.ToInt16(time[1]) < 10) // pokud je číslo u vteřin jednociferné 
                {
                    time[1] = "0" + time[1]; // připíše před vteřiny 0
                }
            }
            if(Convert.ToInt16(time[1]) == 60) // pokud je 60 vteřin => 1 minuta
            {
                time[1] = "00"; // změní čas u vteřin na 00

                time[0] = Convert.ToString(Convert.ToInt16(time[0]) + 1); // zvětší počet minut o jedna
                if (Convert.ToInt16(time[0]) < 10) // pokud je číslo u minut jednociferné
                {
                    time[0] = "0" + time[0]; // přípíše před minuty 0
                }
            }
            labelTime.Text = time[0] + ":" + time[1] + ":" + time[2]; // vypíše aktuální čas
        }

        private void buttonTimeAdd_Click(object sender, EventArgs e) // kliknutí na tlačítko mezičas
        {
            textBoxTimes.Text += labelTime.Text + "\r\n"; // přidá do textboxu mezičas
        }

        private void buttonReset_Click(object sender, EventArgs e) // kliknutí na tlačítko vynulovat
        {
            if (timer.Enabled) // pokud je zapnutý timer
            {
                timer.Enabled = false; // vypne timer
            }
            buttonStartPause.Text = "Spustit"; // změní text na spustit

            labelTime.Text = "00:00:00"; // vynuluje čas v labelu
        }

        private void buttonSave_Click(object sender, EventArgs e) // kliknutí na tlačítko uložit časy
        {
            SaveFileDialog saveDialog = new SaveFileDialog(); // vytvoření dialogu
            saveDialog.Title = "Uložit časy"; // nadpis dialogu
            saveDialog.Filter = "Textové soubory (*.txt)|*.txt"; // nastavení spodního textu dialogu a filtru pro výstupní soubor
            if (saveDialog.ShowDialog() == DialogResult.OK) // po úspěšném uzavření dialogu
            {
                using (StreamWriter sw = new StreamWriter(saveDialog.FileName)) // otevření streamu pro uložení souboru s cestou z dialogu
                {
                    foreach (string line in textBoxTimes.Lines) // cyklus pro průchod všech řádků v textboxu
                    {
                        sw.WriteLine(line); // uložení řádku
                    }
                    sw.Close(); // uzavření streamu
                }
            }
        }

        private void buttonLoad_Click(object sender, EventArgs e) // kliknutí na tlačítko načíst časy
        {
            OpenFileDialog LoadDialog = new OpenFileDialog(); // vytvoření dialogu
            LoadDialog.Title = "Načíst data"; // nadpis dialogu
            LoadDialog.Filter = "Textové soubory (*.txt)|*.txt"; // vytvoření spodního textu dialogu a filtru pro vstupní soubor
            textBoxTimes.Clear(); // vyčištění textboxu pro časy
            if (LoadDialog.ShowDialog() == DialogResult.OK) // po úspěšném uzavření dialogu
            {
                using (StreamReader sr = new StreamReader(LoadDialog.FileName)) // vytvoření streamu pro načtení souboru s cestou z dialogu
                {
                    string line = ""; // proměnná pro načítání řádku
                    while ((line = sr.ReadLine()) != null) // cyklus, který se opakuje dokud se nachází v souboru další řádek
                    {
                        textBoxTimes.Text += line + "\r\n"; // zapsaní řádků do textboxu s časy
                    }
                    sr.Close(); // uzavření streamu
                }
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e) // kliknutí na tlačítko statistika
        {

            int[] timesInTenths = new int[textBoxTimes.Lines.Length - 1]; // pole pro jednotlivé časy v desetinách
            for (int i = 0; i < timesInTenths.Length; i++) // cyklus pro naplnění pole časy
            {
                int tenths = Convert.ToInt32(textBoxTimes.Lines[i].Split(':')[2]); // počet desetin v čase
                int sec = Convert.ToInt32(textBoxTimes.Lines[i].Split(':')[1]); // počet sekund v čase
                int min = Convert.ToInt32(textBoxTimes.Lines[i].Split(':')[0]); // počet minut v čase
                timesInTenths[i] = (sec * 60) + (min * 60 * 60) + tenths; // součet minut, vteřin a desetin na desetiny do pole
            }

            int average = 0; //proměnná pro průměr
            int maximum = timesInTenths.Max(); //proměnná pro maximální hodnota
            int minimum = timesInTenths.Min(); //proměnná pro minimální hodnota

            for (int i = 0; i < timesInTenths.Length; i++) // cyklus pro součet hodnot pro průměr
            {
                average += timesInTenths[i]; // přičítání časů do průměru
            }
            average = average / timesInTenths.Length; // součet časů dělený počtem časů pro výpočet průměru

            int[] timesInTenthsTemp = timesInTenths; // dočasné pole času v desetinách vteřin pro výpočet medianu
            int median = 0; // proměnná pro median
            Array.Sort(timesInTenthsTemp); // seřazení dočasného pole s časy
            if ((timesInTenthsTemp.Length % 2) == 1) // pokud je počet časů lichý
            {
                median = timesInTenthsTemp[timesInTenthsTemp.Length / 2]; // median je střední hodnota z dočasného pole s časy
            }
            else if ((timesInTenthsTemp.Length % 2) == 0) //pokud je počet časů lichý
            {
                median = (timesInTenthsTemp[timesInTenthsTemp.Length / 2] + timesInTenthsTemp[(timesInTenthsTemp.Length / 2) - 1]) / 2; // podíl součtu časů nejbližších ke středu pro výpočet medianu
            }

            int range = timesInTenths.Max() - timesInTenths.Min(); // proměnná pro variační rozpětí a výpočet rozpětí

            int deviation = 0;      // proměnná pro absolutní odchylka
            foreach (int num in timesInTenths) // cyklus pro výpočet odchylky
            {
                deviation += Math.Abs(num - average); // sčítání absolutních rozdílů času od průměrného času
            }
            deviation = deviation / timesInTenths.Length; // podíl součtu absolutních rozdílů časů od průměrných časů a počtu časů

            int modus = 0; // proměnná pro modus
            int modusMaxNums = 0; // proměnná pro výpočet modusu, slouží k uložení počtu hodnot času
            Dictionary<int, int> timesWithNums = new Dictionary<int, int>(); // slovník pro výpočet modusu, složí k uložení klíče (času) a počtu kolikrát je obsažen
            for (int i = 0; i < timesInTenths.Length; i++) // cyklus, který projde všechny časy
            {
                if (timesWithNums.ContainsKey(timesInTenths[i])) // pokud slovník obsahuje čas jako klíč
                {
                    timesWithNums[timesInTenths[i]] += 1; // zvýšení hodnoty kolikrát byl daný čas obsažen ve všech časech
                }
                else // pokud není čas obsažen jako klíč
                {
                    timesWithNums.Add(timesInTenths[i], 0); // přidání času jako klíče
                    timesWithNums[timesInTenths[i]] += 1; // zvýšení hodnoty kolikrát byl klíč obsažen
                }
            }
            foreach (KeyValuePair<int, int> timeNum in timesWithNums) // cyklus pro průchod slovníku
            {
                if (timeNum.Value > modusMaxNums) // pokud je hodnota větší než největší hodnota obsaženého času 
                {
                    modus = timeNum.Key; // jako modus se zapíše klíč času
                    modusMaxNums = timeNum.Value; // jako počet obsažení času se zapíše počet času
                }
            }

            labelStatistics.Text = "Průměrný čas je: " + FormatTime(average) + "\r\n"; // slouží k výpisu průměrného času ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
            labelStatistics.Text += "Modus časů je: " + FormatTime(modus) + "\r\n";// slouží k výpisu modusu časů ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
            labelStatistics.Text += "Medián časů je: " + FormatTime(median) + "\r\n";// slouží k výpisu medianu časů ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
            labelStatistics.Text += "Minimální hodnota času je: " + FormatTime(minimum) + "\r\n";// slouží k výpisu minimální hodnotě časů ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
            labelStatistics.Text += "Maximální hodnota času je: " + FormatTime(maximum) + "\r\n";// slouží k výpisu maximální hodnotě časů ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
            labelStatistics.Text += "Variační rozpětí časů je: " + FormatTime(range) + "\r\n";// slouží k výpisu variačního rozpětí časů ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
            labelStatistics.Text += "Průměrná absolutní odchylka časů je: " + FormatTime(deviation) + "\r\n";// slouží k výpisu průměrné absolutní odchylce časů ve stejném formátu jako je čas v labelu a textboxu, využití vlastní metodu
        }

        public string FormatTime(int tenths) // vlastní návratová metoda pro převod desetin na formát času, který je používán u textboxu a labelu
        {
            string output = ""; // proměnná pro výstupní čas
            int sec = 0, min = 0;// proměnné pro sekundy a minuty

            while (tenths >= 360) // cyklus se opakuje dokud jsou desetiny větší než 360 ( počet desetin vteřin v minutě)
            {
                tenths -= 360; // odečte počet desetin potřebných na minutu
                min++; // zvětší počet minut o jedna
            }
            while (tenths >= 60) // cyklus se opakuje dokud jsou destiny větší než 60 ( počet desetin ve vteřině)
            {
                tenths -= 60; // odečte počet desetin potřebných na vteřinu
                sec++; // zvětší počet vteřin o jedna
            }
            if (min < 10) // pokud je počet minut jednociferné číslo
            {
                output += "0" + Convert.ToString(min) + ":"; // připíše nulu před minuty a dvojtečku za minuty
            }
            else // pokud jsou minuty dvojciferné číslo
            {
                output += Convert.ToString(min) + ":";// připíše počet minut
            }

            if (sec < 10) // pokud jsou vteřiny jednociferné číslo
            {
                output += "0" + Convert.ToString(sec) + ":";// připíše nulu před vteřiny a dvojtečku za minuty
            }
            else // pokud jsou vteřiny dvojciferné číslo
            {
                output += Convert.ToString(sec) + ":";// připíše počet vteřin
            }

            if (tenths < 10) // pokud jsou desetiny jednociferné číslo
            {
                output += "0" + Convert.ToString(tenths);// připíše nulu před desetiny a dvojtečku za minuty
            }
            else // pokud jsou desetiny dvojciferné číslo
            {
                output += Convert.ToString(tenths);// přidá počet desetin
            }

            return output; // vrací čas ve správném formátu jako string
        }
    }
}
