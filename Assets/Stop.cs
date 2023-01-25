using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "death")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "health")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "1.5")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "4")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "3.75")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "5.25")
        {
            Destroy(other.gameObject);
        }
    }
}
