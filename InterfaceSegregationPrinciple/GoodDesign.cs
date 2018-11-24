using System;

namespace InterfaceSegregationPrinciple.GoodDesign
{
    /// <summary>
    /// Common interface
    /// </summary>
    public interface IMessage
    {
        void Send();
        string Sender { get; set; }
        string Receiver { get; set; }
    }

    /// <summary>
    /// Interface extends IMessgage interface
    /// </summary>
    public interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }

    /// <summary>
    /// Interface extends ITextMessage interface
    /// </summary>
    public interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }

    /// <summary>
    /// Interface extends IMessage interface
    /// </summary>
    public interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }

    /// <summary>
    /// Class implements methods of IEmailMessage interface.
    /// Interface provides only required method for concrete purpose (SRP)
    /// Class doesn't force to implement needless functionality or mock useless method.
    /// </summary>
    public class EmailMessage : IEmailMessage
    {
        public string Subject { get; set; }
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public void Send()
        {
            Console.WriteLine($"Send letter from {this.Sender} to {this.Receiver} ");
            Console.WriteLine($"Send {this.Subject}");
            Console.WriteLine($"Send {this.Text}");
        }
    }

    /// <summary>
    /// Class implements methods of ITextMessage interface.
    /// Interface provides only required method for concrete purpose (SRP)
    /// Class doesn't force to implement needless functionality or mock useless method.
    /// </summary>
    public class SMSMessage : ITextMessage
    {
        public string Text { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public void Send()
        {
            Console.WriteLine($"Send SMS-message from {this.Sender} to {this.Receiver} ");
            Console.WriteLine($"Send {this.Text}");
        }
    }

    /// <summary>
    /// Class implements methods of IVoiceMessage interface.
    /// Interface provides only required method for concrete purpose (SRP)
    /// Class doesn't force to implement needless functionality or mock useless method.
    /// </summary>
    public class VoiceMessage : IVoiceMessage
    {
        public byte[] Voice { get; set; }
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public void Send()
        {
            Console.WriteLine($"Send Voice-message from {this.Sender} to {this.Receiver} ");
            Console.WriteLine($"Send {nameof(this.Voice)}");
        }
    }
}
