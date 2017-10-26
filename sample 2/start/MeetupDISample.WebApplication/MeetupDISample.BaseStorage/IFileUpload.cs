namespace MeetupDISample.BaseStorage
{
    public interface IFileUpload
    {
        void Upload(string fileName, string text);
    }
}