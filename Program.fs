module Program

open Functions

[<EntryPoint>]
let main argv =
    let f: uint64 = rec31 (uint64 "600851475143") (uint64 3)
    printfn "%A" f

    let factors = factorise (uint64 "600851475143")
    printfn "%A" factors[0]

    let factRes = resultFactors (uint64 3) (uint64 "600851475143")
    printfn "%A" factRes

    printfn "Хвостовая рекурсия 28"
    let tail28 = tailRec28 3 1
    printfn "%A" tail28

    printfn "Map-module реализация 28"
    let list1 = [ 1..500 ] |> Seq.map (fun n -> n * 2 + 1)
    let tail28 = module28 list1
    printfn "%A" tail28

    0
