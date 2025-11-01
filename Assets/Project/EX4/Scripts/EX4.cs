using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX4 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        int[] Array = GeneraArray(20, 1, 10);
        StampaArray(Array);


        int minimo = TrovaMinimo(Array);
        int massimo = TrovaMassimo(Array);
        Debug.Log("Valore MINIMO nell'array  = " + minimo);
        Debug.Log("Valore MASSIMO nell'array = " + massimo);

        TrovaMinimo_2(Array);
        TrovaMassimo_2(Array);
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
        int valoreletto;          // valore letto dall'array
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
        int valoreletto;          // valore letto dall'array
        int valoresalvato = Array[0]; // salvo il primo elemento dell'array come valore iniziale da confrontare

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto > valoresalvato)
                valoresalvato = valoreletto;
        }
        return valoresalvato;
    }

    void TrovaMinimo_2(int[] Array)
    {
        int valoreletto;
        int valoresalvato1 = Array[0];
        int valoresalvato2 = Array[1];

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto < valoresalvato1) valoresalvato1 = valoreletto;
        }

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto < valoresalvato2 && valoreletto > valoresalvato1) valoresalvato2 = valoreletto;
        }

        Debug.Log("Valore minimo 1  = " + valoresalvato1);
        Debug.Log("Valore minimo 2  = " + valoresalvato2);
    }


    void TrovaMassimo_2(int[] Array)
    {
        int valoreletto;
        int valoresalvato1 = Array[0];
        int valoresalvato2 = Array[1];

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto > valoresalvato1) valoresalvato1 = valoreletto;
        }

        for (int i = 0; i < Array.Length; i++)
        {
            valoreletto = Array[i];
            if (valoreletto > valoresalvato2 && valoreletto < valoresalvato1) valoresalvato2 = valoreletto;
        }

        Debug.Log("Valore massimo 1  = " + valoresalvato1);
        Debug.Log("Valore massimo 2  = " + valoresalvato2);
    }


}
