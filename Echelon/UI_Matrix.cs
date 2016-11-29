using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echelon
{
    public partial class UI_Matrix : UserControl
    {
        public Matrix Matrix;
        public UI_RNumber multiple;
        public UI_Matrix(Matrix matrix)
        {
            this.Matrix = matrix;
            this.multiple = new UI_RNumber(this.Matrix.Multiple);
            InitializeComponent();
            this.Controls.Add(multiple);
            Refresh();
        }
        public void SetSizeAndLocations()
        {
            //Multiple
            int Start = 0;
            if(!(this.Matrix.Multiple.Numerator == 1 && this.Matrix.Multiple.Denominator == 1))
            {
                this.multiple.Visible = true;
                RNumber xx = this.multiple.RNumber;
                this.multiple.Size = new Size(new Point(this.Size.Width/6, this.Size.Width / 6));
                this.multiple.Location = new Point(0, (this.Size.Height - this.multiple.Size.Height) / 2);
                Start = this.multiple.Size.Width;
            }
            else
            {
                this.multiple.Visible = false;
            }
            int cWidth = this.Size.Width - Start;
            int Padding = 4;
            //Sizes
            this.BorderBottomLeft.Size = this.BorderTopLeft.Size = this.BorderTopRight.Size = this.BorderBottomRight.Size = new Size(new Point(cWidth / 5, Padding));
            this.BorderLeft.Size = this.BorderRight.Size = new Size(new Point(Padding,this.Height));
            this.MainPanel.Size = new Size(new Point(cWidth - Padding * 2,this.Size.Height - Padding * 2));
            //Locations
            this.BorderLeft.Location = this.BorderTopLeft.Location = new Point(Start, 0);
            this.BorderBottomLeft.Location = new Point(Start, this.Height - Padding);
            this.BorderRight.Location = new Point(cWidth - Padding + Start, 0);
            this.BorderTopRight.Location = new Point(cWidth - this.BorderTopRight.Size.Width + Start, 0);
            this.BorderBottomRight.Location = new Point(cWidth - this.BorderBottomRight.Size.Width + Start, this.Height - Padding);
            this.MainPanel.Location = new Point(Padding + Start, Padding);
        }
        public override void Refresh()
        {
            SetSizeAndLocations();
            SetUnits();
            base.Refresh();
        }
        private void UI_Matrix_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
        public void SetUnits()
        {
            this.MainPanel.Controls.Clear();
            int curRow = 1, curCol = 1;
            foreach (RNumber r in this.Matrix.UnitList)
            {
                int UnitX = this.MainPanel.Size.Width / this.Matrix.ColumnCount;
                int UnitY = this.MainPanel.Size.Height / this.Matrix.RowCount;
                UI_RNumber uir = new UI_RNumber(r);
                uir.Size = new Size(new Point(UnitX, UnitY));
                uir.Location = new Point((curCol - 1) * UnitX, (curRow - 1) * UnitY);
                this.MainPanel.Controls.Add(uir);
                if (curCol == this.Matrix.ColumnCount)
                {
                    curCol = 1;
                    curRow++;
                }
                else { curCol++; }


            }
        }
    }
}
