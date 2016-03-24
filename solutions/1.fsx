/// Problem 1 - Multiples of 3 and 5
///
/// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9.
/// The sum of these multiples is 23.
///
/// Find the sum of all the multiples of 3 or 5 below 1000.

// Common functions
let divisibleBy3Or5 n = n % 3 = 0 || n % 5 = 0
let sum x y = x + y
let printAnswer ans = printfn "The sum of all the multiples of 3 or 5 below 1000 is %d" ans

// Using pipelining
printAnswer ([1..999] |> List.filter divisibleBy3Or5 |> List.reduce sum)

// Using function composition
let sumOfMultiplesOf3And5 = List.filter divisibleBy3Or5 >> List.reduce sum
printAnswer (sumOfMultiplesOf3And5 [1..999])
