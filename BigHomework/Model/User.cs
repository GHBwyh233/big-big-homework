using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class User
    {
        private int id;//用户id
        private string username;//用户账号
        private string pwd;//用户密码
        private string tele ;//用户电话
        private string email;//用户邮箱
        private int perLevel;//用户权限级别，1为超级管理员，2为家族管理员，3为普通成员
        private int mapid;//用户所属族谱的id
        private int memberid;//用户对应的成员id
        public int Id 
        {
            get { return id;}
            set{ id = value; }
        }
        public string Username
        {
            get{ return username;}
            set{username = value;}
        }
        public string Pwd
        {
            get{ return pwd; }
            set{pwd = value;}
        }
        public string Tele
        {
            get{return tele; }
            set{tele = value;}
        }
        public string Email
        {
            get{return email; }
            set{email = value; }
        }
        public int PerLevel
        {
            get{ return perLevel; }
            set{ perLevel = value;}
        }
        public int Mapid
        {
            get{return mapid;}
            set{mapid = value;}
        }
        public int Memberid
        {
            get{return memberid;}
            set{ memberid = value;}
        }
    }
}
