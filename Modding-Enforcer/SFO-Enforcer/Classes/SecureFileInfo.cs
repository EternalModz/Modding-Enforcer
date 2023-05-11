namespace SFO_Enforcer
{
    public class SecureFileInfo
    {
        public SecureFileInfo(string name, string id, string securefileid, string dischashkey, bool isprotected)
        {
            Name = name;
            GameIDs = id.Trim(new[] { '[', ']' }).Split('/');
            SecureFileID = securefileid;
            DiscHashKey = dischashkey;
            Protected = isprotected;
        }

        public string Name { get; set; }
        public string[] GameIDs { get; set; }
        public string SecureFileID { get; set; }
        public string DiscHashKey { get; set; }

        public bool Protected { get; set; }
    }
}