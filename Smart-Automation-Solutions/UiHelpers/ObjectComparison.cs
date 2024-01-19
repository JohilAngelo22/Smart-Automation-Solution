namespace UiHelpers
{
    public class ObjectComparison<T>
    {
        public bool AreEqual(T obj1, T obj2)
        {
            if (obj1 == null && obj2 == null)
                return true;

            if (obj1 == null || obj2 == null)
                return false;

            return obj1.Equals(obj2);
        }
    }
}
