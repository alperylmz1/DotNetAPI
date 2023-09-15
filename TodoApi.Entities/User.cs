using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TodoApi.Entities
{
    public class User
    {

        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int UserId { get; set; }

        public string UserMail { get; set; }

        public string UserName { get; set; }

        public int UserRole { get; set; }

        public string UserPassword { get; set; }



    }
}
