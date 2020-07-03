using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public interface IMemberManager
    {
        void addMember(Member member);//添加成员
        int getFatherId(string name);//通过父亲姓名获取父亲id
        int getMapid(int id);//通过成员id来获取族谱的id
    }
}
