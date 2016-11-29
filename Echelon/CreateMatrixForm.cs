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
    public partial class CreateMatrixForm : Form
    {
        public CreateMatrixForm()
        {
            InitializeComponent();
        }
        public UI_Matrix UI_newMatrix;
        private void CreateMatrixForm_Load(object sender, EventArgs e)
        {
            Matrix newMatrix = new Matrix(1, 1);
            UI_newMatrix = new UI_Matrix(newMatrix);
            UI_newMatrix.Dock = DockStyle.Fill;
            this.panel1.Controls.Add(UI_newMatrix);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.UI_newMatrix.Matrix.RowCount = Convert.ToInt32(textBox2.Text);
            this.UI_newMatrix.Matrix.ColumnCount = Convert.ToInt32(textBox3.Text);
            this.UI_newMatrix.Matrix.DeserializeUnitList(textBox1.Text);
            UI_newMatrix.Refresh();
        }
    }
}
