# C# 10 Features

This project works with .NET 6 preview 4 SDK and higher along with the compiler tools.

## Features Shown In Program.cs

- **Global using statements**: Developers can use the `global` keyword in using statements to indicate that the namespace should be imported everywhere in a project. The scope is limited to a project, so referencing between projects in unaffected. In this project, we use a `.usings` file, but that's not a convention, just something I thought was fun and intuitive.
- **Const string interpolation**: You can use string interpolation in constants as long as the values being interpolated are constants as well.
- **Default Type deconstruction**: You can now use the default keyword with Tuples types defined in parenthesis style.
- **Lambda target typing**: Lambda methods are automatically supported by `Delegate` types, reducing the need for casts.
- **Record struct**: Records can now be structs `record struct` to reduce allocations for memory sensitive applications.

## Getting Started

```console
> dotnet restore && dotnet run
```

## License

Do what you like! If you mention or use this, I appreciate a follow on Twitter [@buhakmeh](https://twitter.com).