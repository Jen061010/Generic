using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generic
{
    public class Padre<T>
    {
        //T[] _array;
        public virtual void Save() {
            var type = typeof(T);

            foreach (var property in type.GetProperties()) {
                Console.WriteLine(property.Name);
                
            }
            Console.ReadLine();
        }

    }
}
