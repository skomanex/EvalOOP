using System;

public class Case
{
    public string Type;

    public Coordonee coordonee;

    public string Representation;
   
    public Case(int x, int y)
    {
        Type = "chemin";
        Representation = "□";
        coordonee = new Coordonee(x, y);
    }

    public void Update()
    {
        switch (Type)
        {
            case "mur":
                Representation = "■";
                break;
            case "chemin":
                Representation = "□";
                break;
            default:
                Representation = null;
                break;
        }
    }

}