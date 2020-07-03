using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Map//族谱实体类
    {
        private int id;//族谱id
        private string name;//族谱名称
        private string surname;//族谱姓氏
        private string introduce;//族谱简介
        private string precepts;//家训
        private string generation;//字辈词串
        public string Name 
        {
            get { return name; }
            set { name = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Surname
        {
            get { return surname; }
            set { surname = value; }
        }
        public string Introduce
        {
            get { return introduce; }
            set { introduce = value; }
        }
        public string Precepts
        {
            get { return precepts; }
            set { precepts = value; }
        }
        public string Generation
        {
            get { return generation; }
            set { generation = value; }
        }
    }
}
