# SimpleFactoryPizzaria

## SIMPLE FACTORY

### O simple Factory é um objeto que é usado para criar instâncias de um objeto para o cliente.
### Permite usar interfaces para criar objetos sem expor a lógica da criação do objeto ao cliente.

![image](https://user-images.githubusercontent.com/72822204/191749021-cf5f9ea5-7873-4dd4-9321-a6c076c76eed.png)

### 1 - O cliente precisa de um produto, mas ao invés de cria-lo diretamente usando o operador New, ele pede o objeto Factory. Um novo produto fornecendo as informações sobre o tipo que necessita.

### 2 - A fábrica instancia um novo produto concreto, em seguida, retorna ao cliente, o produto criado, convertido para uma base de produto abstrata.

### 3 - O cliente usa os produtos sem estar ciente de sua implementação concreta.

![image](https://user-images.githubusercontent.com/72822204/191749226-cc1209d7-d7c3-4392-885d-2e846a6cd7a6.png)

#### Fonte: Macoratti
