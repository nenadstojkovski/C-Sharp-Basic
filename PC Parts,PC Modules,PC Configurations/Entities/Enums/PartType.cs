using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public enum PartType
    {
        // Proccessing
        Cpu=1,
        CpuCooler=2,
        // Graphics
        Gpu=3,
        GpuCooler=4,
        // Casing
        Case=5,
        PowerSuply=6,
        // MainBoard
        MotherBoard=7,
        ConnectionCable=8,
        PowerCable=9,
        // Memory
        SSD=10,
        HDD=11,
        RAM=12,
        // Other
        Monitor=13,
        Mouse=14,
        Keyboard=15
    }
}
