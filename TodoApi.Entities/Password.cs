using System;
using System.Collections.Generic;
using System.Text;

namespace TodoApi.Entities
{
    public class Password
    {
        public int Id { get; set; }

        public string UserMail { get; set; }

        public string UserPassword { get; set; }

        public string NewUserPassword { get; set; }

    }

}
