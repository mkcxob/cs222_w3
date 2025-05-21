/*
Explore inheritance hierarchies by following these steps:
1. Add a new console application named Exercise02 to your workspace.
Implementing Interfaces and Inheriting Classes | 06
[ 221 ]
2. Create a class named Shape with properties named Height, Width, and Area.
3. Add three classes that derive from it—Rectangle, Square, and
Circle—with any additional members you feel are appropriate and that
override and implement the Area property correctly.
4. In Program.cs, in the Main method, add statements to create one
instance of each shape, as shown in the following code:
var r = new Rectangle(3, 4.5);
WriteLine($"Rectangle H: {r.Height}, W: {r.Width}, Area:
{r.Area}");
var s = new Square(5);
WriteLine($"Square H: {s.Height}, W: {s.Width}, Area:
{s.Area}");
var c = new Circle(2.5);
WriteLine($"Circle H: {c.Height}, W: {c.Width}, Area:
{c.Area}");
5. Run the console application and ensure that the result looks like the
following output:
Rectangle H: 3, W: 4.5, Area: 13.5
Square H: 5, W: 5, Area: 25
Circle H: 5, W: 5, Area: 19.6349540849362
*/