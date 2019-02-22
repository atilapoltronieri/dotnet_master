# dotnet_master

Projeto Dot.Master

Para realizar a chamada do WebAPi para trazer as 5 Ubs mais próximas, ordenadas pela Avaliação, siga o modelo abaixo:

../api/Ubs/GetUbs?pLatitude={0}&pLongetude={1}

O método é composto por dois pararâmetros do tipo double. Há um tratamento na chamada "GetUbs", sem parametrização, para interceptar tentativas de parâmetros incorretos.

A importação das Ubs foi feita através de lista, como uma das opções sugerira, assim não necessitando a validação na importação dos dados do arquivo .csv durante a execução. Os dados foram normalizados anteriormente para evitar perda de desempenho e sua execução ocorre em torno de 1 segundo com mais de 37 mil registros. A performance seria mais efetiva em um todo caso a inteligência da rotina fosse transferida para um banco de dados, desta maneira realizando a consulta as Ubs e analisando a distância das mesmas e retornando as 5 primeiras de maneira muito mais eficiente.

No projeto de Teste foram feitos 4 testes utilizando o XUnit. 3 dos testes são verdadeiros enquanto ocorre erro no outro, como pedido pela avaliação. Um dos testes foi feito para validar que uma determinada posição retornaria as 5 Ubs mais próximas enquanto o próximo efetua um Loop de 100 localidades diferentes mostrando que sempre irá trazer as 5 primeiras independente do local. Nos outros dois foi posto a exata localidade da Ubs USF ENFERMEIRO PEDRO JACINTO AREA 09 e mostrando que a ordenação por Avaliação a faz retornar não como a primeira opção justamente por não ter a melhor Avaliação.
