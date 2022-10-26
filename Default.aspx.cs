using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASSIG1_BinaryConverter
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            
            if (numList1.SelectedIndex == 1 && numList2.SelectedIndex == 1)
            {
                try
                {
                    int numberused = Convert.ToInt32(TextBox1.Text);
                    string hexValue = numberused.ToString("X");
                    result1.Text = hexValue;              

                }
                    
                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;   
                }
                

            }
            if (numList1.SelectedIndex == 1 && numList2.SelectedIndex == 2)
            {
                try
                {
                    int numberused = Convert.ToInt16(TextBox1.Text);
                    string newoct = Convert.ToString(deciToOct(numberused));
                    result1.Text = newoct;

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }

            }
           
            if (numList1.SelectedIndex == 1 && numList2.SelectedIndex == 3)
            {
                try
                {
                    int numberused = Convert.ToInt16(TextBox1.Text);
                    string newbin = Convert.ToString(deciTobin(numberused));
                    result1.Text = newbin;

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
            }
            if (numList1.SelectedIndex == 2 && numList2.SelectedIndex == 1)
            {
                try
                {
                    int decValue = int.Parse(TextBox1.Text, System.Globalization.NumberStyles.HexNumber);
                    string newbin = Convert.ToString(decValue);
                    result1.Text = newbin;

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
            
            }
            if (numList1.SelectedIndex == 2 && numList2.SelectedIndex == 2)
            {
                try
                {
                    int decValue = int.Parse(TextBox1.Text, System.Globalization.NumberStyles.HexNumber);
                    string newoct = Convert.ToString(deciToOct(decValue));
                    result1.Text = newoct;

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
            }
            if (numList1.SelectedIndex == 2 && numList2.SelectedIndex == 3)
            {
                try
                {
                    int decValue = int.Parse(TextBox1.Text, System.Globalization.NumberStyles.HexNumber);
                    string newbin = Convert.ToString(deciTobin(decValue));
                    result1.Text = newbin;
                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
            }
            if (numList1.SelectedIndex == 3 && numList2.SelectedIndex == 1)/*octal to decimal*/
            {
                int n = Convert.ToInt32(TextBox1.Text, 8);
                result1.Text = Convert.ToString(n);

            }
            if (numList1.SelectedIndex == 3 && numList2.SelectedIndex == 2)/*octal to hex*/
            {
                int n = Convert.ToInt32(TextBox1.Text, 8);
                string n2 = n.ToString("X");
                result1.Text = n2;

            }
            if (numList1.SelectedIndex == 3 && numList2.SelectedIndex == 3)/*octal to binary*/
            {
                int n = Convert.ToInt32(TextBox1.Text, 8);
                string newbin = Convert.ToString(deciTobin(n));
                result1.Text = newbin;
            }
            if (numList1.SelectedIndex == 4 && numList2.SelectedIndex == 1)
            {
                try
                {
                    result1.Text = Convert.ToInt32(TextBox1.Text, 2).ToString();

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
               
            }
            if (numList1.SelectedIndex == 4 && numList2.SelectedIndex == 2)
            {
                try
                {
                    String tempBinDec = Convert.ToInt32(TextBox1.Text, 2).ToString();
                    int numberused = Convert.ToInt32(tempBinDec);
                    string hexValue = numberused.ToString("X");
                    result1.Text = hexValue;

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
            }
            if (numList1.SelectedIndex == 4 && numList2.SelectedIndex == 3)
            {
                try
                {
                    String tempBinDec = Convert.ToInt32(TextBox1.Text, 2).ToString();
                    int numberused = Convert.ToInt16(tempBinDec);
                    string newoct = Convert.ToString(deciToOct(numberused));
                    result1.Text = newoct;

                }

                catch (System.Exception exception)
                {
                    result1.Text = exception.Message;
                }
            }

        }
        public string deciTobin(int n)
        {
            int quotient;
            string rem = "";
            while (n >= 1)
            {
                quotient = n / 2;
                rem += (n % 2).ToString();
                n = quotient;
            }
            string binary = "";
            for (int i = rem.Length - 1; i >= 0; i--)
            {
                binary = binary + rem[i];
            }
            return binary;
        }
        public string deciToOct(int n)
        {
            int[] octalNumber = new int[100];
            int quotient, i = 1, j;
            string Octal = "";
            quotient = n;
            while (quotient != 0)
            {
                octalNumber[i++] = quotient % 8;
                quotient = quotient / 8;
            }        
            for (j = i - 1; j > 0; j--)
                Octal += octalNumber[j].ToString();
            return Octal;
        }
       
       

        protected void Button1_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            result1.Text = "";
            numList1.SelectedIndex = 0;
            numList2.SelectedIndex = 0;
        }

        protected void numList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (numList1.SelectedIndex == 1)
            {
                numList2.Items.Clear();
                numList2.Items.Add(new ListItem("Select a Value"));
                numList2.Items.Add(new ListItem("Hexa-Decimal"));
                numList2.Items.Add(new ListItem("Octal"));
                numList2.Items.Add(new ListItem("Binary"));               
            }

            else if (numList1.SelectedIndex == 2)
            {
                numList2.Items.Clear();
                numList2.Items.Add(new ListItem("Select a Value"));
                numList2.Items.Add(new ListItem("Decimal"));
                numList2.Items.Add(new ListItem("Octal"));
                numList2.Items.Add(new ListItem("Binary"));

            }
            else if (numList1.SelectedIndex == 3)
            {
                numList2.Items.Clear();
                numList2.Items.Add(new ListItem("Select a Value"));
                numList2.Items.Add(new ListItem("Decimal"));
                numList2.Items.Add(new ListItem("Hexa-Decimal"));
                numList2.Items.Add(new ListItem("Binary"));
            }
            else if (numList1.SelectedIndex == 4)
            {
                numList2.Items.Clear();
                numList2.Items.Add(new ListItem("Select a Value"));
                numList2.Items.Add(new ListItem("Decimal"));
                numList2.Items.Add(new ListItem("Hexa-Decimal"));
                numList2.Items.Add(new ListItem("Octal"));
            }
            else if (numList1.SelectedIndex == 0)
            {
                numList2.Items.Clear();
                numList2.Items.Add(new ListItem("Select a initial value to convert first!"));
            }

        }
    }
}
    
