using System;

namespace InterfaceSegregationPrinciple.BadDesign
{
    /// <summary>
    /// Fat interface
    /// </summary>
    public interface IMessage
    {
        void Send();
        string Sender { get; set; }
        string Receiver { get; set; }
        string Subject { get; set; }
        string Text { get; set; }
        byte[] Voice { get; set; }
    }

    public class EmailMessage : IMessage
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Subject { get; set; }
        public string Text { get; set; }
        /// <summary>
        /// Isn't used
        /// </summary>
        public byte[] Voice
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public void Send()
        {
            Console.WriteLine($"Send letter from {this.Sender} to {this.Receiver} ");
            Console.WriteLine($"Send {this.Subject}");
            Console.WriteLine($"Send {this.Text}");
        }
    }

    public class SMSMessage : IMessage
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string Text { get; set; }
        /// <summary>
        /// Isn't used
        /// </summary>
        public string Subject
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        /// <summary>
        /// Isn't used
        /// </summary>
        public byte[] Voice
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public void Send()
        {
            Console.WriteLine($"Send SMS-message from {this.Sender} to {this.Receiver} ");
            Console.WriteLine($"Send {this.Text}");
        }
    }

    public class VoiceMessage : IMessage
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        /// <summary>
        /// Isn't used
        /// </summary>
        public string Subject
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        /// <summary>
        /// Isn't used
        /// </summary>
        public string Text
        {
            get => throw new NotImplementedException();
            set => throw new NotImplementedException();
        }
        public byte[] Voice { get; set; }
        public void Send()
        {
            Console.WriteLine($"Send Voice-message from {this.Sender} to {this.Receiver} ");
            Console.WriteLine($"Send {nameof(this.Voice)}");
        }
    }
}
