class CatalogoJogos
{
    public CatalogoJogos(string nome, string genero, int anoLanc, List<string> jogos)
    {
        Nome = nome;
        Genero = genero;
        AnoLanc = anoLanc;
        Jogos = jogos;
    }
    public string Nome { get; set; }
    public string Genero { get; set; }
    public int AnoLanc { get; set; }

    public List<string> Jogos { get; set; } = new List<string>();

    public void AdicionarJogos(string nome)
    {
        Jogos.Add(nome);
        Console.WriteLine($"O jogo {nome} foi adicionado com sucesso!");
    }

    public void ExibirJogos()
    {
        Console.WriteLine("Catálogo de jogos: ");
        foreach (string jog in Jogos)
        {
            Console.WriteLine($"Jogo: {jog}");
        }
    }
}