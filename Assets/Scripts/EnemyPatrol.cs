using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField]
    // Velocidade do inimigo
    float speed;

    [SerializeField]
    // Pontos de patrulhas
    Transform[] patrolPoints;

    [SerializeField]
    // Controla quanto tempo o inimigo irá ficar em cada ponto de patrulha
    float waitTime;

    // Armazena qual ponto o inimigo está 
    int currentPointIndex;

    // Controla a corrotina
    bool once;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != patrolPoints[currentPointIndex].position)
        {
            //Faz o inimigo se mover em  direção aos pontos
            transform.position = Vector2.MoveTowards(transform.position, patrolPoints[currentPointIndex].position, speed * Time.deltaTime);
        }
        else
        {
            if (once == false)
            {
                once = true;
                StartCoroutine(Wait());
            }
        }
    }


    // Controla o tempo que o inimigo fica parado
    IEnumerator Wait()
    {
        yield return new WaitForSeconds(waitTime);
        if (currentPointIndex + 1 < patrolPoints.Length)
        {
            currentPointIndex++;
        }
        else
        {
                currentPointIndex = 0;
        }
        once = false;
    }
















}
