# Mandatory Assignment. Task 1. - Computer Science Modelling

## Files - F#/FsLexYacc

GCLLexer.fsl: The F# lexer for guarded command programs  
GCLParser.fsp: The F# parser for guarded command programs  
GCLTypesAST.fs: F# types for AST of guarded command programs  
GCL.fsx: The F# script for the GCL parser. The script prints "ok" if a valid GCL program has been entered. 

## Instructions for F# #/FSLexYacc

This is instructions assume that you have followed the guidelines to getting started with F# and FSLexYacc and that you are using a terminal on a folder contaning the F# files mentioned above.

Invoke the lexer generator with 
```
mono FsLexYacc.7.0.6/build/fslex.exe GCLLexer.fsl --unicode
```
Invoke the parser generator with 
```
mono FsLexYacc.7.0.6/build/fsyacc.exe GCLrParser.fsp --module GCLrParser
```
Invoke the program with
```
fsharpi GCL.fsx
```

## Tests for the GCL Parser

We wrote a few programs that included all tokens used for testing. These can be found in the file GCLtests.fsx.  
Each one of the lines can be used as the input GCL program for when the GCL.fsx file asks for it.
