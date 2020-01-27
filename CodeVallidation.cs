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
            string xPoint,yPoint;
            string[] retu = { };
            string[] sText = text.Split(',', ' ');
            try
            {
                if (sText[0].ToUpper() == "LOOP") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 3)
                    {
                        int x = Convert.ToInt32(sText[2]);// converts string value to integer and stores into variable
                        xPoint = Convert.ToString(x);
                        string[] sPoint = { "loop", xPoint };// stores in array
                        retu = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "END") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 1)
                    {
                        string[] sPoint = { "end" };// stores in array
                        retu = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "ENDMETHOD") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 1)
                    {
                        string[] sPoint = { "endmethod" };// stores in array
                        retu = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "ENDIF") // converts aplhabets to uppercase and condition is checked
                {
                    if (sText.Length == 1)
                    {
                        string[] sPoint = { "endif" };// stores in array
                        retu = sPoint;
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
                            string[] sPoint = { "if", shap, sym, xPoint };// stores in array
                            retu = sPoint;
                        }
                        else
                        {
                            MessageBox.Show("Invalid symbol");
                        }
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
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
                         retu= sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
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
                        string[] sPoint = { "radius", xPoint, yPoint };
                        retu = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
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
                        retu = sPoint;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "HEIGHT" && sText[0] == "=")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] k = { "height", xPoint, yPoint };
                        retu = k;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }

                if (sText[0].ToUpper() == "RADIUS" && sText[1] == "+")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] k = { "radius", xPoint, yPoint };
                        retu = k;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }


                if (sText[0].ToUpper() == "WIDTH" && sText[1] == "+")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] k = { "width", xPoint, yPoint };
                        retu = k;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
                    }
                }
                if (sText[0].ToUpper() == "HEIGHT" && sText[1] == "+")
                {
                    if (sText.Length == 3)
                    {
                        int y = Convert.ToInt32(sText[2]);
                        xPoint = sText[1];
                        yPoint = Convert.ToString(y);
                        string[] k = { "height", xPoint, yPoint };
                        retu = k;
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
                        MessageBox.Show("Invalid Commmand");// displays message box
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
                                retu = k;
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
                                retu = k;
                            }
                        }
                    }
                    else
                    {
                        string[] sPoint = { "1", "1" };
                        retu = sPoint;
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
                            string[] sPoint = { "myrectangle", xPoint, yPoint };
                            retu = sPoint;
                        }
                    }
                }


                if (sText[0].ToUpper() == "MYCIRCLE")
                {
                    if (sText.Length == 3)
                    {
                        if (sText[1] == "(" && sText[2] == ")")
                        {
                            string[] sPoint = { "mycircle" };
                            retu = sPoint;
                        }
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





