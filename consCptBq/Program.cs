using libCptBq;
using banque;

Banque b = new Banque();
Compte c1;
c1 = new Compte(12345, "toto", 1000, -500);
b.AjouterCompte(c1);
b.AjouterCompte(12345, "toto", 1000, -500);
b.AjouterCompte(45657, "titi", 2000, -1000);
b.AjouterCompte(12654, "tintin", 5000, -500);
Console.WriteLine(b.RendCompte(45657).ToString());


b.AjouterType("ch", "chèque débité", '-');
b.AjouterType("pre", "prélèvement", '-');
b.AjouterType("dab", "retrait en distributeur", '-');
b.AjouterType("ret", "retrait guichet ", '-');
b.AjouterType("vir", "virement sur compte", '+');
b.AjouterType("dch", "chèque déposé", '+');
b.AjouterType("des", "dépôt d’espèce", '+');
Console.WriteLine(b.GetType("ch").ToString());