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
        public string Foo
        {
            get
            {
                // Use both the lib and the resource for testing!
                return typeof(ClaySharp.Clay).Name + " " + Resource1.Foo;
            }
        }
    }
}
