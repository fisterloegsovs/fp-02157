
let fib n =
  let rec fib_ n a b =
    if n = 0 then a
    else fib_ (n-1) b (a+b)
  fib_ n 0 1

let result = [|for i in 0..10 -> fib i|]
printfn "%A" result