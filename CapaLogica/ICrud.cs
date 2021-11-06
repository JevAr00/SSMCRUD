using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    interface ICrud<T>
    {
        void Create(T obj);
        void Read(T obj);
        void Update(T obj);
        void Delete(T obj);
    }
}
