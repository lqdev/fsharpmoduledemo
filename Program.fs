// Learn more about F# at http://fsharp.org

open System
open Math

[<EntryPoint>]
let main argv =
    printfn "Add: %i" (add 1 2)
    printfn "Subtract: %i" (subtract 1 2)
    printfn "Multiply: %i" (multiply 1 2)
    printfn "Divide: %i" (divide 4 2)
    0 // return an integer exit code
