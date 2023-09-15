using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TodoApi.Entities
{
    public class Notification
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        public int SenderId { get; set; }

        public int ReceiverId { get; set; }

        public String MessageTitle { get; set; }

        public int MessageStatus { get; set; }

        public String Message { get; set; }

        public DateTime SentDate { get; set; }

        public String SenderName { get; set; }


    }
}
