using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Partner
    {
        private int id;//配偶id
        private string name;
        private char sex;
        private int partnerid;//配偶对应的成员id
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public char Sex
        {
            get { return sex; }
            set { sex = value; }
        }
        public int Partnerid
        {
            get { return partnerid; }
            set { partnerid = value; }
        }
    }
}
