using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Decisions
{
    public partial class Main : Form
    {
        List<string> firstLine = new List<string>();
        List<string> secondLine = new List<string>();
        int rowCount = 0;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const int packageSize = 200;

            var realizationSizeVar = Convert.ToInt32(this.realizationSize.Text);
            var demandVar = Convert.ToInt32(this.demand.Text);
            var regularPriceVar = Convert.ToDouble(this.regularPrice.Text);
            var discountPriceVar = Convert.ToDouble(this.discountPrice.Text);

            if (demandVar > (realizationSizeVar * packageSize))
            {
                demandVar = realizationSizeVar * packageSize;
            }

            var price1Var = Convert.ToDouble(this.price1.Text);
            var price2Var = Convert.ToDouble(this.price2.Text);
            var price3Var = Convert.ToDouble(this.price3.Text);

            double cost;
            if (realizationSizeVar == 1)
                cost = price1Var * packageSize;
            else if (realizationSizeVar == 2)
                cost = price2Var * realizationSizeVar * packageSize;
            else
                cost = price3Var * realizationSizeVar * packageSize;

            CostValue.Text = cost.ToString();
            IncomeValue.Text = (demandVar * regularPriceVar).ToString();
            IncomeValue2.Text = (((realizationSizeVar * packageSize) - demandVar) * discountPriceVar).ToString();
            ProfitValue.Text =
                ((0 - cost + (demandVar * regularPriceVar) + (((realizationSizeVar * packageSize) - demandVar) * discountPriceVar)))
                .ToString();
        }

        private void readDataButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();
            this.dataGridView2.Rows.Clear();
            this.dataGridView2.Columns.Clear();
            firstLine.Clear();
            secondLine.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);

                var allCharactersInDocument = (sr.ReadToEnd());

                var allCharactersInDocumentArray = allCharactersInDocument.Split();
                var z = 1;

                foreach (var item in allCharactersInDocumentArray)
                {
                    if (item.Equals(""))
                    {
                        for (var x = z; x < allCharactersInDocumentArray.Length; x++)
                        {
                            secondLine.Add(allCharactersInDocumentArray[x]);
                        }
                        break;
                    }

                    firstLine.Add(item);
                    z++;
                }

                int id = 1;
                foreach (var item in firstLine)
                {
                    this.dataGridView1.Columns.Add("column", "s" + id);
                    this.dataGridView2.Columns.Add("column", "s" + id);
                    id++;
                }

                this.dataGridView1.Rows.Add();
                this.dataGridView2.Rows.Add();
                for (var j = 0; j < firstLine.Count; j++)
                {
                    this.dataGridView1.Rows[0].Cells[j].Value = firstLine[j];
                    this.dataGridView1.Rows[0].HeaderCell.Value = "zamówienie";
                    this.dataGridView2.Rows[0].Cells[j].Value = firstLine[j];
                    this.dataGridView2.Rows[0].HeaderCell.Value = "zamówienie";
                }

                sr.Close();
            }
        }

        private void CalculateValuesButton_Click(object sender, EventArgs e)
        {
            rowCount = 0;
            for (var i = 0; i < secondLine.Count; i++)
            {
                this.dataGridView1.Rows.Add();
                this.dataGridView2.Rows.Add();
                rowCount++;
                this.dataGridView1.Rows[rowCount].HeaderCell.Value = secondLine[i];
                this.dataGridView2.Rows[rowCount].HeaderCell.Value = secondLine[i];

                for (var j = 0; j < firstLine.Count; j++)
                {
                    var demandVar = Convert.ToInt32(this.dataGridView1.Rows[0].Cells[j].Value);
                    var regularPriceVar = Convert.ToDouble(this.regularPrice.Text);
                    var discountPriceVar = Convert.ToDouble(this.discountPrice.Text);
                    var orderSize = Convert.ToInt32(secondLine[i]);

                    if (demandVar > (Convert.ToInt32(secondLine[i])))
                    {
                        demandVar = (Convert.ToInt32(secondLine[i]));
                    }

                    var price1Var = Convert.ToDouble(this.price1.Text);
                    var price2Var = Convert.ToDouble(this.price2.Text);
                    var price3Var = Convert.ToDouble(this.price3.Text);

                    double cost;
                    if (orderSize == 200)
                        cost = price1Var * orderSize;
                    else if (orderSize == 400)
                        cost = price2Var * orderSize;
                    else
                        cost = price3Var * orderSize;

                    var profit =
                        ((0 - cost + demandVar * regularPriceVar) +
                         ((Convert.ToInt32(secondLine[i]) - demandVar) * discountPriceVar))
                        .ToString();

                    this.dataGridView1.Rows[rowCount].Cells[j].Value = profit;
                }
            }

            for (var i = 0; i < this.dataGridView2.ColumnCount; i++)
            {
                double maxColumnValue = 0.0;
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

        private void calculationButton_Click(object sender, EventArgs e)
        {
            double max = 0.0;
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

            this.Hurwicza.Text = "Najlepsza decyzja " + decyzja + " (najwieksza wyplata) to: " + max.ToString();

            List<double> waldList = new List<double>();
            double min = Double.MaxValue;
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
                min = Double.MaxValue;
            }

            max = waldList.Max();
            this.Walda.Text = "Najlepsza z najgorszych wyplat a" + (waldList.IndexOf(max) + 1) + " to: " + max.ToString();

            List<double> savagaList = new List<double>();
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
                min = Double.MaxValue;
            }

            max = savagaList.Max();
            this.Savagea.Text = "Najmniejsza wsrod najwiekszych a" + (savagaList.IndexOf(max) + 1) + " strat to: " +  max.ToString();
            
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

            this.Laplacea.Text = "Najlepsza decyzja " + decyzja + " (z takim samym prawdopodobienstwem) to: " + max.ToString();
            
            max = 0.0;
            var max2 = 0.0;
            for (var i = 0; i < this.dataGridView1.ColumnCount; i++)
            {
                var posibility = 0.0;
                if (i == 0)
                    posibility = Convert.ToDouble(P1Value.Text.Replace(".", ","));
                if (i == 1)
                    posibility = Convert.ToDouble(P2Value.Text.Replace(".", ","));
                if (i == 2)
                    posibility = Convert.ToDouble(P3Value.Text.Replace(".", ","));
                if (i == 3)
                    posibility = Convert.ToDouble(P4Value.Text.Replace(".", ","));
                for (var j = 1; j < this.dataGridView1.RowCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value) * posibility > max)
                    {
                        max = Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value) * posibility;
                        max2 = Convert.ToDouble(this.dataGridView1.Rows[j].Cells[i].Value);
                        decyzja = "a" + i;
                    }
                }
            }

            this.OW.Text = "OW: decyzja: " + decyzja + ": " + max2;

            List<double> osmList = new List<double>();
            for (var i = 1; i < this.dataGridView2.ColumnCount; i++)
            {
                var posibility = 0.0;
                if (i == 0)
                    posibility = Convert.ToDouble(P1Value.Text.Replace(".", ","));
                if (i == 1)
                    posibility = Convert.ToDouble(P2Value.Text.Replace(".", ","));
                if (i == 2)
                    posibility = Convert.ToDouble(P3Value.Text.Replace(".", ","));
                if (i == 3)
                    posibility = Convert.ToDouble(P4Value.Text.Replace(".", ","));
                for (var j = 0; j < this.dataGridView2.RowCount; j++)
                {
                    if (Convert.ToDouble(this.dataGridView2.Rows[i].Cells[j].Value) * posibility < min)
                    {
                        min = Convert.ToDouble(this.dataGridView2.Rows[i].Cells[j].Value) * posibility;
                    }
                }

                osmList.Add(min);
                min = Double.MaxValue;
            }

            max = osmList.Max();
            this.OSM.Text = "OSM: decyzja a" + ": " + max.ToString();
        }
    }
}
