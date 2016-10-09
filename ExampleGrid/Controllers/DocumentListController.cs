using ExampleGrid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ExampleGrid.Controllers
{
    public class DocumentListController : Controller
    {
        public SiteSummary Sites;

        // GET: DocumentList
        public ActionResult Index()
        {
            Sites = new SiteSummary
            {
                Address = "Somewhere",
                AllocatedSurveyor = "ABC123",
                Reference = "THIS/SITE"
            };

            Sites.SiteEmailAttachment = new List<EmailAttachment>();

            var ext = new List<string> { "pdf", "xls", "txt", "doc", "png" };

            Sites.DocumentSummary = new List<DocumentSummary>();
            //Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Not Indexed" });
            //Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Plans" });
            //Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Drawings" });
            //Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Spec" });

            Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Group 1", DocumentId = "Group1" });
            Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Group 2", DocumentId = "Group2" });
            Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Group 3", DocumentId = "Group3" });
            Sites.DocumentSummary.Add(new DocumentSummary { DocumentType = "Group 4", DocumentId = "Group4" });

            for (int i = 0; i < 20; i ++)
            {
                Random rnd = new Random(i);
                int extensionIndex = rnd.Next(0, 5);
                var extension = ext[extensionIndex];

                var documentIndex = rnd.Next(0, 4);
                var documentType = Sites.DocumentSummary[documentIndex].DocumentType;

                var em = new EmailAttachment
                {
                    Id = 1 + i,
                    OriginalFileName = string.Format("test{0}.{1}", i + 1, extension),
                    CustomFileName = null,
                    DocType = documentType,
                    DateReceived = new DateTime(2016, 10, 7, 13, i, 0),
                    FileType = extension,
                    ObjectReference = "THIS/SITE"
                };

                Sites.SiteEmailAttachment.Add(em);
            }

            foreach (var attachment in Sites.SiteEmailAttachment)
            {
                var documentType = attachment.DocType ?? "Not Indexed";
                var documentSummary = Sites.DocumentSummary.FirstOrDefault(d => d.DocumentType.Equals(documentType, StringComparison.InvariantCultureIgnoreCase));
                if (documentSummary == null)
                {
                    documentSummary = new DocumentSummary
                    {
                        DocumentType = documentType,
                    };
                    Sites.DocumentSummary.Add(documentSummary);
                }
                documentSummary.SiteEmailAttachment.Add(attachment);
            }

            return View(Sites);
        }

        public ActionResult MoveDocument(string targetId, string sourceId)
        {
            var documentIndex = targetId.Replace("Group", "").Replace("_Folder", "").Replace("_", "");
            var attachmentIndex = sourceId.Replace("attachment", "");
            
            return new EmptyResult();
        }
    }
}