using System;
using System.IO;
using MeetupDISample.BaseStorage;

namespace MeetupDISample.LocalStorage
{
    public class LocalFileUpload:IFileUpload
    {
        public void Upload(string fileName, string text)
        {
            File.WriteAllText($"{fileName}.txt",text);
        }
    }
}
