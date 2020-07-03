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
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImplementer");
            Member t1 = sd.getMember(id);
            return t1;
        }
        Map IQueryManager.queryMap(int id)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImplementer");
            Map t2 = sd.getMap(id);
            return t2;
        }
    }
}
