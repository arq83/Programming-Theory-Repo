using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chicken : Animal //INHERITANCE
{
    protected override void MakeSound()// POLYMORPHISM
    {
        Debug.Log("Bwak! Bwak! Bwaaak!");
    }
}
