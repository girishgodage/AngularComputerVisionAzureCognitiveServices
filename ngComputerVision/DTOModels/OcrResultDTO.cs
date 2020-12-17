using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ngComputerVision.DTOModels
{
    public class OcrResultDTO
    {
        public string Language { get; set; }
        public string DetectedText { get; set; }
    }
}
