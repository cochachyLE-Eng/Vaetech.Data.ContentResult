using System;
using Vaetech.Data.ContentResult.Enums;

namespace Vaetech.Data.ContentResult.Events
{    
    public delegate void MessageEventHandler<T>(object sender, MessageEventArgs<T> e);
    public class MessageEventArgs<T> : EventArgs
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public MessageIcon Icon { get; set; }
        public MessageEventArgs(string title, string description, MessageIcon icon = MessageIcon.Information)
        {
            Title = title;
            Description = description;
            Icon = icon;
        }
    }    
}
