namespace EZTM.Common.Tda.Model
{
    public class SocketData
    {
        public string service { get; set; }
        public long timestamp { get; set; }
        public string command { get; set; }
        public List<Dictionary<string, string>> content { get; set; }
    }
}
