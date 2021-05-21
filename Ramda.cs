using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ramda : MonoBehaviour
{
    int a = 5;
    int b = 5;
    int sum;

    void Add()
    {
        sum = a + b;
        Back();
    }
    void Back()
    {
        sum = 0;
    }

    delegate void MyDelegate();
    MyDelegate myDelegate;
    // Start is called before the first frame update
    void Start()
    {
        myDelegate = Add;
        myDelegate += Back;

        myDelegate();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
