using System;

namespace QTassessment
{
    public class Inspection
    {
        public int id { get; set; }

        public int itemId { get; set; }

        public string dateOfInspection { get; set; } // ($MM/dd/yyyy)

        public string inspectorName { get; set; }

        public string condition { get; set; }
        // Condition Status Arry[6] Enum:[ new, like new, good, used, damaged, needs replacement ]
    }
}
