# O que é este projeto?

Projeto de estudo sobre autenticação em API utilizando JWT (JSON Web Tokens)

Conteúdo que utilizei como referência:

https://medium.com/@renato.groffe/asp-net-core-2-0-autentica%C3%A7%C3%A3o-em-apis-utilizando-jwt-json-web-tokens-4b1871efd

# Para testar

POST para `https://localhost:5001/api/login`

Coloque em Raw um JSON do tipo:

```
{
    "userID": "usuario01",
    "accessKey": "94be650011cf412ca906fc335f615cdc"
}
```

Vai ser gerado um Token e com esse Token realizamos o GET

GET para `https://localhost:5001/api/ConversorAlturas/PesMetros/200`

Com o Postman, vá na aba `Authorization` e informe o Type `Bearer Token`
Informe também o Token que retornou no POST.

# Criado com

* Microsoft Visual Studio Community 2019
* .NET Core 2.1
* MySql.Data 8.0.21
* Dapper 2.0.35

