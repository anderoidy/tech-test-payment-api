# tech-test-payment-api
API de Venda com .NET C#, SQL Server e Entity Framework

PRINCIPAIS COMANDOS PARA USAR O EMTITY FRAMWORK

dotnet tool install --global dotnet-ef   //instala o Entity nao aparece no arquivo pois é nivel de maquina

//esses vai pra developer.json  nivel de teste
dotnet add package Microsoft.EntityFrameworkCore.Design  // instala o design
dotnet add package Microsoft.EntityFrameworkCore.SqlServer  instala o banco 

comando para criar a connection string dentro da pasta Properties arquvio 
{...} appsetit....Development.jason

//Linha abaixxo sem as aspas
"Server=localhost\\sqlexpress; Initial Catalog=NomeDoBanco; Integrated Security=True "


dotnet-ef migrations add NomeDoBanco  //Esse gera a migrations em nome do banco Muda para o Nome do banco
dotnet-ef database update //E agora sim Este proximo comando que gera as tabelas no banco 
dotnet watch run  // E por ultimo esse comando é para rodar o projeto e sera aberto uma nova aba na pagina do 
Swagger UI para realilzarmos os testes da nossa API Loja 


Passos Para o Desenvolvimento da API C# usando EntityFramework

1 - Criamos a Classe Tarefa
2 - Criamos o nosso Context que vai representar o nosso banco
3 - E por ultimo passamos a ConexaoPadrao que declaramos la em .Development.json aqui em Program.cs
4 - Agora que ja criou as migrations ja criou o banco, entao vamos criar a controller onde vai os end points no caso os "Metodos"


Obs:  1 Criamos a ConectionString em ...Development.json

	2 depois chamamos a ConexaoPadrao em Program.cs

 Feliz aquele que transfere o que sabe e aprende o que ensina.

“A arte de ensinar baseia-se em acordar em meio da noite escura as mentes jovens, a ponto de os fazeres despertarem curiosidades, para que elas fiquem inquietas, insatisfeitas, e busquem o conhecimento até se encantarem ao verem o sol.”
ONIFUR LEAFAR
[Tags:ensinar, ensino]