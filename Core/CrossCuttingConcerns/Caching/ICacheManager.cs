using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Caching
{
    public interface ICacheManager
    {
        T Get<T>(string key);
        object Get(string key);
        void Add(string key, object value, int duration);
        //object: tum veri tiplerinin base'i, her turlu veri tipi olabilir
        //cache'de ne kadar sure durmasini istedigimiz, durations
        bool IsAdd(string key); //cache'de data var mi kontrol eden metod
        void Remove(string key); //cache'den ucurma metod
        void RemoveByPattern(string pattern); //kelime icerisinde get veya category olanlari bulup ucurma 

    }
}
