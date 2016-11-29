using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Echelon
{
    public class Matrix
    {
        public RNumber Multiple;
        public int RowCount;
        public int ColumnCount;
        public List<RNumber> UnitList;
        public Matrix(int r,int c)
        {
            this.RowCount = Math.Abs(r); this.ColumnCount = Math.Abs(c); this.UnitList = new List<RNumber>();this.Multiple = new RNumber(1);
        }
        public List<RNumber> GetRow(int r)
        {
            List<RNumber> rtrn = new List<RNumber>();
            if(r > this.RowCount || r < 1) { return rtrn; }
            int Start = (r-1) * this.ColumnCount;
            int End = Start + this.ColumnCount;
            for (int i = Start;i< End; i++) rtrn.Add(this.UnitList[i]);
            return rtrn;
        }
        public List<RNumber> GetColumn(int c)
        {
            List<RNumber> rtrn = new List<RNumber>();
            if (c > this.ColumnCount || c < 1) { return rtrn; }
            int Start = (c - 1);
            int End = this.ColumnCount * this.RowCount - (this.ColumnCount - c);
            for(int i = Start; i < End; i += this.ColumnCount) rtrn.Add(this.UnitList[i]);
            return rtrn;
        }
        public void DeserializeUnitList(string str)
        {
            this.UnitList = new List<RNumber>();
            string[] strArr = str.Split(',');
            foreach(string s in strArr)
            {
                this.UnitList.Add(s.toRNumber());
            }
        }
        public Matrix Clone()
        {
            Matrix rtrn = new Matrix(this.RowCount, this.ColumnCount);
            foreach(RNumber r in this.UnitList)
            {
                rtrn.UnitList.Add(new RNumber(r.Numerator,r.Denominator));
            }
            return rtrn;
        }
    }
}
