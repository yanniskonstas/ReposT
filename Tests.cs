using System.Linq;
using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace ReposT
{
    [TestFixture]
    public class Tests
    {
        IRepository<Storable> _repository = new Repository<Storable>();

        [Test]
        public void TestStore() {            
            Assert.IsInstanceOf(typeof(IEnumerable<Storable>), _repository.All());
        }

        [TestCase(1)]
        public void TestSave(IComparable id) {           
            var item = CreateTestItem(id);
            Assert.IsTrue(_repository.All().Contains(item), "Save method failed. Item not found");                        
        }

        [TestCase(1)]
        public void TestDelete(IComparable id) {            
            var item = CreateTestItem(id);
            _repository.Delete(id);
            Assert.IsTrue(!_repository.All().Contains(item), "Delete method failed. Item found");
        }

        [TestCase(1)]
        public void TestFind(IComparable id) { 
            var item = CreateTestItem(id);
            var itemCreated = _repository.FindById(id);
            Assert.AreEqual(item, itemCreated);            
        }

        IStoreable CreateTestItem(IComparable id) {
            var item = new Storable { Id = id };
            _repository.Save(item);
            return item;
        }



    }
}