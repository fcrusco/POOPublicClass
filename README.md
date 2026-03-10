# AppPOO - Conta Bancária 🏦

### 📝 Sobre o Projeto
Este é um exemplo prático de uma aplicação console desenvolvida em C# que simula o gerenciamento de uma conta bancária simples. 
O foco principal é o ensino de fundamentos de **Programação Orientada a Objetos (POO)**.

### 🧠 Resumo Técnico: POO e Classes Públicas
* **Programação Orientada a Objetos (POO):**
* É um paradigma que estrutura o software em volta de "objetos" (como a `ContaBancaria`), que agrupam dados (propriedades) e comportamentos (métodos).
* **Classes Públicas (`public`):**
* O modificador `public` torna a classe visível para todo o projeto. Sem ele, o arquivo `Program.cs` não conseguiria "enxergar" ou instanciar a classe dentro do namespace.
* **Encapsulamento:**
* No código, o uso de `private` para o saldo protege a integridade dos dados, forçando que qualquer alteração passe pelas regras de negócio dos métodos `Sacar` e `Depositar`.

---

## English

### 📝 About the Project
This is a practical example of a C# console application that simulates simple bank account management. The main focus is teaching the fundamentals of **Object-Oriented Programming (OOP)**.

### 🧠 Technical Summary: OOP and Public Classes
* **Object-Oriented Programming (OOP):** A paradigm that structures software around "objects" (like `ContaBancaria`), which group data (properties) and behaviors (methods).
* **Public Classes (`public`):** The `public` modifier makes the class visible to the entire project. Without it, `Program.cs` wouldn't be able to "see" or instantiate the class within the namespace.
* **Encapsulation:** In the code, using `private` for the balance protects data integrity, forcing any changes to go through the business rules in the `Sacar` (Withdraw) and `Depositar` (Deposit) methods.

---

## Español

### 📝 Sobre el Proyecto
Este es un ejemplo práctico de una aplicación de consola en C# que simula la gestión de una cuenta bancaria simple. El objetivo principal es enseñar los fundamentos de la **Programación Orientada a Objetos (POO)**.

### 🧠 Resumen Técnico: POO y Clases Públicas
* **Programación Orientada a Objetos (POO):** Es un paradigma que estructura el software en torno a "objetos" (como `ContaBancaria`), que agrupan datos (propiedades) y comportamientos (métodos).
* **Clases Públicas (`public`):** El modificador `public` hace que la clase sea visible para todo el proyecto. Sin él, `Program.cs` no podría "ver" ni instanciar la clase dentro del namespace.
* **Encapsulamiento:** En el código, el uso de `private` para el saldo protege la integridad de los datos, obligando a que cualquier cambio pase por las reglas de negocio de los métodos `Sacar` (Retirar) y `Depositar`.

---

## 🛠️ Tecnologias / Technologies / Tecnologías
* **Language:** C#
* **Platform:** .NET Core / .NET 8.0
* **Paradigm:** Object-Oriented Programming (OOP)

## 🚀 Como Executar / How to Run / Cómo Ejecutar

1.  **Clone o repositório:**
    ```bash
    git clone [https://github.com/seu-usuario/nome-do-repositorio.git](https://github.com/seu-usuario/nome-do-repositorio.git)
    ```
2.  **Navegue até a pasta e execute:**
    ```bash
    dotnet run
    ```
