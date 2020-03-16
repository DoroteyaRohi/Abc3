using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Facade.Quantity;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Soft.Areas.Quantity.Pages.Measures
{
    public class EditModel : MeasuresPage
    {
        public EditModel(IMeasuresRepository r) : base(r)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            MeasureView = MeasureViewFactory.Create(await db.Get(id));

            if (MeasureView == null)
            {
                return NotFound();
            }
            return Page();
        }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            await db.Update(MeasureViewFactory.Create(MeasureView));

            return RedirectToPage("./Index");
        }
    }
}
