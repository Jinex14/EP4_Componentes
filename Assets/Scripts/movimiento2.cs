using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento2 : MonoBehaviour
{
    public Rigidbody2D rbd;
    public float f;
    public float speed;
     private SpriteRenderer spitee;
    public GameObject particula;
    private bool aux = false;
    void Start()
    {
        spitee = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (aux)
        {
            if (Input.GetKeyDown(KeyCode.Keypad8))
            {
                rbd.AddForce(Vector2.up * f, ForceMode2D.Impulse);
            }

            if (Input.GetKey(KeyCode.Keypad6))
            {
                rbd.velocity = new Vector2(speed, rbd.velocity.y);
                spitee.flipX = true;
            }

            else if (Input.GetKey(KeyCode.Keypad4))
            {
                rbd.velocity = new Vector2(-speed, rbd.velocity.y);
                spitee.flipX = false;
            }

            else
            {
                rbd.velocity = new Vector2(0, rbd.velocity.y);
            }

        }
    }

    IEnumerator activeParticles()
    {
        aux = false;
        rbd.velocity = new Vector2(0, rbd.velocity.y);
        particula.transform.position = transform.position;
        particula.GetComponent<ParticleSystem>().Play();
        yield return new WaitForSeconds(3);
        StartCoroutine(activeParticles());
    }

    public void winActive()
    {
        StartCoroutine(activeParticles());
    }

    public void startGame()
    {
        aux = true;
    }
}
