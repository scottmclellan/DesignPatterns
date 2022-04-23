using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Builder
{
    public class House
    {
        public string Name { get;  set; }
        public int NumberOfDoors { get; set; }

        public int NumberOfWindows { get; set; }
        public int NumberOfGarageDoors { get; set; }
        public string ExteriorMaterial { get; set; }
        public string RoofMaterial { get; set; }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"\n************************");
            sb.AppendLine($"House Type: {Name}");
            sb.AppendLine($"************************");
            sb.AppendLine($"Number of Doors: {NumberOfDoors}");
            sb.AppendLine($"Number of Windows: {NumberOfWindows}");

            if (NumberOfGarageDoors > 0)
                sb.AppendLine($"Has a {NumberOfGarageDoors} car garage");
            else
                sb.AppendLine("Has no garage");

            sb.AppendLine($"Exterior Material: {ExteriorMaterial}");
            sb.AppendLine($"Roof Material: {RoofMaterial}");

            return sb.ToString();            
        }

    }
}
