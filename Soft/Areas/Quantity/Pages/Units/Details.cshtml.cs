﻿using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abc.Facade.Quantity;
using Abc.Domain.Quantity;
using Abc.Pages.Quantity;

namespace Soft.Areas.Quantity.Pages.Units 
{
    public class DetailsModel : UnitsPage
    {
        public DetailsModel(IUnitsRepository r, IMeasuresRepository m) : base(r, m)
        {
        }

        public async Task<IActionResult> OnGetAsync(string id)
        {
            await getObject(id);

            return Page();
        }
    }
}
