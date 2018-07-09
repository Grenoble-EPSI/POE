using System;

public class Mot
{
    private String mot = "";

    public Mot(string mot)
    {
        this.mot = mot;
    }

    /// <summary>
    /// la méthode getMot() qui permet de selectionner un mot
    /// </summary>
    /// <param name="mot"></param>
    /// <returns></returns>
    public static Mot CreateMot()
    {        
        return new Mot("fox");
    }

    public bool Contains(string character)
    {
        return mot.Contains(character);
    }

    public bool HaveAllLeters(string letters)
    {
        for(int i = 0; i < mot.Length ; i++)
        {
            if (!letters.Contains(mot.Substring(i, 1)))
            {
                return false;
            }
        }

        return true;
    }

    /// <summary>
    /// la méthode getlenght qui permet de retourner la taille du mot
    /// </summary>
    /// <param name="mot"></param>
    /// <returns></returns>
    public int Length
    {
        get
        {
            return mot.Length;
        }
    }
}
