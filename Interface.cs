using System.Collections;
using System.Collections.Generic;
using UnityEngine;


abstract public class A : MonoBehaviour
{
    abstract public void Abc();
}

interface ITest
{
    //���߻��, �������°� �Ұ���
    void Bbc();
    //�Լ�, ������Ƽ, �ε���, �̺�Ʈ

    int SalaryP { get; set; }
}

interface ITest2 : ITest
{

}
public class Interface : A, ITest2 //����� 2�� �̻� �ϴ°� �������̽���
{//���� �۾�
    public int SalaryP { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

    public override void Abc()
    {
        print("abc");
    }

    public void Bbc()//�������̽��� override ���ʿ�
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
