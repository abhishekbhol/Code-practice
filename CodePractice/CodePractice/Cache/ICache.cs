using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Cache
{
    public interface ICache
    {
        public object Get(string key);

        public void Set(string key, object value);

    }
}
