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
        void deleteMember(string name);//删除该成员name对应的成员，以及该成员的所有配偶
        void addPartner(Partner partner);//添加配偶
        void modifyMember(int id,Member member);//将该id对应的成员信息更新进数据库
    }
}
