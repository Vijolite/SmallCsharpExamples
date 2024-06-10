using Newtonsoft.Json;

namespace Udemi_VideoGames_Exceptions.Model
{
    public class Logger
    {
        private string _fileName;
        
        public Logger (string fileName)
        {
            _fileName = fileName;
        }

        public void Log(string info)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            writefile.WriteLine(info);
            writefile.Close();
        }

        public void Log(string info, Exception ex)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            var logInfoItem = new LogInfoItem(info, ex.Message);
            writefile.WriteLine(logInfoItem.ToString());
            writefile.Close();
            UserInterface.UserOutput.PrintInRed(logInfoItem.ToString());
        }

        public void Log(Exception ex)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            var logInfoItem = new LogInfoItem(ex.Message);
            writefile.WriteLine(logInfoItem.ToString());
            writefile.Close();
            UserInterface.UserOutput.PrintInRed(logInfoItem.ToString());
        }

    }
}
