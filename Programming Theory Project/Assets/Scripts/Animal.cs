using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Animal : MonoBehaviour
{
    [SerializeField]
    private float jumpheight;
    public Rigidbody rb { get; set; } //ENCAPSULATION

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetMouseButtonDown(0))
        {
            MakeSound();
        }
    }

    //Identifying a method as virtual indicates that it can, but doesn’t have to, be overridden.
    public virtual void Jump() //ABSTRACTION
    {
        rb.AddForce(transform.up * jumpheight, ForceMode.Impulse);
    }

    //Unlike virtual methods for which overriding is optional, this method uses the abstract notation, which indicates that it must be overridden.
    protected abstract void MakeSound();
}
