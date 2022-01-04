using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollower : MonoBehaviour
{

    [SerializeField]
    // Velocidade de movimento do inimigo
    float speed;

    [SerializeField]
    //Objeto que será perseguido
    Transform target;

    [SerializeField]
    //Faz o inimigo parar quando chega a certa distância do alvo
    float minimunDistance;
     
    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        //Verifica se a distância do inimigo é maior que a distância minima
        if(Vector2.Distance(transform.position, target.position) > minimunDistance){
            // Faz o inimigo seguir o alvo
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
        else
        {
            // Fazer o inimigo atacar quando chega perto
        }
    }
}





















