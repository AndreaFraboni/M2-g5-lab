using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class EX3 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] Array = GeneraArray(20, 1, 10);
        StampaArray(Array);
        Debug.Log("Valore MINIMO nell'array  = " + TrovaMinimo(Array));
        Debug.Log("Valore MASSIMO nell'array = " + TrovaMassimo(Array));
    }

    int[] GeneraArray(int dimensioni, int minimo, int massimo)
    {
        Debug.Log("*********** Genero Array ***********");
        int[] array = new int[dimensioni];
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = Random.Range(minimo, massimo);
        }
        return array;
    }

    void StampaArray(int[] Array)
    {
        Debug.Log("*********** STAMPO Array ***********");
        for (int i = 0; i < Array.Length; i++)
        {
            Debug.Log(Array[i]);
        }
        Debug.Log("************************************");
    }

    int TrovaMinimo(int[] Array)
    {
        int valoreletto;              // valore letto dall'array
        int valoresalvato = Array[0]; // salvo il primo elemento dell'array come valore iniziale da confrontare

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto < valoresalvato)
                valoresalvato = valoreletto;
        }
        return valoresalvato;
    }

    int TrovaMassimo(int[] Array)
    {
        int valoreletto;              // valore letto dall'array
        int valoresalvato = Array[0]; // salvo il primo elemento dell'array come valore iniziale da confrontare

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto > valoresalvato)
                valoresalvato = valoreletto;
        }
        return valoresalvato;
    }


}
