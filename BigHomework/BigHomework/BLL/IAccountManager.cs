using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public interface IAccountManager
    {
        bool isLogin(string username,string pwd);//检测是否登录成功,通过调用IDBUtil接口的方法完成
        int getPerLevel(string username);//获取用户权限级别，通过调用IDBUtil接口的方法完成
    }
}
