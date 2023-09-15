using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Business.Abstract;
using TodoApi.DataAccess.Abstract;
using TodoApi.DataAccess.Concrete;
using TodoApi.Entities;

namespace TodoApi.Business.Concrete
{
    public class NotificationManager : INotificationService
    {
        private INotificationRepository _notificationRepository;

        public NotificationManager()
        {
            _notificationRepository = new NotificationRepository();
        }

        public Notification CreateNotification(Notification notification)
        {
            return _notificationRepository.CreateNotification(notification);
        }

        public void DeleteNotification(int id)
        {
            _notificationRepository.DeleteNotification(id);
        }

        public Notification GetNotificationById(int id)
        {
            return _notificationRepository.GetNotificationById(id);
        }

        public List<Notification> GetNotificationByReceiverId(int id)
        {
            return _notificationRepository.GetNotificationByReceiverId(id);
        }

        public List<Notification> GetNotificationBySenderId(int id)
        {
            return _notificationRepository.GetNotificationBySenderId(id);
        }

        public List<Notification> GetAllNotifications()
        {
            return _notificationRepository.GetAllNotifications();
        }

        public Notification UpdateNotification(Notification notification)
        {
            return _notificationRepository.UpdateNotification(notification);
        }
    }
}
