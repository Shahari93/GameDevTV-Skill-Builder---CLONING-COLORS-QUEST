using System.Collections;
using UnityEngine;

public class FlashCoin : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    private bool isColliding = false;

    private void Start()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (isColliding)
        {
            StartCoroutine(CollidWithCoin());
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("Block") && collision.gameObject.GetComponent<SpriteRenderer>().color != mySpriteRenderer.color)
        {
            isColliding = true;
        }
    }

    private IEnumerator CollidWithCoin()
    {
        Color color = mySpriteRenderer.color;
        color.a = Mathf.PingPong(Time.time, 1);
        mySpriteRenderer.color = color;
        yield return new WaitForSecondsRealtime(.5f);
        color.a = 1;
        mySpriteRenderer.color = color;
        isColliding = false;
    }
}