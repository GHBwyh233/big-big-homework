using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    class QUeryManagerImpl: IQueryManager
    {
       Member IQueryManager.queryMember(int id)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member t1 = sd.getMember(id);
            return t1;
        }
        Map IQueryManager.queryMap(int id)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            Map t2 = sd.getMap(id);
            return t2;
        }

        public string getFatherName(int id)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getMember(id);
            if (m1 == null)
            {
                return null;
            }
            return m1.Name;
        }

        public string getMapName(int id)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getMember(id);
            Map m2 = dBUtil.getMap(m1.Mapid);
            return m2.Name;
        }

        public string getPartnerName(int id)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getMember(id);
            List<Partner> list1 = dBUtil.getPartnerList(m1.Name);
            if (list1.Count == 0) 
            {
                return null;
            }
            return list1[0].Name;
           
 
        }

        public User queryUser(string username)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            return dBUtil.getUser(username);
        }

        public string getMemberName(int id)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            return dBUtil.getMember(id).Name;
        }
    }
}
