using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.Business.Abstract
{
    public interface INotificationService
    {
        Notification CreateNotification(Notification notification);
        Notification GetNotificationById(int id);

        List<Notification> GetNotificationByReceiverId(int id);

        List<Notification> GetNotificationBySenderId(int id);

        List<Notification> GetAllNotifications();

        Notification UpdateNotification(Notification notification);

        void DeleteNotification(int id);
    }
}
