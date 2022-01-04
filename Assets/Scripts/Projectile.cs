using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{

    // Posição do alvo
    Vector3 targetPosition;

    [SerializeField]
    // Velocidade do projétil
    float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Fazer com que o alvo seja um objeto com o script do player
        //targetPosition = FindObjectOfType<Player>().transform.position;

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);

        // Destroy projétil caso a posição seja igual a do alvo(acertou)
        if (transform.position == targetPosition)
        {
            Destroy(gameObject);
        }
    }
}
















