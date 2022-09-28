using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackground : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position; //Guardamos la Posición actual
        repeatWidth = gameObject.GetComponent<BoxCollider>().size.x / 2f; //Obtenemos el valor de la mitad exacta de nuestro fondo
    }

    // Update is called once per frame
    void Update()
    {
        //Si la posición actual pasó la mitad de nuestro fondo, que vuelva a su posición inicial
        if (transform.position.x < startPos.x - repeatWidth) transform.position = startPos;
    }
}
