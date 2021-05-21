using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Record
{
    public int[] temp = new int[5];

    public int this[int index]
    {
        get {
            if (index >= temp.Length)
            {
                Debug.Log("인덱스가 너무 크다고.");
                return 0;
            }
            else
            {
                return temp[index];
            }

        }
        set { if (index >= temp.Length) Debug.Log("인덱스가 너무 큼"); else temp[index] = value; }
    }
}
public class Index : MonoBehaviour
{
    Record record = new Record();
    // Start is called before the first frame update
    void Start()
    {
        record[3] = 5;
        record[5] = 5;
        print(record[3]);
        print(record[5]);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
