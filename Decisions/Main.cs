using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Main : Form
    {
        private readonly List<string> _firstLine = new List<string>();
        private readonly List<string> _secondLine = new List<string>();
        private int _rowCount;

        public Main()
        {
            InitializeComponent();
        }

        //metoda pomocnicza która posłużyła do prawidłowego obliczania tabelek
        private void Button1_Click(object sender, EventArgs e)
        {
            const int packageSize = 200;
            var realizationSizeVar = Convert.ToInt32(this.realizationSize.Text);
            var demandVar = Convert.ToInt32(this.demand.Text);
            var regularPriceVar = Convert.ToDouble(this.regularPrice.Text);
            var discountPriceVar = Convert.ToDouble(this.discountPrice.Text);

            if (demandVar > realizationSizeVar * packageSize)
            {
                demandVar = realizationSizeVar * packageSize;
            }

            var price1Var = Convert.ToDouble(this.price1.Text);
            var price2Var = Convert.ToDouble(this.price2.Text);
            var price3Var = Convert.ToDouble(this.price3.Text);
            double cost;

            switch (realizationSizeVar)
            {
                case 1:
                    cost = price1Var * packageSize;
                    break;
                case 2:
                    cost = price2Var * realizationSizeVar * packageSize;
                    break;
                default:
                    cost = price3Var * realizationSizeVar * packageSize;
                    break;
            }

            CostValue.Text = cost.ToString(CultureInfo.InvariantCulture);
            IncomeValue.Text = (demandVar * regularPriceVar).ToString(CultureInfo.InvariantCulture);
            IncomeValue2.Text = ((realizationSizeVar * packageSize - demandVar) * discountPriceVar).ToString(CultureInfo.InvariantCulture);
            ProfitValue.Text =
                (0 - cost + demandVar * regularPriceVar + (realizationSizeVar * packageSize - demandVar) * discountPriceVar)
                .ToString(CultureInfo.InvariantCulture);
        }

        //wczytanie danych z pliku do zmiennych
        private void ReadDataButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            this.dataGridView2.Rows.Clear();
            this.dataGridView2.Columns.Clear();
            _firstLine.Clear();
            _secondLine.Clear();

            if (openFileDialog1.ShowDialog() != DialogResult.OK) return;

            var sr = new
                System.IO.StreamReader(openFileDialog1.FileName);
            var allCharactersInDocument = sr.ReadToEnd();
            var allCharactersInDocumentArray = allCharactersInDocument.Split();
            var z = 1;

            foreach (var item in allCharactersInDocumentArray)
            {
                if (item.Equals(""))
                {
                    for (var x = z; x < allCharactersInDocumentArray.Length; x++)
                    {
                        _secondLine.Add(allCharactersInDocumentArray[x]);
                    }

                    break;
                }

                _firstLine.Add(item);
                z++;
            }

            var id = 1;

            foreach (var unused in _firstLine)
            {
                this.dataGridView1.Columns.Add("column", "s" + id);
                this.dataGridView2.Columns.Add("column", "s" + id);
                id++;
            }

            this.dataGridView1.Rows.Add();
            this.dataGridView2.Rows.Add();

            for (var j = 0; j < _firstLine.Count; j++)
            {
                this.dataGridView1.Rows[0].Cells[j].Value = _firstLine[j];
                this.dataGridView1.Rows[0].HeaderCell.Value = "zamówienie";
                this.dataGridView2.Rows[0].Cells[j].Value = _firstLine[j];
                this.dataGridView2.Rows[0].HeaderCell.Value = "zamówienie";
            }

            sr.Close();
        }

        //oblicza wartości oraz wpisuje je odpowiednio do tabelek
        private void CalculateValuesButton_Click(object sender, EventArgs e)
        {
            _rowCount = 0;

            foreach (var item in _secondLine)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView2.Rows.Add();
                _rowCount++;
                this.dataGridView1.Rows[_rowCount].HeaderCell.Value = item;
                this.dataGridView2.Rows[_rowCount].HeaderCell.Value = item;

                for (var j = 0; j < _firstLine.Count; j++)
                {
                    var demandVar = Convert.ToInt32(this.dataGridView1.Rows[0].Cells[j].Value);
                    var regularPriceVar = Convert.ToDouble(this.regularPrice.Text);
                    var discountPriceVar = Convert.ToDouble(this.discountPrice.Text);
                    var orderSize = Convert.ToInt32(item);

                    if (demandVar > Convert.ToInt32(item))
                    {
                        demandVar = Convert.ToInt32(item);
                    }

                    var price1Var = Convert.ToDouble(this.price1.Text);
                    var price2Var = Convert.ToDouble(this.price2.Text);
                    var price3Var = Convert.ToDouble(this.price3.Text);
                    double cost;

                    switch (orderSize)
                    {
                        case 200:
                            cost = price1Var * orderSize;
                            break;
                        case 400:
                            cost = price2Var * orderSize;
                            break;
                        default:
                            cost = price3Var * orderSize;
                            break;
                    }

                    var profit =
                        (0 - cost + demandVar * regularPriceVar +
                         (Convert.ToInt32(item) - demandVar) * discountPriceVar)
                        .ToString(CultureInfo.InvariantCulture);
                    this.dataGridView1.Rows[_rowCount].Cells[j].Value = profit;
                }
            }

            for (var i = 0; i < this.dataGridView2.ColumnCount; i++)
            {
                var maxColumnValue = 0.0;

                for (var j = 1; j < this.dataGridView2.RowCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value) > maxColumnValue)
                    {
                        maxColumnValue = Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value);
                    }

                }

                for (var j = 1; j < this.dataGridView2.RowCount; j++)
                {
                    this.dataGridView2.Rows[j].Cells[i].Value = Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value) - maxColumnValue;
                }
            }
        }

        //oblicza wszystkie kryteria
        private void CalculationButton_Click(object sender, EventArgs e)
        {
            //obliczanie kryterium Hurwicza
            var max = 0.0;
            var decyzja = "";

            for (var i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                for (var j = 1; j < this.dataGridView1.RowCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value) > max)
                    {
                        max = Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value);
                        decyzja = "a" + i;
                    }
                }
            }

            this.Hurwicza.Text = $@"Najlepsza decyzja {decyzja} (najwieksza wyplata) to: {max.ToString(CultureInfo.InvariantCulture)}";

            //obliczanie kryterium Walda
            var waldList = new List<double>();
            var min = double.MaxValue;

            for (var i = 1; i < this.dataGridView1.RowCount; i++)
            {
                for (var j = 0; j < this.dataGridView1.ColumnCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView1.Rows[i].Cells[j].Value) < min)
                    {
                        min = Convert.ToDouble(this.dataGridView1.Rows[i].Cells[j].Value);
                    }
                }

                waldList.Add(min);
                min = double.MaxValue;
            }

            max = waldList.Max();
            this.Walda.Text = $@"Najlepsza z najgorszych wyplat a{waldList.IndexOf(max) + 1} to: {max.ToString(CultureInfo.InvariantCulture)}";

            //obliczanie kryterium Savage'a
            var savagaList = new List<double>();
            for (var i = 1; i < this.dataGridView2.ColumnCount; i++)
            {
                for (var j = 0; j < this.dataGridView2.RowCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView2.Rows[i].Cells[j].Value) < min)
                    {
                        min = Convert.ToDouble(this.dataGridView2.Rows[i].Cells[j].Value);
                    }
                }

                savagaList.Add(min);
                min = double.MaxValue;
            }

            max = savagaList.Max();
            this.Savagea.Text = $@"Najmniejsza wsrod najwiekszych a{savagaList.IndexOf(max) + 1} strat to: {max.ToString(CultureInfo.InvariantCulture)}";

            //obliczanie kryterium Laplacea
            max = 0.0;
            for (var i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                for (var j = 1; j < this.dataGridView1.RowCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value) > max)
                    {
                        max = Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value);
                        decyzja = "a" + i;
                    }
                }
            }

            this.Laplacea.Text = $@"Najlepsza decyzja {decyzja} (z takim samym prawdopodobienstwem) to: {max.ToString(CultureInfo.InvariantCulture)}";

            //obliczanie kryterium OW
            var owList = new List<double>();
            var owList2 = new List<double>();
            for (var i = 1; i < this.dataGridView1.RowCount; i++)
            {
                var rowDecision = 0.0;
                var rowDecision2 = 0.0;
                for (var j = 0; j < this.dataGridView1.ColumnCount; j++)
                {
                    var posibility = 0.0;
                    switch (j)
                    {
                        case 0:
                            posibility = Convert.ToDouble(P1Value.Text.Replace(".", ","));
                            break;
                        case 1:
                            posibility = Convert.ToDouble(P2Value.Text.Replace(".", ","));
                            break;
                        case 2:
                            posibility = Convert.ToDouble(P3Value.Text.Replace(".", ","));
                            break;
                        case 3:
                            posibility = Convert.ToDouble(P4Value.Text.Replace(".", ","));
                            break;
                    }

                    rowDecision += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[j].Value) * posibility;
                    rowDecision2 += Convert.ToDouble(this.dataGridView1.Rows[i].Cells[j].Value);
                }

                owList.Add(rowDecision);
                owList2.Add(rowDecision2);
            }

            max = owList.Max();
            var indeks = owList.IndexOf(max);
            this.OW.Text = $@"OW: decyzja: a{owList.IndexOf(max) + 1} :{owList2[indeks]}";
            //wyswietlanie OWDI na podstawie OW
            this.OWDI.Text = $@"OWDI: decyzja: a{owList.IndexOf(max) + 1} :{owList2[indeks]}";

            //obliczanie kryterium OSM
            var osmList = new List<double>();
            var osmList2 = new List<double>();
            for (var i = 1; i < this.dataGridView2.RowCount; i++)
            {
                var rowDecision = 0.0;
                var rowDecision2 = 0.0;
                for (var j = 0; j < this.dataGridView2.ColumnCount; j++)
                {
                    var posibility = 0.0;
                    switch (j)
                    {
                        case 0:
                            posibility = Convert.ToDouble(P1Value.Text.Replace(".", ","));
                            break;
                        case 1:
                            posibility = Convert.ToDouble(P2Value.Text.Replace(".", ","));
                            break;
                        case 2:
                            posibility = Convert.ToDouble(P3Value.Text.Replace(".", ","));
                            break;
                        case 3:
                            posibility = Convert.ToDouble(P4Value.Text.Replace(".", ","));
                            break;
                    }

                    rowDecision += Math.Abs(Convert.ToDouble(this.dataGridView2.Rows[i].Cells[j].Value) * posibility);
                    rowDecision2 += Math.Abs(Convert.ToDouble(this.dataGridView2.Rows[i].Cells[j].Value));
                }

                osmList.Add(rowDecision);
                osmList2.Add(rowDecision2);
            }

            max = osmList.Min();
            indeks = osmList.IndexOf(max);
            this.OSM.Text = $@"OSM decyzja: a{(osmList.IndexOf(max) + 1)} : -{osmList2[indeks]}";

            //wyszukanie decyzji zdominowanych
            this.domination.Text = "";

            for (var z = 1; z < this.dataGridView1.RowCount; z++)
            {
                for (var i = 1; i < this.dataGridView1.RowCount; i++)
                {
                    if (z != i)
                    {
                        var dominationBool = true;
                        for (var j = 0; j < this.dataGridView1.ColumnCount; j++)
                        {
                            if (Convert.ToDouble(this.dataGridView1.Rows[i].Cells[j].Value) <=
                                Convert.ToDouble(this.dataGridView1.Rows[z].Cells[j].Value))
                            {
                                dominationBool = false;
                                break;
                            }
                        }

                        if (dominationBool)
                        {
                            this.domination.Text += $@"Decyzja {z} zdominowana przez {i}";
                        }
                    }
                }
            }

            if (string.IsNullOrEmpty(this.domination.Text))
            {
                this.domination.Text = @"brak wartosci zdominowanych";
            }
        }
    }
}
