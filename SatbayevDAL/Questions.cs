using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SatbayevDAL
{
    public class QuestionTemplate
    {
        public int id {  get; set; }
        public string author { get; set; }
        public DateTime createDate { get; set; }
        public string questions { get; set; }
        public double mark { get; set; }
        public string level { get; set; }
        public string changeAuthor { get; set; }
        public DateTime changeDate { get; set; }
        public Category Category { get; set; }
        public int CategoryId { get; set; }

        

    }
}
