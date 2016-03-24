/// Problem 1 - Multiples of 3 and 5
///
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
/// The sum of these multiples is 23.
///
/// Find the sum of all the multiples of 3 or 5 below 1000.

// Common functions
let multiplesOf3Or5 = List.filter (fun n -> n % 3 = 0 || n % 5 = 0)
let printAnswer = printfn "The sum of all the multiples of 3 or 5 below 1000 is %d"
let sumList = List.reduce (+)

// Using pipelining
printAnswer ([1..999] |> multiplesOf3Or5 |> sumList)

// Using function composition
let sumOfMultiplesOf3And5 = multiplesOf3Or5 >> sumList
printAnswer (sumOfMultiplesOf3And5 [1..999])
