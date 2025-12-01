using System.Net.Security;
using System.Xml;

namespace simpleTEST
{
    //THIS ALLLLLLL NEEDS ERROR HANDLING
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


            try
            {
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
            catch { Outputbox.Text = "An error has occurred, check your input formatting and try again!"; }
        }


        private void LiquidRun_Click(object sender, EventArgs e)
        {

            Double quantity;
            Double price;
            Double priceperkilo;
            String unit = "";
            String output;
            try
            {
                //adds functionality to enter amount + ; + unit
                if (LiquidAmountBox.Text.Contains(";"))
                {
                    unit = LiquidAmountBox.Text.Split(";")[1];
                    quantity = double.Parse(LiquidAmountBox.Text.Split(";")[0]);

                    if (unit == "gal")
                    {
                        quantity = quantity / 0.264172;
                    }

                    if (unit == "floz")
                    {
                        quantity = quantity / 33.814;
                    }
                }
                else
                {
                    quantity = double.Parse(LiquidAmountBox.Text);

                    //set unit
                    if (LiquidLiterCheck.Checked)
                    {
                        unit = "L";
                    }

                    if (LiquidGallonCheck.Checked)
                    {
                        quantity = quantity / 0.264172;
                        unit = "gal";
                    }

                    if (LiquidFlozCheck.Checked)
                    {
                        quantity = quantity / 33.814;
                        unit = "floz";
                    }
                }
                price = double.Parse(LiquidPriceBox.Text);

                quantity = quantity * double.Parse(LiquidDensityBox.Text);

                //set price per kilo
                if (perkilocheck.Checked)
                {
                    priceperkilo = price;
                    price = priceperkilo * quantity;
                }
                priceperkilo = price / quantity;



                priceperkilo = priceperkilo + 4;


                output = DateTime.Today.ToString("MM/dd/yyyy") + "\r\nDensity: " + LiquidDensityBox.Text + "\r\nPriced from: " + LiquidAmountBox.Text.Split(";")[0] + unit + " = $" + Math.Round(price, 2) + " ($" + Math.Round((price / quantity), 2) + "/kg) landed price: $" + Math.Round(priceperkilo, 2) + "/kg";
                if (LiquidCopyCheck.Checked)
                {
                    System.Windows.Forms.Clipboard.SetText(output);
                }
                LiquidOutputBox.Text = output;
            }

            catch { LiquidOutputBox.Text = "An error has occurred, check your input formatting and try again!"; }
        }

        private void templaterun_Click(object sender, EventArgs e)
        {
            String[] tempStrArr;
            double[] unitsArr;

            double[] priceArr;

            double[] lpriceArr;

            double[] moqArr;



            //going to parse all these as double[], if not in list then return array len 1.
            //FUNCTION WORKFLOW: take all parameters as input, assume columnated format (i.e. order of initial input arrays corresponds-
            //to their order in columns and assumes same number of elements unless length is one. these values will then be added into the normal string format and added to a "line" string-
            //the content of which will consist of each column's contents on that row, followed by a number of padding characters (" ") determined by a function up to an arbitrary max character per line limit.
            //each line string will then be separated by a line break "\r\n" and added to the output box to obtain the final formatted chart.


           //initialize double arrays for each input box, then delimit input by "," and add to the array 
            tempStrArr = TemplateUnitKgInput.Text.Split(',');
            unitsArr = cDoubleArr(tempStrArr);

            tempStrArr = TemplatePricesBox.Text.Split(",");
            priceArr = cDoubleArr(tempStrArr);

            tempStrArr = TemplatePricesBox.Text.Split(",");
            lpriceArr =cDoubleArr(tempStrArr);

            tempStrArr = TemplatePricesBox.Text.Split(",");
            moqArr = cDoubleArr(tempStrArr);

            //So that all these rows can be of an arbitrary length, use for loops to initialize each row into its respective line before sending it to paddingfunc
            





        }
        private static double[] cDoubleArr(string[] arr)
        {
            double[] output;
            output = new double[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                output[i] = double.Parse(arr[i]);
            }
            return output;
        }

        private static string PaddingFunc(string rowName, string line, int padValue) //This function takes an input string of 1 row from templaterun_click (3 values separated by spaces) and pads the spaces until it reaches a maximum character limit
        {
            string output = "";
            string[] lineArr = line.Split(" ");
           
            
            for(int j = 0; j < lineArr.Length-1; j++)
            {
                while (lineArr[j].Length < padValue)
                {
                    lineArr[j] = lineArr[j] + " ";
                }
                output = output + lineArr[j];
            }
            
            
            return output;
        }


    }
}
