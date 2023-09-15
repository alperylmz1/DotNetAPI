using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TodoApi.DataAccess.Abstract;
using TodoApi.Entities;

namespace TodoApi.DataAccess.Concrete
{
    public class NotificationRepository : INotificationRepository

    {
        
        public Notification CreateNotification(Notification notification)
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                notificationDbContext.Notifications.Add(notification);
                notificationDbContext.SaveChanges();
                return notification;
            }
        }

        public void DeleteNotification(int id)
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                var deleteNotification = GetNotificationById(id);
                notificationDbContext.Notifications.Remove(deleteNotification);
                notificationDbContext.SaveChanges();
            }
        }

        public List<Notification> GetAllNotifications()
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                return notificationDbContext.Notifications.ToList();
            }
        }

        public Notification GetNotificationById(int id)
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                return notificationDbContext.Notifications.Find(id);
            }
        }

        public List<Notification> GetNotificationByReceiverId(int id)
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                return notificationDbContext.Notifications.Where(a => a.ReceiverId == id).OrderByDescending(b => b.SentDate).ToList();
            }
        }

        public List<Notification> GetNotificationBySenderId(int id)
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                return notificationDbContext.Notifications.Where(b => b.SenderId == id).ToList();
            }
        }

        public Notification UpdateNotification(Notification notification)
        {
            using (var notificationDbContext = new TodoDbContext())
            {
                notificationDbContext.Notifications.Update(notification);
                notificationDbContext.SaveChanges();
                return notification;
            }
        }
        
    }

}
