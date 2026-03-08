using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
     Rigidbody2D rb; 
    [SerializeField] int speed = 3;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>(); 
          if (InputsManager.inputsManager == null)
        Debug.LogError("InputsManager is NULL - check your scene!");
    }
    void FixedUpdate()
    {
       rb.linearVelocity = InputsManager.inputsManager.MoveInput.normalized * speed;
    }


}
