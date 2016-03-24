/// Problem 1 - Multiples of 3 and 5
///
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
/// The sum of these multiples is 23.
///
/// Find the sum of all the multiples of 3 or 5 below 1000.

// Using pipelining
let answer = [1..999]
             |> List.filter (fun n -> n % 3 = 0 || n % 5 = 0)
             |> List.reduce (fun x y -> x + y)

printfn "The sum of all the multiples of 3 or 5 below 1000 is %d" answer

// Using function composition
let sumOfMultiplesOf3And5 = List.filter (fun n -> n % 3 = 0 || n % 5 = 0)
                            >> List.reduce (fun x y -> x + y)

printfn "The sum of all the multiples of 3 or 5 below 1000 is %d" (sumOfMultiplesOf3And5 [1..999])
