
namespace drawingProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dashed = new System.Windows.Forms.Button();
            this.Color = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.Dotted = new System.Windows.Forms.Button();
            this.pointer = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.dashed, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Color, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.Line, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.Circle, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.Rectangle, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.Dotted, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.pointer, 0, 6);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15.15152F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.09091F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(202, 592);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dashed
            // 
            this.dashed.Location = new System.Drawing.Point(3, 92);
            this.dashed.Name = "dashed";
            this.dashed.Size = new System.Drawing.Size(132, 69);
            this.dashed.TabIndex = 1;
            this.dashed.Text = "dashed";
            this.dashed.UseVisualStyleBackColor = true;
            this.dashed.Click += new System.EventHandler(this.dashed_Click);
            // 
            // Color
            // 
            this.Color.Location = new System.Drawing.Point(3, 181);
            this.Color.Name = "Color";
            this.Color.Size = new System.Drawing.Size(132, 69);
            this.Color.TabIndex = 2;
            this.Color.Text = "Color";
            this.Color.UseVisualStyleBackColor = true;
            this.Color.Click += new System.EventHandler(this.Color_Click);
            // 
            // Line
            // 
            this.Line.Location = new System.Drawing.Point(3, 270);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(132, 69);
            this.Line.TabIndex = 3;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = true;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Circle
            // 
            this.Circle.Location = new System.Drawing.Point(3, 359);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(132, 69);
            this.Circle.TabIndex = 4;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = true;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.Location = new System.Drawing.Point(3, 448);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(132, 69);
            this.Rectangle.TabIndex = 5;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = true;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // Dotted
            // 
            this.Dotted.Location = new System.Drawing.Point(3, 3);
            this.Dotted.Name = "Dotted";
            this.Dotted.Size = new System.Drawing.Size(132, 69);
            this.Dotted.TabIndex = 0;
            this.Dotted.Text = "dotted";
            this.Dotted.UseVisualStyleBackColor = true;
            this.Dotted.Click += new System.EventHandler(this.Dotted_Click);
            // 
            // pointer
            // 
            this.pointer.Location = new System.Drawing.Point(3, 537);
            this.pointer.Name = "pointer";
            this.pointer.Size = new System.Drawing.Size(150, 46);
            this.pointer.TabIndex = 6;
            this.pointer.Text = "pointer";
            this.pointer.UseVisualStyleBackColor = true;
            this.pointer.Click += new System.EventHandler(this.pointer_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 32F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 592);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Click += new System.EventHandler(this.Form1_Click);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button dashed;
        private System.Windows.Forms.Button Color;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.Button Dotted;
        private System.Windows.Forms.Button pointer;
    }
}

