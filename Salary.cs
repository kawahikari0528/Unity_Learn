using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Salary : MonoBehaviour
{

    private int salary;

    public int SalaryP { get { return salary; } private set { salary = value; } }
    // Start is called before the first frame update
    void Start()
    {
        SalaryP = 10;
        print(SalaryP);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
