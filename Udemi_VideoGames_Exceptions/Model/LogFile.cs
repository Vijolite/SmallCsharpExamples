using Newtonsoft.Json;

namespace Udemi_VideoGames_Exceptions.Model
{
    public class LogFile
    {
        private string _fileName;
        
        public LogFile (string fileName)
        {
            _fileName = fileName;
        }

        public void Append(string info)
        {
            using StreamWriter writefile = File.AppendText(_fileName);
            writefile.WriteLine(info);
            writefile.Close();
        }

    }
}
