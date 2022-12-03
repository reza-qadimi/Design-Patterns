using CompositeWithBuilder.Sales;

var node =
	CompositeWithBuilder.Dom.XmlDocumentBuilder.CreateNode(rootNode: "Root")
	//.WithAttribute("ng-class", "show")
	.WithAttribute(current => current.WithAttribute("ng-class", "show"))
	.AddChild("child1").WithAttribute("attr-1", "1020")
	.AddSibling("child2").WithAttribute("attr-2", "2030")
	.Build();

var output = node?.Render();

System.Console.WriteLine(output);

var newAgents1 =
	new SalesAgent();

var newAgents2 =
	new SalesAgent();

var newAgents3 =
	new SalesAgent();

var newGroup1 =
	new SalesGroup()
	.AddUnit(newAgents1)
	.AddUnit(newAgents3);

var newGroup2 =
	new SalesGroup()
	.AddUnit(newAgents2)
	.AddUnit(newGroup1);

newGroup2.PayCommission(amount: 100000);

var groupCredit2 = newGroup2.GetCredit();
var groupCredit1 = newGroup1.GetCredit();
var agentCredit1 = newAgents1.GetCredit();
var agentCredit2 = newAgents2.GetCredit();
var agentCredit3 = newAgents3.GetCredit();

Console.WriteLine(groupCredit2);
Console.WriteLine(groupCredit1);
Console.WriteLine(agentCredit1);
Console.WriteLine(agentCredit2);
Console.WriteLine(agentCredit3);
