using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControlllerScript : MonoBehaviour
{
    [Header("Player Component Reference")]
    [SerializeField] Rigidbody2D rb;

    [Header("Player Settings")]
    [SerializeField] float speed;
    [SerializeField] float jumpingpower;

    [Header("Grounding")]
    [SerializeField] LayerMask groundlayer;
    [SerializeField] Transform groundChenk;

    private float horizontal;

    private void FixedUpdate()
    {
        rb.linearVelocity = new Vector2(horizontal * speed, rb.linearVelocityY);
    }

    #region PLAYER_CONTROLS
    public void Move(InputAction.CallbackContext context)
    {
        horizontal = context.ReadValue<Vector2>().x;
    }

    #endregion

}
