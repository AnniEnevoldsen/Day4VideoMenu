using System;
using System.Collections.Generic;
using System.Text;

namespace Day4VideoMenu
{
    class Video
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public static implicit operator List<object>(Video v)
        {
            throw new NotImplementedException();
        }
    }
}
