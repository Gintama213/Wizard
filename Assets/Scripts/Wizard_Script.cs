using UnityEngine;

public class Wizard_Script : MonoBehaviour
{

    public GameObject FireballPrefab;
   

    public float moveSpeed = 2f;

    // Update is called once per frame
    void Update()
    {
        Movement();
        Casting();
    }

    private void Movement()
    {
        Vector3 velocity = Vector3.zero;

        //float f = Input.GetAxis("Horizontal");
        if (Input.GetKey(KeyCode.W))
        {
            velocity.y += 2;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velocity.y -= 2;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velocity.x += 2;
        }
        if (Input.GetKey(KeyCode.A))
        {
            velocity.x -= 2;
        }
        if (velocity != Vector3.zero)
        {
            velocity = velocity.normalized * moveSpeed;
        }
        transform.position += velocity * Time.deltaTime;
    }
    private void Casting() 
    {
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            Vector3 position = transform.position + new Vector3(0.9f,0.8f,0);
            Instantiate(FireballPrefab);
        }
    }
    
}


