var node =
	CompositeWithBuilder.Dom.XmlDocumentBuilder.CreateNode(rootNode: "Root")
	//.WithAttribute("ng-class", "show")
	.WithAttribute(current => current.WithAttribute("ng-class", "show"))
	.AddChild("child1").WithAttribute("attr-1", "1020")
	.AddSibling("child2").WithAttribute("attr-2", "2030")
	.Build();

var output = node?.Render();

System.Console.WriteLine(output);
