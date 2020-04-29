using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtvHerança
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1. Criar uma Classe Pessoa, contendo os atributos encapsulados, com seus respectivos seletores (getters) e
            modificadores (setters), e ainda o construtor padrão. Atributos: String nome; String endereco; String telefone;

                2. Considere, como subclasse da classe Pessoa (desenvolvida no exercício anterior) a classe Fornecedor. Considere que cada instância da classe Fornecedor tem, para além dos atributos que caracterizam a classe Pessoa, os atributos valorCredito (correspondente ao crédito máximo atribuído ao fornecedor) e valorDivida (montante da dívida com o fornecedor). Implemente na classe Fornecedor, além dos usuais métodos seletores e modificadores, um método obterSaldo que devolve a diferença entre os valores dos atributos valorCredito e valorDivida. Depois de implementada a classe Fornecedor, crie um programa de teste adequado que lhe permita verificar o funcionamento dos métodos implementados na classe Fornecedor e os herdados da classe Pessoa.
            */
            Fornecedor f = new Fornecedor("Marlão", "Mutuca", "(35)3264-1111");
            f.ValorCredito = 1000000.00;
            f.ValorDivida = 316000.12;
            Console.WriteLine("Fornecedor, saldo de :" + f.obterSaldo());

            /*
            3. Considere, como subclasse da classe Pessoa, a classe Colaborador. Considere que cada instância da classe Colaborador tem, além dos atributos que caracterizam a classe Pessoa, os atributos codigoSetor (inteiro), salarioBase (valor tomado como base para estipular benefícios previdenciários ao empregado) e imposto (porcentagem retida dos impostos). Implemente a classe Colaborador com métodos seletores e modificadores e um método calcularSalario (que retorna salário base menos os impostos). Escreva um programa de teste adequado para a classe Colaborador.
            */
            Colaborador c = new Colaborador("Yasuo", "Ionia", "(02)7777 - 7777");
            c.CodSetor = 30;
            c.SalarioBase = 50.32;
            c.Impostos = 2; // Porcentagem
            Console.WriteLine("Colaborador, salário :" + c.calcularSalario());

            /* 4. Implemente a classe Administrador como subclasse da classe Colaborador. Um determinado administrador tem como atributos, além dos atributos da classe Pessoa e da classe Colaborador, o atributo ajudaDeCusto (ajudas referentes a viagens, estadias). Você deverá redefinir na classe Administrador o método herdado calcularSalario (o salário de um administrador é equivalente ao salário de um Colaborador usual acrescido das ajuda de custo). Escreva um programa de teste adequado para esta classe.
            */
            Administrador a = new Administrador("Breno", "New York", "(01)3412-3123");
            a.CodSetor = 30;
            a.SalarioBase = 11000.50;
            a.Impostos = 2; // Porcentagem
            a.AjudaDeCusto = 100.00;
            Console.WriteLine("Administrador, salário :" + a.calcularSalario());

            /*5. Implemente a classe Operario como subclasse da classe Colaborador. Um determinado operário tem como
atributos, além dos atributos da classe Pessoa e da classe Colaborador, o atributo valorProducao (que
corresponde ao valor monetário dos artigos efetivamente produzidos pelo operário) e comissao (que
corresponde à porcentagem do valorProducao que será adicionado ao salário base do operário). Você deverá redefinir nesta subclasse o método herdado calcularSalario (o salário de um operário é equivalente ao salário de um Colaborador usual acrescido da referida comissão). Escreva um programa de teste adequado para esta classe.

             */
            Operario o = new Operario("Marcio", "varginha", "(35)3123-4324");
            o.CodSetor = 30;
            o.SalarioBase = 818.23;
            o.Impostos = 2; // %
            o.ValorProducao = 177.09;
            o.Comissao = 3;
            Console.WriteLine("Operário, salário :" + o.calcularSalario());

            /*6. Implemente a classe Vendedor como subclasse da classe Colaborador. Um determinado vendedor tem como atributos, além dos atributos da classe Pessoa e da classe Colaborador, o atributo valorVendas
(correspondente ao valor monetário dos artigos vendidos) e o atributo comissao (porcentagem do valorVendas que será adicionado ao salário base do vendedor). Note que deverá redefinir nesta subclasse o método herdado calcularSalario (o salário de um vendedor é equivalente ao salário de um Colaborador usual acrescido da referida comissão). Escreva um programa de teste adequado para esta classe.
             */
            Vendedor v = new Vendedor("Rodrigo", "Elói Mendes", "(35)2344-423");
            v.CodSetor = 30;
            v.SalarioBase = 818.13;
            v.Impostos = 2; // %
            v.ValorVendas = 518.22;
            v.Comissao = 5;
            Console.WriteLine("Vendedor, salário :" + v.calcularSalario());
        }
    }
}
