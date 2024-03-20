using ShapeApplication;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ShapeUI
{
    public partial class Form1 : Form
    {
        public static GraphicTool tool;
        public Circle myCircle;
        public Square mySquare;
        public ShapeApplication.Rectangle myRectangle;
        public Triangle myTriangle;
        public Line myLine;
        public static int idC=0, idS=0, idT=0, idR=0, idL=0;

        public Form1()
        {
            InitializeComponent();
            tool = new GraphicTool();
            
               
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tool.DrawAll(panel1);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            idC++;
            myCircle = new Circle();
            myCircle.Name = "Circle"+idC.ToString();
            myCircle.Origin = new Point2d { X = Convert.ToInt32(textBox_xcircle.Text), Y = Convert.ToInt32(textBox_ycircle.Text) };
            myCircle.Radius = Convert.ToDouble(textBox_radius.Text);
            
            tool.Add(ShapeType.Circle, new Dictionary<string, object>()
            {
                { "radius", Convert.ToDouble(textBox_radius.Text) },
                { "origin", new Point2d { X = Convert.ToInt32(textBox_xcircle.Text), Y = Convert.ToInt32(textBox_ycircle.Text)} }
            });
            textBox_radius.Text = "";
            textBox_xcircle.Text = "";
            textBox_ycircle.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            myCircle.Draw(panel1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    

        }

        private void button4_Click(object sender, EventArgs e)
        {
            mySquare.Draw(panel1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            idS++;
            mySquare = new Square();
            mySquare.Name = "Square" + idS.ToString();
            mySquare.Origin = new Point2d { X = Convert.ToInt32(textBox_xsquare.Text), Y = Convert.ToInt32(textBox_ysquare.Text) };
            mySquare.Length = Convert.ToDouble(textBox_Length.Text);

            tool.Add(ShapeType.Square, new Dictionary<string, object>()
            {
                { "length", Convert.ToDouble(textBox_Length.Text) },
                { "origin", new Point2d { X = Convert.ToInt32(textBox_xsquare.Text), Y = Convert.ToInt32(textBox_ysquare.Text)} }
            }) ;
            textBox_xsquare.Text = "";
            textBox_ysquare.Text = "";
            textBox_Length.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = myCircle.Area().ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            myCircle.Resize(Convert.ToDouble(textBox_NewRadius.Text));
            textBox_NewRadius.Text = "";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Point2d _point = new Point2d();
            _point = new Point2d { X = Convert.ToInt32(textBox_newx.Text), Y = Convert.ToInt32(textBox_newy.Text) };
            myCircle.MoveTo(_point);
            textBox_newx.Text = "";
            textBox_newy.Text = "";
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            richTextBox1.Text = mySquare.Area().ToString(); 
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            mySquare.Resize(Convert.ToDouble(textBox_newlength.Text));
            textBox_newlength.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Point2d _point = new Point2d();
            _point = new Point2d { X = Convert.ToInt32(textBox_newxs.Text), Y = Convert.ToInt32(textBox_newys.Text) };
            mySquare.MoveTo(_point);
            textBox_newxs.Text = "";
            textBox_newys.Text = "";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            idR++;
            myRectangle = new ShapeApplication.Rectangle();
            myRectangle.Name = "Rectangle" + idR.ToString();

            myRectangle.Origin = new Point2d { X = Convert.ToInt32(textBox_xRect.Text), Y = Convert.ToInt32(textBox_yRect.Text) };
            myRectangle.point = new Point2d { X = Convert.ToInt32(textBox_xpoint.Text), Y = Convert.ToInt32(textBox_ypoint.Text) };
            tool.Add(ShapeType.Rectangle, new Dictionary<string, object>()
            {
                { "point", new Point2d { X = Convert.ToInt32(textBox_xpoint.Text), Y = Convert.ToInt32(textBox_ypoint.Text)} },
                { "origin", new Point2d { X = Convert.ToInt32(textBox_xRect.Text), Y = Convert.ToInt32(textBox_yRect.Text)} }
            });

            textBox_xRect.Text = "";
            textBox_yRect.Text = "";
            textBox_xpoint.Text = "";
            textBox_ypoint.Text = "";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            myRectangle.Draw(panel1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = myRectangle.Area().ToString();
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            myRectangle.Resize(Convert.ToDouble(textBox_rv.Text));
            textBox_rv.Text = "";

        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            Point2d _point = new Point2d();
            _point = new Point2d { X = Convert.ToInt32(textBox_newxp.Text), Y = Convert.ToInt32(textBox_newyp.Text) };
            myRectangle.MoveTo(_point);
            textBox_newxp.Text = "";
            textBox_newyp.Text = "";
        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            idR++;
            myTriangle = new Triangle();
            myTriangle.Name = "Triangle"+idR.ToString();    
            myTriangle.Origin = new Point2d { X = Convert.ToInt32(textBox_Xtriangle.Text), Y = Convert.ToInt32(textBox_Ytriangle.Text) };
            myTriangle.point1 = new Point2d { X = Convert.ToInt32(textBox_xtpoint1.Text), Y = Convert.ToInt32(textBox_ytpoint1.Text) };
            myTriangle.point2 = new Point2d { X = Convert.ToInt32(textBox_xtpoint2.Text), Y = Convert.ToInt32(textBox_ytpoint2.Text) };

            //GraphicTool tool = new GraphicTool();
            tool.Add(ShapeType.Triangle, new Dictionary<string, object>()
            {
                { "point1", new Point2d { X = Convert.ToInt32(textBox_xtpoint1.Text), Y = Convert.ToInt32(textBox_ytpoint1.Text)} },
                { "point2", new Point2d { X = Convert.ToInt32(textBox_xtpoint2.Text), Y = Convert.ToInt32(textBox_ytpoint2.Text)} },           
                { "origin", new Point2d { X = Convert.ToInt32(textBox_Xtriangle.Text), Y = Convert.ToInt32(textBox_Ytriangle.Text)} }
            });
            textBox_Xtriangle.Text = "";
            textBox_Ytriangle.Text = "";
            textBox_xtpoint1.Text = "";
            textBox_xtpoint2.Text = "";
            textBox_ytpoint1.Text = "";
            textBox_ytpoint2.Text = "";
        }

        private void button15_Click(object sender, EventArgs e)
        {
            myTriangle.Draw(panel1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = myTriangle.Area().ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            myTriangle.Resize(Convert.ToDouble(textBox_rt.Text));
            textBox_rt.Text = "";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Point2d _point = new Point2d();
            _point = new Point2d { X = Convert.ToInt32(textBox_newxt.Text), Y = Convert.ToInt32(textBox_newyt.Text) };
            myTriangle.MoveTo(_point);
            textBox_newxt.Text = "";
            textBox_newyt.Text = "";
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button21_Click(object sender, EventArgs e)
        {
            idL++;
            myLine = new Line();
            myLine.Name = "Line"+idL.ToString();
            myLine.Origin = new Point2d { X = Convert.ToInt32(textBox_xline.Text), Y = Convert.ToInt32(textBox_yline.Text) };
            myLine.EndPoint = new Point2d { X = Convert.ToInt32(textBox_xlpoint.Text), Y = Convert.ToInt32(textBox_ylpoint.Text) };
            //GraphicTool tool = new GraphicTool();
            tool.Add(ShapeType.Line, new Dictionary<string, object>()
            {
                { "EndPoint", new Point2d { X = Convert.ToInt32(textBox_xlpoint.Text), Y = Convert.ToInt32(textBox_ylpoint.Text)} },
                { "origin", new Point2d { X = Convert.ToInt32(textBox_xline.Text), Y = Convert.ToInt32(textBox_yline.Text)} }
            });
            textBox_xline.Text = "";
            textBox_yline.Text = "";
            textBox_xlpoint.Text = "";
            textBox_ylpoint.Text = "";
        }

        private void button20_Click(object sender, EventArgs e)
        {
            myLine.Draw(panel1);
        }

        private void button19_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = myLine.Area().ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            myLine.Resize(Convert.ToDouble(textBox_rl.Text));
            textBox_rl.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Point2d _point = new Point2d();
            _point = new Point2d { X = Convert.ToInt32(textBox_newxl.Text), Y = Convert.ToInt32(textBox_newyl.Text) };
            myLine.MoveTo(_point);
            textBox_newxl.Text = "";
            textBox_newyl.Text = "";
        }

        private void button22_Click(object sender, EventArgs e)
        {
            using (Graphics g = panel1.CreateGraphics())
            {
                g.Clear(Color.White);
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {


            Bitmap bmp = new Bitmap(panel1.Width, panel1.Height);

            
            using (Graphics g = Graphics.FromImage(bmp))
            {
                
                g.CopyFromScreen(panel1.PointToScreen(Point.Empty), Point.Empty, panel1.Size);
            }
            string folderPath = @"E:\C#\ShapeApplication";
                string fileName = "PanelImage.Png";
                string filePath = System.IO.Path.Combine(folderPath, fileName);
                bmp.Save(filePath, System.Drawing.Imaging.ImageFormat.Png);
                bmp.Dispose();
            

        }

        private void button24_Click(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            frm.Show();
            this.Hide();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Form3 frm = new Form3();
            frm.Show();
            this.Hide();
        }
    }
}
