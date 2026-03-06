using System;
using System.Collections.Generic;

// deixei aqui os objetos para instanciar pois existe um erro de top-level statements
// instanciando a barbearia e contratando funcionários e cadastrando clientes
// Criando a barbearia
Barbearia minhaBarbearia = new Barbearia("Corte Certo");

// instanciando um funcionário e um cliente
Funcionario f1 = new Funcionario("Fernando", "Barbeiro", 2500);
Cliente c1 = new Cliente("João", "123456789", "joao@gmail.com");

// cadastrando o funcionário e o cliente na barbearia
minhaBarbearia.ContratarFuncionario(f1);
minhaBarbearia.CadastrarCliente(c1);

// listando a equipe da barbearia
minhaBarbearia.ListarEquipe(f1);


class Funcionario
{
    public string Nome;
    public string Cargo;
    public double Salario;

    public Funcionario(string nome, string cargo, double salario)
    {
        Nome = nome;
        Cargo = cargo;
        Salario = salario;
    }

}

class Cliente
{
    public string Nome;
    public string Telefone;
    public string Email;

    public Cliente(string nome, string telefone, string email)
    {
        Nome = nome;
        Telefone = telefone;
        Email = email;
    }
}

// barbearia vai ser a classe que vai usar os metodos das outras classes para criar a barbearia, contratar funcionários e cadastrar clientes
// troquei o nome da main por barbearia
class Barbearia
{
    public string NomeDaBarbearia;

    // cria listas para armazenar os funcionários e clientes da barbearia
    List<Funcionario> Funcionarios = new List<Funcionario>();
    List<Cliente> Clientes = new List<Cliente>();

    public Barbearia(string nomeDaBarbearia)
    {
        NomeDaBarbearia = nomeDaBarbearia;
    }

    // ========= metodos da classe barbearia ========
    public void ContratarFuncionario(Funcionario f)
    {
        Funcionarios.Add(f);
        Console.WriteLine($"Funcionário {f.Nome} contratado para o cargo de {f.Cargo} com salário de {f.Salario}");
    }

    public void CadastrarCliente(Cliente c)
    {
        Clientes.Add(c);
        Console.WriteLine($"Cliente {c.Nome} cadastrado com telefone {c.Telefone} e email {c.Email}");
    }

    public void ListarEquipe(Funcionario c)
    {
        Console.WriteLine("========= Equipe da Barbearia ========");
        foreach (Funcionario f in Funcionarios)
        {
            Console.WriteLine($"Funcionário: {f.Nome} - Cargo: {f.Cargo}");
        }
    }
}


// ouput:
// Funcionário Fernando contratado para o cargo de Barbeiro com salário de 2500
// Cliente João cadastrado com telefone 123456789 e email
// ========= Equipe da Barbearia ========
// Funcionário: Fernando - Cargo: Barbeiro