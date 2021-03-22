# Projeto - Programação Orientado a Objetos em C#

## :scroll: Sumário

- [Sobre](#about)
- [Estrutura](#structure)
- [Conceitos](#learned)

## :computer: Sobre <a name = "about"></a>

Projeto desenvolvido em console de aplicação de cadastro de séries aplicando o paradigma de orientação a objetos em prática, e o conceito de CRUD.
> Create, Read, Update e Delete


> Bootcamp 🚀 = .Net Fundamentals
<p align="center">
<br>
  <a href="https://web.digitalinnovation.one/" rel="noopener">
 <img width=800px height=400px src="https://hermes.digitalinnovation.one/site/images/cover_dio.jpg" alt="Logo Digital Innovation One"></a>
</p>


### :mag: Imagens do projeto

<p align="center">
 :globe_with_meridians: DEPLOY
</p>

<p align="center">
<img src="https://raw.githubusercontent.com/lcds90/dio-project-poo-csharp/development/img/screenshot.PNG" alt="Screenshot 1">
<img src="https://raw.githubusercontent.com/lcds90/dio-project-poo-csharp/development/img/screenshot2.PNG" alt="Screenshot 2">
</p>

## :file_folder: Estrutura do projeto <a name = "structure"></a>
```
 ├── dio-project-poo                   
    ├── class                    # Arquivos com classes do programa.
    ├── interface                # Arquivos com regras de métodos
    ├── Program.cs               # Main de app
    └── README.md
```
## :memo: Conceitos aprendidos <a name = "learned"></a>

### Orientação a objetos

#### Classe Abstrata
Não pode ser instanciada. São moldes para outra classe servindo de base

#### [Interfaces](https://docs.microsoft.com/pt-br/dotnet/csharp/programming-guide/interfaces/)
Não pode ser instanciada. Normalmente, uma interface é como uma classe base abstrata com apenas membros abstratos. Qualquer classe ou struct que implementa a interface deve implementar todos os seus membros. 

#### Enviroment
Obtém a cadeia de caracteres de nova linha definida dependendo do ambiente da aplicação.
> \r\n para plataformas não Unix ou \n para plataformas UNIX.
```
using System;
message += "Gênero: " + this.Genre + Environment.NewLine;
```

#### Interface - Uso de Exemplo
Para realizar o armazenamento de dados, é utilizado um design pattern tendo como o conceito principal de ter uma interface repositório.
Obriga a ter metodos para utilização de dados
##### <T>
> Tipo Genérico de utilização para varias classes

Exemplo no projeto poderia ser reutilizado como:

```
public class SerieRepositorio : iRepositorio<Serie>
...

public class SerieRepositorio : iRepositorio<Filmes>
...

public class SerieRepositorio : iRepositorio<Documentarios>
```

#### Enum
[Enum.Get.Values()](https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getvalues?view=net-5.0) -> Recupera uma matriz de valores de constantes em uma enumeração especificada.

[Enum.Get.Name()](https://docs.microsoft.com/pt-br/dotnet/api/system.enum.getname?view=net-5.0) ->