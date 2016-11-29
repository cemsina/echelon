using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Echelon
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            Matrix mtrx = new Matrix(3, 3);
            mtrx.DeserializeUnitList("3/2,2,3,5/2,6,1,7,63/5,11");
            Move mo = new Move();
            mo.from = mtrx.Clone();
            mo.to = mtrx.Clone();
            mo.Details.Add("3/2R1 + R2 -> R1");
            mo.Details.Add("5R3 + R2 -> R3");
            mo.Details.Add("5R3 + R2 -> R3");
            UI_Move mm = new UI_Move(mo);
            mm.Location = new Point(0, 0);
            mm.Size = new Size(new Point(800, 200));
            this.MainPanel.Controls.Add(mm);
        }

        private void calculateNewMatrixToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form newForm = new CreateMatrixForm();
            newForm.Show();
        }
    }
}
