using Abc.Data.Common;
using Abc.Data.Quantity;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using Abc.Tests;

namespace Tests.Data.Quantity
{
    [TestClass]
    public class UnitDataTests : SealedClassTest<UnitData, DefinedEntityData>
    {
        [TestMethod]
        public void MeasureIdTest()
        {
            IsNullableProperty(() => obj.MeasureId, x => obj.MeasureId = x);
        }
    }
}
