using Abc.Data.Common;
using Abc.Tests;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Tests.Data.Common
{
    [TestClass]
    public class NamedEntityDataTests : AbstractClassTest<NamedEntityData, UniqueEntityData>
    {
        private class TestClass : NamedEntityData { }

        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new TestClass();
        }

        [TestMethod]
        public void NameTest()
        {
            IsNullableProperty(() => obj.Name, x => obj.Name = x);
        }

        [TestMethod]
        public void CodeTest()
        {
            IsNullableProperty(() => obj.Code, x => obj.Code = x);
        }
    }
}

