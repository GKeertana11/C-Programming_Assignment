using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfElseConditions : MonoBehaviour
{
    public float GPA = 3.0F;
    public int option=3;
    // Start is called before the first frame update
    void Start()
    {
        if(GPA>=3.0F)
        {
            Debug.Log("congo! you made it to dean list");
        }
        else
        {
            Debug.Log("you cannot make  it to dean list");
        }

        switch (option)
        {
            case 1:
                print("Hello");
                break;
            case 2:
                print("im keertana");
                break;
            case 3:
                print("Ok bye");
                break;
            default:
                break;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
