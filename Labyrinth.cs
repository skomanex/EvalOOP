using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

internal class Labyrinth
{
    private List<Case> cases = new List<Case>();

    private int taille;

    // Constructeur du labyrinthe
    public Labyrinth(int t)
    {
        taille = t;
        this.Generate();
    }

    // Génération du labyrinthe
    private void Generate()
    {
        Random random = new Random();
        int k = 0;

        // Génération de la grille du labyrinthe, par default toutes les cases sont des chemins
        for (int i = 0; i < taille; i++)
        {
            for (int j = 0; j < taille; j++)
            {
                cases.Add(new Case(i,j));
            }
        }

        // Ajout des murs du labyrinthe
        for (int i = 0; i < cases.Count; i++)
        {
            if (cases[i].coordonee.x == 0 || cases[i].coordonee.x == taille-1 || cases[i].coordonee.y == 0 || cases[i].coordonee.y == taille-1)
            {
                cases[i].Type = "mur";
            }
        }

        //Ajout de l'entree et de la sortie (fixées au sens des coodonées)
        for (int i = 0; i < cases.Count; i++)
        {
            if ((cases[i].coordonee.x == 1 & cases[i].coordonee.y == 0) || (cases[i].coordonee.x == taille -2 & cases[i].coordonee.y == taille - 1))
            {
                cases[i].Type = "chemin";
            }
        }

        /* PAS FAIT PAR MANQUE DE TEMPS : IMPLEMENTATION DE l'ALGORITHME DE PRIM ITERATIF POUR GENERER UN LABYRINTHE RESOLUBLE */

        // Update des cases du labyrinthe pour mettre à jour leur representation en fonction de leurs nouveaux types
        this.Update();
    }

    // Update des cases du labyrinthe
    private void Update()
    {
        for (int i = 0;i < cases.Count;i++)
        {
            cases[i].Update();
        }
    }

    // Affichage du labyrinthe dans la console
    internal void Display()
    {
        for (int i = 0;i < cases.Count;i += taille) 
        {
            string ligne = "";
            for (int j = 0;j < taille; j++)
            {
                ligne += cases[i+j].Representation;
            }
            Console.WriteLine(ligne);
        }
    }
}