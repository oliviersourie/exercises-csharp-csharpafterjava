using System.Drawing;

namespace ClassLib.Models
{
    public interface IComputer
    {
        string Brand { get; set; }
        Color DeviceColor { get; set; }
        bool? PoweredOn { get; }

        void ExecuteProgram(string program);
        void PowerOn();
        string ToString();
    }
}