var specification =
	CompositeVisitor.Leafs.IsPositiveNumber.Create()
	.And(CompositeVisitor.Leafs.IsBetweenNumber.Create(start: 1, end: 100))
	.Or(CompositeVisitor.Leafs.IsNegativeNumber.Create().Not())
	;

var visitor = new CompositeVisitor.Visitors.PersianTranslator();

specification.Accept(visitor);

var text =
	visitor.GetPersianTranslate();

System.Console.WriteLine(text);
