using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    class QUeryManagerImpl : IQueryManager
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
            if (m2 == null)
            {
                return null;
            }
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
            Member member = dBUtil.getMember(id);
              if (member == null)
            {
                return null;
            }
            return member.Name;
        }
        public int[] getRelativeId(int num, int id)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getMember(id);
            int[] a = new int[10];
            for (int i = 0; i < 10; i++)
            {
                a[i] = 0;
            }
            if (num == 1)
            {
                a[0] = m1.Fatherid;
            }
            else if (num == 2)
            {
                List<Member> l1 = dBUtil.getChildList(m1.Fatherid);
                for (int i = 0; i < l1.Count; i++)
                {
                    if (l1[i].Sex == '男'&& l1[i].Id!=id)
                    {
                        a[i] = l1[i].Id;
                    }
                }
            }
            else if (num == 3)
            {
                List<Member> l1 = dBUtil.getChildList(m1.Fatherid);
                for (int i = 0; i < l1.Count; i++)
                {
                    if (l1[i].Sex == '女' && l1[i].Id != id)
                    {
                        a[i] = l1[i].Id;
                    }
                }
            }
            else if (num == 4)
            {
                List<Member> l1 = dBUtil.getChildList(m1.Id);
                {
                    for (int i = 0; i < l1.Count; i++)
                    {
                        a[i] = l1[i].Id;
                    }
                }
            }
            return a;
        }

        public Partner getMother(int id)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getMember(id);
            Member f1 = dBUtil.getMember(m1.Fatherid);
            List <Partner> p1 = dBUtil.getPartnerList(f1.Name);
            if (p1.Count != 0)
                return p1[0];
            else
                return null;     
        }
        public List<Member> getMemberList(int mapid)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            List<Member> m1 = dBUtil.getMemberList(mapid);
            return m1;
        }

        public Member getAncestor(int mapid) 
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member m1 = dBUtil.getAncestor(mapid);
            return m1;
        }

        public Member queryMember(string name)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            return dBUtil.getMember(name);
        }
    }
}
