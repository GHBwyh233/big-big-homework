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
            if (manager.Equals("AccountManagerImpl"))
            {
                return new AccountManagerImpl();
            }
            return null;
        }
        public static IMapManager getMapManager(string manager)
        {
            if (manager.Equals("MapManagerImpl"))
            {
                return new MapManagerImpl();
            }
            return null;
        }
        public static IMemberManager getMememberManager(string manager)
        {
            if (manager.Equals("MemberMangerImpl"))
            {
                return new MemberMangerImpl();
            }
            return null;
        }
        public static IQueryManager getQueryManager(string manager)
        {
            if (manager.Equals("QUeryManagerImpl"))
            {
                return new QUeryManagerImpl();
            }
            return null;
        }
    }
}
