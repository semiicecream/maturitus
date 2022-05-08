using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Průsečík_dvou_přímek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int a1 = Convert.ToInt32(textBoxA1.Text); // načtení koeficientu a1
            int a2 = Convert.ToInt32(textBoxA2.Text); // načtení koeficientu a2
            int b1 = Convert.ToInt32(textBoxB1.Text); // načtení koeficientu b1
            int b2 = Convert.ToInt32(textBoxB2.Text); // načtení koeficientu b2

            int minX = Convert.ToInt32(textBoxMinX.Text); // načtení minimální hodnoty pro X
            int maxX = Convert.ToInt32(textBoxMaxX.Text); // načtení maximální hodnoty pro X

            dataGridView1.Rows.Clear(); // smazání řádků v datagridview
            dataGridView1.Refresh(); // obnovení datagridview
            chart1.Series[0].Points.Clear(); // smazání bodů v grafu pro první přímku
            chart1.Series[1].Points.Clear(); // smazání bodů v grafu pro druhou přímku 

            for(int x = minX; x <= maxX; x++) // cyklus, který vytvoří x a výpočítá y pro rovnice v zadaném rozmezí
            {
                int y1 = (a1 * x) + b1; // výpočet první rovnice
                int y2 = (a2 * x) + b2; // výpočet druhé rovnice
                dataGridView1.Rows.Add(new string[] {Convert.ToString(x),  Convert.ToString(y1), Convert.ToString(y2)}); // přidání řádku do tabulky s x, y1 a y2
                chart1.Series[0].Points.AddXY(x, y1); // přidání bodu pro první přímku
                chart1.Series[1].Points.AddXY(x, y2); // přidání bodu pro druhou rovnici
            }

            float A1 = (float)a1, B1 = (float)-1, C1 = (float)-b1; // výpočet A1 a B1 a C1 pro výpočet soustavy rovnic ( převedení do jiného tvaru rovnice pro lepší výpočet průsečíku)
            float A2 = (float)a2, B2 = (float)-1, C2 = (float)-b2; // výpočet A2 a B2 a C2 pro výpočet soustavy rovnic ( převedení do jiného tvaru rovnice pro lepší výpočet průsečíku)

            float delta = A1 * B2 - A2 * B1; // vyopčítání delty pro určení zda jsou přímky shodné 

            if (delta == 0) // pokud je delta 0 přímky jsou shodné
            {
                labelIntersection.Text = "Přímky jsou shodné"; // vypsání, že přímky jsou shodné
            }
            else // pokud přímky nejsou shodné
            {
                float y = (A1 * C2 - A2 * C1) / delta; // vypočítání Y průsečíku přímek
                float x = (C1 - B1 * y) / A1; // vypočítání X průsečíku přímek
                labelIntersection.Text = "Souřadnice průsečíku jsou  x = " + x + " y = " + y; // vypsání průsečíku přímek
            }
        }

        private void buttonSaveChart_Click(object sender, EventArgs e) // kliknutí na tlačítko uložit
        {
            SaveFileDialog saveDialog = new SaveFileDialog(); // vytvoření dialogu pro uložení
            saveDialog.Title = "Uložit graf"; // nadpis dialogu
            saveDialog.Filter = "Grafický soubor (*.png)|*.png"; // spodní text dialogu a filtr pro formát výstupního formátu
            if (saveDialog.ShowDialog() == DialogResult.OK) // po úspěšném uzavření dialogu
            {
                chart1.SaveImage(saveDialog.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png); // uložení grafu do souboru podle cesty z dialogu
            }
        }
    }
}
