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
	new CompositeWithBuilder.Sales.SalesAgent(name: "Agent-01");

var newAgents2 =
	new CompositeWithBuilder.Sales.SalesAgent(name: "Agent-02");

var newAgents3 =
	new CompositeWithBuilder.Sales.SalesAgent(name: "Agent-03");

var newGroup1 =
	new CompositeWithBuilder.Sales.SalesGroup(name: "Group-01")
	.AddChild(newAgents1)
	.AddChild(newAgents3);

var newGroup2 =
	new CompositeWithBuilder.Sales.SalesGroup(name: "Group-01")
	.AddChild(newAgents2)
	.AddChild(newGroup1);

newGroup2.PayCommission(amount: 100000);

var groupCredit2 = newGroup2.GetCredit();
var groupCredit1 = newGroup1.GetCredit();
var agentCredit1 = newAgents1.GetCredit();
var agentCredit2 = newAgents2.GetCredit();
var agentCredit3 = newAgents3.GetCredit();

System.Console.WriteLine(groupCredit2);
System.Console.WriteLine(groupCredit1);
System.Console.WriteLine(agentCredit1);
System.Console.WriteLine(agentCredit2);
System.Console.WriteLine(agentCredit3);



var group = CompositeWithBuilder.SalesUnitBuilder.Create("Root")
	.WithGroup(current => current.Named("Group1").WithAgent("Agent X").WithAgent("Agent Y"))
	.WithAgent("AgentZ")
	.Build();

System.Console.WriteLine();
