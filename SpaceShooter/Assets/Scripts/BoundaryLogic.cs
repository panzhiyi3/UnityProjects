using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundaryLogic : MonoBehaviour
{
    void OnTriggerExit(Collider other)
    {
        Destroy(other.gameObject);
    }
}
