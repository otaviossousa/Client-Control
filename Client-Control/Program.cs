using System;
namespace Client_Control
{
    class Program 
    {   
        static void Main(string[] args )
        {   
            float val_pag;
            Console.WriteLine("Informar Nome:");
            string var_nome = Console.ReadLine();
            Console.WriteLine("Informar Endereco:");
            string var_endereco = Console.ReadLine();
            Console.WriteLine("Informar Pessoa Fisica (f) ou Pessoa Juridica (j):");
            string var_tipo = Console.ReadLine();

            if(var_tipo == "f")
            {
                // Pessoa Fisica 

                Pessoa_Fisica pf = new Pessoa_Fisica();
                pf.nome = var_nome;
                pf.endereco = var_endereco;
                Console.WriteLine("Informar CPF:");
                pf.cpf = Console.ReadLine();
                Console.WriteLine("Informar RG:");
                pf.rg = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pf.Pagar_Imposto(val_pag);
                Console.WriteLine("--------- Pessoa Fisica ---------");
                Console.WriteLine("Nome ..........: {0}", pf.nome);
                Console.WriteLine("Endereco ......: {0}", pf.endereco);
                Console.WriteLine("CPF ...........: {0}", pf.cpf);
                Console.WriteLine("RG ............: {0}", pf.rg);
                Console.WriteLine("Valor de Compra: {0}", pf.valor.ToString("C"));
                Console.WriteLine("Imposto .......: {0}", pf.valor_imposto.ToString("C"));
                Console.WriteLine("Total .........: {0}", pf.total.ToString("C"));

            }
            else
            {
                // Pessoa Juridica
                
                Pessoa_Juridica pj = new Pessoa_Juridica();
                pj.nome = var_nome;
                pj.endereco = var_endereco;
                Console.WriteLine("Informar CNPJ:");
                pj.cnpj = Console.ReadLine();
                Console.WriteLine("Informar IE:");
                pj.ie = Console.ReadLine();
                Console.WriteLine("Informar Valor de Compra:");
                val_pag = float.Parse(Console.ReadLine());
                pj.Pagar_Imposto(val_pag);
                Console.WriteLine("--------- Pessoa Juridica ---------");
                Console.WriteLine("Nome ..........: {0}", pj.nome);
                Console.WriteLine("Endereco ......: {0}", pj.endereco);
                Console.WriteLine("CNPJ ..........: {0}", pj.cnpj);
                Console.WriteLine("IE ............: {0}", pj.ie);
                Console.WriteLine("Valor de Compra: {0}", pj.valor.ToString("C"));
                Console.WriteLine("Imposto .......: {0}", pj.valor_imposto.ToString("C"));
                Console.WriteLine("Total .........: {0}", pj.total.ToString("C"));
            }

        }

    }
}