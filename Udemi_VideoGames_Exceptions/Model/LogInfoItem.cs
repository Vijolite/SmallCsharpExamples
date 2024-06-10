namespace Udemi_VideoGames_Exceptions.Model
{
    public class LogInfoItem
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
        public string ExceptionMessage { get; set; }

        public LogInfoItem(string message, string exceptionMessage)
        {
            Message = message;
            ExceptionMessage = exceptionMessage;
            Date = DateTime.Now;
        }

        public override string ToString()
        {
            return $"[{Date}] {Message} ({ExceptionMessage})";
        }
    }
}
