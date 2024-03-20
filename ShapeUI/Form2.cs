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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

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

        private void button1_Click(object sender, EventArgs e)
        {
            var radiusToFind = Convert.ToDouble(textBox_radius.Text);
            var originToFind = new Point2d { X = Convert.ToInt32(textBox_xcircle.Text), Y = Convert.ToInt32(textBox_ycircle.Text) };

            var foundCircle = Form1.tool.Shapes.Find(shape => shape is Circle &&
                                                         ((Circle)shape).Radius == radiusToFind &&
                                                         ((Circle)shape).Origin.X == originToFind.X &&
                                                         ((Circle)shape).Origin.Y == originToFind.Y);

            if (foundCircle != null)
            {
                Form1.tool.Remove(foundCircle);
                MessageBox.Show("Circle deleted!");
                textBox_radius.Text = "";
                textBox_xcircle.Text = "";
                textBox_ycircle.Text = "";
            }
            else
            {
                MessageBox.Show("This Circle is not on the list");
            }



        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form1 frm = new Form1();
            frm.ShowDialog();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var lengthToFind = Convert.ToDouble(textBox_Length.Text);
            var originToFind = new Point2d { X = Convert.ToInt32(textBox_xsquare.Text), Y = Convert.ToInt32(textBox_ysquare.Text) };

            var foundSquare = Form1.tool.Shapes.Find(shape => shape is Square &&
                                                         ((Square)shape).Length == lengthToFind &&
                                                         ((Square)shape).Origin.X == originToFind.X &&
                                                         ((Square)shape).Origin.Y == originToFind.Y);

            if (foundSquare != null)
            {
                Form1.tool.Remove(foundSquare);
                MessageBox.Show("Square deleted!");
                textBox_Length.Text = "";
                textBox_xsquare.Text = "";
                textBox_ysquare.Text = "";
            }
            else
            {
                MessageBox.Show("This Square is not on the list");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var pointToFind =  new Point2d { X = Convert.ToInt32(textBox_xr.Text), Y = Convert.ToInt32(textBox_yr.Text) };
            var originToFind = new Point2d { X = Convert.ToInt32(textBox_xRect.Text), Y = Convert.ToInt32(textBox_yRect.Text) };

            var foundRectangle = Form1.tool.Shapes.Find(shape => shape is ShapeApplication.Rectangle &&
                                                         ((ShapeApplication.Rectangle)shape).point.X == pointToFind.X &&
                                                          ((ShapeApplication.Rectangle)shape).point.Y == pointToFind.Y &&
                                                         ((ShapeApplication.Rectangle)shape).Origin.X == originToFind.X &&
                                                         ((ShapeApplication.Rectangle)shape).Origin.Y == originToFind.Y);

            if (foundRectangle != null)
            {
                Form1.tool.Remove(foundRectangle);
                MessageBox.Show("Rectangle deleted!");
                textBox_xr.Text = "";
                textBox_yr.Text = "";
                textBox_xRect.Text = "";
                textBox_yRect.Text = "";
            }
            else
            {
                MessageBox.Show("This Rectangle is not on the list");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var point1ToFind = new Point2d { X = Convert.ToInt32(textBox_xt1.Text), Y = Convert.ToInt32(textBox_yt1.Text) };
            var point2ToFind = new Point2d { X = Convert.ToInt32(textBox_xt2.Text), Y = Convert.ToInt32(textBox_yt2.Text) };
            var originToFind = new Point2d { X = Convert.ToInt32(textBox_xot.Text), Y = Convert.ToInt32(textBox_yot.Text) };

            var foundTriangle = Form1.tool.Shapes.Find(shape => shape is Triangle &&
                                                         ((Triangle)shape).point1.X == point1ToFind.X &&
                                                          ((Triangle)shape).point1.Y == point1ToFind.Y &&
                                                          ((Triangle)shape).point2.X == point2ToFind.X &&
                                                          ((Triangle)shape).point2.Y == point2ToFind.Y &&
                                                         ((Triangle)shape).Origin.X == originToFind.X &&
                                                         ((Triangle)shape).Origin.Y == originToFind.Y);

            if (foundTriangle != null)
            {
                Form1.tool.Remove(foundTriangle);
                MessageBox.Show("Triangle deleted!");
                textBox_xt1.Text = "";
                textBox_yt1.Text = "";
                textBox_xt2.Text = "";
                textBox_yt2.Text = "";
                textBox_xot.Text = "";
                textBox_yot.Text = "";
            }
            else
            {
                MessageBox.Show("This Triangle is not on the list");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var pointToFind = new Point2d { X = Convert.ToInt32(textBox_xlpoint.Text), Y = Convert.ToInt32(textBox_ylpoint.Text) };
            var originToFind = new Point2d { X = Convert.ToInt32(textBox_xline.Text), Y = Convert.ToInt32(textBox_yline.Text) };

            var foundLine = Form1.tool.Shapes.Find(shape => shape is Line &&
                                                         ((Line)shape).EndPoint.X == pointToFind.X &&
                                                          ((Line)shape).EndPoint.Y == pointToFind.Y &&
                                                         ((Line)shape).Origin.X == originToFind.X &&
                                                         ((Line)shape).Origin.Y == originToFind.Y);

            if (foundLine != null)
            {
                Form1.tool.Remove(foundLine);
                MessageBox.Show("Line deleted!");
                textBox_xlpoint.Text = "";
                textBox_ylpoint.Text = "";
                textBox_xline.Text = "";
                textBox_yline.Text = "";
            }
            else
            {
                MessageBox.Show("This Line is not on the list");
            }
        }
    }
}
