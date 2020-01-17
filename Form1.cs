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
        int x_axis = 0, y_axis = 0;
        Graphics graph;

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
                    Shape sh = s1.getShape(result[0]);
                    sh.DrawShape(result, graph, x_axis, y_axis);
                }
                if (result[0] == "triangle")
                {
                    ShapeFactory t1 = new ShapeFactory();
                    Shape sh = t1.getShape(result[0]);
                    sh.DrawShape(result, graph, x_axis, y_axis);
                }
                if (result[0] == "circle")
                {
                    ShapeFactory c1 = new ShapeFactory();
                    Shape sh = c1.getShape(result[0]);
                    sh.DrawShape(result, graph, x_axis, y_axis);
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

                    try
                    {
                        if (result[0] == "loop")
                        {
                            int a = Convert.ToInt32(result[1]);
                            for (int j = 0; j <= Convert.ToInt32(result[1]); j++)
                            {
                                MessageBox.Show("aaaaaaa1");
                                if (result[0] == "moveTo")
                                {
                                    MessageBox.Show("aaaaaaa");
                                }
                            }
                        }
                        if (result[0] == "moveTo")
                        {
                            int x_axis1 = Convert.ToInt32(result[1]);
                            int y_axis1 = Convert.ToInt32(result[2]);
                            x_axis = x_axis1;
                            y_axis = y_axis1;
                        }
                        else if (result[0] == "rectangle")
                        {
                            ShapeFactory s1 = new ShapeFactory();
                            Shape sh = s1.getShape(result[0]);
                            sh.DrawShape(result, graph, x_axis, y_axis);
                        }
                        else if (result[0] == "triangle")
                        {
                            ShapeFactory t1 = new ShapeFactory();
                            Shape sh = t1.getShape(result[0]);
                            sh.DrawShape(result, graph, x_axis, y_axis);
                        }
                        else if (result[0] == "circle")
                        {
                            ShapeFactory c1 = new ShapeFactory();
                            Shape sh = c1.getShape(result[0]);
                            sh.DrawShape(result, graph, x_axis, y_axis);
                        }
                    }
                    catch (IndexOutOfRangeException)
                    {
                        //MessageBox.Show("Invalid Command");
                    }
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
    }
}
