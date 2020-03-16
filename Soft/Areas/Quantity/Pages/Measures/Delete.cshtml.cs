using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Facade.Quantity;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Soft.Areas.Quantity.Pages.Measures
{
    public class DeleteModel : MeasuresPage
    {
        public DeleteModel(IMeasuresRepository r) : base(r)
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

        public async Task<IActionResult> OnPostAsync(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            await db.Delete(id);
            return RedirectToPage("./Index");
        }
    }
}
