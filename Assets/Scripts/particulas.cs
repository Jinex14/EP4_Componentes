using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class particulas : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.name == "Player1")
        {
            GameObject.Find("Player1").GetComponent<movimiento>().winActive();
            gameObject.SetActive(false);
        }
        if (collision.gameObject.name == "Player2")
        {
            GameObject.Find("Player2").GetComponent<movimiento2>().winActive();
            gameObject.SetActive(false);
        }
    }
}
