using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var : MonoBehaviour
{
    void Print<T>(T value) //���� �����ֱ� where T : class && struct ��
    {
        print(value);
    }
    // Start is called before the first frame update
    void Start()
    {
        Print<string>("abc");
        Print<float>(4.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
