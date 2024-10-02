
let fibonacci n =
  let rec fibonacci_ n a b =
    if n = 0 then a
    else fibonacci_ (n-1) b (a+b)
  fibonacci_ n 0 1

let result = [for i in 0..10 -> fibonacci i]
printfn "%A" result