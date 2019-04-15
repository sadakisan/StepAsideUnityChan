using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour {

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "CoinTag")
        {
            Destroy(other.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "CoinTag" || other.gameObject.tag == "CarTag" || other.gameObject.tag == "TrafficConeTag")
        {
            Destroy(other.gameObject);
        }
    }
}