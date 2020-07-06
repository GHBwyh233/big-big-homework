using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Member
    {
        private int id;//成员id
        private string name;//成员姓名
        private char sex;//成员性别
        private string generation;//成员字辈
        private string birth;//出生日期,格式：xxxx/xx/xx
        private string birthPlace;//出生地
        private string idcard;//身份证号
        private int fatherid;//父亲id
        private int mapid;//族谱id
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
        public string Generation
        {
            get { return generation; }
            set { generation = value; }
        }
        public string Birth
        {
            get { return birth; }
            set { birth = value; }
        }
        public string BirthPlace
        {
            get { return birthPlace; }
            set { birthPlace = value; }
        }
        public string Idcard
        {
            get { return idcard; }
            set { idcard = value; }
        }
        public int Fatherid
        {
            get { return fatherid; }
            set { fatherid = value; }
        }
        public int Mapid
        {
            get { return mapid; }
            set { mapid = value; }
        }
    }
}
