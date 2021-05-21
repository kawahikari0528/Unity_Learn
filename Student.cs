using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Student : Human
{
    string schoolName;

    // Start is called before the first frame update
    void Start()
    {
        schoolName = "school";
        humanName = "name";
        humanAge = 8;

        Info();
    }

    protected override void Info()
    {
        base.Info();
        print("¾È³ç");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
