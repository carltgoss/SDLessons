using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_Classes
{
    public class Room
    {
        private double _minLength = 1.0d;
        private double _minWidth = 1.0d;
        private double _minHeight = 1.0d;
        private double _maxLength = 999.0d;
        private double _maxWidth = 999.0d;
        private double _maxHeight = 999.0d;

        private double _length;
        private double _width;
        private double _height;
        public double Length {
            get { return _length; }
            set
            {
                if (value > _minLength && value < _maxLength)
                {
                    _length = value;
                }
                else
                {
                    throw new ArgumentException("Length is outside of valid range");
                }
            } 
        }
        public double Width { get; set; }
        public double Height { get; set; }
        public double GetSurfaceArea()
        {
            return 2 * Length + Height + 2 * Length * Width + 2 * Width * Height;
        }
    }

    
}
