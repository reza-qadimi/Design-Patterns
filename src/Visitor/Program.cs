var board =
	new
	Visitor.DoubleDispatch.Boards.WhiteBoard();

Visitor.DoubleDispatch.Shapes.IShape shape =
	new Visitor.DoubleDispatch.Shapes.Circle();

//board.Draw(shape);

// Multiple Dispatch
//board.Draw(shape as dynamic);

//Double Dispatch
shape.Draw(board);
