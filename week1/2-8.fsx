let factorial n =
  let rec fact_ n acc =
    if n = 0 then acc
    else fact_ (n-1) (n*acc)
  fact_ n 1
  
let binomial_coefficient n k =
  if k = 0 || k = n then 1
  else factorial n / (factorial k * factorial (n-k))

let result = binomial_coefficient 11 5
printfn "%A" result