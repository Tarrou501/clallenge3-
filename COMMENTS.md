Projeto de cadastro de cliente dividido em 2 módulos Frontend(pasta frontend) e Backend (pasta webApp)

FRontend em angular versão 13.1.4
  Foi usando o angular material versão 13.1.3 com ferramenta vs code
  Na resposta da requisição foi incluida tratamento de erros,  faltou detalhar erros de servidor, 4XX, 5XX e outros.
  Na listagem de cliente, foi utilizado pipe Date, e tambem foi criado um pipe persnolizado para formatar o CPF.
  Estruratura separa em 
    components
       cliente
       template
          footer
          header
          nnav
       Utils
    Views
       home
       client-crud


Backend foi feito em C# EF core versão 2.2, na verdade tive no criterio de escolha, pois o projeto não menciona se poderia fazer EF6.
   Na primeira versão do sistema foi utilizado para gerar o banco no MySQL, mas em contato com o Fabio foi modificado para o SQLSever.
   Não foi criado os scripts para geração do banco de dados e da tabela de cliente, pois adotado o tecnologia Code-First.
   Foi criada a entidade de dominio, e a EF API criará o banco de dados com base na classe Cliente de dominio e configuração
   
   Para criar o banco de dados na produção ou em outro, terá que configurar a string de conexão WebAppContext que esta na tag ConnectionStrings do arquivo appsettings.json, no meu caso, eu use o banco de dados local (mssqllocaldb). E executao comando update-database no console gerenciador de pacote(NuGet)

   O projeto de backend foi criada uma solução webApp.sln, e dentro da solução há 3 projetos:
       - API
           Controllers
       - Dominio
           Contratos
           Entidades
       - Repositório
           Config
           Contexto
           Data
           Migrations (foi gerado pelo Code-Fisrt)
           Repositorios 

    Foi criado a classe SeedData, para popular automatico 3 registros de cliente nop banco de dados para teste.
    Os testes de backend foram simulados no Postman
    No controle cliente foram criados 5 serviços Restful, e cada servico no verbo Http adequado. (houve a necessidade de usar o PATCH)
       Buscar todos os clientes (GET)
       Buscar cliente pelo Id   (GET)
       Inserir novo cliente     (POST)
       Atualizar cliente        (PUT)
       Excluir cliente          (DELETE)
    Houve necessidade de configurar e implementar o CORS no backend devido as divergencia de origens de servidores entre o backend e o frontend.
    No meu projeto foi configurado para o frontend ma url http://localhost:4200 , se foi publicar o frontend em outro servidor deverá configurar o Cors no Statup.cs do projeto WebApp.API. 

    Consideração: na tabela Cliente, a coluna idade não foi criada pois na classe Cliente é um campo calculado. o motivo de não criar pois a idade é calculada em todo momento e poderá esta desfasado com valor real gravado na tabela. por isso é um atributo de uma classe.
    A lista de profissão está HardCode, futuramente deverá ser implementadad uma tabela de profissão.
    
    Por falta de tempo faltou mascará validar o CPF no momento da inclusão e edição no Frontend.

    Obrigado pelo desafio.



