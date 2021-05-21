using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Var : MonoBehaviour
{
    void Print<T>(T value) //형식 정해주기 where T : class && struct 등
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
