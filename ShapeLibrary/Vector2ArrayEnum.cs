using System.Collections;
using System.Numerics;

namespace ShapeLibrary
{
    public class Vector2ArrayEnum : IEnumerator
    {
        private readonly Vector2[] Vector2Array;
        private int i = -1;

        public Vector2ArrayEnum(Vector2[] vector2Array)
        {
            Vector2Array = vector2Array;
        }

        public object Current
        {
            get
            {
                return Vector2Array[i];
            }
        }

        public bool MoveNext()
        {
            if (i < Vector2Array.Length - 1)
            {
                i++;
                return true;
            }
            else
            {
                return false;
            }
        }

        public void Reset()
        {
            i = -1;
        }
    }
}
