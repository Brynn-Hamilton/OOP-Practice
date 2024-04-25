
using Interfaces_and_Polymorphism;

var encoder = new VideoEncoder();
encoder.RegisterNotificationChannel(new MailNotificationChannel());
encoder.RegisterNotificationChannel(new SmsNotificationChannel());
encoder.Encode(new Video());

