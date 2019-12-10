namespace Iterator
{
    public interface Iterator<TObj>
    {
        TObj Current { get; }

        bool MoveNext();
    }
}
