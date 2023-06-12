using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntitiyLayer.Concrete;

namespace BusinessLayer.Concrete
{
    public class NotificationManager : INotificationService
    {
        INotificationDal _notificationdal;

        public NotificationManager(INotificationDal notificationdal)
        {
            _notificationdal = notificationdal;
        }

        public void AddT(Notification t)
        {
            throw new NotImplementedException();
        }

        public void DeleteT(Notification t)
        {
            throw new NotImplementedException();
        }

        public Notification GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Notification> GetList()
        {
            return _notificationdal.GetListAll();
        }

        public void UpdateT(Notification t)
        {
            throw new NotImplementedException();
        }
    }
}
