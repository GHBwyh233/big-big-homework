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
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImplementer");
            Map map = sd.getMap(id);
            return map.Id;
        }

        public void addMember(Member member)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImplementer");
            sd.addMember(member);
   
        }


        public int getFatherId(string name)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImplementer");
            Member father = sd.getMember(name);
            return father.Id;

        }

    }
}
