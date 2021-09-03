using System;
using System.Collections.Generic;
using System.Text;

namespace CodePractice.Cache
{
    public interface ICache
    {
        public string Get(string key);

        public void Set(string key, string value);

    }
}
