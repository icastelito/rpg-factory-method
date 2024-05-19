# RPGFactoryMethod

## Aluno: Icaro Castelo Branco da Costa

## Descrição

Este projeto é uma implementação do padrão de design Factory Method em C# dentro do contexto de um jogo de RPG. Ele define uma estrutura para criar alguns tipos de desafios (como monstros e armadilhas) sem acoplar o código do jogo às classes concretas desses desafios.
## Estrutura do Código

O código é composto por várias classes organizadas da seguinte forma:

### Classes Abstratas

1. **Desafio**:
   - Classe base abstrata que representa um desafio no jogo.
   - Contém uma propriedade abstrata `Nome` e um método abstrato `Executar`.

2. **FabricaDesafio**:
   - Classe base abstrata para as fábricas de desafios.
   - Define um método abstrato `CriarDesafio` que retorna um objeto do tipo `Desafio`.

### Classes Concretas

1. **Monstro**:
   - Subclasse concreta de `Desafio`.
   - Implementa a propriedade `Nome` e o método `Executar`, que exibe uma mensagem indicando que um monstro apareceu.

2. **Armadilha**:
   - Subclasse concreta de `Desafio`.
   - Implementa a propriedade `Nome` e o método `Executar`, que exibe uma mensagem indicando que uma armadilha foi acionada.

3. **FabricaMonstro**:
   - Subclasse concreta de `FabricaDesafio`.
   - Implementa o método `CriarDesafio`, retornando uma nova instância de `Monstro`.

4. **FabricaArmadilha**:
   - Subclasse concreta de `FabricaDesafio`.
   - Implementa o método `CriarDesafio`, retornando uma nova instância de `Armadilha`.

### Classe Principal

1. **Program**:
   - Classe principal que contém o método `Main`, ponto de entrada do programa.
   - Cria instâncias das fábricas de desafios (`FabricaMonstro` e `FabricaArmadilha`), utiliza essas fábricas para criar desafios específicos, e executa esses desafios, exibindo mensagens no console.

## Passo a Passo

1. **Definir a classe base Desafio**:
   - `Desafio` é uma classe abstrata que contém uma propriedade abstrata `Nome` e um método abstrato `Executar`.

2. **Criar subclasses concretas de Desafio**:
   - `Monstro` e `Armadilha` são subclasses concretas de `Desafio` que implementam a propriedade `Nome` e o método `Executar` com mensagens específicas.

3. **Definir a classe base FabricaDesafio**:
   - `FabricaDesafio` é uma classe abstrata com um método abstrato `CriarDesafio` que retorna um objeto do tipo `Desafio`.

4. **Criar subclasses concretas de FabricaDesafio**:
   - `FabricaMonstro` e `FabricaArmadilha` são subclasses concretas de `FabricaDesafio` que implementam o método `CriarDesafio` para retornar instâncias de `Monstro` e `Armadilha`, respectivamente.

5. **Implementar a classe Program**:
   - No método `Main`, instanciar `FabricaMonstro` e `FabricaArmadilha`.
   - Utilizar essas instâncias para criar objetos `Monstro` e `Armadilha`.
   - Chamar o método `Executar` em cada um desses objetos para exibir as mensagens no console.

## Execução

Para executar o programa, siga os passos abaixo:

1. Compile o código utilizando um compilador C# (por exemplo, através do Visual Studio ou linha de comando com `csc`).
2. Execute o programa compilado. Você verá as seguintes mensagens no console:

```
Desafio criado: Monstro
Um monstro apareceu! Prepare-se para a batalha!
Desafio criado: Armadilha
Você caiu em uma armadilha! Tente escapar!
```

Essas mensagens indicam que os desafios foram criados e executados corretamente.
