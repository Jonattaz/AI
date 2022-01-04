using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShooter : MonoBehaviour
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

    [SerializeField]
    //Faz referência ao projétil do inimigo
    GameObject projectile;

    [SerializeField]
    // Tempo entre os tiros
    float timeBetweenShots;

    // Reserva o tempo do próximo tiro
    float nextShotTime;

    [SerializeField]
    // Ponto de spawn do tiro
    Transform spawnShoot;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


        if (Time.time > nextShotTime)
        {
            Instantiate(projectile, spawnShoot.position, Quaternion.identity);
            nextShotTime = Time.time + timeBetweenShots;
        }



        //Verifica se a distância do inimigo é menor que a distância minima
        if (Vector2.Distance(transform.position, target.position) < minimunDistance)
        {
            // Faz o inimigo recuar do alvo
            transform.position = Vector2.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        }
        else
        {
            // Fazer o inimigo atacar quando se afasta. Testar
        }
    }
}
