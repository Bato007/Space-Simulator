using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class triggerHealth : MonoBehaviour
{
    public GameObject option;
    public GameObject vending;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (option && collision.tag != "Arrow")
            option.SetActive(true);

        // Va para el Controll Room
        if (Input.GetKeyDown(KeyCode.R))
        {
            vending.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (option && collision.tag != "Arrow")
            option.SetActive(false);
    }

}
