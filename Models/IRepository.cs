using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BuildPipeEditDockerProject.Models
{
    public interface IRepository<t>
    {
        public IEnumerable<t> GetItems();
        public t GetItemById(int id);
        public void AddItem(t t);
    }
}
