using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class InputsManager : MonoBehaviour
{
   public static InputsManager inputsManager;

   public Vector2 MoveInput { get ; private set; }
   
   void Awake()
    {
        if (inputsManager == null) inputsManager = this ;
        else Destroy(gameObject);
    }
   void OnMove(InputValue value)
    {
        MoveInput = value.Get<Vector2>();
    }

}
