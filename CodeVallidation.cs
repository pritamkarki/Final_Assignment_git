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
        string xPoint, yPoint;
        string[] rPoint = { };
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




                if (sText[0].ToUpper() == "LOOP") // converts aplhabets to uppercase and condition is checked
                {

                    if (sText.Length == 3)
                    {

                        int x = Convert.ToInt32(sText[2]);// converts string value to integer and stores into variable
                        xPoint = Convert.ToString(x);
                        string[] k = { "loop", xPoint };// stores in array
                        retu = k;
                    }
                }
                else if (sText[0].ToUpper() == "END") // converts aplhabets to uppercase and condition is checked
                {

                    if (sText.Length == 1)
                    {

                        string[] k = { "end" };// stores in array
                        retu = k;
                    }
                }

                if (sText[0].ToUpper() == "CIRCLE")
                {
                    if (sText.Length == 2)
                    {
                        if (sText[1].Equals("radius"))
                        {
                            xPoint = sText[1];
                        }
                        else
                        {


                            xPoint = sText[1];
                        }
                        MessageBox.Show(xPoint);
                        string[] k = { "circle", xPoint };
                        retu = k;
                    }

                }
                if (sText[0].ToUpper() == "DRAWTO")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1].Equals("a") && sText[2].Equals("b"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            int y = Convert.ToInt32(sText[2]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);

                        }
                        string[] sPoint = { "drawTo", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "SQUARE")
                {
                    if (sText.Length == 2)
                    {
                        if (sText[1].Equals("side"))
                        {
                            xPoint = sText[1];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            xPoint = Convert.ToString(x);
                        }
                        string[] sPoint = { "square", xPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "TRANSFORM")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1].Equals("xpoint") && sText[2].Equals("ypoint"))
                        {
                            xPoint = sText[1];
                            yPoint = sText[2];
                        }
                        else
                        {
                            int x = Convert.ToInt32(sText[1]);
                            int y = Convert.ToInt32(sText[2]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);
                        }
                        string[] sPoint = { "transform", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "WIDTH" && sText[1] == "=")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        yPoint = Convert.ToString(y);
                        xPoint = sText[1];
                        string[] sPoint = { "width", xPoint, yPoint };
                        rPoint = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }



                if (sText[0].ToUpper() == "RADIUS" && sText[1] == "=")
                {
                    if (sText.Length == 3)
                    {

                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] k = { "radius", xPoint, yPoint };
                        retu = k;
                    }

                }
                if (sText[0].ToUpper() == "IF") // converts aplhabets to uppercase and condition is checked
                {
                    string shap;
                    string sym;
                    if (sText.Length == 5)
                    {
                        int x = Convert.ToInt32(sText[3]);// converts string value to integer and stores into variable
                        if (sText[2] == "=" || sText[2] == ">" || sText[2] == "<")
                        {
                            sym = sText[2];
                            shap = sText[1];
                            xPoint = Convert.ToString(x);
                            string[] k = { "if", shap, sym, xPoint };// stores in array
                            retu = k;
                        }
                        else
                        {
                            MessageBox.Show("Invalid symbol");
                        }
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "MYRECTANGLE")
                {
                    if (sText.Length == 5)
                    {
                        if (sText[1] == "(" && sText[4] == ")")
                        {
                            int x = Convert.ToInt32(sText[2]);
                            int y = Convert.ToInt32(sText[3]);
                            xPoint = Convert.ToString(x);
                            yPoint = Convert.ToString(y);
                            string[] k = { "myrectangle", xPoint, yPoint };
                            retu = k;
                        }
                    }
                }


                if (sText[0].ToUpper() == "MYCIRCLE")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1] == "(" && sText[2] == ")")
                        {
                            string[] k = { "mycircle" };
                            retu = k;
                        }
                    }
                }


                if (sText[0].ToUpper() == "METHOD")
                {
                    if (sText[1].ToUpper() == "MYRECTANGLE")
                    {
                        if (sText.Length == 6)
                        {
                            if (sText[2] == "(" && sText[5] == ")")
                            {
                                string a1 = Convert.ToString(sText[1]);
                                string xaxis = Convert.ToString(sText[3]);
                                string yaxis = Convert.ToString(sText[4]);
                                string[] k = { "method", a1, xaxis, yaxis };
                                rPoint = k;
                            }
                        }
                    }
                    else if (sText[1].ToUpper() == "MYCIRCLE")
                    {
                        if (sText.Length == 4)
                        {
                            if (sText[2] == "(" && sText[3] == ")")
                            {
                                string a1 = Convert.ToString(sText[1]);
                                string[] k = { "method", a1 };
                                rPoint = k;
                            }
                        }
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        rPoint = sPoint;
                    }
                }




            }
            catch (FormatException e)
            {

                MessageBox.Show(e.Message);
            }
            catch (NullReferenceException f)
            {
                MessageBox.Show(f.Message);
            }
            return retu;
        }
    }
}
