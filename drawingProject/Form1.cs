using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace drawingProject
{
    public abstract class Shape {
        public Point start;
        public Point end;
        public int width;
        public int height;

        public bool isActive;
        public Pen pen;
        public abstract void draw(Graphics g, bool active =false);
        public bool IsInside(Point p)
        {
            int width = Math.Abs(this.end.X - this.start.X);
            int height = Math.Abs(this.end.Y - this.start.Y);
            return (p.X >= start.X &&
                p.X <= (start.X + width) &&
                p.Y >= start.Y &&
                p.Y <= (start.Y + height));
        }

    }
    public class Line : Shape
    {
        public override void draw(Graphics g, bool isActive =false)
        {
            int width = Math.Abs(this.end.X - this.start.X);
            int height = Math.Abs(this.end.Y - this.start.Y);

            g.DrawLine(this.pen,
                            this.start.X,
                            this.start.Y,
                            this.end.X,
                            this.end.Y);
            if (isActive)
            {
                Pen p = new Pen(Brushes.Gray, 2);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(p, start.X-10, start.Y-10, width + 20, height+20);
            }
        }
    }
    public class Circle : Shape
    {
        public override void draw(Graphics g, bool isActive = false)
        {
           int width = Math.Abs(this.end.X - this.start.X);
            int height = Math.Abs(this.end.Y - this.start.Y);

           /* if (end.X > start.X)
            {
                if (end.Y > start.Y)
                {

                     g.DrawEllipse(this.pen,
                                    this.start.X,
                                    this.start.Y,
                                    width,
                                    height);
                }
                else
                {
                    g.DrawEllipse(this.pen,
                                    this.start.X,
                                    this.end.Y,
                                    Math.Abs(this.end.X - this.start.X),
                                    Math.Abs(this.end.Y - this.start.Y));
                }
            }
            else
            {
                if (end.Y > start.Y)
                {
                    g.DrawEllipse(this.pen,
                                   this.end.X,
                                   this.start.Y,
                                   width,
                                   height);
                }
                else
                {
                    g.DrawEllipse(this.pen,
                                    this.end.X,
                                    this.end.Y,
                                    Math.Abs(this.end.X - this.start.X),
                                    Math.Abs(this.end.Y - this.start.Y));
                }
            }*/
            g.DrawEllipse(this.pen,
               this.start.X,
               this.start.Y,
               width,
               height);

            if (isActive)
            {
                Pen p = new Pen(Brushes.Gray, 2);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(p, start.X - 10, start.Y - 10, width + 20, height + 20);
            }
        }
    }
    public class Rectangle : Shape
    {
        public override void draw(Graphics g, bool isActive = false)
        {
            int width = Math.Abs(this.end.X - this.start.X);
            int height = Math.Abs(this.end.Y - this.start.Y);
            g.DrawRectangle(this.pen,
                                      this.start.X,
                                      this.start.Y,
                                      Math.Abs(this.end.X - this.start.X),
                                      Math.Abs(this.end.Y - this.start.Y));
            if (isActive)
            {
                Pen p = new Pen(Brushes.Gray, 2);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
                g.DrawRectangle(p, start.X - 10, start.Y - 10, width + 20, height + 20);
            }
        }
    }

    public partial class Form1 : Form
    {

        private List<Shape> shapes;
        /// pen settings
        private float penSize = 4;
        private static Color penColor = System.Drawing.Color.Black;
        private DashStyle penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        //private Pen p = new Pen(Brushes.Black, 4);

        private string selectedShape = "Line";

        private bool isPointerMode = false;

        private Shape currentShape = null;

        private Shape activeShape = null;

        public Form1()
        {
            InitializeComponent();
            this.shapes = new List<Shape>();

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (!isPointerMode)
            {
                if(selectedShape == "Rectangle")
                {
                    currentShape = new Rectangle();
                }
                else if (selectedShape == "Circle" )
                {
                    currentShape = new Circle();
                }
                else
                {
                    currentShape = new Line();
                }
           
                currentShape.pen = new Pen(penColor, penSize);
                currentShape.pen.DashStyle = penStyle;
                currentShape.start = e.Location;
                this.Invalidate();
            }
           
      
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isPointerMode)
            {
                currentShape.end = e.Location;
           //     currentShape.width = Math.Abs(currentShape.end.X - currentShape.start.X);
           //     currentShape.height = Math.Abs(currentShape.end.Y - currentShape.start.Y);

               /* if (currentShape.end.X> currentShape.start.X)
                {
                    if (currentShape.end.Y < currentShape.start.Y)
                    {
                        int temp = currentShape.start.Y;
                        currentShape.start.Y = currentShape.end.Y;
                        currentShape.end.Y = temp + currentShape.height;
                    }
                }
                else
                {
                    if (currentShape.end.Y > currentShape.start.Y)
                    {
                        currentShape.start.X = currentShape.end.X;
                    }
                    else
                    {
                        currentShape.start.X = currentShape.end.X;
                        currentShape.start.Y = currentShape.end.Y;
                    }
                }*/
                this.shapes.Add(currentShape);
                this.Invalidate();
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPointerMode)
            {
                foreach (var shape in shapes)
                {
                    if (shape.IsInside(e.Location))
                    {
                        activeShape = shape;
                        break;
                        //shape.pen.Brush= Brushes.Red;
                    }
                    else
                    {
                        activeShape = null;
                    }
                }
                
            }
            this.Invalidate();
            /*if (!this.isClicked)
            {
                this.currentLine = new Line();
                currentLine.start = new Point(e.X, e.Y);
            }
            else
            {
                currentLine.end = new Point(e.X, e.Y);
                this.lines.Add(currentLine);
                this.Invalidate();
            }
            this.isClicked = !isClicked;*/
        }

        private void Form1_Click(object sender, EventArgs e)
        {

        }


        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void toolStrip1_ItemClicked_1(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dashed_Click(object sender, EventArgs e)
        {
            this.penStyle = System.Drawing.Drawing2D.DashStyle.DashDot;

        }

        private void Dotted_Click(object sender, EventArgs e)
        {
            this.penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        }

        private void Color_Click(object sender, EventArgs e)
        {
            if(colorDialog1.ShowDialog()== DialogResult.OK)
            {
                penColor = colorDialog1.Color;
            }
        }

        private void Circle_Click(object sender, EventArgs e)
        {
            isPointerMode = false;

            selectedShape = "Circle";

        }

        private void Rectangle_Click(object sender, EventArgs e)
        {
            isPointerMode = false;
            selectedShape = "Rectangle";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            foreach (var shape in this.shapes)
            {
                if (isPointerMode && shape.Equals(activeShape)){
                    shape.draw(g,true);
                }
                else
                {
                    shape.draw(g);
                }
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pointer_Click(object sender, EventArgs e)
        {
            isPointerMode = true;

        }

        private void Line_Click(object sender, EventArgs e)
        {
            isPointerMode = false;
            selectedShape = "Line";

        }
    }
}
