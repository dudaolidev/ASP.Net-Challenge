# ASP.Net-Challenge
# MyTrendApp

## Descrição
**MyTrendApp** é uma API .NET para o projeto **My Trend**, uma solução inovadora voltada para o mercado da moda. A aplicação oferece diversos serviços como avaliação de produtos, recomendação de looks, gestão de roupas e pedidos, entre outros.

## Pré-requisitos

Para executar e testar a aplicação localmente, você precisa ter:

- **Visual Studio 2022** ou superior
- **.NET SDK 6.0** ou superior instalado
- **Oracle Database** configurado e rodando
- Uma string de conexão válida com o Oracle Database no arquivo `appsettings.json`
- Uma conta no **Microsoft Azure** com os devidos acessos para criar e gerenciar recursos.

### Dependências principais
- **Entity Framework Core** com suporte para **Oracle**
- **Swagger** para documentação da API
- Serviços e camadas de negócio personalizadas para o domínio do projeto My Trend

## Configuração

### 1. Clone o repositório:
```bash
git clone 
````
## 2. Configurar a conexão com o banco de dados:

No arquivo `appsettings.json`, configure sua string de conexão com o Oracle:

```
"ConnectionStrings": {
  "DefaultConnection": "your_oracle_connection_string_here"
}
```
## 3. Abrir o projeto no Visual Studio:

1. Abra o Visual Studio 2022.
2. No menu principal, clique em `File > Open > Project/Solution` e navegue até o diretório onde você clonou o projeto.
3. Selecione o arquivo da solução (.sln).

## 4. Restaurar pacotes NuGet:

Quando o projeto for carregado, o Visual Studio irá sugerir a restauração dos pacotes NuGet necessários. Aceite a sugestão e permita que o Visual Studio restaure as dependências.

## 5. Executar as migrações do banco de dados:

Você pode rodar as migrações diretamente do Package Manager Console no Visual Studio:

1. Vá para o menu `Tools > NuGet Package Manager > Package Manager Console`.
2. Execute o seguinte comando para aplicar as migrações no banco de dados Oracle:

```
add-migrations
Update-Database
```
## 6. Rodar a aplicação localmente:

1. No Visual Studio, clique no botão `IIS Express` ou na opção de execução ao lado de `MyTrendApp` para rodar a aplicação localmente.
2. A aplicação será iniciada, e o Swagger estará disponível em:

```
https://localhost:5001/swagger
````

## Deploy na Azure via Visual Studio

### Passos para fazer o deploy diretamente pelo Visual Studio:

#### Publicar a Aplicação:

1. Clique com o botão direito no projeto `MyTrendApp` na `Solution Explorer`.
2. Selecione `Publish`.

#### Escolher o Destino:

1. Na janela `Pick a publish target`, selecione `Azure`.
2. Em seguida, escolha `Azure App Service (Windows)` e clique em `Next`.

#### Criar um Novo App Service:

1. Selecione a opção para `Criar um novo Azure App Service`.
2. Preencha as informações necessárias, como:
   - Nome do App Service (Ex: `MyTrendApp`)
   - Resource Group (Crie um novo ou escolha um existente)
   - Plano de Serviço (Defina o plano de escalabilidade)
3. Clique em `Create`.

#### Configurar a String de Conexão no Azure:

1. Após criar o App Service, vá para o Azure Portal.
2. Navegue até o App Service que você acabou de criar.
3. No painel do App Service, vá para `Settings > Configuration`.
4. Adicione a string de conexão com o banco de dados Oracle:
   - Nome: `DefaultConnection`
   - Valor: `User Id=seuusuario;Password=suasenha;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=oracle.fiap.com.br)(PORT=1521)))(CONNECT_DATA=(SERVER=DEDICATED)(SID=orcl)));`
   - Tipo: `Custom`

#### Deploy da Aplicação:

1. No Visual Studio, confirme suas configurações de publicação e clique em `Publish`.
2. O Visual Studio cuidará do deploy, e a aplicação será disponibilizada no Azure.

#### Acessar a Aplicação no Azure:

1. Após a publicação ser concluída, a aplicação estará disponível na URL fornecida pelo Azure.





