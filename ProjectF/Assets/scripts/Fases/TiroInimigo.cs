using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TiroInimigo : MonoBehaviour
{

    public float speed = 5f;

    private int damage = 1;
    public AudioSource audioSourceDano;

    GameManager gameManager;
    void Start(){
        gameManager = GameManager.Instance;
    }

    // Update is called once per frame
    void Update(){
        transform.Translate(Vector3.right * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collision){
        Scene scene = SceneManager.GetActiveScene();

        if(collision.CompareTag("DestruirObjeto")){
            Destroy(gameObject);
        }

        if (scene.name == "GinasioFase"){


            // if(collision.CompareTag("DestruirObjeto")){
            //     Destroy(gameObject);
            // }

            if (collision.CompareTag("Player")){
                gameManager.Lifes -= damage;
                Destroy(gameObject);
            }


        }

        else if (scene.name == "FasePredioK"){
            damage = 2;

            // if (collision.CompareTag("DestruirObjeto"))
            // {
            //     Destroy(gameObject);
            // }

            if (collision.CompareTag("Player")){
                gameManager.Lifes -= damage;
                Destroy(gameObject);
                
            }


        }else if (scene.name == "CastelinhoFase"){
            damage = 1;

            // if (collision.CompareTag("DestruirObjeto"))
            // {
            //     Destroy(gameObject);
            // }

            if (collision.CompareTag("Player")){
                gameManager.Lifes -= damage;
                Destroy(gameObject);
            }

        }else if (scene.name == "Maua"){
            damage = 2;

            // if (collision.CompareTag("DestruirObjeto"))
            // {
            //     Destroy(gameObject);
            // }

            if (collision.CompareTag("Player")){
                gameManager.Lifes -= damage;
                Destroy(gameObject);
            }
        }
    }
}
