using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class AccountManagerImp : IAccountManager
    {
        public int getPerLevel(string username)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImplementer");
            User user = dBUtil.getUser(username);
            if(user == null)
            {
                return -1;
            }
            else
            {
                return user.PerLevel;
            }
        }

        public bool isLogin(string username, string pwd)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImplementer");
            User user = dBUtil.getUser(username);
            if (pwd != user.Pwd)
            {
                return false;
            }
            else
                return true;
        }
    }
}
