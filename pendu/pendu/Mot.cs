﻿using System;

public class Mot
{
    private String mot;

    /// <summary>
    /// la Création de la classe Mot() avec les constructeurs 
    /// </summary>
	public Mot()
	{
	}


    public Mot(String mot)
    {
        this.mot = mot;
    }

    /// <summary>
    /// la méthode getMot() qui permet de selectionner un mot
    /// </summary>
    /// <param name="mot"></param>
    /// <returns></returns>
    public String getMot(String mot)
    {        
        return mot;
    }

    /// <summary>
    /// la méthode getlenght qui permet de retourner la taille du mot
    /// </summary>
    /// <param name="mot"></param>
    /// <returns></returns>
    
    public int getlenght(String mot)
    {
        int taille;
        taille = mot.Length;
        return taille;
    }

}
