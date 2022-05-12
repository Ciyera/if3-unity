 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateObjects : MonoBehaviour
{
  public float rotationSpeed ; 
  public Space mySpace; 
    

    // Update is called once per frame
    void Update()
    {
      transform.Rotate(0,rotationSpeed * Time.deltaTime,0,Space.World);
      
    }
}
