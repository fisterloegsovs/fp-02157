let multiplicity x xs =
  List.filter (fun y -> y = x) xs |> List.length

let result = [1;2;3;4;1;2;3;1;2;1] |> multiplicity 1
printfn "%A" result