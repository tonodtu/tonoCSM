// This file implements a module where we define a data type "expr"
// to store represent arithmetic expressions


//Do branches? difference between else and implication?
//How to (synactically) separate two branches?
//How to end a node?

module GCLTypesAST

type expr =
  | Num of float
  | Var of string
  | TimesExpr of (expr * expr)
  | DivExpr of (expr * expr)
  | PlusExpr of (expr * expr)
  | MinusExpr of (expr * expr)
  | PowExpr of (expr * expr)
  | UPlusExpr of expr
  | UMinusExpr of expr
  | Par of expr

type booleanexpr =
    | Boolean of bool
    | And of (booleanexpr * booleanexpr)
    | Or of (booleanexpr * booleanexpr)
    | Dand of (booleanexpr * booleanexpr)
    | Dor of (booleanexpr * booleanexpr)
    | Not of booleanexpr
    | Eq of (expr * expr)
    | Neq of (expr * expr)
    | Greater of (expr * expr)
    | Less of (expr * expr)
    | Geq of (expr * expr)
    | Leq of (expr * expr)
    | BPar of booleanexpr

type commands =
    | If of guardedcommands
    | Do of guardedcommands
    | Skip
    | Assign of (string * expr)  
    | Semi of (commands * commands)
and guardedcommands =
    | Conditional of (booleanexpr * commands)
    | Sqr of (guardedcommands * guardedcommands)