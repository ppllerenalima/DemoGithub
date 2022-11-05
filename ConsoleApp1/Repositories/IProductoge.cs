using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Repositories
{
    public interface IProductoge
    {
        public bool Update();

        public List<IEnumerable> getAll();
    }
}
