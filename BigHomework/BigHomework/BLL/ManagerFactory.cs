using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ManagerFactory
    {
        public static IAccountManager getAccountManager(string manager) 
        {
            return null;
        }
        public static IMapManager getMapManager(string namager)
        {
            return null;
        }
        public static IMemberManager getMememberManager(string manager)
        {
            return null;
        }
        public static IQueryManager getQueryManager(string manager)
        {
            return null;
        }
    }
}
