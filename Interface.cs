using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class A : MonoBehaviour
{
    abstract public void Abc();
}

interface ITest
{
    //다중상속, 변수오는거 불가능
    void Bbc();
    //함수, 프로퍼티, 인덱서, 이벤트

    int SalaryP { get; set; }
}

interface ITest2 : ITest
{

}
public class Interface : A, ITest2 //상속을 2개 이상 하는게 인터페이스임
{//빠른 작업
    public int SalaryP { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void Abc()
    {
        print("abc");
    }

    public void Bbc()//인터페이스는 override 노필요
    {
        print("bbc");
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
