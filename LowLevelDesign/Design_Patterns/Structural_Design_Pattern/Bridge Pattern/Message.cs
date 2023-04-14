namespace LowLevelDesign.Design_Patterns.Structural_Design_Pattern.Bridge_Pattern
{
    using System;

    // Implementor interface
    interface IMessageSender
    {
        void SendMessage(string subject, string body);
    }

    // Concrete Implementor 1
    class EmailSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Sending email with subject '{0}' and body '{1}'", subject, body);
        }
    }

    // Concrete Implementor 2
    class SmsSender : IMessageSender
    {
        public void SendMessage(string subject, string body)
        {
            Console.WriteLine("Sending SMS with subject '{0}' and body '{1}'", subject, body);
        }
    }

    // Abstraction
    abstract class Message
    {
        protected IMessageSender _sender;

        public Message(IMessageSender sender)
        {
            _sender = sender;
        }

        public abstract void Send(string subject, string body);
    }

    // Refined Abstraction 1
    class EmailMessage : Message
    {
        public EmailMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string subject, string body)
        {
            _sender.SendMessage(subject, body);
        }
    }

    // Refined Abstraction 2
    class SmsMessage : Message
    {
        public SmsMessage(IMessageSender sender) : base(sender) { }

        public override void Send(string subject, string body)
        {
            _sender.SendMessage(subject, body);
        }
    }

    // Client
    class Program
    {
        static void Main(string[] args)
        {
            // Creating objects
            IMessageSender emailSender = new EmailSender();
            IMessageSender smsSender = new SmsSender();

            Message emailMessage = new EmailMessage(emailSender);
            Message smsMessage = new SmsMessage(smsSender);

            // Sending messages
            emailMessage.Send("Hello from C#", "This is an email message");
            smsMessage.Send("Hello from C#", "This is an SMS message");

            Console.ReadKey();
        }
    }

}
