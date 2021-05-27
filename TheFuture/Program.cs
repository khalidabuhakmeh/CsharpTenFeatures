// const string interpolation
const string s1 = $"abc";
const string s2 = $"{s1}edf";
Console.WriteLine(s2);

// default Tuple deconstruction
var (x, y) = default((int, bool));
Console.WriteLine($"({x}, {y})");

// lambda target typing to Delegate
void Method(Delegate hello) {
    Console.WriteLine(hello.DynamicInvoke());
}

Method(() => "Hello");

// record struct
var person = new Person("Khalid");
Console.WriteLine(person);

record struct Person(string Name);





