namespace System
{
    public interface IDateTimeProxy
    {
        DateTime Now { get; }
    }

    public class DateTimeProxy : IDateTimeProxy
    {
        public DateTime Now
        {
            get { return DateTime.Now; }
        }   
    }    
}
