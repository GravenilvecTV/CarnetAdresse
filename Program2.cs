Console.WriteLine("Bienvenue dans le carnet d'adresse");
Console.WriteLine("Tapez 1 pour ajouter un contact (nom, prenom, tel , adresse)");
Console.WriteLine("Tapez 2 pour lire les informations d'un contact");
Console.WriteLine("Tapez 3 pour bloquer un contact");
int choix = int.Parse(Console.ReadLine());

Dictionary<string, Dictionary<string, string>> carnet = new Dictionary<string, Dictionary<string, string>>();
/*
    "cacciato" => {"nom": "cacciato", "prenom": "lorenzo", "telephone": "030303030", "adresse": "1 rkekke"}
    "di caprio" => {"nom": "di caprio", "prenom": "leonardo", "telephone": "020200220", "adresse": "1 rue du titanic"}
*/

if (choix == 1) {
    // ajouter
    Dictionary<string, string> infos = new Dictionary<string, string>();
    infos.Add("nom", "cacciato");
    infos.Add("prenom", "lorenzo");
    infos.Add("telephone", "0102030405");
    infos.Add("adresse", "1 rue des oiseaux vivants");

    carnet.Add("cacciato", infos);
    Console.WriteLine("Nouveau contact ajouté");

} else if(choix == 2){
    // lire les infos
    Console.WriteLine("Entrer le nom d'un contact");
    string contact = Console.ReadLine(); // cacciato
    Dictionary<string, string> infos = carnet.GetValueOrDefault(contact);
    string telephone = infos.GetValueOrDefault("telephone");
    Console.WriteLine(telephone);

} else if(choix == 3){
    // bloquer
} else {
    // message
}