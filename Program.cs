List<string> ctlgJogos = new List<string>();

Console.Write("Digite o nome do jogo: ");
string nome = Console.ReadLine();
Console.Write("Digite o genero do jogo: ");
string genero = Console.ReadLine();
Console.Write("Digite o ano do lançamento: ");
int anoLanc = int.Parse(Console.ReadLine());
CatalogoJogos jogo1 = new CatalogoJogos(nome, genero, anoLanc, ctlgJogos);

Console.Write("Digite o nome do jogo: ");
string nome2 = Console.ReadLine();
Console.Write("Digite o genero do jogo: ");
string genero2 = Console.ReadLine();
Console.Write("Digite o ano do lançamento: ");
int anoLanc2 = int.Parse(Console.ReadLine());

CatalogoJogos jogo2 = new CatalogoJogos(nome2, genero2, anoLanc2, ctlgJogos);
 
 


jogo1.AdicionarJogos(nome);
jogo2.AdicionarJogos(nome2);
jogo2.ExibirJogos();