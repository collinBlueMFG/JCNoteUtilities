using System.Net.Security;

namespace simpleTEST
{
    public partial class Form1 : Form
    {








        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //exclusive checkbox behavior
        private void kgcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (kgcheck.Checked)
            {
                lbscheck.Checked = false;
                ozcheck.Checked = false;
            }
        }

        private void lbscheck_CheckedChanged(object sender, EventArgs e)
        {
            if (lbscheck.Checked)
            {
                kgcheck.Checked = false;
                ozcheck.Checked = false;
            }
        }

        private void ozcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (ozcheck.Checked)
            {
                lbscheck.Checked = false;
                kgcheck.Checked = false;
            }
        }

        private void Liquidcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Liquidcheck.Checked)
            {
                Solidcheck.Checked = false;
            }
        }

        private void Solidcheck_CheckedChanged(object sender, EventArgs e)
        {
            if (Solidcheck.Checked)
            {
                Liquidcheck.Checked = false;
            }
        }

        //calculation
        private void Run_Click_1(object sender, EventArgs e)
        {

            Double quantity;
            Double price;
            Double priceperkilo;
            String unit = "";
            String output;

            //adds functionality to enter amount + ; + unit
            if (Amountbox.Text.Contains(";"))
            {
                unit = Amountbox.Text.Split(";")[1];
                quantity = double.Parse(Amountbox.Text.Split(";")[0]);

                if (unit == "lbs")
                {
                    quantity = quantity * 0.453592;
                }
                
                if (unit == "oz")
                {
                    quantity = quantity * 0.0283495;
                }
            }
            else
            {
                quantity = double.Parse(Amountbox.Text);
                
                //set unit
                if (kgcheck.Checked)
                {
                    unit = "kgs";
                }

                if (lbscheck.Checked)
                {
                    quantity = quantity * 0.453592;
                    unit = "lbs";
                }

                if (ozcheck.Checked)
                {
                    quantity = quantity * 0.0283495;
                    unit = "oz";
                }
            }
            price = double.Parse(Pricebox.Text);

            
            
            //set price per kilo
            if (perkilocheck.Checked)
            {
                priceperkilo = price;
                price = priceperkilo * quantity;
            }
            priceperkilo = price / quantity;
            


            //landed pricing
            if (Solidcheck.Checked || Amountbox.Text.Split(";")[2] == "s")
            {
                priceperkilo = priceperkilo + 3;
            }

            if (Liquidcheck.Checked || Amountbox.Text.Split(";")[2] == "l")
            {
                priceperkilo = priceperkilo + 4;
            }



            output = DateTime.Today.ToString("MM/dd/yyyy") + "\r\nPriced from: " + Amountbox.Text.Split(";")[0] + unit + " = $" + Math.Round(price, 2) + " ($" + Math.Round((price / quantity), 2) + "/kg) landed price: $" + Math.Round(priceperkilo, 2) + "/kg";
            if (copycheck.Checked)
            {
                System.Windows.Forms.Clipboard.SetText(output);
            }
            Outputbox.Text = output;
        }

        private void templaterun_Click(object sender, EventArgs e)
        {
            String[] tempStrArr;
            double[] unitsArr;

            double[] priceArr;

            double[] lpriceArr;

            double[] moqArr;
            


            //going to parse all these as double[], if not in list then return array len 1.
            tempStrArr = TemplateUnitKgInput.Text.Split(',');
            unitsArr = new double[tempStrArr.Length];

            for (int i = 0; i < tempStrArr.Length; i++)
            {
                unitsArr[i] = double.Parse(tempStrArr[i]);
            }
            
            tempStrArr = TemplatePricesBox.Text.Split(",");
            priceArr = new double[tempStrArr.Length];
            for (int i = 0; i < tempStrArr.Length; i++)
            {
                priceArr[i] = double.Parse(tempStrArr[i]);
            }
            
            
            tempStrArr = TemplatePricesBox.Text.Split(",");
            lpriceArr = new double[tempStrArr.Length];
            for (int i = 0; i < tempStrArr.Length; i++)
            {
                lpriceArr[i] = double.Parse(tempStrArr[i]);
            }
            
	    	    
            tempStrArr = TemplatePricesBox.Text.Split(",");
            moqArr = new double[tempStrArr.Length];
            for (int i = 0; i < tempStrArr.Length; i++)
            {
                moqArr[i] = double.Parse(tempStrArr[i]);
            }

            


            
            
           
        }
    }
}
