using System;
using System.Collections.Generic;
using System.Threading;

namespace ContruDelasConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            //mostrar
            //Console.WriteLine("Hello World!");

            //ler
            //int nome = Convert.ToInt32("0" + Console.ReadLine());

            //setando tipos de variávies
            //double moeda = 0.2;
            //int inteiro = 4;
            //string stringgg = "dddd";
            //bool verdadeiro = true;
            //DateTime data = new DateTime();

            //fazendo conversão de variáveis
            //var teste1 = int.Parse("11");
            //var teste2 = Convert.ToInt32(1.5);
            //var teste3 = 1.5.ToString();

            // double = moeda (1.5)
            // int  = numeros (1,2,3,4)
            // string  = letras e números ("O seu nome com ç ou ~ ")
            // bool  = verdadeiro ou false (true, false)
            // DateTime = defini datas (2021-01-01 00:00:00)

            // concatenação
            //Console.WriteLine("O número é: " + teste1);
            //Console.WriteLine($"O número é: {teste1}");
            //Console.WriteLine(string.Format("O número é: ?", teste1));

            /*
            dado os tipos de conversões e os comando para mostrar e ler os dados na tela,
            faça um programa para caputar dois números(int), e no final mostre o resultado
            da soma dos mesmos
            */

            /*
            Faça um programa que leia o nome e o valor do produto digitado, após digitar,
            faça o calculo de 5% sobre o valor do produto, no final do programa mostre a
            mensagem:
                "O valor calculado foi x% do produto y"
            */

            /*

            if (1 == 1) // compara igual
            {
                Console.WriteLine("entrou igual");
            }

            if (1 != 1) // compara diferente
            {
                Console.WriteLine("não entrou");
            }

            if (1 > 1) // maior que
            {
                Console.WriteLine("não entrou");
            }

            if (1 < 1) // menor que
            {
                Console.WriteLine("não entrou");
            }


            if (1 >= 1) // maior que
            {
                Console.WriteLine("maior igual");
            }

            if (1 <= 1) // menor que
            {
                Console.WriteLine("menor iqual");
            }

            if ("ee" == "ee") // menor que
            {
                Console.WriteLine("menor iqual");
            }

            //var result = 1 == 1;

            if (true || false) // verdadeiro ou falso
            {
                Console.WriteLine("menor iqual");
            }

            if (false || false) // falso ou falso
            {
                Console.WriteLine("menor iqual");
            }

            if (true && false) // verdadeiro e falso
            {
                Console.WriteLine("menor iqual");
            }

            if (true && true) // verdadeiro e verdadeiro
            {
                Console.WriteLine("menor iqual");
            }

            if (true)
            {
                Console.WriteLine("entro aqui if");
            }
            else
            {
                Console.WriteLine("entro aqui else");
            }

            if (false)
            {
                Console.WriteLine("entro aqui if");
            }
            else
            {
                Console.WriteLine("entro aqui else");
            }

            if (false)
            {
                Console.WriteLine("entro aqui if");
            }
            else if(true)
            {
                Console.WriteLine("entro aqui else");
            }

            if (false)
            {
                Console.WriteLine("entro aqui if");
            }
            else if (false)
            {
                Console.WriteLine("entro aqui else if");
            }
            else
            {
                Console.WriteLine("entro aqui else");
            }


            if(!((true && true && false) && (true || true)))
            {
                Console.WriteLine("entro aqui else");
            }

            */


            //Console.WriteLine("Digite os números separados por ','");
            //string numeros = Console.ReadLine();
            //var numerosArray = numeros.Split(',');

            //int soma = 0;
            //foreach(string item in numerosArray)
            //{
            //    soma += int.Parse(item);
            //}

            //Console.WriteLine($"A soma dos números é: {soma}");

            /*
             * faça um programa que solicite 3 números faça a multiplicação dos mesmos e
             * no resultado final, verifique se este número é maior que 10 e menor que 20 ou
             * maior que 100 e menor que 200, ou maior quem 1000 e menor que 2000
             * caso seja verdadeira a condição, mostre a mensagem = "Sim é verdadeiro achou o número premiado"
             * se nao, mostre "infelizmente você perdeu"
             */

            /*
            var a = 1;

            if (a > 1)
            {
                Console.WriteLine("entro aqui if");
            }
            else if (a == 3)
            {
                Console.WriteLine("entro aqui else if");
            }
            else if (a != 1)
            {
                Console.WriteLine("entro aqui else if");
            }
            else
            {
                Console.WriteLine("entro aqui else");
            }


            switch (a)
            {
                case 11:
                    Console.WriteLine("entro aqui else");
                    break;
                case 3:
                    Console.WriteLine("entro aqui else");
                    break;
                case 10:
                    Console.WriteLine("entro aqui else");
                    break;
                default:
                    Console.WriteLine("entro aqui else");
                    break;
            }


            var upper = "ddd".ToUpper(); // = DDD maiúsculo
            var lower = "DDD".ToLower(); // = ddd minusculo

            */

            /*
             * faça um programa que peça para digitar um nome
             * caso o nome digitado for leo mostre "Oláaaa leo"
             * caso o nome digitado for dirceu mostre "Opa e ai Dirceu"
             * caso o nome digitado for thais mostre "Nossa Thais que vestido lindo"
             * caso não for nenhum moste "opção inválida"
             */


            //int i = 0;
            //while (i == 0) // ele mantém no looping até que a condição for falsa
            //{
            //    Console.WriteLine("Digite um número");
            //    i = Convert.ToInt32("0" + Console.ReadLine());
            //    Console.WriteLine($"O número digitado foi: {i}");
            //}

            //int x = 10;
            //do
            //{
            //    //if (x == 1) continue;
            //    Console.WriteLine("Digite um número");
            //    //if (x == 10) break;
            //    x = Convert.ToInt32("0" + Console.ReadLine());
            //    Console.WriteLine($"O número digitado foi: {x}");
            //}
            //while (x == 1); // ele mantém no looping até que a condição for falsa

            //for (var i=1; i<=100; i++)
            //{
            //    Console.WriteLine($"Número: {i}");
            //}


            //int[] numeros = new int[6];// { 3, 5, 7, 1, 10, 60 };
            //numeros[0] = Convert.ToInt16("0" + Console.ReadLine());
            //numeros[2] = Convert.ToInt16("0" + Console.ReadLine());
            //numeros[4] = Convert.ToInt16("0" + Console.ReadLine());

            //foreach (var item in numeros)
            //{
            //    Console.WriteLine($"Número: {item}");
            //}


            /*
             * Faça um programa para calcular a tabuada do número que o usuário digitar
             * no programa o usuário vai digitar o número da tabuado e a quantidade de números a 
             * calcular
             * o resultado final é para mostrar exemplo X * Y = ZZ para todos os números
             */


            //string[] nomes = new string[3] { "222", "11s", "ssdd" }; // obrigrado a definir a quantidade de espaços
            //nomes[0] = "Danilo";
            //nomes[1] = "Aíla";
            //nomes[2] = "Jane";
            //var qtd = nomes.Length;

            //List<string> nomesLista = new List<string>() { "222", "11s", "ssdd" }; // não é obrigrado a definir a quantidade de espaços
            //nomesLista[0] = "Danilo";
            //nomesLista[1] = "Aíla";
            //nomesLista[2] = "Jane";
            //nomesLista.Add("Maria");
            //var qtdList = nomesLista.Count;

            /*
             * Faça um programa que solicite o nome de 3 alunos e 4 notas para os tres alunos(ou seja 4 notas para cada um)
             * calcule a média das notas
             * no final do programa, mostre um relatório da seguinte forma:
             * Aluno: xxx, média: ?, notas: (?,?,?,?), Status: Aprovado ou Reprovado (aprovado média > 5)
             * Aluno: xxx, média: ?, notas: (?,?,?,?), Status: Aprovado ou Reprovado (aprovado média > 5)
             * Aluno: xxx, média: ?, notas: (?,?,?,?), Status: Aprovado ou Reprovado (aprovado média > 5)
             * Aluno: xxx, média: ?, notas: (?,?,?,?), Status: Aprovado ou Reprovado (aprovado média > 5)
             */

            /*
            List<string> nomesAlunos = new List<string>();
            List<List<double>> notasDosAlunos = new List<List<double>>();

            for(int i=1; i<=3; i++)
            {
                Console.WriteLine($"Digite a nome do {i}º aluno(a):");
                nomesAlunos.Add(Console.ReadLine());

                var notas = new List<double>();
                for (int x = 1; x <= 4; x++)
                {
                    Console.WriteLine($"Digite a {x}º nota do aluno(a) {nomesAlunos[i-1]}");
                    double nota = Convert.ToDouble("0" + Console.ReadLine());
                    notas.Add(nota);
                }

                notasDosAlunos.Add(notas);
            }

            for (int i = 0; i < 3; i++)
            {
                double soma = 0;
                var notas = notasDosAlunos[i];
                foreach (var nota in notas)
                {
                    soma += nota;
                }

                double media = soma / notas.Count;
                string status = media > 5 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"Aluno(a): {nomesAlunos[i]}, média: {media.ToString("#.##")}, notas: ({string.Join(",", notas.ToArray())}), Status: {status}");
            }
            */

            /*
            List<string> nomesAlunos = new List<string>();
            List<string> notasDosAlunos = new List<string>();
            List<string> matriculaDosAlunos = new List<string>();

            int qtd = 2;

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Digite a nome do {i}º aluno(a):");
                nomesAlunos.Add(Console.ReadLine());
                var nomeAluno = nomesAlunos[i - 1];

                Console.WriteLine($"Digite a matricula do(a) {nomeAluno}:");
                matriculaDosAlunos.Add(Console.ReadLine());

                Console.WriteLine($"Digite as 4 notas do aluno(a) {nomeAluno} separados por ','");
                string notas = Console.ReadLine();

                notasDosAlunos.Add(notas);
            }

            for (int i = 0; i < qtd; i++)
            {
                double soma = 0;
                var notasSeparadasPorVirgula = notasDosAlunos[i];
                var notas = notasSeparadasPorVirgula.Split(',');
                foreach (var nota in notas)
                {
                    soma += Convert.ToDouble("0" + nota);
                }

                double media = soma / notas.Length;
                string status = media > 5 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"Aluno(a): {nomesAlunos[i]}, Matricula: {matriculaDosAlunos[i]}, média: {media.ToString("#.##")}, notas: ({string.Join(",", notas)}), Status: {status}");
            }
            */

            /*
            List<dynamic> alunos = new List<dynamic>();

            int qtd = 2;

            for (int i = 1; i <= qtd; i++)
            {
                Console.WriteLine($"Digite a nome do {i}º aluno(a):");
                string nomeAluno = Console.ReadLine();

                Console.WriteLine($"Digite a matricula do(a) {nomeAluno}:");
                var matricula = Console.ReadLine();

                Console.WriteLine($"Digite as 4 notas do aluno(a) {nomeAluno} separados por ','");
                string notas = Console.ReadLine();

                alunos.Add(new {
                    Nome = nomeAluno,
                    Matricula = matricula,
                    Notas = notas
                });
            }

            foreach (var aluno in alunos)
            {
                double soma = 0;
                var notas = aluno.Notas.Split(',');
                foreach (var nota in notas)
                {
                    soma += Convert.ToDouble("0" + nota);
                }

                double media = soma / notas.Length;
                string status = media > 5 ? "Aprovado" : "Reprovado";

                Console.WriteLine($"Aluno(a): {aluno.Nome}, Matricula: {aluno.Matricula}, média: {media.ToString("#.##")}, notas: ({string.Join(",", notas)}), Status: {status}");
            }
            */

            /*
            Faça um programa para venda de produtos, neste programa você precisa 
            capiturar o nome do produto e o valor, depois capiturar o nome do comprador
            o endereço do comprador e a quantidade de produtos.
            após capiturar as informações gere um objeto de pedido, vinculando
            o usuario ao produto selecionado.

            relatório final:
            Olá senhor(a) XXX o valor total de seu pedido é: R$ XXX
            e os itens são: Quantidade XXX, Produto: XXX
            Será entregue no endereço XXX
            */

            //List<dynamic> pedidos = new List<dynamic>();

            /*
            Console.WriteLine($"Digite o nome do produto:");
            string nomeProduto = Console.ReadLine();

            Console.WriteLine($"O Valor do {nomeProduto}: ");
            var valor = Convert.ToDouble("0" + Console.ReadLine());

            Console.WriteLine($"Digite o nome do comprador:");
            var nomeComprador = Console.ReadLine();

            Console.WriteLine($"Olá {nomeComprador} digite o seu endereço: ");
            var endereco = Console.ReadLine();

            Console.WriteLine($"Agora {nomeComprador} digite a quantidade que deseja: ");
            var quantidade = Convert.ToInt16("0" + Console.ReadLine());

            dynamic pedido = new
            {
                Produto = new
                {
                    Nome = nomeProduto,
                    Valor = valor
                },
                Cliente = new
                {
                    Nome = nomeComprador,
                    Endereco = endereco,
                },
                Quantidade = quantidade,
                ValorTotal = quantidade * valor
            };

            Console.WriteLine($"Olá senhor(a) {pedido.Cliente.Nome} o valor total de seu pedido é: R$ {pedido.ValorTotal.ToString("#.##")}");
            Console.WriteLine($"E os itens são: Produto: {pedido.Produto.Nome}, Quantidade { pedido.Quantidade}");
            Console.WriteLine($"Será entregue no endereço {pedido.Cliente.Endereco}")
            */

            /*
            List<Pedido> pedidos = new List<Pedido>();
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"Digite o nome do produto:");
                string nomeProduto = Console.ReadLine();

                Console.WriteLine($"O Valor do {nomeProduto}: ");
                var valor = Convert.ToDouble("0" + Console.ReadLine());

                Console.WriteLine($"Digite o nome do comprador:");
                var nomeComprador = Console.ReadLine();

                Console.WriteLine($"Olá {nomeComprador} digite o seu endereço: ");
                var endereco = Console.ReadLine();

                Console.WriteLine($"Agora {nomeComprador} digite a quantidade que deseja: ");
                var quantidade = Convert.ToInt16("0" + Console.ReadLine());

                Pedido pedido = new Pedido()
                {
                    Produto = new Produto()
                    {
                        Nome = nomeProduto,
                        Valor = valor
                    },
                    Cliente = new Cliente()
                    {
                        Nome = nomeComprador,
                        Endereco = endereco,
                    },
                    Quantidade = quantidade,
                    ValorTotal = quantidade * valor
                };

                pedidos.Add(pedido);
            }

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Olá senhor(a) {pedido.Cliente.Nome} o valor total de seu pedido é: R$ {pedido.ValorTotal.ToString("#.##")}");
                Console.WriteLine($"E os itens são: Produto: {pedido.Produto.Nome}, Quantidade { pedido.Quantidade}");
                Console.WriteLine($"Será entregue no endereço {pedido.Cliente.Endereco}");
                Console.WriteLine($"----------------------------");
            }
            */

            /*
            Faça um programa para venda de produtos, neste programa você precisa 
            capiturar o nome de 5 produtos e o valor dos mesmos para cada cliente, depois capiturar os produtos, capturar o nome e
            endereço de 5 compradores, também a quantidade de produtos.
            após capiturar as informações gerar 5 pedidos com as informações

            Relatório final:
            Olá senhor(a) XXX o valor total de seu pedido é: R$ XXX
            e os itens são: Quantidade XXX, Produto: XXX
            Será entregue no endereço XXX
            ----------------------------
            Olá senhor(a) XXX o valor total de seu pedido é: R$ XXX
            e os itens são: Quantidade XXX, Produto: XXX
            Será entregue no endereço XXX
            -----------------------------
            Olá senhor(a) XXX o valor total de seu pedido é: R$ XXX
            e os itens são: Quantidade XXX, Produto: XXX
            Será entregue no endereço XXX
            -----------------------------
            Olá senhor(a) XXX o valor total de seu pedido é: R$ XXX
            e os itens são: Quantidade XXX, Produto: XXX
            Será entregue no endereço XXX
            -----------------------------
            Olá senhor(a) XXX o valor total de seu pedido é: R$ XXX
            e os itens são: Quantidade XXX, Produto: XXX
            Será entregue no endereço XXX
            -----------------------------
            */

            /*
            List<Pedido> pedidos = new List<Pedido>();
            for (int i = 0; i < 1; i++)
            {
                Pedido pedido = new Pedido() { Cliente = new Cliente() };

                Console.WriteLine($"Digite o nome do cliente:");
                pedido.Cliente.Nome = Console.ReadLine();

                Console.WriteLine($"Olá {pedido.Cliente.Nome} digite o seu endereço: ");
                pedido.Cliente.Endereco = Console.ReadLine();

                pedido.Produtos = new List<Produto>();

                while (true)
                {
                    var produto = new Produto();
                    Console.WriteLine($"Digite o nome do produto:");
                    produto.Nome = Console.ReadLine();

                    Console.WriteLine($"O Valor do {produto.Nome}: ");
                    produto.Valor = Convert.ToDouble("0" + Console.ReadLine());

                    Console.WriteLine($"Agora {pedido.Cliente.Nome} digite a quantidade que deseja: ");
                    produto.Quantidade = Convert.ToInt16("0" + Console.ReadLine());

                    pedido.Produtos.Add(produto);

                    Console.WriteLine("Digite 1 para adicionar um novo produto");
                    var saida = Console.ReadLine();
                    if (saida.Trim() != "1") break;
                }


                pedidos.Add(pedido);
            }

            Console.Clear();

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Olá senhor(a) {pedido.Cliente.Nome} o valor total de seu pedido é: R$ {pedido.ValorTotal().ToString("#.##")}");
                Console.WriteLine($"E os itens são:");

                foreach (var produto in pedido.Produtos)
                {
                    Console.WriteLine($" - { produto.Nome}, Quantidade { produto.Quantidade}, Valor R${produto.Valor.ToString("#.##")} ");
                }

                Console.WriteLine($"Será entregue no endereço {pedido.Cliente.Endereco}");
                Console.WriteLine($"----------------------------");
            }
            */

            var estoqueDeProdutos = new List<Produto>();
            var pedidos = new List<Pedido>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Olá ... O que vc deseja fazer ? ");
                Console.WriteLine("Digite 1 para cadastrar um produtos");
                Console.WriteLine("Digite 2 para cadastrar um pedido");
                Console.WriteLine("Digite 3 para mostrar relatório");
                Console.WriteLine("Digite 4 para mostrar estoque");
                Console.WriteLine("Digite 0 para mostrar sair");
                var dado = Console.ReadLine();
                if (dado.Trim() == "0") break;
                if (dado.Trim() != "1" &&
                    dado.Trim() != "2" &&
                    dado.Trim() != "3" &&
                    dado.Trim() != "4")
                {
                    Console.WriteLine("Opção inválida ...");
                    Thread.Sleep(5000); // 5 segundos
                    continue;
                }

                switch (Convert.ToInt16(dado))
                {
                    case 1:
                        cadastraProdutos(estoqueDeProdutos);
                        break;
                    case 2:
                        pedidos.Add(cadastrarPedido(estoqueDeProdutos));
                        break;
                    case 3:
                        mostraRelatorioDePedidos(pedidos);
                        break;
                    case 4:
                        Console.Clear();
                        mostrarEstoque(estoqueDeProdutos);
                        Thread.Sleep(5000); // 5 segundos
                        break;
                }
            }

        }

        private static void mostrarEstoque(List<Produto> produtos)
        {
            if (produtos.Count == 0)
            {
                Console.WriteLine("Não exite produtos cadastrados no estoque");
                return;
            }

            foreach (var produto in produtos)
            {
                Console.WriteLine($" {produto.Codigo} - {produto.Nome}");
            }
        }

        private static void cadastraProdutos(List<Produto> produtos)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine("Olá ... Bem vindo ao cadastro de produtos");
                Console.WriteLine("Digite 1 para cadastrar um produto ou 0 para sair");
                var dado = Console.ReadLine();
                if (dado.Trim() != "1") break;

                produtos.Add(cadastrarProduto());
            }
        }

        private static Produto cadastrarProduto()
        {
            Console.Clear();
            var produto = new Produto();

            try
            {
                Console.WriteLine($"Digite o código do produto:");
                produto.Codigo = Convert.ToInt16("0" + Console.ReadLine());

                Console.WriteLine($"Digite o nome do produto:");
                produto.Nome = Console.ReadLine();

                Console.WriteLine($"O Valor do {produto.Nome}: ");
                produto.Valor = Convert.ToDouble("0" + Console.ReadLine());
            }
            catch
            {
                return cadastrarProduto();
            }

            return produto;
        }

        private static void mostraRelatorioDePedidos(List<Pedido> pedidos)
        {
            Console.Clear();

            if (pedidos.Count == 0)
            {
                Console.WriteLine($"Não existe produtos cadastrados");
                Thread.Sleep(5000); // 5 segundos
                return;
            }

            foreach (var pedido in pedidos)
            {
                Console.WriteLine($"Olá senhor(a) {pedido.Cliente.Nome} o valor total de seu pedido é: R$ {pedido.ValorTotal().ToString("#.##")}");
                Console.WriteLine($"E os itens são:");

                foreach (var produto in pedido.Produtos)
                {
                    Console.WriteLine($" - { produto.Nome}, Quantidade { produto.Quantidade}, Valor unitário R${produto.Valor.ToString("#.##")}, Valor R${produto.ValorTotal().ToString("#.##")} ");
                }

                Console.WriteLine($"Será entregue no endereço {pedido.Cliente.Endereco}");
                Console.WriteLine($"----------------------------");
            }


            Thread.Sleep(15000); // 15 segundos
        }

        private static Pedido cadastrarPedido(List<Produto> produtos)
        {
            Console.Clear();

            Pedido pedido = new Pedido() { Cliente = new Cliente() };

            Console.WriteLine($"Digite o nome do cliente:");
            pedido.Cliente.Nome = Console.ReadLine();

            Console.WriteLine($"Olá {pedido.Cliente.Nome} digite o seu endereço: ");
            pedido.Cliente.Endereco = Console.ReadLine();

            pedido.Produtos = new List<Produto>();

            while (true)
            {
                Console.Clear();

                Console.WriteLine($"Segue a lista de produtos disponíveis no estoque:");
                mostrarEstoque(produtos);

                Console.WriteLine($"Digite o código do produto que deseja:");
                var codigo = Convert.ToInt16("0" + Console.ReadLine());

                var produto = produtos.Find(p => p.Codigo == codigo);
                if(produto == null)
                {
                    Console.WriteLine($"Código de produto inválido");
                    Thread.Sleep(2000); // 2 segundos
                    continue;
                }

                Console.WriteLine($"Agora {pedido.Cliente.Nome} digite a quantidade que deseja do(a) {produto.Nome}: ");
                produto.Quantidade = Convert.ToInt16("0" + Console.ReadLine());

                pedido.Produtos.Add(produto);

                Console.WriteLine("Digite 1 para adicionar um novo produto");
                var saida = Console.ReadLine();
                if (saida.Trim() != "1") break;
            }

            return pedido;
        }
    }
}
