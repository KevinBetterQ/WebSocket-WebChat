using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;

namespace WebChat.Service
{
    public class DBService
    {
        private MySqlConnection connection = new MySqlConnection();

        public DBService()
        {
            string connectionString = "Host=127.0.0.1;UserName=root;Password=123456;Database=test;Port=3306;CharSet=utf8";
            connection.ConnectionString = connectionString;
            connection.Open();
        }

        //打开连接
        public void Open()
        {
            connection.Open();
        }

        //关闭连接
        public void Close()
        {
            connection.Close();
        }

        //zhuceu查询
        public int Query(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            int rows = command.ExecuteNonQuery();
            return rows;
        }

        //denglu查询并遍历
        public MySqlDataReader Query2(string sql)
        {
            MySqlCommand command = new MySqlCommand(sql, connection);
            MySqlDataReader reader = command.ExecuteReader();
            return reader;
        }

        //更新
        public bool UpdateTable(string sql)
        {
            return new MySqlCommand(sql, connection).ExecuteNonQuery() > 0 ? true : false;
        }
    }
}