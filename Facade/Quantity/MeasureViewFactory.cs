using Abc.Data.Quantity;
using Abc.Domain.Quantity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Abc.Facade.Quantity
{
    public static class MeasureViewFactory
    {
        public static Measure Create(MeasureView v)
        {
            var d = new MeasureData
            {
                Id = v.Id,
                Name = v.Name,
                Code = v.Code,
                Definition = v.Definition,
                ValidFrom = v.ValidFrom,
                ValidTo = v.ValidTo
            };
            return new Measure(d);
        }

        public static MeasureView Create(Measure o)
        {
            var v = new MeasureView();
            v.Id = o.Data.Id;
            v.Name = o.Data.Name;
            v.Code = o.Data.Code;
            v.Definition = o.Data.Definition;
            v.ValidFrom = o.Data.ValidFrom;
            v.ValidTo = o.Data.ValidTo;
            return v;
        }
    }
}
