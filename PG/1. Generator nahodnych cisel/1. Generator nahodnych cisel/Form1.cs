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

namespace _1.Generator_nahodnych_cisel
{
    public partial class Form1 : Form
    {
        int[] nahodnaCisla; // pole s náhodnými čísly pro lepší přístup u kliknutí na jednotlivé části statistiky
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGeneruj_Click(object sender, EventArgs e) // kliknutí na tlačítko generuj
        {
            int nahodnaOd = Convert.ToInt32(textBoxOd.Text); // minimální hodnota od které se generují čísla
            int nahodnaDo = Convert.ToInt32(textBoxDo.Text); // maximální hodnota do které se generují čísla
            int nahodnaPocet = Convert.ToInt32(textBoxPocet.Text); // počet generovaných čísel
            nahodnaCisla = new int[nahodnaPocet]; // pole pro uchování náhodných čísel v paměti
            Random rand = new Random(); // třída random pro náhodné generování čísel

            for(int i = 0; i < nahodnaPocet; i++) // cyklus pro naplnění pole náhodnými čísly
            {
                nahodnaCisla[i] = rand.Next(nahodnaOd, nahodnaDo + 1); // generování náhodných čísel a jejich vložení do pole
            }
            vypis();    // metoda pro vypsání náhodných čísel
            buttonSeradit.Enabled = true; // povolí kliknutí na tlačítko, protože již jsou náhodná čísla, se kterými lze pracovat
            buttonPrumer.Enabled = true;
            buttonNejmensi.Enabled = true;
            buttonNejvetsi.Enabled = true;
            buttonMedian.Enabled = true;
            buttonVariacniRozpeti.Enabled = true;
            buttonOdchylka.Enabled = true;
            buttonUlozit.Enabled = true;
            buttonModus.Enabled = true;
        }

        public void vypis() // metoda pro vypsání náhodných čísel do textboxu
        {
            textBoxVystup.Clear(); // vyčištění textboxu
            for (int i = 0; i < nahodnaCisla.Length; i++) // cyklus který projde všechna náhodná čísla
            {
                textBoxVystup.Text += nahodnaCisla[i] + "\r\n"; // vypsání náhodného čísla + přidání nového řádků pomocí \r\n
            }
        }

        private void buttonSeradit_Click(object sender, EventArgs e) // kliknutí na tlačítko seřadit
        {
            int aktualni, x;// vytvoření potřebných proměnných pro seřazení čísel pomocí vlastního cyklu
            for(int i = 1; i <= (nahodnaCisla.Length-1); i++) // cyklus prochází všechna náhodná čísla
            {
                aktualni = nahodnaCisla[i]; // uložení čísla z pole do aktuální
                x = i - 1;
                while((x>=0) && (nahodnaCisla[x] > aktualni))// procházení pole dokud není číslo větší než aktuální
                {
                    nahodnaCisla[x + 1] = nahodnaCisla[x]; // prohození čísel
                    x--; // zmenšení potřebné proměnné 
                }
                nahodnaCisla[x + 1] = aktualni; // zapsaní aktuálního čísla na novou pozici
            }
            vypis(); // vypsaní čísel
        }

        private void buttonPrumer_Click(object sender, EventArgs e) // klik na tlačítko průměr
        {
            float prumer = 0; // proměnná pro průměr
            for(int i = 0; i < nahodnaCisla.Length; i++) // cyklus, který projde všechna čísla
            {
                prumer += nahodnaCisla[i]; // součet všech čísel do průměru
            }
            prumer = prumer / nahodnaCisla.Length; // vydělení součtu hodnot počtem hodnot v poli aby vznikl průměr
            labelVystup.Text = "Aritmetický průměr je: " + Convert.ToString(prumer); // vypsání průměru
        }

        private void buttonNejmensi_Click(object sender, EventArgs e) // kliknutí na tlačítko nejmenší
        {
            int nejmensi = 0; // proměnná pro nejmenší číslo
            for (int i = 0; i < nahodnaCisla.Length; i++) // cyklus pro průchod všemi čísly
            {
                if (i == 0) // pokud je první hodnota z pole
                {
                    nejmensi = nahodnaCisla[0]; // uložení první hodnoty z pole jako nejmenší, nutno udělat, protože pokud by byla čísla zaporná zůstala by 0, která by byla největší
                } else if(i > 0) // pokud se jedná o další číslo z pole
                {
                    if(nejmensi > nahodnaCisla[i]) // porovnání zda je menší
                    {
                        nejmensi = nahodnaCisla[i]; // pokud je menší, je nejmenší číslo nahrazeným aktuálním
                    }
                }
            }
            labelVystup.Text = "Nejmenší číslo je: " + Convert.ToString(nejmensi); // výpis nejmenšího čísla
        }

        private void buttonNejvetsi_Click(object sender, EventArgs e) // klik na tlačítko největší
        {
            int nejvetsi = 0;// proměnná pro největší číslo
            for (int i = 0; i < nahodnaCisla.Length; i++) // cyklus pro průchod všemi čísly
            {
                if (i == 0)// pokud je první hodnota z pole
                {
                    nejvetsi = nahodnaCisla[0]; // uloží se pro důvěryhodné provonání
                }
                else if (i > 0)// pokud se jedná o další číslo z pole
                {
                    if (nejvetsi < nahodnaCisla[i]) // porovnání zda je aktuální číslo větší
                    {
                        nejvetsi = nahodnaCisla[i]; // pokud ano nahradí uložené největší číslo
                    }
                }
            }
            labelVystup.Text = "Největší číslo je: " + Convert.ToString(nejvetsi); // vypíše největší číslo
        }

        private void buttonMedian_Click(object sender, EventArgs e) // kliknutí na tlačítko median
        {
            int[] nahodnaDocasna = nahodnaCisla; // vytvoření dočasných náhodných čísel
            float median = 0; // proměnná pro uložení medianu
            if((nahodnaDocasna.Length % 2) == 1) // pokud je lichý počet čísel
            {
                Array.Sort(nahodnaDocasna); // dočasná uložená čísla se seřadí
                median = nahodnaDocasna[nahodnaDocasna.Length / 2]; // do medianu se vloží prostřední hodnota, liché číslo děleno 2 se zaokrouhlí nahoru, tudíž na prostřední hodnotu
            } else if((nahodnaDocasna.Length % 2) == 0) // pokud je počet čísel lichý
            {
                Array.Sort(nahodnaDocasna); // seřazení dočasných čísel
                median = (nahodnaDocasna[(nahodnaDocasna.Length) / 2] + nahodnaDocasna[((nahodnaDocasna.Length) / 2) - 1]) / 2f; // součet dvou hodnot blízkích ke středu
            }
            labelVystup.Text = "Medián je: " + median.ToString(); // vypíše median
        }

        private void buttonVariacniRozpeti_Click(object sender, EventArgs e) // kliknutí na tlačítko variační rozpětí
        {
            labelVystup.Text = "Variační rozpětí je: " + (nahodnaCisla.Max() - nahodnaCisla.Min()).ToString(); // odečte od největší čísla nejmenší a rovnou vypíše variační rozpětí
        }

        private void buttonOdchylka_Click(object sender, EventArgs e) // kliknutí na tlačítko průměrná absolutní odchylka
        {
            float prumer = 0; // proměnná pro průměr
            foreach(int x in nahodnaCisla) // projde náhodná čísla
            {
                prumer += x; // sečte všechna náhodná čísla
            }
            prumer = prumer / nahodnaCisla.Length; // součet hodnot vydělí počtem hodnot a vytvoří průměr
            float odchylka = 0; // proměnná pro odchylku
            foreach(int x in nahodnaCisla) // projde náhodná čísla
            {
                odchylka += Math.Abs(x - prumer); // součet absolutních hodnot rozdílu náhodného čísla a průměru
            }
            odchylka = odchylka / nahodnaCisla.Length; // součet hodnot vydělí počtem hodnot 
            labelVystup.Text = "Absolutní průměrná odchylka je: " + Convert.ToString(odchylka);// vypíše absolutní průměrnou odchylku
        }

        private void buttonNacist_Click(object sender, EventArgs e) // kliknutí na tlačítlo načíst
        {
            OpenFileDialog nacistDialog = new OpenFileDialog(); // vytvoření dialogu
            nacistDialog.Title = "Načíst data"; // nadpis dialogového okna
            nacistDialog.Filter = "Textové soubory (*.txt)|*.txt"; // spodní text + filtr jaké soubory lze vybrat
            textBoxVystup.Clear(); // vyčištění textboxu pro výstup
            if(nacistDialog.ShowDialog() == DialogResult.OK)// pokud je dialog úspěšně uzavřen
            {
                using(StreamReader sr = new StreamReader(nacistDialog.FileName)) // stream pro čtení ze souboru
                {
                    string radek = ""; // proměnná pro jednotlivý řádek
                    while((radek = sr.ReadLine()) != null) // cyklus opakující se dokud existuje další řádek
                    {
                        textBoxVystup.Text += radek + "\r\n"; // načtení dat do textboxu
                    }
                    sr.Close(); // zavření streamu
                }
                nahodnaCisla = new int[textBoxVystup.Lines.Length - 1]; // vytvoření nové velikosti podle načteného počtu řádků
                for (int i = 0; i < nahodnaCisla.Length; i++) // cyklus pro naplnění pole načtenými čísly
                {
                    nahodnaCisla[i] = Convert.ToInt32(textBoxVystup.Lines[i]); // načtení čísel z textboxu do pole
                }
                buttonSeradit.Enabled = true; // umožnění kliknout na tlačítka protože byly načteny hodnoty
                buttonPrumer.Enabled = true;
                buttonNejmensi.Enabled = true;
                buttonNejvetsi.Enabled = true;
                buttonMedian.Enabled = true;
                buttonMedian.Enabled = true;
                buttonVariacniRozpeti.Enabled = true;
                buttonOdchylka.Enabled = true;
                buttonUlozit.Enabled = true;
            }
        }

        private void buttonUlozit_Click(object sender, EventArgs e) // kliknutí na tlačítko uložit
        {
            SaveFileDialog ulozitDialog = new SaveFileDialog(); // vytvoření dialogu na uložení
            ulozitDialog.Title = "Uložit data"; // nadpis dialogu
            ulozitDialog.Filter = "Textové soubory (*.txt)|*.txt"; // filtr a spodní text dialogu
            if (ulozitDialog.ShowDialog() == DialogResult.OK) // po úspěšném zavření dialogu
            {
                using (StreamWriter sw = new StreamWriter(ulozitDialog.FileName)) // stream pro uložení dat
                {
                    foreach(string radek in textBoxVystup.Lines) // cyklus na průchod textboxu s čísly
                    {
                        sw.WriteLine(radek);// uložení řádků
                    }
                    sw.Close();// zavření streamu
                }
            }
        }

        private void buttonModus_Click(object sender, EventArgs e) // kliknutí na tlačítko modus
        {
            Dictionary<int, int> hodnotySpocty = new Dictionary<int, int>(); // slovník pro možnost k číslu ukládat počet 
            for (int i = 0; i < nahodnaCisla.Length; i++) // cyklus pro naplnění slovníku
            {
                if (hodnotySpocty.ContainsKey(nahodnaCisla[i])) // pokud již slovník obsahuje číslo jako klíč
                {
                    hodnotySpocty[nahodnaCisla[i]] += 1; // přičte se jedna, kvůli počtu kolikrát je obsaženo dané číslo
                } else // pokud neobsahuje číslo jako klíč
                {
                    hodnotySpocty.Add(nahodnaCisla[i], 0); // přidá se číslo jako klíč
                    hodnotySpocty[nahodnaCisla[i]] += 1; // přičte se jedna k hodně u klíče
                }
            }
            int modus = 0; //proměnná pro  modus
            int max = 0; // proměnná pro počet kolikrát je modus obsažen
            foreach(KeyValuePair<int, int> hodnotaPocet in hodnotySpocty) // cyklus projde slovník
            {
                if(hodnotaPocet.Value > max) // pokud je hodnota větší než největší hodnota obsaženého čísla
                {
                    modus = hodnotaPocet.Key; // jako modus se zapíše klíč čísla
                    max = hodnotaPocet.Value; // jako počet obsažení čísla se zapíše počet
                }
            }
            labelVystup.Text = "Modus je " + Convert.ToString(modus) + " s počtem hodnot " + Convert.ToString(max); // vypsání modusu
        }
    }
}
