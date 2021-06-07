¢

nC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Constant\Messages\ErrorMessages.cs
	namespace 	
Business
 
. 
Constant 
. 
Messages $
{ 
public 

static 
class 
ErrorMessages %
{ 
public		 
static		 
readonly		 
string		 %
Unauthorized		& 2
=		3 4
$str		5 ]
;		] ^
public 
static 
readonly 
string %
UserNotFound& 2
=3 4
$str5 K
;K L
public 
static 
readonly 
string %
	PassError& /
=0 1
$str2 @
;@ A
public 
static 
readonly 
string %
UserAlreadyExists& 7
=8 9
$str: x
;x y
public 
static 
readonly 
string %
RegisterError& 3
=4 5
$str6 S
;S T
public 
static 
readonly 
string %
TokenCreateError& 6
=7 8
$str9 O
;O P
} 
} Ò
pC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Constant\Messages\SuccessMessages.cs
	namespace 	
Business
 
. 
Constant 
. 
Messages $
{ 
public 

static 
class 
SuccessMessages '
{ 
public		 
static		 
readonly		 
string		 %
AccessTokenCreated		& 8
=		9 :
$str		; X
;		X Y
public 
static 
readonly 
string %
SuccessfulLogin& 5
=6 7
$str8 O
;O P
public 
static 
readonly 
string %
UserRegistered& 4
=5 6
$str7 N
;N O
public 
static 
readonly 
string %
TokenVerify& 1
=2 3
$str4 F
;F G
} 
} Ä
ÄC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\DependencyResolvers\Autofac\AutofacBusinessModule.cs
	namespace 	
Business
 
. 
DependencyResolvers &
.& '
Autofac' .
{ 
public 

class !
AutofacBusinessModule &
:' (
Module) /
{ 
	protected 
override 
void 
Load  $
($ %
ContainerBuilder% 5
builder6 =
)= >
{ 	
builder 
. 
RegisterType  
<  !
AuthService! ,
>, -
(- .
). /
./ 0
As0 2
<2 3
IAuthService3 ?
>? @
(@ A
)A B
;B C
builder 
. 
RegisterType  
<  !
	JwtHelper! *
>* +
(+ ,
), -
.- .
As. 0
<0 1
ITokenHelper1 =
>= >
(> ?
)? @
;@ A
builder 
. 
RegisterType  
<  !
UserRepository! /
>/ 0
(0 1
)1 2
.2 3
As3 5
<5 6
IUserRepository6 E
>E F
(F G
)G H
;H I
builder 
. 
RegisterType  
<  !
UserService! ,
>, -
(- .
). /
./ 0
As0 2
<2 3
IUserService3 ?
>? @
(@ A
)A B
;B C
builder 
. 
RegisterType  
<  !
RedisService! -
>- .
(. /
)/ 0
.0 1
As1 3
<3 4
IRedisService4 A
>A B
(B C
)C D
;D E
builder 
. 
RegisterType  
<  !
RabbitMqService! 0
>0 1
(1 2
)2 3
.3 4
As4 6
<6 7
IRabbitMqService7 G
>G H
(H I
)I J
;J K
builder   
.   
RegisterType    
<    !
MinioService  ! -
>  - .
(  . /
)  / 0
.  0 1
As  1 3
<  3 4
IMinioService  4 A
>  A B
(  B C
)  C D
;  D E
builder"" 
."" 
RegisterType""  
<""  !

UnitOfWork""! +
>""+ ,
("", -
)""- .
."". /
As""/ 1
<""1 2
IUnitOfWork""2 =
>""= >
(""> ?
)""? @
.""@ A$
InstancePerLifetimeScope""A Y
(""Y Z
)""Z [
;""[ \
}## 	
}$$ 
}%% Ä

fC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Interfaces\IAuthService.cs
	namespace

 	
Business


 
.

 

Interfaces

 
{ 
public 

	interface 
IAuthService !
{ 
IDataResult 
< 
User 
> 
Login 
(  
UserLoginRequestDto  3
userForLoginDto4 C
)C D
;D E
IDataResult 
< 
AccessToken 
>  
CreateAccessToken! 2
(2 3
User3 7
user8 <
)< =
;= >
IResult 

UserExists 
( 
string !
email" '
)' (
;( )
IDataResult&& 
<&& 
User&& 
>&& 
Register&& "
(&&" #"
UserRegisterRequestDto&&# 9
userForRegisterDto&&: L
)&&L M
;&&M N
IDataResult++ 
<++ 
List++ 
<++ 
UserListResponseDto++ ,
>++, -
>++- .
GetUsers++/ 7
(++7 8
long++8 <
userId++= C
)++C D
;++D E
},, 
}-- ∑
fC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Interfaces\IUserService.cs
	namespace 	
Business
 
. 

Interfaces 
{ 
public		 

	interface		 
IUserService		 !
{

 
} 
} πJ
cC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Services\AuthService.cs
	namespace 	
Business
 
. 
Services 
{ 
public 

class 
AuthService 
: 
BaseService *
,* +
IAuthService, 8
{ 
private 
readonly 
ITokenHelper %
_tokenHelper& 2
;2 3
public 
AuthService 
( 
IUnitOfWork &
_unitOfWork' 2
,2 3
IMapper4 ;
_mapper< C
,C D
ITokenHelperE Q
tokenHelperR ]
)] ^
: 
base 
( 
_unitOfWork 
, 
_mapper  '
)' (
{ 	
_tokenHelper 
= 
tokenHelper &
;& '
} 	
public$$ 
IDataResult$$ 
<$$ 
User$$ 
>$$  
Login$$! &
($$& '
UserLoginRequestDto$$' :
userForLoginDto$$; J
)$$J K
{%% 	
ValidationTool&& 
.&& 
Validate&& #
(&&# $
new&&$ '
LoginValidation&&( 7
(&&7 8
)&&8 9
,&&9 :
userForLoginDto&&; J
)&&J K
;&&K L
var(( 
userToCheck(( 
=(( 
_unitOfWork(( )
.(() *
UserRepository((* 8
.((8 9
GetUserByEmail((9 G
(((G H
userForLoginDto((H W
.((W X
Email((X ]
)((] ^
;((^ _
if** 
(** 
userToCheck** 
==** 
null** #
)**# $
{++ 
return,, 
new,, 
ErrorDataResult,, *
<,,* +
User,,+ /
>,,/ 0
(,,0 1
ErrorMessages,,1 >
.,,> ?
UserNotFound,,? K
),,K L
;,,L M
}-- 
if// 
(// 
!// 
HashingHelper// 
.// 
VerifyPasswordHash// 1
(//1 2
userForLoginDto//2 A
.//A B
Password//B J
,//J K
userToCheck//L W
.//W X
PasswordHash//X d
,//d e
userToCheck//f q
.//q r
PasswordSalt//r ~
)//~ 
)	// Ä
{00 
return11 
new11 
ErrorDataResult11 *
<11* +
User11+ /
>11/ 0
(110 1
ErrorMessages111 >
.11> ?
	PassError11? H
)11H I
;11I J
}22 
return44 
new44 
SuccessDataResult44 (
<44( )
User44) -
>44- .
(44. /
userToCheck44/ :
,44: ;
SuccessMessages44< K
.44K L
SuccessfulLogin44L [
)44[ \
;44\ ]
}55 	
public<< 
IDataResult<< 
<<< 
User<< 
><<  
Register<<! )
(<<) *"
UserRegisterRequestDto<<* @
userForRegisterDto<<A S
)<<S T
{== 	
ValidationTool>> 
.>> 
Validate>> #
(>># $
new>>$ '
RegisterValidation>>( :
(>>: ;
)>>; <
,>>< =
userForRegisterDto>>> P
)>>P Q
;>>Q R
byte@@ 
[@@ 
]@@ 
passwordHash@@ 
,@@  
passwordSalt@@! -
;@@- .
HashingHelperBB 
.BB 
CreatePasswordHashBB ,
(BB, -
userForRegisterDtoBB- ?
.BB? @
PasswordBB@ H
,BBH I
outBBJ M
passwordHashBBN Z
,BBZ [
outBB\ _
passwordSaltBB` l
)BBl m
;BBm n
varDD 
userDD 
=DD 
newDD 
UserDD 
{EE 
EmailFF 
=FF 
userForRegisterDtoFF *
.FF* +
EmailFF+ 0
,FF0 1
	FirstNameGG 
=GG 
userForRegisterDtoGG .
.GG. /
	FirstNameGG/ 8
,GG8 9
SurnameHH 
=HH 
userForRegisterDtoHH ,
.HH, -
SurnameHH- 4
,HH4 5
PasswordHashII 
=II 
passwordHashII +
,II+ ,
PasswordSaltJJ 
=JJ 
passwordSaltJJ +
,JJ+ ,
StatusIdKK 
=KK 
(KK 
intKK 
)KK  

EnumStatusKK  *
.KK* +
ActiveKK+ 1
}LL 
;LL 
ifNN 
(NN 
_unitOfWorkNN 
.NN 
UserRepositoryNN *
.NN* +
InsertNN+ 1
(NN1 2
userNN2 6
)NN6 7
<=NN8 :
$numNN; <
)NN< =
{OO 
returnPP 
newPP 
ErrorDataResultPP *
<PP* +
UserPP+ /
>PP/ 0
(PP0 1
ErrorMessagesPP1 >
.PP> ?
RegisterErrorPP? L
)PPL M
;PPM N
}QQ 
returnSS 
newSS 
SuccessDataResultSS (
<SS( )
UserSS) -
>SS- .
(SS. /
userSS/ 3
,SS3 4
SuccessMessagesSS5 D
.SSD E
UserRegisteredSSE S
)SSS T
;SST U
}TT 	
public[[ 
IDataResult[[ 
<[[ 
AccessToken[[ &
>[[& '
CreateAccessToken[[( 9
([[9 :
User[[: >
user[[? C
)[[C D
{\\ 	
if]] 
(]] 
user]] 
is]] 
null]] 
)]] 
{^^ 
return__ 
new__ 
ErrorDataResult__ *
<__* +
AccessToken__+ 6
>__6 7
(__7 8
ErrorMessages__8 E
.__E F
TokenCreateError__F V
)__V W
;__W X
}`` 
varbb 
accessTokenbb 
=bb 
_tokenHelperbb *
.bb* +
CreateTokenbb+ 6
(bb6 7
userbb7 ;
)bb; <
;bb< =
returndd 
newdd 
SuccessDataResultdd (
<dd( )
AccessTokendd) 4
>dd4 5
(dd5 6
accessTokendd6 A
,ddA B
SuccessMessagesddC R
.ddR S
AccessTokenCreatedddS e
)dde f
;ddf g
}ee 	
publicll 
IResultll 

UserExistsll !
(ll! "
stringll" (
emailll) .
)ll. /
{mm 	
ifnn 
(nn 
_unitOfWorknn 
.nn 
UserRepositorynn *
.nn* +
GetUserByEmailnn+ 9
(nn9 :
emailnn: ?
)nn? @
!=nnA C
nullnnD H
)nnH I
{oo 
returnpp 
newpp 
ErrorResultpp &
(pp& '
ErrorMessagespp' 4
.pp4 5
UserAlreadyExistspp5 F
)ppF G
;ppG H
}qq 
returnrr 
newrr 
SuccessResultrr $
(rr$ %
)rr% &
;rr& '
}ss 	
publiczz 
IDataResultzz 
<zz 
Listzz 
<zz  
UserListResponseDtozz  3
>zz3 4
>zz4 5
GetUserszz6 >
(zz> ?
longzz? C
userIdzzD J
)zzJ K
{{{ 	
var|| 
currentUser|| 
=|| 
_unitOfWork|| )
.||) *
UserRepository||* 8
.||8 9
GetById||9 @
(||@ A
userId||A G
)||G H
;||H I
if~~ 
(~~ 
currentUser~~ 
is~~ 
null~~ #
)~~# $
{ 
return
ÄÄ 
new
ÄÄ 
ErrorDataResult
ÄÄ *
<
ÄÄ* +
List
ÄÄ+ /
<
ÄÄ/ 0!
UserListResponseDto
ÄÄ0 C
>
ÄÄC D
>
ÄÄD E
(
ÄÄE F
ErrorMessages
ÄÄF S
.
ÄÄS T
UserNotFound
ÄÄT `
)
ÄÄ` a
;
ÄÄa b
}
ÅÅ 
if
ÉÉ 
(
ÉÉ 
currentUser
ÉÉ 
.
ÉÉ 
UserRole
ÉÉ $
!=
ÉÉ% '
(
ÉÉ( )
int
ÉÉ) ,
)
ÉÉ, -
EnumUserRole
ÉÉ- 9
.
ÉÉ9 :
Admin
ÉÉ: ?
)
ÉÉ? @
{
ÑÑ 
return
ÖÖ 
new
ÖÖ 
ErrorDataResult
ÖÖ *
<
ÖÖ* +
List
ÖÖ+ /
<
ÖÖ/ 0!
UserListResponseDto
ÖÖ0 C
>
ÖÖC D
>
ÖÖD E
(
ÖÖE F
ErrorMessages
ÖÖF S
.
ÖÖS T
Unauthorized
ÖÖT `
)
ÖÖ` a
;
ÖÖa b
}
ÜÜ 
var
àà 
users
àà 
=
àà 
_mapper
àà 
.
àà  
Map
àà  #
<
àà# $
List
àà$ (
<
àà( )!
UserListResponseDto
àà) <
>
àà< =
>
àà= >
(
àà> ?
_unitOfWork
àà? J
.
ààJ K
UserRepository
ààK Y
.
ààY Z
GetAll
ààZ `
(
àà` a
)
ààa b
)
ààb c
;
ààc d
return
ää 
new
ää 
SuccessDataResult
ää (
<
ää( )
List
ää) -
<
ää- .!
UserListResponseDto
ää. A
>
ääA B
>
ääB C
(
ääC D
users
ääD I
)
ääI J
;
ääJ K
}
ãã 	
}
åå 
}çç „
cC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Services\BaseService.cs
	namespace 	
Business
 
. 
Services 
{ 
public		 

class		 
BaseService		 
{

 
public 
readonly 
IUnitOfWork #
_unitOfWork$ /
;/ 0
public 
readonly 
IMapper 
_mapper  '
;' (
public 
BaseService 
( 
IUnitOfWork &

unitOfWork' 1
,1 2
IMapper2 9
mapper: @
)@ A
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
_mapper 
= 
mapper 
; 
} 	
} 
} ÷
cC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\Services\UserService.cs
	namespace 	
Business
 
. 
Services 
{		 
public

 

class

 
UserService

 
:

 
IUserService

 +
{ 
} 
} Õ
sC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\ValidationRules\User\LoginValidation.cs
	namespace 	
Business
 
. 
ValidationRules "
." #
User# '
{ 
public		 

class		 
LoginValidation		  
:		! "
AbstractValidator		# 4
<		4 5
UserLoginRequestDto		5 H
>		H I
{

 
public 
LoginValidation 
( 
)  
{ 	
RuleFor 
( 
x 
=> 
x 
. 
Email  
)  !
.! "
EmailAddress" .
(. /
)/ 0
.0 1
MaximumLength1 >
(> ?
$num? B
)B C
;C D
RuleFor 
( 
x 
=> 
x 
. 
Password #
)# $
.$ %
NotNull% ,
(, -
)- .
;. /
} 	
} 
} á
vC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Business\ValidationRules\User\RegisterValidation.cs
	namespace		 	
Business		
 
.		 
ValidationRules		 "
.		" #
User		# '
{

 
public 

class 
RegisterValidation #
:$ %
AbstractValidator& 7
<7 8"
UserRegisterRequestDto8 N
>N O
{ 
public 
RegisterValidation !
(! "
)" #
{ 	
RuleFor 
( 
x 
=> 
x 
. 
Email  
)  !
.! "
EmailAddress" .
(. /
)/ 0
.0 1
MaximumLength1 >
(> ?
$num? B
)B C
;C D
RuleFor 
( 
x 
=> 
x 
. 
Password #
)# $
.$ %
NotNull% ,
(, -
)- .
;. /
RuleFor 
( 
x 
=> 
x 
. 
	FirstName $
)$ %
.% &
NotNull& -
(- .
). /
;/ 0
RuleFor 
( 
x 
=> 
x 
. 
Surname "
)" #
.# $
NotNull$ +
(+ ,
), -
;- .
} 	
} 
} 