using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour
{
    [SerializeField] Cube cube = new Cube();

    private void Start()
    {
        ObjectName();
    }
    private void Update()
    {
        CubeMovement();
        CubeRotation();
    }

    private void CubeMovement() => transform.Translate(0, 0, -cube.moveSpeed * Time.deltaTime);    
    private void CubeRotation() => transform.Rotate(0, 0, cube.rotateSpeed * Time.deltaTime);
    private void ObjectName() => Debug.Log(cube.objectName);  
        
    
}
