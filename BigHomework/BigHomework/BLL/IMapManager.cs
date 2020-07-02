using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public interface IMapManager
    {
        void addMap(Map map);//完成创建族谱功能，通过调用IDBUtil的方法完成
    }
}
