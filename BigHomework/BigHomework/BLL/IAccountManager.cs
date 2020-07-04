using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public interface IAccountManager//该接口所有方法均调用IDBUtil接口的方法实现
    {
        bool isLogin(string username,string pwd);//检测是否登录成功,通过调用IDBUtil接口的方法完成
        int getPerLevel(string username);//获取用户权限级别，通过调用IDBUtil接口的方法完成
        int getMemberid(string name);//通过成员姓名获取成员的id，如果未获取到成员id，返回-1
        int getMapid(string name);//通过成员姓名获取其所属族谱的id 如果未获取到族谱id，返回-1
        void addUser(User user);//将用户对象添加进数据库，通过调用IDBUtil的方法实现
        bool hasUser(string username);//判断输入的用户名username对应的用户是否在数据库中
        bool verifyUser(string username,string email);//验证该用户名username在数据库对应的用户的邮箱是否为参数email
        void modifyUserPassword(string username, string pwd);//将该用户名username在数据库中的密码属性值修改为参数pwd
        void modifyUserPerLevel(string username, int perLevel);//将该用户名username在数据库中的权限级别属性值修改为参数perLevel
        void modifyUser(string username,User user);//将该username对应的用户信息更新进数据库
    }
}
