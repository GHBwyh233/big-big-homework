using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class AccountManagerImpl : IAccountManager
    {
        public int getPerLevel(string username)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User user = dBUtil.getUser(username);
            if (user == null)
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
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User user = dBUtil.getUser(username);
            if (pwd != user.Pwd)
            {
                return false;
            }
            else
                return true;
        }

        /*以下为2.0*/

        public int getMemberid(string name)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getMember(name);
            return m1.Id;
        }

        public int getMapid(string name)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User u1 = dBUtil.getUser(name);
            Map m2 = dBUtil.getMap(u1.Mapid);
            return m2.Id;
        }

        public void addUser(User user)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            dBUtil.addUser(user);
        }

        public bool hasUser(string username)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User user = dBUtil.getUser(username);
            if (user == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool verifyUser(string username, string email)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User user = dBUtil.getUser(username);
            if (user.Email == email)
            {
                return true;
            }
            else
                return false;
        }
        public void modifyUserPassword(string username, string pwd)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User user = dBUtil.getUser(username);
            user.Pwd = pwd;
            dBUtil.modifyUser(username, 2, user);
        }

        public void modifyUserPerLevel(string username, int perLevel)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            User user = dBUtil.getUser(username);
            user.PerLevel = perLevel;
            dBUtil.modifyUser(username, 5, user);
        }

        public void modifyUser(string username, User user)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            dBUtil.modifyUser(username, 0, user);
        }
    }
}
