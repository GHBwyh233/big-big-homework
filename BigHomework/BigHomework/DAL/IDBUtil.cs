using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using Model;

namespace DAL
{
    public interface IDBUtil//数据库工具接口类
    {
        User getUser(string username);//通过用户名返回对应的用户账号实体类，若查找结果为空，返回null,否则返回账号实体类
        void addMap(Map map);//将族谱实体类对象对应的族谱添加进数据库
        void addMember(Member member);//将成员实体类对象对应的成员添加进数据库
        Member getMember(string name);//通过成员姓名获取成员基本信息
        Map getMap(int id);//通过族谱id获取族谱基本信息
        Member getMember(int id);//通过成员id获取成员基本信息
        void addUser(User user);//将用户实体类对象添加进数据库
        List<Member> getMemberList(int mapid);//返回属于mapid对应族谱的所有成员
        List<Partner> getPartnerList(string name);//返回该name对应成员的所有配偶

        /*
         * 在数据库更新参数num对应的用户属性值，新的值在参数user对应属性中
         * num取值：
         * 值------对应的User对象属性
         * 0            全部(1~7)
         * 1            username
         * 2            pwd
         * 3            tele
         * 4            email
         * 5            perLevel
         * 6            mapid
         * 7            memberid
         * 8            tele+email
         */
        void modifyUser(string username, int num, User user);
        void deleteMap(int mapid);//删除族谱id对应的族谱
        void deleteMember(string name);//删除该成员name对应的成员
        //void deleteAllMember(List<Member> memberList);//删除List集合中的所有成员
        //void deleteAllPartner(List<Partner> partnerList);//删除List集合中的所有配偶
        void deletePartner(string name);//删除该配偶name对应的配偶
        void addPartner(Partner partner);//添加配偶到数据库
     /*
      * 在数据库更新参数num对应的用户属性值，新的值在参数user对应属性中
      * num取值：
      * 值------对应的User对象属性
      * 0            全部(1~8)
      * 1            name
      * 2            sex
      * 3            generation
      * 4            birth
      * 5            birthPlace
      * 6            idcard
      * 7            fatherid
      * 8            mapid
      */
        void modifyMember(int id, int num, Member member);
        /*
        * 在数据库更新参数num对应的用户属性值，新的值在参数user对应属性中
        * num取值：
        * 值------对应的User对象属性
        * 0            全部(1~5)
        * 1            name
        * 2            surname
        * 3            introduce
        * 4            precepts
        * 5            generation
        */
        void modifyMap(int id, int num, Map map);
    }
}
