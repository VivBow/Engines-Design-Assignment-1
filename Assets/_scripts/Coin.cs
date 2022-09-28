using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{

    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.tag == "Player")
        {
            ScoresManager.instance.ChangeScore(1);
            Destroy(gameObject);

        }
    }
    void Start()
    {

    }

    void Update()
    {

    }
}

