module Lab1

open NUnit.Framework
open Functions

[<SetUp>]
let Setup () = ()

let input3D = uint64 "600851475143"
let input3N = uint64 3
let result3 = 6857UL

let result28 = 669171001

[<Test>]
let Test1 () =
    let f: uint64 = rec31 input3D input3N
    assert (f = result3)

[<Test>]
let Test2 () =
    let factRes = resultFactors input3N input3D
    assert (factRes = result3)

[<Test>]
let Test3 () =
    let fact = factorise input3D
    assert (fact[0] = result3)


[<Test>]
let TestTailRec () =
    let tail28 = tailRec28 3 1
    assert (tail28 = result28)

[<Test>]
let TestModuleRel () =
    let list1 =
        [ for a in 1..500 do
              yield (a * 2 + 1) ]

    let res = module28 list1
    assert (res = result28)
