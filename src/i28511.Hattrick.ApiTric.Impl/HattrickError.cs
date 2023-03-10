using System.Xml.Serialization;

namespace i28511.Hattrick.ApiTrick.Impl;

public class HattrickError
{
    [XmlElement("Error")]
    public string Error { get; set; }

    [XmlElement("ErrorCode")]
    public int ErrorCode { get; set; }

    [XmlElement("ErrorGUID")]
    public string ErrorGuid { get; set; }

    [XmlElement("Server")]
    public string Server { get; set; }

    [XmlElement("Request")]
    public string Request { get; set; }

    [XmlElement("LineNumber")]
    public int LineNumber { get; set; }
}