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
    public class DBUtiIlmplementer : IDBUtil
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
            //drow[0] = map.Id;//给id赋值
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
    }
}
