using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArrayExample : MonoBehaviour
{
    private int a = 10;
    private int[] students = new int[3] { 1, 2, 3 };
    private int[] students2;

    private void Start()
    {
        students2 = new int[10];

        for(int i = 0; i < students2.Length; i++)
        {
            students2[i] = i % 6;
        }

        for(int i = 0; i < students2.Length; i++)
        {
            Debug.Log(students2[i]);
        }
    }
}
