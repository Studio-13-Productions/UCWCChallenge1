using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PropellerSpin : MonoBehaviour

{
    public float rotationSpeed = 10;
    public Vector3 propellerAngle = new Vector3(0,0,1);

    // Start is called before the first frame update
    void Start()
    {
        
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //spins the propeller on the Z axis to rotate
        transform.Rotate(propellerAngle* rotationSpeed );
        
    }
}
