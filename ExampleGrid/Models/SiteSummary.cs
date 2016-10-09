using System;
using System.Collections.Generic;

namespace ExampleGrid.Models
{
    public class SiteSummary
    {
        public string Reference { get; set; }
        public string Address { get; set; }
        public string AllocatedSurveyor { get; set; }
        public string CoalArea { get; set; }
        public List<EmailAttachment> SiteEmailAttachment { get; set; }

        public List<DocumentSummary> DocumentSummary { get; set; }
    }

    public class DocumentSummary
    {
        public string DocumentType { get; set; }

        public List<EmailAttachment> SiteEmailAttachment { get; set; } = new List<EmailAttachment>();
    }

    public class EmailAttachment
    {
        public int Id { get; set; }

        public string OriginalFileName { get; set; }
        public string CustomFileName { get; set; }
        public string DocType { get; set; }
        public string ObjectReference { get; set; }

        public string FileType { get; set; }

        public DateTime DateReceived { get; set; }
    }
}
