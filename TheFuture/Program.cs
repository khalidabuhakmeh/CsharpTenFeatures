// const string interpolation
const string s1 = $"abc";
const string s2 = $"{s1}edf";
WriteLine(s2);

// default Tuple deconstruction
var (x, y) = default((int, bool));
WriteLine($"({x}, {y})");

// lambda target typing to Delegate
void Method(Delegate hello) {
    WriteLine(hello.DynamicInvoke());
}

Method(() => "Hello");

// record struct
var person = new Person("Khalid");
WriteLine(person);

record struct Person(string Name);





