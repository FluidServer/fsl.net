# .fsl Parser for .NET

> FluidServer Configuration Parser for .NET

Parse .fsl FluidServer files for your project.
Rust and C# versions are also available: 
- [fsl (Python)](https://github.com/FluidServer/fsl)
- [fsl.rs (Rust)](https://github.com/FluidServer/fsl.rs)

## What is .fsl?
.fsl is a file format similar to .ini for FluidServer, an open-source POS-system. Checkout [the example .fsl file](https://github.com/FluidServer/fsl/example.fsl).

# Usage Example
Import `FluidServer.fsl` and then parse your `String`:
```csharp
using System;
using fsl.net;
using System.Text.Json; // for printing

namespace MyProject
{
    internal class Program
    {
        static void Main()
        {
            var Parser = new fsl.net.Parser();

            var parsed = Parser.Parse(
                "FluidServer .fsl File, 1.0\nTest=abc\n;Test2=abc\n:Test3=abc"
            );

            Console.WriteLine(
                "Dictionary = " 
                + JsonSerializer.Serialize(parsed)
            ); // Dictionary = {"Version":"1","Test":"abc"}
        }
    }
}

```

# Meta
Built by clue <<lost@biitle.nl>>.

Distributed under the MIT license.

# Contributing
1. Fork the repo (https://github.com/FluidServer/fsl.net)
2. Create your feature branch (`git checkout -b feature/yournewfeature`)
3. Commit your changes (`git commit -am 'Add some change'`)
4. Push to the branch (`git push origin feature/yournewfeature`)
5. Create a new pull request

`SPDX-License-Identifier: MIT or Apache-2.0`