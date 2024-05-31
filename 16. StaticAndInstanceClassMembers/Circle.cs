using System;

namespace StaticAndInstanceClassMembers
{
    public class Circle
    {
        static float _PI = 3.1416F;
        int _Radius;

        public Circle(int Radius)
        {
            this._Radius = Radius;
        }
        public float CalculationArea()
        {
            return Circle._PI * this._Radius * this._Radius;
        }

    }
}
