using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GiveIceCream : MonoBehaviour
{

public GameObject IceCreamOnPlayer;
public GameObject Celebration_Particle;

    void Start()
    {
                Celebration_Particle.SetActive(false);

    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                
                IceCreamOnPlayer.SetActive(false);
                Celebration_Particle.SetActive(true);

            }
        }
    }


}
