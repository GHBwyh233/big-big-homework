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
        string getFatherName(int id);//通过父亲id来获取父亲姓名
        string getMapName(int id);//通过成员id来获取其所属族谱的名称
        string getPartnerName(int id);//通过成员id来获取其配偶名称
        User queryUser(string username);//通过用户名获取用户基本信息
        string getMemberName(int id);//通过成员id来获取该成员的姓名
        Member queryMember(string name);//通过成员姓名获取成员信息
        /*
         * 通过成员id获取成员在参数num下对应的亲戚（成员）id
         * 参数num值          亲戚
         * -----------------------
         *   1                父亲
         *   2                兄弟
         *   3                姐妹
         *   4                子女
         */
        int[] getRelativeId(int num,int id);
        Partner getMother(int id);//返回成员id对应成员的母亲
        List<Member> getMemberList(int mapid);//返回mapid对应族谱的所有成员
        Member getAncestor(int mapid);//获取该mapid对应族谱的祖先
    }
}
