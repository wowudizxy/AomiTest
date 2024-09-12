using UnityEngine;

public class BallCollision : MonoBehaviour
{
    private Renderer ballRenderer;
    private void Start()
    {
        ballRenderer = GetComponent<Renderer>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ball"))
        {
            ballRenderer.material.color = Color.red; 
        }
    }
}
