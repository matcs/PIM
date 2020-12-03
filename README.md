# PIM (descontinuado)

Esta repositório faz parte do projeto integrado multidisciplinar (abreviando: PIM) da universidade paulista (UNIP). 
Ele se divide em quatro aplicações:

## API
A API é a parte principal do projeto. Lá estão todos os models do projeto, as migrations, conexão com o banco de dados utilizando o [EntityFrameworkCore](https://docs.microsoft.com/en-us/ef/core/) que também permitira que haja métodos de para criar, ler, atualizar e deletar os dados. Por fim a API também possui um sistema básico de segurança feito por JWT para proteger acessos indevidos. Para iniciar o banco de dados basta abrir o Package-Manager no Visual Studio 2019 e digitar o comando:
  `EntityFrameworkCore\Update-Database`
  
## MVC
A aplicação MVC se o responsável por fazer o client-side. Todas as APIs consumidas viram da aplicação API. O cliente poderá realizar tudo que estiver ao seu alcance, como atualizar dados pessoais, endereços e afins.

## Desktop
Por fim, a aplicação de Desktop será destinada apenas aos funcionários da empresa que poderão fazer as alterações desejadas, além da requisição de relatórios específicos como de clientes ativos, maiores investidores e afins. 

## Instalação
A única coisa que os programas precisão para funcionar é o .NET Framework 4.5 e o SQLServer 18.0 . Dito isso é só executar o binário que cada pasta tem. O caminho dos binários é o mesmo, é pasta do projeto>Bin>Releases>{Nome do projeto}.exe

## NOTAS
### DockerFiles
Nos projetos de API e MVC existem arquivos de para serem utilizados pelo Docker, entretanto nenhum deles está configurado corretamente e também não tem nenhum arquivo yml para rodar o Docker Compose.
