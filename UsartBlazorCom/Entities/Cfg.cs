using System.IO.Ports;

namespace UsartBlazorCom.Entities; 

public class Cfg {
    public string ProjectFolder { get; set; } = null!;
    public string CurrentProjectName { get; set; } = null!;


    public string PortName { get; set; } = null!;
    public int BaudRate { get; set; }
    public Parity Parity { get; set; }
    public int DataBits { get; set; }
    public StopBits StopBits { get; set; }
    public Handshake Handshake { get; set; }
}