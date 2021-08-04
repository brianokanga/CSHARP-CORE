namespace Generics
{
    //Generic constrains to a value type
    // Giving value types ability to be null
    public class Nullable<T> where T : struct
    {
        private object _value;

        public Nullable()
        {
            
        }
        public Nullable(T value)
        {
            _value = value;
        }

        public bool HasValue
        {
            get { return _value != null; }
        }

        public T GetValueOrDefault()
        {
            if (HasValue)
                return (T) _value;

            return default(T);
        }
    }
}