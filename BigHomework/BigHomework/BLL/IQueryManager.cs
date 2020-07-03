using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace BLL
{
    public interface IQueryManager
    {
        Member queryMember(int id);//通过id获取成员信息
        Map queryMap(int id);//通过族谱获取族谱基本信息
        //string getFatherName(int id);//通过父亲id来获取父亲姓名
        //string getMapName(int id);//通过成员id来获取其所属族谱的名称
        //string getPartnerName(int id);//通过成员id来获取其配偶名称
    }
}
