using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using DAL;

namespace BLL
{
    public class MapMangerImpl : IMapManager
    {
        public void addMap(Map map)
        {
            IDBUtil sd = DBUtilFactory.getDBUtil("DBUtilImplementer");
            sd.addMap(map);
        }
    }
}
