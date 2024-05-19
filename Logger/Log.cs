using System.Text;

namespace Logger
{
    public class Log : Ilog
    {
        //lazy loading using lazy  
        // Lazy initialization means that the object is not created until it is needed.
        private static readonly Lazy<Log> _instance
            = new Lazy<Log>(() => new Log());

        private Log()
        {

        }
        public static Log Getnstance()
        {
            //for lazy loading using lazy
            return _instance.Value;
        }

        public void LogException(string message)
        {
            string fileName = string.Format("{0}_{1}.log", "Exception", DateTime.Now.ToShortDateString());
            string logFilePath = string.Format(@"{0}\{1}", AppDomain.CurrentDomain.BaseDirectory, fileName);
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("----------------------------------------");
            sb.AppendLine(DateTime.Now.ToString());
            sb.AppendLine(message);
            using (StreamWriter writer = new StreamWriter(logFilePath, true))
            {
                writer.Write(sb.ToString());
                writer.Flush();
            }
        }
    }
}
