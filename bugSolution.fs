let rec loop x y acc =
    if x > 10 then
        acc
    else
        loop (x + 1) (x + y) (x + y)

printf "%d" (loop 0 1 0) 