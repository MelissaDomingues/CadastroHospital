using CadastroHospital;


    namespace CadastroHospital
    {
        public class Program
        {
            public static void Main()
            {

            Pessoa pessoa1 = new Pessoa();
            pessoa1.nome = "Melissa";
            pessoa1.sobrenome = "Domingues";
            pessoa1.cpf = 555555555 - 55;
            pessoa1.idade = 20;
            pessoa1.altura = 1.50;
            pessoa1.peso = 45;
            pessoa1.convenio = "xxxx";


            Console.WriteLine("Cadastro de Pacientes");
            Console.WriteLine("");
            Console.WriteLine("Nome: " + pessoa1.nome);
            Console.WriteLine("Sobrenome: " + pessoa1.sobrenome);
            Console.WriteLine("CPF: " + pessoa1.cpf);
            Console.WriteLine("Idade: " + pessoa1.idade);
            Console.WriteLine("Altura: " + pessoa1.altura);
            Console.WriteLine("Peso: " + pessoa1.peso);
            Console.WriteLine("Convênio: " + pessoa1.convenio);

           
            Pessoa pessoa2 = new Pessoa();
            pessoa2.nome = "Maria";
            pessoa2.sobrenome = "Oliveira";
            pessoa2.cpf = 22222222 - 2;
            pessoa2.idade = 62;
            pessoa2.altura = 1.65;
            pessoa2.peso = 70;
            pessoa2.convenio = "aaaaaa";

            Console.WriteLine("Cadastro de Pacientes");
            Console.WriteLine("");
            Console.WriteLine("Nome: " + pessoa2.nome);
            Console.WriteLine("Sobrenome: " + pessoa2.sobrenome);
            Console.WriteLine("CPF: " + pessoa2.cpf);
            Console.WriteLine("Idade: " + pessoa2.idade);
            Console.WriteLine("Altura: " + pessoa2.altura);
            Console.WriteLine("Peso: " + pessoa2.peso);
            Console.WriteLine("Convênio: " + pessoa2.convenio);



        }

           


        }
            

       
    }





