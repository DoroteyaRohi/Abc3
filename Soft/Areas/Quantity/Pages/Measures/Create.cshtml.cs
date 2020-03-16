using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Facade.Quantity;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Soft.Areas.Quantity.Pages.Measures
{
    public class CreateModel : MeasuresPage
    {
        public CreateModel(IMeasuresRepository r) : base(r)
        {
        }

        public IActionResult OnGet => Page();

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await db.Add(MeasureViewFactory.Create(MeasureView));

            return RedirectToPage("./Index");
        }
    }
}
