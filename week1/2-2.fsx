let pow (s : string) (n: int) : string =
  let rec _pow s n acc =
    if n = 0 then acc
    else _pow s (n-1) (s+acc)
  _pow s n ""

let result = (pow "Functional Programming is fun!\n" 3)
printfn "%A" result