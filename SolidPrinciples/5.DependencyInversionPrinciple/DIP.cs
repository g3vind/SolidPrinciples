namespace SolidPrinciples._5.DependencyInversionPrinciple
{
    class DIP
    {
        // High-level modules should not depend on low-level modules.Both should depend on abstractions.

        // Instead of writing code where a class depends directly on another class, we should depend
        // on interfaces or abstract classes.

        public class EmailService
        {
            public string SendEmail()
            {
                return "Email sent successfully!";
            }
        }

        public class Notification
        {
            private readonly EmailService emailService = new EmailService(); // tightly coupled
            public string Notify()
            {
                return emailService.SendEmail();
            }
        }

        // above is not following the dependency inversion principle
        // Notification is dependent on a specific implementation (EmailService)

        // below is solution with dip

        public interface IMessageService
        {
            void Send();
        }

        public class EmailServiceDIP : IMessageService
        {
            public void Send()
            {
                // Logic to send email
            }
        }

        public class NotificationDIP
        {
            private readonly IMessageService messageService;
            public NotificationDIP(IMessageService messageService)
            {
                this.messageService = messageService;
            }

            public void Notify()
            {
                messageService.Send();
            }
        }
    }
}
