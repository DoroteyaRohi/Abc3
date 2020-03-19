using Abc.Aids;
using Abc.Data.Quantity;
using Abc.Domain.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Abc.Tests.Domain.Common
{
    [TestClass]
    public class EntityTests : AbstractClassTests<Entity<MeasureData>, object>
    {
        private class testClass : Entity<MeasureData>
        {
            public testClass(MeasureData d = null) : base(d) { }
        }
        [TestInitialize]
        public override void TestInitialize()
        {
            base.TestInitialize();
            obj = new testClass();
        }

        [TestMethod]
        public void DataTest()//можно ли че то дать конструктору 
        {
            var d = GetRandom.Object<MeasureData>();
            Assert.AreNotSame(d, obj.Data);
            obj = new testClass(d);
            Assert.AreSame(d,obj.Data);
        }

        [TestMethod]
        public void DataIsNullTest() //дать данные
        {
            var d = GetRandom.Object<MeasureData>();
            Assert.IsNotNull(obj.Data);
            obj.Data = d;
            Assert.AreSame(d, obj.Data);
        }
        [TestMethod]
        public void CanSetNullDataTest() // дать значения
        {
            Assert.IsNotNull(obj.Data);
            obj.Data = null;
            Assert.IsNull(obj.Data); 
        }
    }
}
