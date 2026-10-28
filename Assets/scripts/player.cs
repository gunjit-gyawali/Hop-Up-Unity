using UnityEngine;
using UnityEngine.InputSystem;

public class player : MonoBehaviour
{
    private float speed = 5f;
    private float inputDirection;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (inputDirection != 0)
        {
            transform.Translate(Vector2.right * inputDirection * speed * Time.deltaTime);
        }
    }
    public void OnMove(InputValue direction)
    {
        inputDirection = direction.Get<float>();

    }
}
