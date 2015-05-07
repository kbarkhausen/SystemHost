using System;

namespace SystemHost
{
    public interface IClock
    {
        DateTime Now { get; }
    }

    public class Clock : IClock
    {
        public DateTime Now {
            get { return DateTime.Now; }
        }   
    }    
}
