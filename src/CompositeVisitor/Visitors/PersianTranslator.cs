namespace CompositeVisitor.Visitors;

public class PersianTranslator : object, IVisitor
{
	public PersianTranslator() : base()
	{
		_verb = Text.Bashad;
		_stringBuilder = new();
	}

	private string _verb;

	private System.Text.StringBuilder _stringBuilder;

	public void Visit<T>(Composite.AndSpecification<T> specification)
	{
		_stringBuilder.Append(Text.OpenParenthesis);
		specification.Left.Accept(visitor: this);
		_stringBuilder.Append(" و ");
		specification.Right.Accept(visitor: this);
		_stringBuilder.Append(Text.CloseParenthesis);
	}

	public void Visit<T>(Composite.OrSpecification<T> specification)
	{
		_stringBuilder.Append(Text.OpenParenthesis);
		specification.Left.Accept(visitor: this);
		_stringBuilder.Append(" یا ");
		specification.Right.Accept(visitor: this);
		_stringBuilder.Append(Text.CloseParenthesis);
	}

	public void Visit<T>(Composite.NotSpecification<T> specification)
	{
		_verb = Text.Nabashad;
		specification.Target.Accept(visitor: this);
		_verb = Text.Bashad;
	}


	public void Visit(Leafs.IsZeroNumber specification)
	{
		_stringBuilder.Append("صفر");

		_stringBuilder.Append(_verb);
	}

	public void Visit(Leafs.IsBetweenNumber specification)
	{
		_stringBuilder.Append("بین دو عدد");

		_stringBuilder.Append(_verb);
	}

	public void Visit(Leafs.IsNegativeNumber specification)
	{
		_stringBuilder.Append("منفی");

		_stringBuilder.Append(_verb);
	}

	public void Visit(Leafs.IsPositiveNumber specification)
	{
		_stringBuilder.Append("مثبت");

		_stringBuilder.Append(_verb);
	}

	public string GetPersianTranslate() => $"{_stringBuilder}";
}
