using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EX2 : MonoBehaviour
{
    [SerializeField] private int number;
    [SerializeField] private int baseNumber;
    [SerializeField] private int multipleNumber;

    // Start is called before the first frame update
    void Start()
    {
        if (IsEven(number))
        {
            Debug.Log("Il numero : " + number + " �  un numero PARI !!! ");
        }
        else
        {
            Debug.Log("Il numero : " + number + " � DISPARI !!! ");
        }

        if (isMultipleOf(baseNumber, multipleNumber))
        {
            Debug.Log("Il numero : " + multipleNumber + " � multiplo del numero " + baseNumber);
        }
        else
        {
            Debug.Log("Il numero : " + multipleNumber + " NON � un multiplo del numero " + baseNumber);
        }

    }

    bool IsEven(int value)
    {
        if (value % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
    bool isMultipleOf(int baseNumber, int multiple)
    {
        if (multiple % baseNumber == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
