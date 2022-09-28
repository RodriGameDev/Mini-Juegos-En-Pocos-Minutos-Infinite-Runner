using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public bool gameOver = false;
    [SerializeField] private bool jumping = false;
    private Rigidbody playerRb;
    private PlayerScore playerScoreScript;

    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
        playerScoreScript = GetComponent<PlayerScore>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.UpArrow)) && !jumping)
        {
            playerRb.AddForce(Vector3.up * 5, ForceMode.Impulse);
            jumping = true; //Cambiamos la var a true para que no pueda hacer un double jump
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        //Si toca el suelo, cambiamos la var bool
        if (other.gameObject.CompareTag("Floor"))
        {
            jumping = false;
        }

        if (other.gameObject.CompareTag("Obstacle"))
        {
            gameOver = true;
            Debug.Log("Has perdido!");
            Debug.Log("Puntaje final: " + ((int)playerScoreScript.scoring));

            Time.timeScale = 0; //Pausa
        }
    }
}
