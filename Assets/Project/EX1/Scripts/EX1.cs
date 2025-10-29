using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Calcolo e stampo in console le tabelline dall'1 al 10
        for (int i = 0; i < 10; i++)
        {
            for (int j = 1; j <= 10; j++)
            {
                int numero = (i + 1) * j;
                Debug.Log(numero);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
