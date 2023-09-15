using System;
using System.Collections.Generic;
using System.Text;
using TodoApi.Entities;

namespace TodoApi.DataAccess.Abstract
{
    public interface INotificationRepository
    {

        List<Notification> GetAllNotifications();
        Notification GetNotificationById(int id);

        Notification CreateNotification(Notification notification);

        Notification UpdateNotification(Notification notification);

        void DeleteNotification(int id);

        List<Notification> GetNotificationBySenderId(int id);

        List<Notification> GetNotificationByReceiverId(int id);

    }
}
