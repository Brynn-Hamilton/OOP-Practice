using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_and_Polymorphism
{
    public class VideoEncoder
    {
        //private readonly MailService _mailService;
        private readonly IList<INotificationChannel> _notificationChannels;

        public VideoEncoder()
        {
            //_mailService = new MailService();

            // initialize the list
            _notificationChannels = new List<INotificationChannel>();
        }

        public void Encode(Video video)
        {
            // Video encoding logic
            // ...

            //_mailService.Send(new Mail());

            // Iterate over over the notification channels to notify each
            foreach (var channel in _notificationChannels)
            {
                // instance of polymorphic behavior (send message via mail and sms)
                // alternative process is via events/delegates (later topic)
                channel.Send(new Message());
            }
        }

        public void RegisterNotificationChannel(INotificationChannel channel)
        {
            _notificationChannels.Add(channel);
        }
    }
}
