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

            label8.Text = cost.ToString();
            label13.Text = (demandVar * regularPriceVar).ToString();
            label16.Text = (((realizationSizeVar * packageSize) - demandVar) * discountPriceVar).ToString();
            label17.Text =
                ((0 - cost + (demandVar * regularPriceVar) + (((realizationSizeVar * packageSize) - demandVar) * discountPriceVar)))
                .ToString();
        }

        private void readDataButton_Click(object sender, EventArgs e)
        {
            this.dataGridView1.Rows.Clear();
            this.dataGridView1.Columns.Clear();

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.StreamReader sr = new
                    System.IO.StreamReader(openFileDialog1.FileName);

                var allCharactersInDocument = (sr.ReadToEnd());
                //MessageBox.Show(allCharactersInDocument);
                
                var allCharactersInDocumentArray = allCharactersInDocument.Split();
                List<string> firstLine = new List<string>();
                List<string> secondLine = new List<string>();
                var tmp = "";
                var z = 1;
                foreach (var item in allCharactersInDocumentArray)
                {
                    if (item.Equals(""))
                    {
                        for (var x = z; x < allCharactersInDocumentArray.Length; x++)
                        {
                            secondLine.Add(allCharactersInDocumentArray[x]);
                            tmp += allCharactersInDocumentArray[x] + " ";
                        }
                        break;
                    }

                    firstLine.Add(item);
                    z++;
                }
                MessageBox.Show(tmp);

                int id = 1;
                foreach (var item in firstLine)
                {
                    this.dataGridView1.Columns.Add("column", "s" + id);
                    id++;
                }
                
                this.dataGridView1.Rows.Add();
                for (var j = 0; j < firstLine.Count; j++)
                {
                    this.dataGridView1.Rows[0].Cells[j].Value = firstLine[j];
                }

                sr.Close();
            }
        }
    }
}
