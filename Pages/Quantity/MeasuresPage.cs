using Abc.Domain.Quantity;
using Abc.Facade.Quantity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Collections.Generic;

namespace Abc.Pages.Quantity
{
    public abstract class MeasuresPage : PageModel
    {
        protected internal readonly IMeasuresRepository db;

        protected internal MeasuresPage(IMeasuresRepository r)
        {
            db = r;
            PageTitle = "Measures";
        }

        [BindProperty]
        public MeasureView MeasureView { get; set; }
        public IList<MeasureView> Items { get; set; }
        public string ItemId => MeasureView.Id;

        public string PageTitle { get; set; } 
        public string PageSubTitle { get; set; } 
        public string CurrentSort { get; set; } = "Current Sort";
        public string CurrentFilter { get; set; } = "Current Filter";
        public int PageIndex { get; set; } = 3;
        public int TotalPages { get; set; } = 10;
    }
}
