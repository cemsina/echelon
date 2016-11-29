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
    public partial class UI_Move : UserControl
    {
        public Move move;
        public UI_Move(Move m)
        {
            this.move = m;
            InitializeComponent();
            Refresh();
        }
        public void SetMatricesAndDetails()
        {
            UI_Matrix UI_from = new UI_Matrix(this.move.from);
            UI_Matrix UI_to = new UI_Matrix(this.move.to);
            Label details = new Label();
            UI_from.Dock = UI_to.Dock = details.Dock = DockStyle.Fill;
            details.TextAlign = ContentAlignment.MiddleCenter;
            details.Text = "";
            foreach (string s in this.move.Details)
            {
                details.Text += s + Environment.NewLine;
            }
            this.ToMatrixPanel.Controls.Clear();
            this.FromMatrixPanel.Controls.Clear();
            this.DetailsPanel.Controls.Clear();
            this.ToMatrixPanel.Controls.Add(UI_to);
            this.FromMatrixPanel.Controls.Add(UI_from);
            this.DetailsPanel.Controls.Add(details);
        }
        public override void Refresh()
        {
            SetMatricesAndDetails();
            base.Refresh();
        }
    }
}
