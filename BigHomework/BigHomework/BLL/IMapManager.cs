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
        void deleteMap(int mapid);//根据输入的mapid，删除对应的族谱，属于该族谱的所有成员，以及成员的所有配偶记录
        void modifyMap(int id, Map map);//该id对应的族谱信息更新进数据库
    }
}
