let mutable x = 0
let mutable y = 1

let rec loop x y =
    if x > 10 then
        y
    else
        loop (x + 1) (x + y)

printf "%d" (loop x y)