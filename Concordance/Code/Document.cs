using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concordance
{
    class Document
    {
        public string name;
        public string author;
        public string fileName;
        public string link;
        public DateTime datePublished;
        public int chapters;

        public Document(string name, string author, string fileName, string link, DateTime datePublished, int chapters)
        {
            this.name = name;
            this.author = author;
            this.fileName = fileName;
            this.link = link;
            this.datePublished = datePublished;
            this.chapters = chapters;
        }
    }

    
}
