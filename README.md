# O que é este projeto?

Projeto de estudo sobre autenticação em API utilizando JWT (JSON Web Tokens)

Conteúdo que utilizei como referência:

https://medium.com/@renato.groffe/asp-net-core-2-0-autentica%C3%A7%C3%A3o-em-apis-utilizando-jwt-json-web-tokens-4b1871efd

https://medium.com/@renato.groffe/asp-net-core-2-0-jwt-implementando-refresh-tokens-7fa525ffb461

# Para testar

Envie um `POST` para `https://localhost:5001/api/login`

Coloque em Raw um JSON do tipo:

```json
{
    "userID": "usuario01",
    "accessKey": "94be650011cf412ca906fc335f615cdc",
    "GrantType": "password"
}
```

Após o envio, deve retornar um json similar a este:

```json
{
    "authenticated": true,
    "created": "2020-10-16 15:33:06",
    "expiration": "2020-10-16 15:35:06",
    "accessToken": "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJ1c3VhcmlvMDEiLCJ1c3VhcmlvMDEiXSwianRpIjoiM2JjZmYxM2FkMzEyNGExZjllOTQ3ZTYyMDc1YzE3MDUiLCJuYmYiOjE2MDI4NzMxODYsImV4cCI6MTYwMjg3MzMwNiwiaWF0IjoxNjAyODczMTg2LCJpc3MiOiJFeGVtcGxvSXNzdWVyIiwiYXVkIjoiRXhlbXBsb0F1ZGllbmNlIn0.QFMJS-r02ILKITppfk_Al8TmUhecm5_rAdXSajPf1696Lbh-e9JanOEJJjhKMXDyXuXOzPj8aqhKKQopDFeNlRmZYkwMVWO5tPQgz85o8kX_m3SlFAvwv1HN0Ni457HGnpl5yMKsx0x9WyNHhKV3LYryNqPguqum_jKgU_yjxgJPBpmrcMfQY9tbSNSq3BURIhR4IygpQT5rBKxeVa2khAacoUenJPAYGHWtVUqNe9WcxOLbpV0oUryF2-GeB4YdWcYjuZypSL8Tch_y73gCoV9tN12p7-9ig6Vt9zEaP0nC53MNSFTlNlOcyADjK11bi52K2fD8b-GtYBzDxwDmsQ",
    "refreshToken": "24d2c87c50b440148ff01ee16bf00cb7",
    "message": "OK"
}
```

Com o `accessToken` gerado, realizamos o `GET` para `https://localhost:5001/api/ConversorAlturas/PesMetros/200`

Com o Postman, vá na aba `Authorization` e informe o Type `Bearer Token`.

Informe também o Token que retornou no POST.

Para realizar o refresh do token, pegue o conteúdo de `refreshToken` e faça uma nova chamada POST:

```json
{
    "userID": "usuario01",
    "refreshToken": "a9326f1335e147e998cd3997dd60dc9f",
    "GrantType": "refresh_token"
}
```

O retorno será similar a este:

```json
{
    "authenticated": true,
    "created": "2020-10-16 15:36:37",
    "expiration": "2020-10-16 15:38:37",
    "accessToken": "eyJhbGciOiJSUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1bmlxdWVfbmFtZSI6WyJ1c3VhcmlvMDEiLCJ1c3VhcmlvMDEiXSwianRpIjoiOGM2NTllMDg4YTBiNDBjMmFjOTVhNTc2MTAzMzViZTYiLCJuYmYiOjE2MDI4NzMzOTcsImV4cCI6MTYwMjg3MzUxNywiaWF0IjoxNjAyODczMzk3LCJpc3MiOiJFeGVtcGxvSXNzdWVyIiwiYXVkIjoiRXhlbXBsb0F1ZGllbmNlIn0.oiQmgC-MFweUTdw9w8tI5kf0CVVjB39XkCeKj27B1TKswcCELkENhooL64JREKMLdSrpOYDJkeDtCdthJJzZ-X4QLdMW5TA9g-KrRdyP8lmr7mTiicoxl-BYUOz_yMq2g2MKBtTGzihIk7w7cjC4cCC6NOp4TTcWIB9AWX1Vf7Y5_bl5VG2X9vPswXT6ZQcyUq_d1zYJK8AevvFbBHzDujNboUTKqETA-02Ey_pKzh_lHGUAAjfD6vyLYcMIqyVdFpjWjChT8Nxs6A5YJJExotWBDU-9Wm9f0Ygp696UQCHpOzuFeXQ1kan4_HNIjLwJDhOulphNw0OUB3ixxY51-A",
    "refreshToken": "0ee61c96878f49b08d810f5d9ff921bf",
    "message": "OK"
}
```

# Criado com

* Microsoft Visual Studio Community 2019
* .NET Core 2.1
* MySql.Data 8.0.21
* Dapper 2.0.35

