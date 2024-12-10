# Stack Overflow in F# Recursive Function

This repository demonstrates a common error in F#: stack overflow exceptions caused by non-tail-recursive functions.  The `bug.fs` file contains a recursive function that is not tail-recursive.  The `bugSolution.fs` file shows how to rewrite the function to be tail-recursive, preventing stack overflow issues.

## Bug Description

The `loop` function in `bug.fs` recursively calculates a sequence of numbers.  However, it is not tail-recursive.  This means that each recursive call adds a new stack frame.  For large inputs, this will lead to a stack overflow.

## Solution

The `bugSolution.fs` file shows a tail-recursive version of the `loop` function.  Tail recursion allows the compiler to optimize the function into a loop, avoiding stack overflow issues.

## How to Reproduce

1. Compile and run `bug.fs`. Observe the stack overflow exception when the input is large enough.
2. Compile and run `bugSolution.fs`. Observe that the same large input does not cause a stack overflow.