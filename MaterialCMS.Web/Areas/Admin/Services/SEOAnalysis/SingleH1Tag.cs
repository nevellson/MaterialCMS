﻿using System.Collections.Generic;
using System.Linq;
using HtmlAgilityPack;
using MaterialCMS.Entities.Documents.Web;
using MaterialCMS.Web.Areas.Admin.Helpers;
using MaterialCMS.Web.Areas.Admin.Models.SEOAnalysis;

namespace MaterialCMS.Web.Areas.Admin.Services.SEOAnalysis
{
    public class SingleH1Tag : BaseSEOAnalysisFacetProvider
    {
        public override IEnumerable<SEOAnalysisFacet> GetFacets(Webpage webpage, HtmlNode document, string analysisTerm)
        {
            var elements = document.GetElementsOfType("h1");
            if (elements.Count() > 1)
                yield return
                    GetFacet("Document contains multiple H1 tags", SEOAnalysisStatus.Error,
                        "There should only be one H1 tag in a document.");
        }
    }
}