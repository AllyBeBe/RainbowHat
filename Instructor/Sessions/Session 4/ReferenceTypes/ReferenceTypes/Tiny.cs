using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceTypes
{
    class Tiny
    {
        // The "private" access modifier means that nobody outside the Tiny class can look at or change _cuteness.
        private int _cuteness = 77;

        // The "public" access modifier means that anyone can call GetCuteness()
        public int GetCuteness()
        {
            return _cuteness;
        }

        public void BeCuter()
        {
            _cuteness = _cuteness + 10;
        }
    }
}
