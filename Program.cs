// Aula data: 14/05/2025
// Um atributo estática não pode ser chamado em um objeto.
// ex: f1.mediasalario; está incorreto.
// Dentro de uma classe estática pode se ter apenas membros estáticos.
// Dentro de uma classe normal pode se ter ou não membros estático.

// Herança: a classe derivada (filho) herda todas as características da 
// classe base (pai) e pode ter características únicas.

//ClientePf c1 = new ClientePf();
//c1._id = 1;
//c1._nome = "Ana"; 
////Console.WriteLine(c1._nome);

//ClientePj cp2 = new ClientePj();
//cp2._id = 2;
//cp2._nome = "Brasil Telecom";
//Console.WriteLine(cp2._nome);

//c1.Salvar();
//cp2.Salvar();


ContaEmpresa c1 = new ContaEmpresa();
c1.Depositar(1000);
double limiteEmprestimo = 10000;
double totalEmprestimo = 1000;

c1.setLimiteEmprestimo(limiteEmprestimo);

c1.FazerEmprestimo(1000);

ContaEstudante c2 = new ContaEstudante();
c2.Depositar(10000);
double chequeEspecial = 1000;

c2.setLimite(chequeEspecial);

c2.Sacar(1000);

