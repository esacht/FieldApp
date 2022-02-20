using System;
using System.Collections.Generic;
using System.Text;

namespace FieldApp
{
    class Attempt
    {
        public string Id { get; set; }
        public decimal Distance { get; set; }
        public bool IsFoul { get; set; }
        public decimal Wind { get; set; }
        public bool IsPass { get; set; }
    }
}
