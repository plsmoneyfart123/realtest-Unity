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

    public void Jump(InputAction.CallbackContext context)
    {
        if (context.performed && IsGrounded())
        {
            rb.linearVelocity = new Vector2(rb.linearVelocityX, jumpingpower);
        }
    }

    private bool IsGrounded()
    {
        return Physics2D.OverlapCapsule(groundChenk.position, new Vector2(0.65f, 0.1f), CapsuleDirection2D.Horizontal, 0, groundlayer);
    }

    #endregion


}
