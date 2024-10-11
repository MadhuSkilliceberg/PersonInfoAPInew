namespace PersonsInfoV2Api.Models
{
    public class UserDevice
    {
        public string userAgent { get; set; }
        public string os { get; set; }
        public string browser { get; set; }
        public string device { get; set; }
        public string os_version { get; set; }
        public string browser_version { get; set; }
        public string deviceType { get; set; }
        public string orientation { get; set; }
    }
}
