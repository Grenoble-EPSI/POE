using System;

public class Mot
{
    private String mot = "";

    public Mot(string mot)
    {
        this.mot = mot;
    }

    /// <summary>
    /// Crée un mot
    /// </summary>
    public static Mot CreateMot()
    {        
        return new Mot("fox");
    }

    /// <summary>
    /// Retourne vrai si le mot contient le charactere
    /// </summary>
    public bool Contains(string character)
    {
        return mot.Contains(character);
    }

    /// <summary>
    /// retourne vrai si les lettres du mot sont toutes dans letters
    /// </summary>
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
    /// la taille du mot
    /// </summary>
    public int Length
    {
        get
        {
            return mot.Length;
        }
    }
}
