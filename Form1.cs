using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ASE_Assignment
{

    public partial class Form1 : Form
    {
        //declaring variable
        int x = 0, y = 0, radius = 0, d = 0, e, f;
       int  width = 0, height = 0;
        int x_axis = 0, y_axis = 0;

        Graphics graph;
        
        int c = 0;

        int a = 0, b = 0, xTranslate = 0, yTranslate = 0;
        string textOrder;
        public Form1()
        {

            InitializeComponent();
            graph = Panel.CreateGraphics();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save";
            save.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(save.FileName));
                saveStream.Write(MultipleCommand.Text);

                saveStream.Dispose();
            }
        }

        private void loadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Title = "Load.";
            load.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (load.ShowDialog() == DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(load.FileName));
                MultipleCommand.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Panel.Refresh();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            MultipleCommand.ResetText();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SingleCommand.ResetText();
        }

        private void LOAD_Click(object sender, EventArgs e)
        {
            OpenFileDialog load = new OpenFileDialog();
            load.Title = "Load.";
            load.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (load.ShowDialog() == DialogResult.OK)
            {
                StreamReader openStream = new StreamReader(File.OpenRead(load.FileName));
                MultipleCommand.Text = openStream.ReadToEnd();
                openStream.Dispose();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Title = "Save";
            save.Filter = "Text Files(*.txt)|*.txt| All Files(*.*)|*.*";

            if (save.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamWriter saveStream = new StreamWriter(File.Create(save.FileName));
                saveStream.Write(MultipleCommand.Text);

                saveStream.Dispose();
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cmd = SingleCommand.Text;
            CodeVallidation v = new CodeVallidation();
            String[] result = v.valid(cmd);
            try
            {
                if (result[0] == "moveTo")
                {
                    MessageBox.Show("asdda");
                    int store1 = Convert.ToInt32(result[1]);
                    int store2 = Convert.ToInt32(result[2]);
                    x_axis = store1;
                    y_axis = store2;
                }
                if (result[0] == "rectangle")
                {
                    ShapeFactory s1 = new ShapeFactory();
                    FinalShape sh = s1.getShape(result[0]);
                    sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
                }
                if (result[0] == "triangle")
                {
                    ShapeFactory t1 = new ShapeFactory();
                    FinalShape sh = t1.getShape(result[0]);
                    sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
                }
                if (result[0] == "circle")
                {
                    ShapeFactory c1 = new ShapeFactory();
                    FinalShape sh = c1.getShape(result[0]);
                    sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
                }
            }
            catch (IndexOutOfRangeException)
            {
                MessageBox.Show("Please type a valid Command");

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(MultipleCommand.Text))
            {
                textOrder = MultipleCommand.Text.Trim();

                string[] arrayOrder = Regex.Split(textOrder, "\n");

                for (int i = 0; i < arrayOrder.Length; i++)
                {
                    CodeVallidation v = new CodeVallidation();

                    String[] result = v.valid(arrayOrder[i]);
                    getShape(result);
                    
                }
            }
        }

        private void Panel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void commandLIstToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String msg = "Comands are Given Below!!\n\n" +
             "Rectangle width/height\n" +
             "Circle raidus\n" +
             "Traingle side,side,side\n" +
             "Moveto x,y\n" +
             "Drawto x,y\n";
            string title = "Command docs";
            MessageBox.Show(msg, title);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            x_axis = 0;
            y_axis = 0;
        }

        public void getShape(string[]result)
        {
            //variables
            if (result[0] == "radius" && result[1] == "=")
            {
                radiusvariable(result);

            }
            else if (result[0] == "radius" && result[1] == "+")
            {
                radiusadd(result);

            }

            else if (result[0] == "width" && result[1] == "=")
            {
                widthvariable(result);
               
               
            }
            else if (result[0] == "height" && result[1] == "=")
            {
                heightvariable(result);
               
               
            }
            
            
            else if (result[0] == "width" && result[1] == "+")
            {
                widthadd(result);
            }
            else if (result[0] == "height" && result[1] == "+")
            {
                heightadd(result); 
            }

            else if (result[0] == "loop")
            {
                loop(result, radius, width, height);
            }
            else if (result[0] == "if")
            {
                ifcase(result);
            }
            else if (result[0] == "mycircle")
            {
                myCircle(result);
            }
            else if (result[0] == "myrectangle")
            {
                myRectangle(result);
            }

            else if(d == 0){
                if (result[0] == "circle")
                {
                    circle(result);
                }

                else if (result[0] == "square")
                {
                    MessageBox.Show("1");
                    Square(result);
                }
                else if (result[0] == "moveTo")
                {
                    moveto(result);
                }
                else if (result[0] == "drawTo")
                {
                    drawto(result);
                }
                else if (result[0] == "transform")
                {
                    transform(result);
                }
                if (result[0] == "rectangle")
                {
                    rectangle(result);
                }


            } // Shapes


        }

        private void radiusadd(string[] result)
        {
            d = 0;
            radius = radius + Convert.ToInt32(result[2]);
            MessageBox.Show(radius + "");


        }
        private void radiusvariable(string[] result)
        {
            d = 0;
            radius = Convert.ToInt32(result[2]);
            MessageBox.Show(radius + "");
        }
        private void heightvariable(string[] result)
        {
            height = Convert.ToInt32(result[2]);
            MessageBox.Show(height +"");
        }
        private void heightadd(string[] result)
        {
            d = 0;
            height = Convert.ToInt32(result[2]);
            MessageBox.Show(height + "");
        }

     

        private void widthvariable(string[] result)
        {
            d = 0;
            width = Convert.ToInt32(result[2]);
            MessageBox.Show(result[2]);
        }
        private void widthadd(string[] result)
        {
            d = 0;
            width = Convert.ToInt32(result[2]);
            MessageBox.Show(result[2]);
        }
      
        private void circle(string[] result)
        {
            MessageBox.Show("circle");
            ShapeFactory c1 = new ShapeFactory();
            FinalShape sh = c1.getShape(result[0]);
            sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
        }
        

     

        private void moveto(string[] result)
        {
            d = 0;
            int x_axis1 = Convert.ToInt32(result[1]);
            int y_axis1 = Convert.ToInt32(result[2]);
            x_axis = x_axis1;
            y_axis = y_axis1;
        }

        private void triangle(string[] result)
        {
            ShapeFactory t1 = new ShapeFactory();
            FinalShape sh = t1.getShape(result[0]);
            sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
        }

        private void Square(string[] result)
        {
            d = 0;
            MessageBox.Show("2");
            ShapeFactory c1 = new ShapeFactory();
            FinalShape sh = c1.getShape(result[0]);
            sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
        }
        private void drawto(string[] result)
        {
            if (result[1].Equals("a") && result[2].Equals("b"))
            {
                e = 0;
                f = 50;
            }
            else
            {
                e = Convert.ToInt32(result[1]);
                f = Convert.ToInt32(result[2]);
            }
            Pen pen = new Pen(Color.Bisque, 3);
            graph.DrawLine(pen, x_axis, y_axis, e, f);
        }
        private void transform(string[] result)
        {
           
            if (result[1].Equals("xpoint") && result[2].Equals("ypoint"))
            {
                x_axis = 30;
                y_axis = 40;
            }
            else
            {
                x_axis = Convert.ToInt32(result[1]);
                y_axis = Convert.ToInt32(result[2]);
            }
            graph.TranslateTransform(x, y);
            MessageBox.Show("Transform :");
        }

     
        private void rectangle(string[] result)
        {
            ShapeFactory s1 = new ShapeFactory();
            FinalShape sh = s1.getShape(result[0]);
            sh.DrawShape(result, graph, x_axis, y_axis, radius, width, height);
        }


        private int Ending()
        {
            try
            {
                string[] line;
                line = MultipleCommand.Lines;
                CodeVallidation val = new CodeVallidation();
                var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                int length = textArr.Length;
                int counter = 0;
                for (int t = 1; t <= length; t++)
                {
                    string[] arrayOrder = Regex.Split(line[counter], "\r\n");//splits the data at next line and stores themin array
                    string[] result1 = val.valid(arrayOrder[0]);
                    if (result1[0] == "end")
                    {
                        return 5;
                        break;
                    }
                    if (result1[0] == "endmethod")
                    {
                        return 6;
                        break;
                    }
                    if (result1[0] == "endif")
                    {
                        return 7;
                        break;
                    }

                    counter = counter + 1;
                }

               

            }
            catch(NullReferenceException e)
            {
                MessageBox.Show(e.Message);
            }

            return 0;
        }

        //end if

        //


        private int linenumber()
        {
            string[] line;
            line = MultipleCommand.Lines;
            CodeVallidation val = new CodeVallidation();
            var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int length1 = textArr.Length;
            int counter = 0;
            int yell = 1;
            for (int t = 0; t <= length1; t++)
            {
                string[] arrayOrder = Regex.Split(line[counter], "\r\n");//splits the data at next line and stores themin array

                string[] result1 = val.valid(arrayOrder[0]);
                if (result1[0] == "loop")
                {
                    MessageBox.Show(counter + "l");
                    return counter;
                    break;

                }
                else if (result1[0] == "if")
                {
                    MessageBox.Show(counter + "if");
                    return counter;
                    break;
                }
                else if (result1[0] == "circle" || result1[0] == "rectangle")
                {
                    MessageBox.Show(counter + "circle or rectangle");
                    return counter;
                    break;
                }

                counter = counter + 1;
                yell = yell + 1;
            }
            return 0;
        }


        private void loop(string[] result, int radius, int width, int height)
        {
            MessageBox.Show("yaha pugi");
            try
            {
                b = Ending();
                d = 1;
                if (b == 5)
                {
                    string[] line;
                    int a = Convert.ToInt32(result[1]);
                    line = MultipleCommand.Lines;
                    CodeVallidation val = new CodeVallidation();
                    var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                    int length = textArr.Length;
                    for (int s = 1; s <= a; s++)
                    {
                        int temp = linenumber();
                        int number = linenumber();
                        int counter = 0;
                        for (int t = 1; t < length - 1; t++)
                        {
                            string[] arrayOrder = Regex.Split(line[temp], "\r\n");//splits the data at next line and stores themin array
                                                                                  //MessageBox.Show(arrayOrder[0]);
                            String[] results = val.valid(arrayOrder[0]);
                            MessageBox.Show(arrayOrder[0]);

                            if (results[0] == "rectangle")
                            {
                                rectangle(result);
                            }
                            else if (results[0] == "triangle")
                            {
                                triangle(results);
                            }
                            else if (results[0] == "circle")
                            {
                                circle(results);
                            }
                            else if (result[0] == "square")
                            {
                                Square(results);
                            }
                            else if (results[0] == "transform")
                            {
                                transform(results);
                            }
                            else if (results[0] == "drawTo")
                            {
                                drawto(results);
                            }
                            else if (results[0] == "moveto")
                            {
                                moveto(results);
                            }
                            else if (results[0] == "radius" && results[1] == "=")
                            {
                                string[] r = { "circle", results[1], results[2] };
                                radiusvariable(r);

                            }
                            else if (results[0] == "width" && results[1] == "=")
                            {
                                width = Convert.ToInt32(result[2]);
                            }
                            else if (results[0] == "height" && results[1] == "=")
                            {
                                height = Convert.ToInt32(results[2]);
                            }
                            else if (results[0] == "radius" && results[1] == "+")
                            {
                                string[] r = { "circle", results[1], results[2] };
                                radiusadd(r);
                            }
                            else if (results[0] == "width" && results[1] == "+")
                            {
                                width = Convert.ToInt32(results[2]);
                            }
                            else if (results[0] == "height" && results[1] == "+")
                            {
                                height = Convert.ToInt32(results[2]);
                            }

                            counter = counter + 1;
                            temp = temp + 1;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("end command missing");
                    d = 1;
                }
            


            }
            catch (NullReferenceException e)
            {
                MessageBox.Show(e.Message);
            }
        }


        private void ifcase(string[] result)
        {
            d = 1;
            int b = Ending();
            if (b == 7)
            {
                string[] line;
                line = MultipleCommand.Lines;
                CodeVallidation val = new CodeVallidation();
                var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                int length = textArr.Length;


                int counter = 0;
                for (int s = 1; s < length - 1; s++)
                {
                    string[] arrayOrder = Regex.Split(line[counter], "\r\n");//splits the data at next line and stores themin array
                    String[] results = val.valid(arrayOrder[0]);
                    if (results[0] == "endif")
                    {
                        MessageBox.Show("dolll");


                    }
                    else
                    {

                        if (results[1] == "radius")
                        {
                            symbolcheck(results, line, counter);
                        }
                        counter = counter + 1;
                    }

                }
            }
            else
            {
                d = 1;
                MessageBox.Show("endif missing");
            }

        }
        private void symbolcheck(string[] results, string[] line, int counter)
        {
            CodeVallidation val = new CodeVallidation();
            MessageBox.Show(results[2]);
            if (results[2] == "=")
            {
                MessageBox.Show("===");
                MessageBox.Show(radius + "");
                if (results[1] == "radius")
                {
                    if (Convert.ToInt32(results[3]) == radius)
                    {
                        MessageBox.Show("Radius equal");
                        string[] arrayOrders = Regex.Split(line[counter + 1], "\r\n");//splits the data at next line and stores themin array
                        MessageBox.Show(arrayOrders[0]);
                        String[] result = val.valid(arrayOrders[0]);
                        if (result[0] == "circle")
                        {
                            MessageBox.Show("asd");
                            string[] value = { "circle", result[1] };
                            MessageBox.Show("ssssdd");
                            circle(value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("not equal");
                        d = 1;
                    }
                }
            }
            else if (results[2] == ">")
            {
                MessageBox.Show("greater");
                if (results[1] == "radius")
                {
                    if (radius > Convert.ToInt32(results[3]))
                    {
                        MessageBox.Show("assd");
                        string[] arrayOrders = Regex.Split(line[counter + 1], "\r\n");//splits the data at next line and stores themin array
                        String[] result = val.valid(arrayOrders[0]);
                        MessageBox.Show(result[1] + "asssss");
                        MessageBox.Show(result[0]);
                        if (result[0] == "circle")
                        {
                            MessageBox.Show("asd");
                            string[] value = { "circle", result[1] };
                            circle(value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("radius is lesser");
                        d = 1;
                    }
                }

            }

            else if (results[2] == "<")
            {
                if (results[1] == "radius")
                {
                    if (radius < Convert.ToInt32(results[3]))
                    {
                        string[] arrayOrders = Regex.Split(line[counter + 1], "\r\n");//splits the data at next line and stores themin array
                        MessageBox.Show(arrayOrders[0]);
                        String[] r = val.valid(arrayOrders[0]);
                        r = val.valid(arrayOrders[0]);
                        MessageBox.Show(r[1]);
                        if (r[0] == "circle")
                        {
                            string[] value = { "circle", r[1] };
                            circle(value);
                        }
                    }
                    else
                    {
                        MessageBox.Show("radius greater");
                        d = 1;
                    }
                }
            }
        }

        private void definmethod(string[] result)
        {
            d = 1;
            int b = Ending();
            if (b == 6)
            {
                string[] line;
                line = MultipleCommand.Lines;
                CodeVallidation val = new CodeVallidation();
                var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
                int length = textArr.Length;
                int counter = 0;
                int temp = linenumber();
                MessageBox.Show(temp + "");
                for (int t = 1; t < length - 1; t++)
                {
                    string[] arrayOrder = Regex.Split(line[temp], "\r\n");//splits the data at next line and stores themin array
                    String[] results = val.valid(arrayOrder[0]);
                    if (results[0] == "circle" || results[0] == "rectangle")
                    {
                        string[] arrayOrders = Regex.Split(line[temp], "\r\n");//splits the data at next line and stores themin array
                        results = val.valid(arrayOrder[0]);
                        if (results[0] == "rectangle" && result[0] == "rectangle")
                        {
                            string[] arra = { "rectangle", result[1], result[2] };
                            rectangle(arra);
                        }
                        else if (results[0] == "circle" && result[0] == "circle")
                        {
                            string[] arra = { "circle", result[1] };
                            circle(arra);
                            MessageBox.Show("circle build");
                        }
                    }
                    counter = counter + 1;
                }
            }
            else
            {
                d = 1;
                MessageBox.Show("endmethod missing");
            }

        }

        private void myRectangle(string[] result)
        {
            d = 1;
            string[] a;
            string[] line;
            line = MultipleCommand.Lines;
            CodeVallidation val = new CodeVallidation();
            var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int length = textArr.Length;
            int counter = 0;
            for (int t = 1; t <= length; t++)
            {
                string[] arrayOrders = Regex.Split(line[counter], "\r\n");//splits the data at next line and stores themin array                                                                 //MessageBox.Show(arrayOrder[0]);
                String[] res = val.valid(arrayOrders[0]);
                if (res[0] == "myrectangle")
                {
                    string[] arra = Regex.Split(line[counter + 1], "\r\n");//splits the data at next line and stores themin array
                    a = val.valid(arra[0]);
                    if (a[1] == "myrectangle")
                    {
                        string[] re = { "rectangle", res[1], res[2] };
                        definmethod(re);
                    }
                    else
                    {
                        MessageBox.Show("Method doesnot match"); ;
                    }
                }
                counter = counter + 1;
            }
        }
        //
        private void myCircle(string[] result)
        {
            d = 1;
            string[] a;
            string[] line;
            line = MultipleCommand.Lines;
            CodeVallidation val = new CodeVallidation();
            var textArr = textOrder.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);
            int length = textArr.Length;
            int counter = 0;
            for (int t = 1; t <= length - 1; t++)
            {
                string[] arrayOrders = Regex.Split(line[counter], "\r\n");//splits the data at next line and stores themin array                                                                 //MessageBox.Show(arrayOrder[0]);
                String[] res = val.valid(arrayOrders[0]);
                if (res[0] == "mycircle")
                {
                    string[] arra = Regex.Split(line[counter + 1], "\r\n");//splits the data at next line and stores themin array
                    a = val.valid(arra[0]);
                    if (a[1] == "mycircle")
                    {
                        string[] re = { "circle", res[1] };
                        definmethod(re);
                    }
                    else
                    {
                        MessageBox.Show("Method doesnot match"); ;
                    }
                }
                counter = counter + 1;
            }
        }
    }
}
