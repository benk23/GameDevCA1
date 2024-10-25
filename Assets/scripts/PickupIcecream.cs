using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickupIcecream : MonoBehaviour
{

public GameObject IceCreamOnPlayer;
    void Start()
    {
        IceCreamOnPlayer.SetActive(false);
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.tag == "Player")
        {
            if(Input.GetKey(KeyCode.E))
            {
                
                IceCreamOnPlayer.SetActive(true);
            }
        }
    }


}
