using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectVidly.Models
{
    public class Movie : IEnumerable
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}