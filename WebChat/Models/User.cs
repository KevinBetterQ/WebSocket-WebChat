using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebChat.Models
{
    public class User
    {
        private String Uid;
        private String Uname;

        public User()
        {
        }

        public User(String Uid, String Uname)
        {
            this.Uname = Uname;
            this.Uid = Uid;
        }

        public String GetUid()
        {
            return Uid;

        }

        public void SetUid(String Uid)
        {
            this.Uid = Uid;
        }

        public String GetUname()
        {
            return Uname;
        }

        public void SetUname(String Uname)
        {
            this.Uname = Uname;
        }
    }
}