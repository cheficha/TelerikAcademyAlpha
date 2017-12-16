using Bytes2you.Validation;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Comment:IComment
    {
        public readonly string content;
        public string author;
        public Comment(string content)
        {
            Guard.WhenArgument(content, "The comment cant be null!!").IsNull().Throw();
            this.content = content;
        }

        public string Content { get { return this.content; } }

        public string Author { get {return  this.author; } set { this.author=value; } }
    }
}
