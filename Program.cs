Console.WriteLine("Bienvenue dans le carnet d'adresse");
Console.WriteLine("Tapez 1 pour ajouter un contact (nom, prenom, tel , adresse)");
Console.WriteLine("Tapez 2 pour lire les informations d'un contact");
Console.WriteLine("Tapez 3 pour bloquer un contact");
int choix = int.Parse(Console.ReadLine());

List<string[]> carnet = new List<string[]>();

if (choix == 1)
{
    // ajouter
    carnet.Add(["cacciato", "lorenzo", "9292929", "1 rue des trucs"]);
    Console.WriteLine("Nouveau contact ajouté");

}
else if (choix == 2)
{
    Console.WriteLine("Entre un nom");
    string nom = Console.ReadLine();

    foreach (string[] c in carnet)
    {
        if (c[0] == nom){

            Console.WriteLine($" Contact trouvé, il s'appelle {c[1]}");
            break;
        }
    }

}
else if (choix == 3)
{
    // bloquer
}
else
{
    // message
}