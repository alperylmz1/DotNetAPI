using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TodoApi.Business.Abstract;
using TodoApi.Business.Concrete;
using TodoApi.Entities;

namespace TodoApi.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {

        private INotificationService _notificationService;

        public NotificationController()
        {
            _notificationService = new NotificationManager();
        }

        [HttpGet("{id}")]
        public Notification Get(int id)
        {
            return _notificationService.GetNotificationById(id);
        }

        [HttpGet("sender/{id}")]
        public List<Notification> GetSender(int id)
        {
            return _notificationService.GetNotificationBySenderId(id);
        }

        [HttpGet("receiver/{id}")]
        public List<Notification> GetReceiver(int id)
        {
            return _notificationService.GetNotificationByReceiverId(id);
        }

        [HttpPost]
        public Notification Post([FromBody]Notification notification)
        {
            return _notificationService.CreateNotification(notification);
        }

        [HttpPut]
        public Notification Put([FromBody]Notification notification)
        {
            return _notificationService.UpdateNotification(notification);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _notificationService.DeleteNotification(id);
        }

        [HttpGet]
        public List<Notification> Get()
        {
            return _notificationService.GetAllNotifications();
        }


    }
}