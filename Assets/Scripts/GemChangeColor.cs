using UnityEngine;

public class GemChangeColor : MonoBehaviour
{
    private const string blockTag = "Block";

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag(blockTag))
        {
            GameObject player = collision.gameObject;
            player.GetComponent<SpriteRenderer>().color = this.GetComponent<SpriteRenderer>().color;
        }
    }
}