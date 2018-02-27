using System;
namespace SampleWebAPI.Models
{
    public class Message
    {
        public Guid Id { get; set; }
        public string OriginalMessage { get; set; }
        public DateTime CreatedAt { get; set; }

        public Message()
        {
            Id = Guid.NewGuid();
            CreatedAt = DateTime.UtcNow;
        }


    }



}
