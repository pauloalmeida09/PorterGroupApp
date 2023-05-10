### PorterGroupApp
>
>
## Questões
>
>
> <p style="text-align: justify"> 
>
> 1 - Como você implementou a função que retorna a representação por extenso do número no desafio 1? Quais foram os principais desafios encontrados?
>
> R - Esta implementação foi desenvolvida de forma básica utilizando loops e condicionais if e else. A lógica central foi pegar o número de caracteres e fazer o mapeamento de unidade, dezena, centena e milhar, executando as condicionais com os respetivos nomes do número, e sempre que necessário concatenando as palavras correspondentes. Nesta questão coloquei uma regra de que o número poderá ter no máximo 4 caracteres, pois para aumentar os caracteres teria que ter uma implementação maior e possivelmente sendo mais viável criar uma dll só para esta conversão.
>
>
> 2 - Como você lidou com a performance na implementação do desafio 2, considerando que o array pode ter até 1 milhão de números?
>
> R - Nesta implementação utilizei da função "Sum" onde ela efetuar esta soma de inteiro dentro do array sem problemas, porém em caso de uma queda de performance na execução, poderia ser implementado uma paginação na lista de forma assíncrona, para haja uma execução mais eficiente da função.
>
>
> 3 - Como você lidou com os possíveis erros de entrada na implementação do desafio 3, como uma divisão por zero ou uma expressão inválida?
>
> R - Nesta questão utilizei o método "DataTable" onde ele executa a operação em uma row sem grandes problemas e em caso de erro a mensagem de retorno foi tratado e a mesma, e auto explicativa, e sempre gerando log de erro para análise. Neste caso o "DataTable" já identifica esta operação falha e o mesmo gera uma exceção e assim sendo tratada para retorno.
>
> 4 - Como você implementou a função que remove objetos repetidos na implementação do desafio 4? Quais foram os principais desafios encontrados?
>
> R - A função para excluir objetos repetidos foi implementado utilizando o "DistinctBy" da biblioteca "Linq", com isso a mesma já verifica todos os atributos inserido e assim determina o objeto que esta sendo repetido ou não, com isso ela retorna uma lista apenas com os objetos únicos. Caso e faça esta resolução com loops e comparações a mesma fica complexa para execução, tornando um código menos divergente e com maior possibilidade de falha.
>
> </p>
>