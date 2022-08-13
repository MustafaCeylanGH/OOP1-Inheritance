using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylinderController : MonoBehaviour
{
    [SerializeField] Cylinder cylinder = new Cylinder();

    private void Start()
    {
        ObjectName();        
    }
    private void Update()
    {
        CylinderMovement();
        CylinderRotation();        
    }

    private void CylinderMovement() => transform.Translate(0, 0, -cylinder.moveSpeed * Time.deltaTime);
    private void CylinderRotation() => transform.Rotate(0, 0, cylinder.rotateSpeed * Time.deltaTime);
    private void ObjectName() => Debug.Log(cylinder.objectName);
}
