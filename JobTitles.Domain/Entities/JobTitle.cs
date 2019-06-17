using System;
using System.Collections.Generic;
using System.Text;

namespace JobTitles.Domain.Entities
{
    class JobTitle
    {
        public int JobTitleId { get; set; }
        public string JobTitleKey { get; set; }
        public string Name { get; set; }
        public int CompanyId { get; set; }
        public string Color { get; set; }
    }
}
