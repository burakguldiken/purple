‡*
gC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Purple\Controllers\AuthController.cs
	namespace 	
Purple
 
. 
Controllers 
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
[ 

TypeFilter 
( 
typeof 
( $
TokenValidationAttribute /
)/ 0
)0 1
]1 2
public 

class 
AuthController 
:  !
BaseController" 0
{ 
private 
readonly 
IAuthService %
_authService& 2
;2 3
public 
AuthController 
( 
IUnitOfWork )
_unitOfWork* 5
,5 6
IAuthService7 C
authServiceD O
)O P
: 
base 
( 
_unitOfWork 
) 
{ 	
_authService 
= 
authService &
;& '
} 	
[$$ 	
AllowAnonymous$$	 
]$$ 
[%% 	
HttpPost%%	 
(%% 
$str%% 
)%% 
]%% 
public&& 
IActionResult&& 
Login&& "
(&&" #
UserLoginRequestDto&&# 6
request&&7 >
)&&> ?
{'' 	
var(( 
userToLogin(( 
=(( 
_authService(( *
.((* +
Login((+ 0
(((0 1
request((1 8
)((8 9
;((9 :
if** 
(** 
!** 
userToLogin** 
.** 
Success** $
)**$ %
{++ 
return,, 

BadRequest,, !
(,,! "
userToLogin,," -
.,,- .
Message,,. 5
),,5 6
;,,6 7
}-- 
var// 
result// 
=// 
_authService// %
.//% &
CreateAccessToken//& 7
(//7 8
userToLogin//8 C
.//C D
Data//D H
)//H I
;//I J
if11 
(11 
!11 
result11 
.11 
Success11 
)11  
{22 
return33 

BadRequest33 !
(33! "
result33" (
.33( )
Message33) 0
)330 1
;331 2
}44 
_unitOfWork66 
.66 
Commit66 
(66 
)66  
;66  !
return88 
Ok88 
(88 
result88 
.88 
Data88 !
)88! "
;88" #
}99 	
[@@ 	
AllowAnonymous@@	 
]@@ 
[AA 	
HttpPostAA	 
(AA 
$strAA 
)AA 
]AA 
publicBB 
ActionResultBB 
RegisterBB $
(BB$ %"
UserRegisterRequestDtoBB% ;
userForRegisterDtoBB< N
)BBN O
{CC 	
varDD 

userExistsDD 
=DD 
_authServiceDD )
.DD) *

UserExistsDD* 4
(DD4 5
userForRegisterDtoDD5 G
.DDG H
EmailDDH M
)DDM N
;DDN O
ifFF 
(FF 
!FF 

userExistsFF 
.FF 
SuccessFF #
)FF# $
{GG 
returnHH 

BadRequestHH !
(HH! "

userExistsHH" ,
.HH, -
MessageHH- 4
)HH4 5
;HH5 6
}II 
varKK 
registerResultKK 
=KK  
_authServiceKK! -
.KK- .
RegisterKK. 6
(KK6 7
userForRegisterDtoKK7 I
)KKI J
;KKJ K
varMM 
resultMM 
=MM 
_authServiceMM %
.MM% &
CreateAccessTokenMM& 7
(MM7 8
registerResultMM8 F
.MMF G
DataMMG K
)MMK L
;MML M
ifOO 
(OO 
!OO 
resultOO 
.OO 
SuccessOO 
)OO  
{PP 
returnQQ 

BadRequestQQ !
(QQ! "
resultQQ" (
.QQ( )
MessageQQ) 0
)QQ0 1
;QQ1 2
}RR 
_unitOfWorkTT 
.TT 
CommitTT 
(TT 
)TT  
;TT  !
returnVV 
OkVV 
(VV 
resultVV 
.VV 
DataVV !
)VV! "
;VV" #
}WW 	
[]] 	
HttpGet]]	 
(]] 
$str]] 
)]] 
]]] 
public^^ 
IActionResult^^ 
GetUsers^^ %
(^^% &
)^^& '
{__ 	
var`` 
users`` 
=`` 
_authService`` %
.``% &
GetUsers``& .
(``. /
	GetUserId``/ 8
(``8 9
)``9 :
)``: ;
;``; <
ifbb 
(bb 
!bb 
usersbb 
.bb 
Successbb 
)bb 
{cc 
returndd 

BadRequestdd !
(dd! "
usersdd" '
.dd' (
Messagedd( /
)dd/ 0
;dd0 1
}ee 
returngg 
Okgg 
(gg 
usersgg 
.gg 
Datagg  
)gg  !
;gg! "
}hh 	
}ii 
}jj ß

gC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Purple\Controllers\BaseController.cs
	namespace

 	
Purple


 
.

 
Controllers

 
{ 
[ 
Route 

(
 
$str 
) 
] 
[ 
ApiController 
] 
public 

class 
BaseController 
:  !

Controller" ,
{ 
public 
IUnitOfWork 
_unitOfWork &
;& '
public 
BaseController 
( 
IUnitOfWork )

unitOfWork* 4
)4 5
{ 	
_unitOfWork 
= 

unitOfWork $
;$ %
} 	
[ 	
	NonAction	 
] 
public 
long 
	GetUserId 
( 
) 
{ 	
return 
Convert 
. 
ToInt64 "
(" #
HttpContext# .
.. /
User/ 3
.3 4
Claims4 :
.: ;
FirstOrDefault; I
(I J
)J K
.K L
ValueL Q
)Q R
;R S
} 	
} 
} ù'
mC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Purple\Filters\TokenValidationAttribute.cs
	namespace 	
Purple
 
. 
Filters 
{ 
public 

class $
TokenValidationAttribute )
:* +
	Attribute, 5
,5 6
IActionFilter7 D
{ 
public 
void 
OnActionExecuted $
($ %!
ActionExecutedContext% :
context; B
)B C
{ 	
Console 
. 
	WriteLine 
( 
SuccessMessages -
.- .
TokenVerify. 9
)9 :
;: ;
} 	
public   
async   
void   
OnActionExecuting   +
(  + ,"
ActionExecutingContext  , B
context  C J
)  J K
{!! 	 
AllowAnonymousFilter""   
allowAnonymousFilter""! 5
=""6 7
(""8 9 
AllowAnonymousFilter""9 M
)""M N
context""N U
.""U V
Filters""V ]
.""] ^
FirstOrDefault""^ l
(""l m
x""m n
=>""o q
x""r s
.""s t
GetType""t {
(""{ |
)""| }
==	""~ Ä
typeof
""Å á
(
""á à"
AllowAnonymousFilter
""à ú
)
""ú ù
)
""ù û
;
""û ü
if$$ 
($$  
allowAnonymousFilter$$ $
!=$$% '
null$$( ,
)$$, -
{%% 
return&& 
;&& 
}'' 
StringValues)) 
bearer)) 
=))  !
new))" %
StringValues))& 2
())2 3
)))3 4
;))4 5
try++ 
{,, 
var-- 
userId-- 
=-- 
Convert-- $
.--$ %
ToInt32--% ,
(--, -
context--- 4
.--4 5
HttpContext--5 @
.--@ A
User--A E
.--E F
Claims--F L
.--L M
FirstOrDefault--M [
(--[ \
)--\ ]
.--] ^
Value--^ c
)--c d
;--d e
context.. 
... 
HttpContext.. #
...# $
Request..$ +
...+ ,
Headers.., 3
...3 4
TryGetValue..4 ?
(..? @
$str..@ O
,..O P
out..Q T
bearer..U [
)..[ \
;..\ ]
if// 
(// 
userId// 
<=// 
$num// 
||//  "
bearer//# )
.//) *
ToString//* 2
(//2 3
)//3 4
.//4 5
Split//5 :
(//: ;
$char//; >
)//> ?
[//? @
$num//@ A
]//A B
==//C E
null//F J
)//J K
{00 
await11 
UnAuthorized11 &
(11& '
context11' .
)11. /
;11/ 0
return22 
;22 
}33 
}44 
catch55 
(55 
	Exception55 
)55 
{66 
await77 
UnAuthorized77 "
(77" #
context77# *
)77* +
;77+ ,
return88 
;88 
}99 
if;; 
(;;  
allowAnonymousFilter;; $
==;;% '
null;;( ,
);;, -
{<< 
context== 
.== 
HttpContext== #
.==# $
Request==$ +
.==+ ,
Headers==, 3
.==3 4
TryGetValue==4 ?
(==? @
$str==@ O
,==O P
out==Q T
bearer==U [
)==[ \
;==\ ]
if?? 
(?? 
bearer?? 
==?? 
$str?? "
||??# %
String??& ,
.??, -
IsNullOrEmpty??- :
(??: ;
bearer??; A
)??A B
)??B C
{@@ 
awaitAA 
UnAuthorizedAA &
(AA& '
contextAA' .
)AA. /
;AA/ 0
}BB 
}CC 
}DD 	
publicFF 
asyncFF 
TaskFF 
UnAuthorizedFF &
(FF& '"
ActionExecutingContextFF' =
contextFF> E
)FFE F
{GG 	
ErrorResultHH 
errorResultHH #
=HH$ %
newHH& )
ErrorResultHH* 5
(HH5 6
)HH6 7
;HH7 8
errorResultII 
.II 
MessageII 
=II  !
ErrorMessagesII" /
.II/ 0
UnauthorizedII0 <
;II< =
contextJJ 
.JJ 
ResultJJ 
=JJ 
newJJ  $
UnauthorizedObjectResultJJ! 9
(JJ9 :
errorResultJJ: E
)JJE F
;JJF G
awaitKK 
contextKK 
.KK 
ResultKK  
.KK  !
ExecuteResultAsyncKK! 3
(KK3 4
contextKK4 ;
)KK; <
;KK< =
}LL 	
}MM 
}NN ÿ
lC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Purple\Mapper\AutoMapper\MapperProfile.cs
	namespace

 	
Purple


 
.

 
	Utilities

 
.

 
Mapper

 !
.

! "

AutoMapper

" ,
{ 
public 

class 
MapperProfile 
:  
Profile! (
{ 
public 
MapperProfile 
( 
) 
{ 	
	CreateMap 
< 
User 
, 
UserLoginRequestDto /
>/ 0
(0 1
)1 2
;2 3
	CreateMap 
< 
User 
, 
UserListResponseDto /
>/ 0
(0 1
)1 2
;2 3
} 	
} 
} ‹
TC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Purple\Program.cs
	namespace 	
Purple
 
{ 
public 

class 
Program 
{ 
public 
static 
void 
Main 
(  
string  &
[& '
]' (
args) -
)- .
{ 	
CreateHostBuilder 
( 
args "
)" #
.# $
Build$ )
() *
)* +
.+ ,
Run, /
(/ 0
)0 1
;1 2
} 	
public 
static 
IHostBuilder "
CreateHostBuilder# 4
(4 5
string5 ;
[; <
]< =
args> B
)B C
=>D F
Host 
.  
CreateDefaultBuilder %
(% &
args& *
)* +
. %
UseServiceProviderFactory *
(* +
new+ .)
AutofacServiceProviderFactory/ L
(L M
)M N
)N O
. 
ConfigureContainer #
<# $
ContainerBuilder$ 4
>4 5
(5 6
builder6 =
=>> @
{ 
builder 
. 
RegisterModule *
(* +
new+ .!
AutofacBusinessModule/ D
(D E
)E F
)F G
;G H
} 
) 
. $
ConfigureWebHostDefaults )
() *

webBuilder* 4
=>5 7
{ 

webBuilder 
. 
UseUrls &
(& '
$str' 6
)6 7
;7 8

webBuilder   
.   

UseStartup   )
<  ) *
Startup  * 1
>  1 2
(  2 3
)  3 4
;  4 5
}!! 
)!! 
;!! 
}"" 
}## ûG
TC:\Users\burak\Desktop\Burak Template\SourceTrreStarterKit\backend\Purple\Startup.cs
	namespace 	
Purple
 
{ 
public 

class 
Startup 
{ 
public 
IConfiguration 
Configuration +
{, -
get. 1
;1 2
}3 4
public 
Startup 
( 
IConfiguration %
configuration& 3
)3 4
{   	
Configuration!! 
=!! 
configuration!! )
;!!) *
}"" 	
public$$ 
void$$ 
ConfigureServices$$ %
($$% &
IServiceCollection$$& 8
services$$9 A
)$$A B
{%% 	
services&& 
.&& 
	Configure&& 
<&& #
ForwardedHeadersOptions&& 6
>&&6 7
(&&7 8
options&&8 ?
=>&&@ B
{'' 
options(( 
.(( 
ForwardedHeaders(( (
=(() *
ForwardedHeaders((+ ;
.((; <
XForwardedFor((< I
|((J K
ForwardedHeaders((L \
.((\ ]
XForwardedProto((] l
;((l m
})) 
))) 
;)) 
services++ 
.++ 
AddCors++ 
(++ 
)++ 
;++ 
services,, 
.,, 
AddControllers,, #
(,,# $
),,$ %
.-- 
AddNewtonsoftJson-- 
(-- 
options-- &
=>--' )
{.. 
options// 
.// 
SerializerSettings// *
.//* +
ContractResolver//+ ;
=//< =
new//> A#
DefaultContractResolver//B Y
(//Y Z
)//Z [
;//[ \
}00 
)00 
;00 
services11 
.11 
AddMvc11 
(11 
options11 #
=>11$ &
{22 
options33 
.33 !
EnableEndpointRouting33 -
=33. /
false330 5
;335 6
}44 
)44 
;44 
services66 
.66 "
AddDependencyResolvers66 +
(66+ ,
new66, /
ICoreModule660 ;
[66; <
]66< =
{66> ?
new77 

CoreModule77 
(77 
)77  
}88 
)88 
;88 
services:: 
.:: 
AddAutoMapper:: "
(::" #
typeof::# )
(::) *
Startup::* 1
)::1 2
)::2 3
;::3 4
services;; 
.;; 
AddRateLimiting;; $
(;;$ %
);;% &
;;;& '
services>> 
.>> 
AddSwaggerGen>> "
(>>" #
c>># $
=>>>% '
{?? 
c@@ 
.@@ 

SwaggerDoc@@ 
(@@ 
$str@@ %
,@@% &
new@@' *
OpenApiInfo@@+ 6
{AA 
VersionBB 
=BB 
$strBB "
,BB" #
TitleCC 
=CC 
$strCC ,
,CC, -
DescriptionDD 
=DD  !
$strDD" D
,DDD E
}EE 
)EE 
;EE 
cFF 
.FF !
AddSecurityDefinitionFF '
(FF' (
$strFF( 0
,FF0 1
newFF2 5!
OpenApiSecuritySchemeFF6 K
{GG 
InHH 
=HH 
ParameterLocationHH *
.HH* +
HeaderHH+ 1
,HH1 2
DescriptionII 
=II  !
$strII" L
,IIL M
NameJJ 
=JJ 
$strJJ *
,JJ* +
TypeKK 
=KK 
SecuritySchemeTypeKK -
.KK- .
ApiKeyKK. 4
}LL 
)LL 
;LL 
cMM 
.MM "
AddSecurityRequirementMM (
(MM( )
newMM) ,&
OpenApiSecurityRequirementMM- G
{MMH I
{NN 
newOO !
OpenApiSecuritySchemeOO 2
{PP 
	ReferenceQQ $
=QQ% &
newQQ' *
OpenApiReferenceQQ+ ;
{RR 
TypeSS !
=SS" #
ReferenceTypeSS$ 1
.SS1 2
SecuritySchemeSS2 @
,SS@ A
IdTT 
=TT  !
$strTT" *
}UU 
}VV 
,VV 
newWW 
stringWW $
[WW$ %
]WW% &
{WW' (
}WW) *
}XX 
}YY 
)YY 
;YY 
var[[ 
xmlFile[[ 
=[[ 
$"[[  
{[[  !
System[[! '
.[[' (

Reflection[[( 2
.[[2 3
Assembly[[3 ;
.[[; < 
GetExecutingAssembly[[< P
([[P Q
)[[Q R
.[[R S
GetName[[S Z
([[Z [
)[[[ \
.[[\ ]
Name[[] a
}[[a b
$str[[b f
"[[f g
;[[g h
c\\ 
.\\ 
IncludeXmlComments\\ $
(\\$ %
System\\% +
.\\+ ,
IO\\, .
.\\. /
Path\\/ 3
.\\3 4
Combine\\4 ;
(\\; <

AppContext\\< F
.\\F G
BaseDirectory\\G T
,\\T U
xmlFile\\V ]
)\\] ^
)\\^ _
;\\_ `
}]] 
)]] 
;]] 
varaa 
tokenOptionsaa 
=aa 
EnvironmentManageraa 1
.aa1 2
Instanceaa2 :
.aa: ;
GetConfigurationaa; K
(aaK L
)aaL M
.aaM N

GetSectionaaN X
(aaX Y
$straaY g
)aag h
;aah i
servicescc 
.cc 
AddAuthenticationcc &
(cc& '
JwtBearerDefaultscc' 8
.cc8 9 
AuthenticationSchemecc9 M
)ccM N
.dd 
AddJwtBearerdd 
(dd 
optionsdd "
=>dd# %
{ee 
optionsff 
.ff %
TokenValidationParametersff 2
=ff3 4
newff5 8%
TokenValidationParametersff9 R
{gg 
ValidateActorhh "
=hh# $
truehh% )
,hh) *
ValidateAudienceii %
=ii& '
falseii( -
,ii- .
ValidateIssuerjj #
=jj$ %
falsejj& +
,jj+ ,
ValidateLifetimekk %
=kk& '
truekk( ,
,kk, -$
ValidateIssuerSigningKeyll -
=ll. /
truell0 4
,ll4 5
	ClockSkewmm 
=mm  
TimeSpanmm! )
.mm) *
	FromHoursmm* 3
(mm3 4
$nummm4 5
)mm5 6
,mm6 7
IssuerSigningKeynn %
=nn& '
newnn( + 
SymmetricSecurityKeynn, @
(nn@ A
Encodingoo 
.oo 
UTF8oo "
.oo" #
GetBytesoo# +
(oo+ ,
tokenOptionsoo, 8
.oo8 9
GetValueoo9 A
<ooA B
stringooB H
>ooH I
(ooI J
$strooJ W
)ooW X
)ooX Y
)ooY Z
}qq 
;qq 
}rr 
)rr 
;rr 
}tt 	
publicvv 
voidvv 
	Configurevv 
(vv 
IApplicationBuildervv 1
appvv2 5
,vv5 6
IWebHostEnvironmentvv7 J
envvvK N
)vvN O
{ww 	
ifxx 
(xx 
envxx 
.xx 
IsDevelopmentxx !
(xx! "
)xx" #
)xx# $
{yy 
appzz 
.zz %
UseDeveloperExceptionPagezz -
(zz- .
)zz. /
;zz/ 0
}{{ 
app}} 
.}} 
UseIpRateLimiting}} !
(}}! "
)}}" #
;}}# $
app 
. "
UseExceptionMiddleware &
(& '
)' (
;( )
app
ÅÅ 
.
ÅÅ 
UseAuthentication
ÅÅ !
(
ÅÅ! "
)
ÅÅ" #
;
ÅÅ# $
app
ÇÇ 
.
ÇÇ 
UseAuthorization
ÇÇ  
(
ÇÇ  !
)
ÇÇ! "
;
ÇÇ" #
app
ÑÑ 
.
ÑÑ 
UseCors
ÑÑ 
(
ÑÑ 
x
ÑÑ 
=>
ÑÑ 
x
ÑÑ 
.
ÖÖ 
AllowAnyOrigin
ÖÖ *
(
ÖÖ* +
)
ÖÖ+ ,
.
ÜÜ 
AllowAnyMethod
ÜÜ *
(
ÜÜ* +
)
ÜÜ+ ,
.
áá 
AllowAnyHeader
áá *
(
áá* +
)
áá+ ,
)
áá, -
;
áá- .
app
àà 
.
àà 

UseSwagger
àà 
(
àà 
)
àà 
.
ââ 
UseSwaggerUI
ââ 
(
ââ 
c
ââ 
=>
ââ 
{
ää 
c
ãã 
.
ãã 
SwaggerEndpoint
ãã !
(
ãã! "
$str
ãã" @
,
ãã@ A
$str
ããB J
)
ããJ K
;
ããK L
}
åå 
)
åå 
;
åå 
app
éé 
.
éé 
UseMvc
éé 
(
éé 
)
éé 
;
éé 
}
èè 	
}
êê 
}ëë 