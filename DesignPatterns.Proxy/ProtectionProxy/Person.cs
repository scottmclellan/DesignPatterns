using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatterns.Proxy
{
    public class Person : IPerson
    {
        private int _ratingCount = 0;
        private int _geekRating = 0;

        public virtual string Name { get ; set ; }
        public virtual string Gender { get ; set ; }
        public virtual string Interests { get ; set ; }
        public virtual int GeekRating { 
            get
            {
                return _ratingCount == 0 ? 0 : _geekRating / _ratingCount;    
            } 
            set
            {
                _geekRating += value;
                _ratingCount++;
            } 
        }
    }
}
