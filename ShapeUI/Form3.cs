using ShapeApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace ShapeUI
{
    public partial class Form3 : Form
    {
        public static GraphicTool pictures;
        public List<Shape> Shapes;
        public Picture _picture;
        public static int idP = 0;
        public Form3()
        {
            InitializeComponent();
            pictures= new GraphicTool();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1.tool.DrawAll(panel1);
        }

        private void button22_Click(object sender, EventArgs e)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Shapes = new List<Shape>();
            _picture = new Picture();
            idP++;
            _picture.Name = "Picture" + idP.ToString();

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(_picture == null)
            {
                MessageBox.Show("CREATE A PICTURE!");
                return;
            }
            if (!string.IsNullOrEmpty(textBox1.Text))
            {
                foreach (var shape in Form1.tool.Shapes)
                {
                    if (shape.Name == textBox1.Text)
                    {
                        _picture.AddChild(shape);
                        Shapes.Add(shape);
                        break; 
                    }
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form1.tool.Add(ShapeType.Picture, new Dictionary<string, object>()
            {
                { "name", _picture.Name },
                { "children", Shapes}
            });
            pictures.Add(ShapeType.Picture, new Dictionary<string, object>()
            {
                { "name", _picture.Name },
                { "children", Shapes}
            });
            _picture = null; 
        }

        private void button23_Click(object sender, EventArgs e)
        {
            pictures.DrawAll(panel1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox2.Text))
            {
                foreach (var shape in Form1.tool.Shapes)
                {
                    if (shape.Name == textBox2.Text)
                    {
                        shape.Draw(panel1);
                        break;
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {

           Point2d _point = new Point2d { X = Convert.ToInt32(textBox4.Text), Y = Convert.ToInt32(textBox5.Text) };

            if (!string.IsNullOrEmpty(textBox3.Text))
            {
                foreach (var shape in Form1.tool.Shapes)
                {
                    if (shape.Name == textBox3.Text)
                    {
                        shape.MoveTo(_point); 
                        panel1.Refresh();
                        break;

                    }
                }
            }

           
           
        }

        private void button8_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(textBox8.Text))
            {
                foreach (var shape in Form1.tool.Shapes)
                {
                    if (shape.Name == textBox8.Text)
                    {
                       
                        shape.Resize(Convert.ToDouble(textBox7.Text));
                        panel1.Refresh();
                        break;

                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(textBox6.Text))
            {
                foreach (var shape in Form1.tool.Shapes)
                {
                    if (shape.Name == textBox6.Text)
                    {

                        richTextBox1.Text = shape.Area().ToString();
                        break;

                    }
                }
            }
        }
    }
}
