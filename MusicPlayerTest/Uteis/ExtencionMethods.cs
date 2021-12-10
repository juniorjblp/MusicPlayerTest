using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicPlayerTest.Uteis
{
    public static class ExtencionMethods
    {
        public static void AddSeveral<T>(this List<T> add, params T[] itens)
        {
            foreach (T item in itens)
            {
                add.Add(item);
            }
        }
    }
}
