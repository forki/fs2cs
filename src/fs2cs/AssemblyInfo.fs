﻿namespace System
open System.Reflection

[<assembly: AssemblyTitleAttribute("fs2cs")>]
[<assembly: AssemblyProductAttribute("fs2cs")>]
[<assembly: AssemblyDescriptionAttribute("F# to C# Transpiler")>]
[<assembly: AssemblyVersionAttribute("0.0.1")>]
[<assembly: AssemblyFileVersionAttribute("0.0.1")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "0.0.1"
