using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Data;
using MySql.Data.MySqlClient;

namespace DAL
{
    public class DBUtilImpl : IDBUtil
    {


        public User getUser(string username)
        {
            User user = new User();

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_user where username = '"+username+"'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                drow = coldrow[inti];
                user.Id = Convert.ToInt32(drow[0]);
                user.Username = Convert .ToString(drow[1]);
                user.Pwd= Convert.ToString(drow[2]);
                user.Tele= Convert.ToString(drow[3]);
                user.Email= Convert.ToString(drow[4]);
                user.PerLevel= Convert.ToInt32(drow[5]);
                user.Mapid= Convert.ToInt32(drow[6]);
                user.Memberid= Convert.ToInt32(drow[7]);
            }
            sqlCon.Close();
            sqlCon = null;
            return user;
        }
        public Member getMember(int id)
        {
            Member member = new Member();

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_member where id = '" + id + "'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                drow = coldrow[inti];
                member.Id = Convert.ToInt32(drow[0]);//给id赋值
                member.Name = Convert.ToString(drow[1]);//给name赋值
                member.Sex = Convert.ToChar(drow[2]);//给赋值
                member.Generation = Convert.ToString(drow[3]);
                member.Birth = Convert.ToString(drow[4]);
                member.BirthPlace = Convert.ToString(drow[5]);
                member.Idcard = Convert.ToString(drow[6]);
                member.Fatherid = Convert.ToInt32(drow[7]);
                member.Mapid = Convert.ToInt32(drow[8]);
            }
            return member;
        }
        public void addMap(Map map)
        {

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_familymap ";//查询出所有的数据
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //增加记录
            drow = ds.Tables["tabuser"].NewRow();
            //给该记录赋值
            drow[1] = map.Name;//给name赋值
            drow[2] = map.Surname;
            drow[3] = map.Introduce;//给赋值
            drow[4] = map.Precepts;
            drow[5] = map.Generation;
            ds.Tables["tabuser"].Rows.Add(drow);//将记录添加的虚拟数据库
                                                //提交更新
            msda.Update(ds, "tabuser"); //更新真正的数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public void addMember(Member member)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_member ";//查询出所有的数据
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //增加记录
            drow = ds.Tables["tabuser"].NewRow();
            //给该记录赋值
            //drow[0] = member.Id;//给id赋值
            drow[1] = member.Name;//给name赋值
            drow[2] = member.Sex;//给赋值
            drow[3] = member.Generation;
            drow[4] = member.Birth;
            drow[5] = member.BirthPlace;
            drow[6] = member.Idcard;
            drow[7] = member.Fatherid;
            drow[8] = member.Mapid;
            ds.Tables["tabuser"].Rows.Add(drow);//将记录添加的虚拟数据库
                                                //提交更新
            msda.Update(ds, "tabuser"); //更新真正的数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public Member getMember(string name)
        {
            Member member = new Member();

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_member where name = '"+ name +"'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                drow = coldrow[inti];
                member.Id = Convert.ToInt32(drow[0]) ;//给id赋值
                member.Name = Convert.ToString(drow[1]);//给name赋值
                member.Sex= Convert.ToChar(drow[2]);//给赋值
                member.Generation= Convert.ToString(drow[3]);
                member.Birth= Convert.ToString(drow[4]);
                member.BirthPlace= Convert.ToString(drow[5]);
                member.Idcard= Convert.ToString(drow[6]);
                member.Fatherid= Convert.ToInt32(drow[7]);
                member.Mapid= Convert.ToInt32(drow[8]);
            }
            return member;
        }

        public Map getMap(int id)
        {
            Map map = new Map();

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_familymap where id = '"+id+ "'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                drow = coldrow[inti];
                map.Id = Convert.ToInt32(drow[0]);//给id赋值
                map.Name = Convert.ToString(drow[1]);//给name赋值
                map.Surname = Convert.ToString(drow[2]);
                map.Introduce = Convert.ToString(drow[3]);
                map.Precepts = Convert.ToString(drow[4]);
                map.Generation = Convert.ToString(drow[5]);
            }
            return map;
        }

        public void addUser(User user)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_user ";//查询出所有的数据
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //增加记录
            drow = ds.Tables["tabuser"].NewRow();
            //给该记录赋值
            //drow[0] = member.Id;//给id赋值
            drow[1] = user.Username;//给name赋值
            drow[2] = user.Pwd;//给赋值
            drow[3] = user.Tele;
            drow[4] = user.Email;
            drow[5] = user.PerLevel;
            drow[6] = user.Mapid;
            drow[7] = user.Memberid;
            ds.Tables["tabuser"].Rows.Add(drow);//将记录添加的虚拟数据库
                                                //提交更新
            msda.Update(ds, "tabuser"); //更新真正的数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public void modifyUser(string username, int num, User user)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";

            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_user ";//查询出所有的字段
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);


            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);


            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //通过num获得要修改的地方
            string var1=null;
            string var2=null;
            string var3=null;
            string var4=null;
            string var5 = null;
            string var6 = null;
            string var7 = null;
            string var8 = null;
            string var9 = null;
            string var10 = null;
            string var11 = null;
            string var12 = null;
            string var13 = null;
            string var14 = null;

            if (num==0)
            {
                var1 = "username";
                var2 = user.Username;
                var3 = "password";
                var4 = user.Pwd;
                var5 = "tele_number";
                var6 = user.Tele;
                var7 = "email";
                var8 = user.Email;
                var9 = "permission_level";
                var10 = Convert.ToString(user.PerLevel);
                var11 = "map_id";
                var12 = Convert.ToString(user.Mapid);
                var13 = "member_id";
                var14 = Convert.ToString(user.Memberid);
            }
            else if (num == 1)
            {
                //updata user username = user.Username where id = user.id
                var1 = "username";
                var2 = user.Username;
            }
            else if(num == 2)
            {
                //updata user pwd = user.Pwd where id = user.id
                var1 = "password";
                var2 = user.Pwd;
            }
            else if(num == 3)
            {
                var1 = "tele_number";
                var2 = user.Tele;
            }
            else if(num == 4)
            {
                var1 = "email";
                var2 = user.Email;
            }
            else if (num == 5)
            {
                var1 = "permission_level";
                var2 = Convert.ToString(user.PerLevel);
                
            }
            else if (num == 6)
            {
                var1 = "map_id";
                var2 = Convert.ToString(user.Mapid);
            }
            else if (num == 7)
            {
                var1 = "member_id";
                var2 = Convert.ToString(user.Memberid);
            }
            else if (num == 8)
            {
                var1 = "tele_number";
                var2 = Convert.ToString(user.Tele);
                var3 = "email";
                var4 = Convert.ToString(user.Email);
            }
            if(num==0)
            {
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == user.Id + "")
                    {
                        drow[var1] = var2;
                        drow[var3] = var4;
                        drow[var5] = var6;
                        drow[var7] = var8;
                        drow[var9] = Convert.ToInt32(var10);
                        drow[var11] = Convert.ToInt32(var12);
                        drow[var13] = Convert.ToInt32(var14);
                    }
                }
            }
            else if (num != 8&&num!=0)
            {
                //update你的数据(update user password = 123 where id = user.id)
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == user.Id + "")
                    {
                        if (num == 5 || num == 6 || num == 7)
                        {
                            drow[var1] = Convert.ToInt32(var2);
                        }
                        else
                        {
                            drow[var1] = var2;
                        }
                    }
                }
            }
            else if(num==8)
            {
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == user.Id + "")
                    {
                        drow[var1] = var2;
                        drow[var3] = var4;
                    }
                }
            }
            msda.Update(ds, "tabuser");//更新数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public List<Member> getMemberList(int mapid)
        {

            List<Member> MemberList = new List<Member>();

            

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_member where map_id = '" + mapid + "'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                Member member = new Member();
                drow = coldrow[inti];
                member.Id = Convert.ToInt32(drow[0]);//给id赋值
                member.Name = Convert.ToString(drow[1]);//给name赋值
                member.Sex = Convert.ToChar(drow[2]);//给赋值
                member.Generation = Convert.ToString(drow[3]);
                member.Birth = Convert.ToString(drow[4]);
                member.BirthPlace = Convert.ToString(drow[5]);
                member.Idcard = Convert.ToString(drow[6]);
                member.Fatherid = Convert.ToInt32(drow[7]);
                member.Mapid = Convert.ToInt32(drow[8]);
                MemberList.Add(member);
            }

            return MemberList;
        }

        public List<Partner> getPartnerList(string name)
        {
            Member member1 = new Member();
            member1 = getMember(name);

            List<Partner> PartnerList = new List<Partner>();

            

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_partner where partner_id = '" + member1.Id + "'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                Partner member = new Partner();
                drow = coldrow[inti];
                member.Id = Convert.ToInt32(drow[0]);//给id赋值
                member.Name = Convert.ToString(drow[1]);//给name赋值
                member.Sex = Convert.ToChar(drow[2]);//给赋值
                member.Partnerid= Convert.ToInt32(drow[3]);
                PartnerList.Add(member);
            }

            return PartnerList;
        }

        public void deleteMap(int mapid)
        {

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;
            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;
            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_map ";//查询出所有的字段
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;
            //逐行遍历，取出各行的数据,并且删除符合条件的数据（我要删除的id为mapid的记录）
            for (int inti = 0; inti < coldrow.Count; inti++)//删除符合条件的数据
            {
                drow = coldrow[inti];
                if (drow["id"].ToString() == mapid + "")
                {
                    drow.Delete();
                }
            }
            msda.Update(ds, "tabuser");//重点，重点，重点，更新数据库
            sqlCon.Close();
            sqlCon = null;

        }

        public void deleteMember(string name)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;
            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;
            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_member ";//查询出所有的字段
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;
            //逐行遍历，取出各行的数据,并且删除符合条件的数据（我要删除的name为name的记录）
            for (int inti = 0; inti < coldrow.Count; inti++)//删除符合条件的数据
            {
                drow = coldrow[inti];
                if (drow["name"].ToString() == name + "")
                {
                    drow.Delete();
                }
            }
            msda.Update(ds, "tabuser");//更新数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public void deletePartner(string name)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;
            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;
            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_partner ";//查询出所有的字段
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;
            //逐行遍历，取出各行的数据,并且删除符合条件的数据（我要删除的name为name的记录）
            for (int inti = 0; inti < coldrow.Count; inti++)//删除符合条件的数据
            {
                drow = coldrow[inti];
                if (drow["name"].ToString() == name + "")
                {
                    drow.Delete();
                }
            }
            msda.Update(ds, "tabuser");//更新数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public void addPartner(Partner partner)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);
            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();
            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;
            //打开连接
            sqlCon.Open();
            //建立DataAdapter对象  
            string sltStr = "select * from t_partner ";//查询出所有的数据
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);
            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);
            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");
            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];
            //增加记录
            drow = ds.Tables["tabuser"].NewRow();
            //给该记录赋值
            //drow[0] = member.Id;//给id赋值
            drow[1] = partner.Name;//给name赋值
            drow[2] = partner.Sex;//给赋值
            drow[3] = partner.Partnerid;
 
            ds.Tables["tabuser"].Rows.Add(drow);//将记录添加的虚拟数据库
                                                //提交更新
            msda.Update(ds, "tabuser"); //更新真正的数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public void modifyMember(int id, int num, Member member)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";

            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_member ";//查询出所有的字段
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);


            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);


            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //通过num获得要修改的地方
            string var1 = null;
            string var2 = null;
            string var3 = null;
            string var4 = null;
            string var5 = null;
            string var6 = null;
            string var7 = null;
            string var8 = null;
            string var9 = null;
            string var10 = null;
            string var11 = null;
            string var12 = null;
            string var13 = null;
            string var14 = null;
            string var15 = null;
            string var16 = null;

            if (num == 0)
            {
                var1 = "name";
                var2 = member.Name;
                var3 = "sex";
                var4 = Convert.ToString(member.Sex);
                var5 = "generation";
                var6 = member.Generation;
                var7 = "birth";
                var8 = member.Birth;
                var9 = "birth_place";
                var10 = member.BirthPlace;
                var11 = "idcard";
                var12 = member.Idcard;
                var13 = "father_id";
                var14 = Convert.ToString(member.Fatherid);
                var15 = "map_id";
                var16 = Convert.ToString(member.Mapid);

            }
            else if (num == 1)
            {
                //updata user username = user.Username where id = user.id
                var1 = "name";
                var2 = member.Name;
            }
            else if (num == 2)
            {
                //updata user pwd = user.Pwd where id = user.id
                var1 = "sex";
                var2 = Convert.ToString(member.Sex);
            }
            else if (num == 3)
            {
                var1 = "generation";
                var2 = member.Generation;
            }
            else if (num == 4)
            {
                var1 = "birth";
                var2 = member.Birth;
            }
            else if (num == 5)
            {
                var1 = "birth_place";
                var2 = member.BirthPlace;

            }
            else if (num == 6)
            {
                var1 = "idcard";
                var2 = member.Idcard;
            }
            else if (num == 7)
            {
                var1 = "father_id";
                var2 = Convert.ToString(member.Fatherid);
            }
            else if (num == 8)
            {
                var1 = "map_id";
                var2 = Convert.ToString(member.Mapid);
            }
            if (num == 0)
            {
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == member.Id + "")
                    {
                        drow[var1] = var2;
                        drow[var3] = Convert.ToChar(var4);
                        drow[var5] = var6;
                        drow[var7] = var8;
                        drow[var9] = var10;
                        drow[var11] = var12;
                        drow[var13] = Convert.ToInt32(var14);
                        drow[var15] = Convert.ToInt32(var16);
                        
                    }
                }
            }
            else
            {
                //update你的数据(update user password = 123 where id = user.id)
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == member.Id + "")
                    {
                        if (num == 2)
                        {
                            drow[var1] = Convert.ToChar(var2);
                        }
                        else if(num==7 || num==8)
                        {
                            drow[var1] = Convert.ToInt32(var2);
                        }
                        else
                        {
                            drow[var1] = var2;
                        }
                    }
                }
            }
            msda.Update(ds, "tabuser");//更新数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public void modifyMap(int id, int num, Map map)
        {
            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";

            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_familymap ";//查询出所有的字段
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);


            //建立 CommandBuilder 对象来自动生成 DataAdapter 的 Command 命令，否则就要自己编写
            //Insertcommand ,deletecommand , updatecommand 命令。
            MySqlCommandBuilder mySqlCommandBuilder = new MySqlCommandBuilder(msda);


            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //通过num获得要修改的地方
            string var1 = null;
            string var2 = null;
            string var3 = null;
            string var4 = null;
            string var5 = null;
            string var6 = null;
            string var7 = null;
            string var8 = null;
            string var9 = null;
            string var10 = null;

            if (num == 0)
            {
                var1 = "name";
                var2 = map.Name;
                var3 = "surname";
                var4 = map.Surname;
                var5 = "introduce";
                var6 = map.Introduce;
                var7 = "family_precepts";
                var8 = map.Precepts;
                var9 = "total_generation";
                var10 = map.Generation;      

            }
            else if (num == 1)
            {
                //updata user username = user.Username where id = user.id
                var1 = "name";
                var2 = map.Name;
            }
            else if (num == 2)
            {
                //updata user pwd = user.Pwd where id = user.id
                var1 = "surname";
                var2 = map.Surname;
            }
            else if (num == 3)
            {
                var1 = "introduce";
                var2 = map.Introduce;
            }
            else if (num == 4)
            {
                var1 = "family_precepts";
                var2 = map.Precepts;
            }
            else if (num == 5)
            {
                var1 = "total_generation";
                var2 = map.Generation;

            }
            if (num == 0)
            {
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == map.Id + "")
                    {
                        drow[var1] = var2;
                        drow[var3] = var4;
                        drow[var5] = var6;
                        drow[var7] = var8;
                        drow[var9] = var10;
                    }
                }
            }
            else
            {
                //update你的数据(update user password = 123 where id = user.id)
                for (int inti = 0; inti < coldrow.Count; inti++)
                {
                    drow = coldrow[inti];
                    if (drow["id"].ToString() == map.Id + "")
                    {  
                        drow[var1] = var2;     
                    }
                }
            }
            msda.Update(ds, "tabuser");//更新数据库
            sqlCon.Close();
            sqlCon = null;
        }

        public List<Member> getChildList(int id)
        {
            List<Member> MemberList = new List<Member>();

            

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_member where father_id = '" + id+"'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                Member member = new Member();
                drow = coldrow[inti];
                member.Id = Convert.ToInt32(drow[0]);//给id赋值
                member.Name = Convert.ToString(drow[1]);//给name赋值
                member.Sex = Convert.ToChar(drow[2]);//给赋值
                member.Generation = Convert.ToString(drow[3]);
                member.Birth = Convert.ToString(drow[4]);
                member.BirthPlace = Convert.ToString(drow[5]);
                member.Idcard = Convert.ToString(drow[6]);
                member.Fatherid = Convert.ToInt32(drow[7]);
                member.Mapid = Convert.ToInt32(drow[8]);
                MemberList.Add(member);
            }

            return MemberList;
        }

        public Member getAncestor(int mapid)
        {
            Member member = new Member();

            String sqlCconnStr = "Server =47.101.213.60;Database=big-homework;UID=xiehang;Password=Cflolwdza123.";
            //连接数据库 
            MySqlConnection sqlCon = new MySqlConnection(sqlCconnStr);

            //建立DataSet对象(相当于建立前台的虚拟数据库)
            DataSet ds = new DataSet();

            //建立DataTable对象(相当于建立前台的虚拟数据库中的数据表)
            DataTable dtable;

            //建立DataRowCollection对象(相当于表的行的集合)
            DataRowCollection coldrow;

            //建立DataRow对象(相当于表的列的集合)
            DataRow drow;

            //打开连接
            sqlCon.Open();

            //建立DataAdapter对象  
            string sltStr = "select * from t_member where map_id = '" + mapid + "' and father_id='"+ -1 +"'";//编写符合你查询条件的sql语句
            MySqlCommand sqlCmd = new MySqlCommand(sltStr, sqlCon);
            MySqlDataAdapter msda = new MySqlDataAdapter(sqlCmd);

            //将查询的结果存到虚拟数据库ds中的虚拟表tabuser中
            msda.Fill(ds, "tabuser");

            //将数据表tabuser的数据复制到DataTable对象（取数据）
            dtable = ds.Tables["tabuser"];

            //用DataRowCollection对象获取这个数据表的所有数据行
            coldrow = dtable.Rows;

            //逐行遍历，取出各行的数据
            for (int inti = 0; inti < coldrow.Count; inti++)
            {
                drow = coldrow[inti];
                member.Id = Convert.ToInt32(drow[0]);//给id赋值
                member.Name = Convert.ToString(drow[1]);//给name赋值
                member.Sex = Convert.ToChar(drow[2]);//给赋值
                member.Generation = Convert.ToString(drow[3]);
                member.Birth = Convert.ToString(drow[4]);
                member.BirthPlace = Convert.ToString(drow[5]);
                member.Idcard = Convert.ToString(drow[6]);
                member.Fatherid = Convert.ToInt32(drow[7]);
                member.Mapid = Convert.ToInt32(drow[8]);
            }
            return member;
        }
    }
}
