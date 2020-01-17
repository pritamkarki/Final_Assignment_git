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
                string textOrder = MultipleCommand.Text.Trim();

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



            // Shapes
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

            
        }

        private void radiusadd(string[] result)
        {

            radius = radius + Convert.ToInt32(result[2]);
            MessageBox.Show(radius + "");


        }
        private void heightvariable(string[] result)
        {
            height = Convert.ToInt32(result[2]);
        }
        private void heightadd(string[] result)
        {
            height = Convert.ToInt32(result[2]);
        }

     

        private void widthvariable(string[] result)
        {
            width = Convert.ToInt32(result[2]);
        }
        private void widthadd(string[] result)
        {
            width = Convert.ToInt32(result[2]);
        }
        private void radiusvariable(string[] result)
        {
            radius = Convert.ToInt32(result[2]);
            MessageBox.Show(radius + "");
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




    }
}
