using System;


public class ClsEspaces
{
	public ClsEspaces()
	{
		
	}
	private string nom;
	private string numero;
	private string adresse;
	private string ville;
	private int etage;
	private float montantloye;
	private ClsType type;

    public string Nom { get => nom; set => nom = value; }
    public string Numero { get => numero; set => numero = value; }
    public string Adresse { get => adresse; set => adresse = value; }
    public string Ville { get => ville; set => ville = value; }
    public int Etage { get => etage; set => etage = value; }
    public float Montantloye { get => montantloye; set => montantloye = value; }
    public ClsType Type { get => type; set => type = value; }

    public ClsEspaces(string nom,string numero, string adresse, string ville, int etage , float montantloye, ClsType type)
    {
		this.Nom1 = nom;
		this.Numero = numero;
		this.Adresse = adresse;
		this.Ville = ville;
		this.Etage = etage;
		this.Montantloye = montantloye;
		this.Type = type;

    }
}
