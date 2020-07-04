using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class MapManagerImpl : IMapManager
    {
        public void addMap(Map map)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImpl");
            sd.addMap(map);
        }
        /*第二版*/
        public void deleteMap(int mapid)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            dBUtil.deleteMap(mapid);
            List<Member> list1 = dBUtil.getMemberList(mapid);
            for (int i = 0; i < list1.Count; i++)
            {
                List<Partner> list2 = dBUtil.getPartnerList(list1[i].Name);
                for (int j = 0; j < list2.Count; j++)
                {
                    dBUtil.deletePartner(list2[j].Name);
                }
                dBUtil.deleteMember(list1[i].Name);
            }
        }
        public void modifyMap(int id, Map map)
        {
            IDBUtil dBUtil = DBUtilFactory.getDBUtil("DBUtilImpl");
            dBUtil.modifyMap( id,0, map);
        }

    }
}
