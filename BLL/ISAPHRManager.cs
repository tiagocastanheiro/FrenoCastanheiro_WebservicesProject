namespace BLL
{
    public interface ISAPHRManager
    {
        string GetUsernameByUID(int UID);
        int GetUIDbyCardID(int CardUID);
    }
}