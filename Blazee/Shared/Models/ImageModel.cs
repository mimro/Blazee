using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blazee.Shared.Models
{
    public class ImageModel
    {
        public string ImageBase64String { get; set; }

        public string Type { get; set; } = "image/png";

        private string? _source;
        public string? Source { get { return string.IsNullOrEmpty(_source) ? $"data:{Type};base64,{ImageBase64String}" : _source; } set { _source = value; } }


    }
}
