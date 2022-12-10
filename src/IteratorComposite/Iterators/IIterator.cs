namespace IteratorComposite.Iterators;

public interface IIterator<T>
{
	bool HasAny();

	T? Item { get; }

	//void MoveNext();
}
