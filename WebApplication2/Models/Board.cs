using System.Collections.Generic;

namespace WebApplication2.Models {
    public class Board {
        public List<Comment> comments = new List<Comment>();
        public Comment comment { get; set; }
    }
}