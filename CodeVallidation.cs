﻿using System;
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
            string xPoint;
            string[] retu = { };
            string[] sText = text.Split(',', ' ');
            try
            {
                if (sText[0].ToUpper() == "LOOP") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 2)
                    {

                        int x = Convert.ToInt32(sText[1]);// converts string value to integer and stores into variable

                        String a1 = Convert.ToString(x);


                        string[] k = { "loop", a1 };// stores in array
                        retu = k;
                    }

                }


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
                    if (sText.Length == 2)
                    {
                      

                            xPoint = sText[1];
                            MessageBox.Show(xPoint);
                            string[] k = { "circle", xPoint };
                            retu = k;
                                              
                    }

                }
                if (sText[0].ToUpper() == "SQUARE")
                {
                    if (sText.Length == 2)
                    {
                        MessageBox.Show("square3");
                            int x = Convert.ToInt32(sText[1]);
                            xPoint = Convert.ToString(x);
                        
                        string[] k = { "square", xPoint };
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
            catch (IndexOutOfRangeException)
            {

            }
            return retu;
        }
    }
}





