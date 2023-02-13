open System
open System.Linq
            
let Main() = 
    let count : int = Convert.ToInt32(Console.ReadLine())
    let mutable break = false
    let list : int array = Array.zeroCreate (count+1)
    let mutable a : int = 1
    while not break do 
         if a = count then 
              break <- true
         let mutable num : int = Convert.ToInt32(Console.ReadLine())
         if num % 5 = 0 then do
              list[a] <- num
         a <- a + 1
    done
    printfn "%i" (list.Max())        
               
Main()


