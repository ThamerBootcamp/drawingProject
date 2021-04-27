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
        public bool isActive;
        public Pen pen;
        public abstract void drow(Graphics g);
    }
    public class Line : Shape
    {
        public override void drow(Graphics g)
        {
            g.DrawLine(this.pen,
                            this.start.X,
                            this.start.Y,
                            this.end.X,
                            this.end.Y);
        }
    }
    public class Circle : Shape
    {
        public override void drow(Graphics g)
        {
           
            g.DrawEllipse(this.pen,
                            this.start.X,
                            this.start.Y,
                            Math.Abs(this.end.X- this.start.X),
                            Math.Abs(this.end.Y- this.start.Y));
        }
    }
    public class Rectangle : Shape
    {
        public override void drow(Graphics g)
        {
            g.DrawRectangle(this.pen,
                                      this.start.X,
                                      this.start.Y,
                                      Math.Abs(this.end.X - this.start.X),
                                      Math.Abs(this.end.Y - this.start.Y));
        }
    }

    public partial class Form1 : Form
    {

        private List<Shape> shapes;
        /// pen settings
        private float penSize = 4;
        private Brush penColor = Brushes.Black;
        private DashStyle penStyle = System.Drawing.Drawing2D.DashStyle.Solid;
        //private Pen p = new Pen(Brushes.Black, 4);

        private string selectedShape = "Line";

        private bool isPointerMode = false;

        private Shape currentShape = null;


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
                currentShape.start = new Point(e.X, e.Y);
            }
           
      
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            if (!isPointerMode)
            {
                currentShape.end = new Point(e.X, e.Y);
                this.shapes.Add(currentShape);
                this.Invalidate();
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
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
                shape.drow(g);
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
