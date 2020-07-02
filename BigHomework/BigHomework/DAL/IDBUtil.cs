using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace DAL
{
    public interface IDBUtil//数据库工具接口类
    {
        User getUser(string username, string pwd);//通过用户名和密码返回对应的用户账号实体类，若查找结果为空，返回null,否则返回账号实体类
        void addMap(Map map);//将族谱实体类对象对应的族谱添加进数据库
        void addMemeber(Member member);//将成员实体类对象对应的成员添加进数据库
    }
}
