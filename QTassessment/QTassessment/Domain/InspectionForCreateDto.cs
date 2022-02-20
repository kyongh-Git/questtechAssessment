using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace QTassessment.Domain
{
    public class InspectionForCreateDto
    {
        public int itemId { get; set; }

        public string dateOfInspection { get; set; } // ($MM/dd/yyyy)

        public string inspectorName { get; set; }

        public string condition { get; set; }
    }
}
