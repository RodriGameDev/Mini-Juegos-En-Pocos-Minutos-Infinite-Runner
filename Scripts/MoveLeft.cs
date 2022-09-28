using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    private float speed = 5f, leftBound = -12f;

    // Update is called once per frame
    void Update()
    {
        //Background
        transform.Translate(Vector3.left * Time.deltaTime * speed);

        //Comprueba cuando el obstaculo desaparece de la pantalla
        if (transform.position.x < leftBound && gameObject.CompareTag("Obstacle"))
        {
            Destroy(gameObject); //Lo destruimos
        }
    }
}
