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

            var realizationSize = Convert.ToInt32(this.realizationSize.Text);
            var demand = Convert.ToInt32(this.demand.Text);
            var regularPrice = Convert.ToDouble(this.regularPrice.Text);
            var discountPrice = Convert.ToDouble(this.discountPrice.Text);

            var price1 = Convert.ToDouble(this.price1.Text);
            var price2 = Convert.ToDouble(this.price2.Text);
            var price3 = Convert.ToDouble(this.price3.Text);

            double cost;
            if (realizationSize == 1)
                cost = price1 * packageSize;
            else if (realizationSize == 2)
                cost = price2 * realizationSize * packageSize;
            else
                cost = price3 * realizationSize * packageSize;

            label8.Text = cost.ToString();
            label13.Text = (demand * regularPrice).ToString();
            label16.Text = (((realizationSize * packageSize) - demand) * discountPrice).ToString();
            label17.Text =
                ((0 - cost + (demand * regularPrice) + (((realizationSize * packageSize) - demand) * discountPrice)))
                .ToString();
        }
    }
}
