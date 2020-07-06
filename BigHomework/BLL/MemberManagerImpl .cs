using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Model;

namespace BLL
{
    public class MemberMangerImpl : IMemberManager
    {
        public int getMapid(int id)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            Map map = sd.getMap(id);
            return map.Id;
        }

        public void addMember(Member member)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            sd.addMember(member);
   
        }

        public int getFatherId(string name)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            Member father = sd.getMember(name);
            return father.Id;

        }
        /*第二版*/
        public void deletePartner(string name)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            List<Partner> list1 = dBUtil.getPartnerList(name);
            for (int i = 0; i < list1.Count; i++)
            {
                dBUtil.deletePartner(list1[i].Name);
            }
            dBUtil.deleteMember(name);
        }

        public void addPartner(Partner partner)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            sd.addPartner(partner);
        }

        public void modifyMember(int id, Member member)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            dBUtil.modifyMember(id, 0, member);
        }
    }
}
