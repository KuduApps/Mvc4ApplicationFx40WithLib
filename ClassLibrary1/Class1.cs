using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace ClassLibrary1
{
    public class Class1
    {
        [MaxLength]
        public int Foo { get; set; }
    }
}
