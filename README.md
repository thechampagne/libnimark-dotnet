# libnimark-dotnet

[![](https://img.shields.io/github/v/tag/thechampagne/libnimark-dotnet?label=version)](https://github.com/thechampagne/libnimark-dotnet/releases/latest) [![](https://img.shields.io/github/license/thechampagne/libnimark-dotnet)](https://github.com/thechampagne/libnimark-dotnet/blob/main/LICENSE)

.NET binding for **libnimark** a fast markdown converter, based on CommonMark.

### Example

```cs
var spin = new Nimark();
System.Console.Write(spin.Markdown("> Lorem ipsum dolor\nsit amet.\n> - Qui *quodsi iracundia*\n> - aliquando id"));
```

### References
 - [libnimark](https://github.com/thechampagne/libnimark)

### License

This repo is released under the [MIT](https://github.com/thechampagne/libnimark-dotnet/blob/main/LICENSE).
