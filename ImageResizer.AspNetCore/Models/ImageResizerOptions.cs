using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageResizer.AspNetCore.Models
{
    public class ImageResizerOptions
    {
        public Dictionary<string, string> RootMapping { get; set; } = new Dictionary<string, string>();
    }
}
