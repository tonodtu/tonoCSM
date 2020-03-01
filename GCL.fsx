// This script implements our interactive calculator

// We need to import a couple of modules, including the generated lexer and parser
#r "C:/Users/blanc/.nuget/packages/fslexyacc.runtime/7.0.6/lib/portable-net45+netcore45+wpa81+wp8+MonoAndroid10+MonoTouch10/FsLexYacc.Runtime.dll"

open Microsoft.FSharp.Text.Lexing
open System

#load "GCLTypesAST.fs"
open GCLTypesAST

#load "GCLParser.fs"
open GCLParser

#load "GCLLexer.fs"
open GCLLexer

// We define the evaluation function recursively, by induction on the structure

let parse input =
    let lexbuf = LexBuffer<char>.FromString input
    let res = GCLParser.start GCLLexer.tokenize lexbuf
    res

// This function asks for an input and returns the string ok if the input is a program accepted by the GCL grammar 
// specified above, or ko otherwise.
let rec compute m =
    if m = 0 then
        printfn "Bye bye"
    else
        printf "Enter a GCL string: "
        try
            // We parse the input string
            let e = parse (Console.ReadLine())
            // and print the result of evaluating it
            printfn "ok"
            compute m
   
        with err -> 
            printfn "ko"
            compute (m-1)

// Start interacting with the user
compute 3
