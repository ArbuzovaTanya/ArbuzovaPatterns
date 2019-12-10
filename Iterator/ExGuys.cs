using System;
using System.Collections.Generic;
using System.Text;

namespace Iterator
{
    public class ExGuys
    {
        private Boyfriend[] _boyfriends;

        public ExGuys(Boyfriend[] boyfriends)
        {
            _boyfriends = boyfriends;
        }

        public Iterator<Boyfriend> GetIterator()
        {
            return new GuysIterator(this);
        }

        private class GuysIterator : Iterator<Boyfriend>
        {
            private int _index = -1;
            private readonly ExGuys _exGuys;

            public GuysIterator(ExGuys exGuys)
            {
                _exGuys = exGuys;
            }

            public Boyfriend Current => _exGuys._boyfriends[_index];

            public bool MoveNext()
            {
                if (_index < _exGuys._boyfriends.Length - 1)
                {
                    _index++;
                    return true;
                }
                else
                    return false;
            }
        }
    }
}
