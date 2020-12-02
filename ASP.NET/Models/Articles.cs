using System;
using System.Collections.Generic;

namespace CIS_420_Project.Models
{
    public partial class Articles
    {
        public string ArticleId { get; set; }
        public string ImagePath { get; set; }
        public string ArticleTitle { get; set; }
        public DateTime? CreationDate { get; set; }
        public DateTime? ExpirationDate { get; set; }
    }
}
