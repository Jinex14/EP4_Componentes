using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camara : MonoBehaviour
{
    public Transform player;
    public float linicx, lfinalx, linicy, lfinaly;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        {
        transform.position = new Vector3 (Mathf.Clamp(player.position.x, linicx, lfinalx),
        Mathf.Clamp(player.position.y, linicy, lfinaly),-10);
        }
    }
    
}
