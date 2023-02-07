using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Finish : MonoBehaviour
{
    public Setting Levels;
         void OnTriggerEnter()
    {
        Levels.Next();
    }
}
