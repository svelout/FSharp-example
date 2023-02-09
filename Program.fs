open System;
open System.Linq;

let input : int = Convert.ToInt32(Console.ReadLine())
let b = 0
let r = new Random()
let a = r.Next(input)
let list = [a..a+a]
for i = 0 to 100 do 
    b = r.Next(0, i)
    list[i] = b
let GetSum (min : int, max : int) : int = min + max
printfn "Sum of Min and Max: %i" (GetSum(list.Min(), list.Max()))



