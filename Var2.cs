using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Abc<T>{
    public T var;
    public T[] array;
}//형식 매개 변수 T//
public class Var2 : MonoBehaviour
{
    Abc<string> a;
    Abc<float> b;
    // Start is called before the first frame update
    void Start()
    {
        a.var = "abc";
        b.var = 4.5f;

        a.array = new string[1];
        b.array = new float[1];

        a.array[0] = "abc";
        b.array[0] = 4.5f;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
