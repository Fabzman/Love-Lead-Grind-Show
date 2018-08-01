using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boundary : MonoBehaviour {

    private void OnTriggerExit(Collider other)
    {
        Destroy (GameObject.FindGameObjectWithTag("Shot"));
    }
}
