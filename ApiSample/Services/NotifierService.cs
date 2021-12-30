using ApiSample.Services.Dto;
using ApiSample.Services.Interfaces;

namespace ApiSample.Services
{
    public class NotifierService : INotifier
    {
        private readonly List<NotificationsDto> NotificationDto;

        public NotifierService()
        {
            NotificationDto = new List<NotificationsDto>();
        }

        public List<NotificationsDto> GetNotifications()
        {
            return NotificationDto;
        }

        public void Handle(NotificationsDto notificationDto)
        {
            NotificationDto.Add(notificationDto);
        }

        public bool HasNotification()
        {
            return NotificationDto.Any();
        }
    }
}
