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
    public partial class UI_RNumber : UserControl
    {
        public RNumber RNumber;
        public UI_RNumber(RNumber number)
        {
            InitializeComponent();
            this.RNumber = number;
            this.Refresh();
        }
        public override void Refresh()
        {
            if (this.RNumber.Denominator != 1)
            {
                this.DivideLine.Visible = true;
                this.Label_Numarator.Visible = true;
                this.Label_Denominator.Visible = true;
                this.Label_Numarator.Location = new Point(this.Size.Width / 2 - this.Label_Numarator.Size.Width / 2, this.DivideLine.Location.Y - this.Label_Numarator.Size.Height - 2);
                this.Label_Denominator.Location = new Point(this.Size.Width / 2 - this.Label_Denominator.Size.Width / 2, this.DivideLine.Location.Y + 2);
                this.Label_Numarator.Text = RNumber.Numerator.ToString();
                this.Label_Denominator.Text = RNumber.Denominator.ToString();
                int MaxWidth = this.Label_Numarator.Size.Width;
                if (this.Label_Denominator.Size.Width > this.Label_Numarator.Size.Width) MaxWidth = this.Label_Denominator.Size.Width;
                this.DivideLine.Size = new Size(new Point(MaxWidth, 2));
                this.DivideLine.Location = new Point((this.Size.Width- MaxWidth)/2, this.Size.Height / 2 - 1);
            }
            else
            {
                this.DivideLine.Visible = false;
                this.Label_Numarator.Visible = true;
                this.Label_Denominator.Visible = false;
                this.Label_Numarator.Location = new Point(this.Size.Width / 2 - this.Label_Numarator.Size.Width / 2, this.Size.Height / 2 - this.Label_Numarator.Size.Height / 2);
                this.Label_Numarator.Text = RNumber.Numerator.ToString();
            }
            base.Refresh();
        }

        private void UI_RNumber_SizeChanged(object sender, EventArgs e)
        {
            this.Refresh();
        }
    }
}
