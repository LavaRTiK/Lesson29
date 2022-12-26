using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson29
{
     class Point
    {
        public int X { get; set; }

        public Point Y { get; set; }

        public Point Clone()
        {
            return MemberwiseClone() as Point;
        }
       public override bool Equals(object obj)
        {
            if(obj is Point point)
            {
                return point.X == X;
            }
            else
            {
                return false;
            }
            
        }
        public override int GetHashCode()
        {
            return X;
        }
        public override string ToString()
        {
            return X.ToString();
        }

        public new  Type GetType()
        {
            return typeof(UInt16); 
        }

    }
}
