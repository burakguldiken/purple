 
nC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\DataAccess\IRepositories\IUserRepository.cs
	namespace 	

DataAccess
 
. 
IRepositories "
{ 
public		 

	interface		 
IUserRepository		 $
:		% &

IDbContext		' 1
<		1 2
User		2 6
>		6 7
{

 
User 
GetUserByEmail 
( 
string "
email# (
)( )
;) *
} 
} ù
\C:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\DataAccess\IUnitOfWork.cs
	namespace 	

DataAccess
 
{ 
public 

	interface 
IUnitOfWork  
:! "
IDisposable# .
{		 
IUserRepository

 
UserRepository

 &
{

' (
get

) ,
;

, -
}

. /
bool 
Commit 
( 
) 
; 
} 
} ‘	
lC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\DataAccess\Repositories\UserRepository.cs
	namespace

 	

DataAccess


 
.

 
Repositories

 !
{ 
public 

class 
UserRepository 
:  !
	DbContext" +
<+ ,
User, 0
>0 1
,1 2
IUserRepository3 B
{ 
public 
UserRepository 
( 
IDbTransaction ,
dbTransaction- :
): ;
:< =
base> B
(B C
dbTransactionC P
)P Q
{ 	
} 	
public 
User 
GetUserByEmail "
(" #
string# )
email* /
)/ 0
{ 	
string 
sql 
= 
$str T
;T U
return 
ExecuteCommand !
(! "
sql" %
,% &
email' ,
), -
.- .
FirstOrDefault. <
(< =
)= >
;> ?
} 	
} 
} ¾%
[C:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\DataAccess\UnitOfWork.cs
	namespace 	

DataAccess
 
{		 
public

 

class

 

UnitOfWork

 
:

 
IUnitOfWork

 )
{ 
private 
IDbTransaction 
_transaction +
;+ ,
private 
IDbConnection 
_connection )
;) *
private 
IUserRepository 
_userRepository  /
;/ 0
private 
bool 
	_disposed 
; 
public 

UnitOfWork 
( 
) 
{ 	
try 
{ 
_connection 
= 
ConnectionHelper .
.. /
MySqlConnection/ >
(> ?
)? @
;@ A
_connection 
. 
Open  
(  !
)! "
;" #
_transaction 
= 
_connection *
.* +
BeginTransaction+ ;
(; <
)< =
;= >
} 
catch 
( 
	Exception 
ex 
)  
{ 
Console 
. 
	WriteLine !
(! "
ex" $
.$ %
Message% ,
), -
;- .
} 
} 	
public 
IUserRepository 
UserRepository -
{   	
get!! 
{!! 
return!! 
_userRepository!! '
??!!( *
(!!+ ,
_userRepository!!, ;
=!!< =
new!!> A
UserRepository!!B P
(!!P Q
_transaction!!Q ]
)!!] ^
)!!^ _
;!!_ `
}!!a b
}"" 	
public$$ 
bool$$ 
Commit$$ 
($$ 
)$$ 
{%% 	
bool&& 
rtn&& 
=&& 
false&& 
;&& 
try'' 
{(( 
_transaction)) 
.)) 
Commit)) #
())# $
)))$ %
;))% &
rtn** 
=** 
true** 
;** 
}++ 
catch,, 
(,, 
	Exception,, 
),, 
{-- 
_transaction.. 
... 
Rollback.. %
(..% &
)..& '
;..' (
throw// 
;// 
}00 
finally11 
{22 
_transaction33 
.33 
Dispose33 $
(33$ %
)33% &
;33& '
_transaction44 
=44 
_connection44 *
.44* +
BeginTransaction44+ ;
(44; <
)44< =
;44= >
ResetRepositories55 !
(55! "
)55" #
;55# $
}66 
return77 
rtn77 
;77 
}88 	
public:: 
void:: 
Dispose:: 
(:: 
):: 
{;; 	
dispose<< 
(<< 
true<< 
)<< 
;<< 
GC== 
.== 
SuppressFinalize== 
(==  
this==  $
)==$ %
;==% &
}>> 	
private@@ 
void@@ 
ResetRepositories@@ &
(@@& '
)@@' (
{AA 	
_userRepositoryBB 
=BB 
nullBB "
;BB" #
}CC 	
privateEE 
voidEE 
disposeEE 
(EE 
boolEE !
	disposingEE" +
)EE+ ,
{FF 	
ifGG 
(GG 
!GG 
	_disposedGG 
)GG 
{HH 
ifII 
(II 
	disposingII 
)II 
{JJ 
ifKK 
(KK 
_transactionKK $
!=KK% '
nullKK( ,
)KK, -
{LL 
_transactionMM $
.MM$ %
DisposeMM% ,
(MM, -
)MM- .
;MM. /
_transactionNN $
=NN% &
nullNN' +
;NN+ ,
}OO 
ifQQ 
(QQ 
_connectionQQ #
!=QQ$ &
nullQQ' +
)QQ+ ,
{RR 
_connectionSS #
.SS# $
DisposeSS$ +
(SS+ ,
)SS, -
;SS- .
_connectionTT #
=TT$ %
nullTT& *
;TT* +
}UU 
}VV 
	_disposedWW 
=WW 
trueWW  
;WW  !
}XX 
}YY 	
~[[ 	

UnitOfWork[[	 
([[ 
)[[ 
{\\ 	
dispose]] 
(]] 
false]] 
)]] 
;]] 
}^^ 	
}__ 
}`` 