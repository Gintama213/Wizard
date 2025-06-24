using Unity.VisualScripting;
using UnityEngine;

public class Fireball_Red : MonoBehaviour
{
    
    private Animator animator;

    private SpriteRenderer sR;


    void Start() 
    {
        animator = GetComponent<Animator>();
        sR = GetComponent<SpriteRenderer>();

        Destroy(gameObject,5);
        int r = Random.Range(0, 3);

        animator.SetInteger("type", r);
        sR.flipX = true;
        transform.localScale = new Vector3(-1, 1, 1);
    }
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * 2);
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
       if (collision.gameObject.name != "Wizard") 
        {
            Destroy(gameObject);
        }
        
        
    }


}
