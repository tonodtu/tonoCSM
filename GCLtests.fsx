y:=1; do x>0 -> y:=x*y; x:=x/1 od

if true -> x := 1*1 fi ; skip

do (true | false) -> x := (1+x) od ; skip 

do x = 3 -> y := 1^2 [] (y>3) & (x<2) -> skip od 

if x>=y -> z:=x [] y>x -> z:=y fi

x := (1/2)*(y)

if x<0 -> y:=(-1*z)*z [] x=0 -> y:=0 [] x>0 -> y:=z+z fi

x:= (a-x)*(2-y)/2^3 ; skip 

if (x>=2) | (x<=3) -> z:=x [] (x!=2) || (true && false) -> z:=y fi
