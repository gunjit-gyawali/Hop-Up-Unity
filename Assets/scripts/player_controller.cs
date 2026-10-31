using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private float speed = 5f;
    private float inputDirection;
    void Start()
    {
        
    }

    void Update()
    {
        if (inputDirection != 0)
        {
            transform.Translate(Vector2.right * inputDirection * speed * Time.deltaTime);
            // rotate the player to face the direction of movement 
            if (inputDirection > 0)
            {
                transform.localScale = new Vector3(3, 3, 3);
            }
            else
            {
                transform.localScale = new Vector3(-3, 3, 3);
            }
        }
    }
    public void OnMove(InputValue direction)
    {
        inputDirection = direction.Get<float>();

    }
}