using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ASE_Assignment
{
    class CodeVallidation
    {
        public String[] valid(String text)
        {
            string[] retu = { };
            string[] sText = text.Split(',', ' ');
            try
            {
                if (sText[0].ToUpper() == "MOVETO")
                {
                    if (sText.Length < 4)
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "moveTo", a1, b1 };
                        retu = k;
                    }
                }
                if (sText[0].ToUpper() == "RECTANGLE")
                {
                    if (sText.Length < 4)
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        string a1 = Convert.ToString(x);
                        string b1 = Convert.ToString(y);
                        string[] k = { "rectangle", a1, b1 };
                        retu = k;
                    }
                }
                if (sText[0].ToUpper() == "TRIANGLE")
                {
                    if (sText.Length < 5)
                    {
                        int x = Convert.ToInt32(sText[1]);
                        int y = Convert.ToInt32(sText[2]);
                        int z = Convert.ToInt32(sText[3]);
                        String a1 = Convert.ToString(x);
                        String b1 = Convert.ToString(y);
                        String c1 = Convert.ToString(z);
                        string[] k = { "triangle", a1, b1, c1 };
                        retu = k;
                    }
                }
                if (sText[0].ToUpper() == "CIRCLE")
                {
                    if (sText.Length < 3)
                    {
                        int x = Convert.ToInt32(sText[1]);
                       
                        String a1 = Convert.ToString(x*2);
                      
                        string[] k = { "circle", a1 };
                        retu = k;
                    }
                }
            }
            catch (FormatException e)
            {
                string[] k = { "1", "1" };
                retu = k;
                MessageBox.Show(e.Message);
            }
            catch (IndexOutOfRangeException )
            {
                MessageBox.Show("please view command in help");
            }
            return retu;
        }
    }
}
