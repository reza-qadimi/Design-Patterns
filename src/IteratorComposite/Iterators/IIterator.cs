namespace IteratorComposite.Iterators;

public interface IIterator<T>
{
	bool HasAny();

	void MoveNext();

	T? Item { get; }
}
