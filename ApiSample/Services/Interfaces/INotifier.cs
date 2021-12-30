using ApiSample.Services.Dto;

namespace ApiSample.Services.Interfaces
{
    public interface INotifier
    {
        bool HasNotification();
        List<NotificationsDto> GetNotifications();
        void Handle(NotificationsDto notificationDto);
    }
}
