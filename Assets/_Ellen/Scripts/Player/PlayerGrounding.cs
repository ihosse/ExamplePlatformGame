using UnityEngine;

public class PlayerGrounding : MonoBehaviour
{
    public bool IsGrounded {  get; private set; }

    private Transform groundMovingObject;
    private Vector3? groundMovObjectLastPosition;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.isTrigger == true)
            return;

        IsGrounded = true;

        if(collision.GetComponentInParent<Mover>() != null)
        {
            groundMovingObject = collision.transform;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.isTrigger == true)
            return;

        IsGrounded = false;
        groundMovingObject = null;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(groundMovingObject != null)
        {
            if(groundMovObjectLastPosition.HasValue &&
               groundMovObjectLastPosition.Value != groundMovingObject.position)
            {
                Vector3 delta = groundMovingObject.position - groundMovObjectLastPosition.Value;
                transform.position += delta;
            }
            groundMovObjectLastPosition = groundMovingObject.position;
        }
        else
        {
            groundMovObjectLastPosition = null;
        }
    }
}
