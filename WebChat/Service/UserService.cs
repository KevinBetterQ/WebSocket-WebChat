using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using WebChat.Models;


namespace WebChat.Service
{
    public class UserService
    {
        //检查登录
        public User CheckLogin(String uid, String passwd)
        {
            User user = null;
            DBService dbService = new DBService();
            String sql = "select * from Users where uid=\"" + uid + "\" and passwd=\"" + passwd + "\"";
            MySqlDataReader dt = dbService.Query2(sql);
            dt.Read();
            if (dt.HasRows)
            {
                user = new User((String)dt.GetString(0), (String)dt.GetString(1));
            }
            dbService.Close();
            return user;
        }

        //处理注册
        public String DealRegister(string uid, string uname, string passwd)
        {
            String result = null;
            DBService dbService = new DBService();
            String sql = "select * from Users where uid='" + uid + "'";
            int dtCount = dbService.Query(sql);
            if (dtCount > 0)
                result = "账号已存在";
            else
            {
                sql = "insert into Users (uid, uname, passwd) values ('" + uid + "', '" + uname + "', '" + passwd + "')";
                if (!dbService.UpdateTable(sql))
                    result = "注册错误";
            }
            dbService.Close();
            return result;
        }
    }
}