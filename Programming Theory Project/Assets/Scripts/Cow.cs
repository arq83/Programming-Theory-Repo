using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cow : Animal //INHERITANCE
{
    protected override void MakeSound()// POLYMORPHISM
    {
        Debug.Log("Moo! Moo! Moo!");
    }
}
