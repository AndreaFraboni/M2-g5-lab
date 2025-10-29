using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;

public class EX5 : MonoBehaviour
{
    [SerializeField] int[] array;

    // Start is called before the first frame update
    void Start()
    {
        int[] Array = GeneraArray(10, 1, 10);   // genero l'array di dimensione 10
        StampaArray(Array);                     // Stampo l'array generato

        int[] nuovoArrayUguale = CambiaDimensioneArray(Array, 10); // Mantengo la stessa grandezza dell'array generato prima a 10
        StampaArray(nuovoArrayUguale);                             // Stampo l'array dopo cambio dimensione

        int[] nuovoArrayPiccolo = CambiaDimensioneArray(Array, 5); // cambio dimensione dell'array a 5 quindi più piccolo
        StampaArray(nuovoArrayPiccolo);                            // Stampo l'array dopo cambio dimensione

        int[] nuovoArrayGrande = CambiaDimensioneArray(Array, 20); // cambio dimensione dell'array a 20 quindi più grande
        StampaArray(nuovoArrayGrande);                             // Stampo l'array dopo cambio dimensione 
    }

    int[] GeneraArray(int dimensioni, int minimo, int massimo)
    {
        Debug.Log("**************************** Genero Array ********************************");
        array = new int[dimensioni];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(minimo, massimo);
        }
        return array;
    }

    void StampaArray(int[] Array)
    {
        Debug.Log("***************************** STAMPO Array *****************************");
        for (int i = 0; i < Array.Length; i++)
        {
            Debug.Log(Array[i]);
        }
        Debug.Log("************************************************************************");
    }

    int[] CambiaDimensioneArray(int[] Array, int nuovadimensione)
    {
        Debug.Log("*********************** Cambio Dimensione Array ************************");
        Debug.Log("Dimensione nuovo Array = " + nuovadimensione);
        Debug.Log("************************************************************************");
        int[] newArray = new int[nuovadimensione];

        if (Array.Length == newArray.Length)
        {
            newArray = Array;
        }
        else
        {
            if (newArray.Length < Array.Length)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    newArray[i] = Array[i];
                }
            }
            else if (newArray.Length > Array.Length)
            {
                for (int i = 0; i < newArray.Length; i++)
                {
                    if (i < Array.Length)
                        newArray[i] = Array[i];
                    else
                        newArray[i] = 0;
                }
            }

        }

        return newArray;
    }


}
