# OnionApp

## OnionApp is application that peforms CRUD operations over tables using Entity Framework and is operated through API.

## Technologies used in this project:
- ASP.NET Core Identity
- Entity Framework Core
- SQLite
- REST api

## How this app works:
To run app please clone repository and launch it via visual studio. Sqlite database is automatically connected.
1. When run swagger UI is launched in browser.
2. To peform any operation user have to login or register.
  a. login using existing account by sending credentials on **api/authentication/login** endpoint
    - admin credentials: (user1,User1pass!)
    - user credentials: (user2,User1pass!)
    Copy received token, open **authorize tab**, type "Bearer", paste token and click "authorize"
  b. Create new account on **api/authentication/register** endpoint by sending your username and password, and then log in using your credentials like in sub **a**. New account have user role byu default.
 
3. After succesfully sign in user have acces to peform operations on endpoints.
**User** have permission to:
- adding new part
- listing all parts
- get stock for selected id
- add/update stock
- list all stock list
- get warehouse details
- list all suppliers
**Admin** have all user permissions and addictionally:
- remove warehouse
- add warehouse
- add supplier
- delete supplier
- delete part


## Examples
- succesfully receive jwt token after passing correct credentials
![image](https://github.com/MarcinD12/OnionApp/assets/111440372/10133c29-5796-4cd9-ac9c-036503019da6)
- "401 Not authorized" response after invoking endpoint without proper login
![image](https://github.com/MarcinD12/OnionApp/assets/111440372/a3cc4297-e6d4-402a-8e34-9e5a499774a7)
- succesfully receive all parts list after passing valid jwt token:
![image](https://github.com/MarcinD12/OnionApp/assets/111440372/99d1a3aa-be2b-4b9d-85e3-46826db177b0)
- add new part:
![image](https://github.com/MarcinD12/OnionApp/assets/111440372/8c057a29-06be-46a7-b249-948e44a4800e)
-part exists:
![image](https://github.com/MarcinD12/OnionApp/assets/111440372/3c42b3ae-7c7e-41aa-8d6e-5b5340f174b5)
- part succesfully removed
![image](https://github.com/MarcinD12/OnionApp/assets/111440372/37a8d122-b624-4011-916f-b3c18ff0a286)
 


