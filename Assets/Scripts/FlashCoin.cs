using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class FlashCoin : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;
    private bool isColliding = false;
    [SerializeField] private Image coinImage;

    public bool hasCoin = false;

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
        if (collision.gameObject.CompareTag("Block") && collision.gameObject.GetComponent<SpriteRenderer>().color != mySpriteRenderer.color)
        {
            isColliding = true;
        }
        else if (collision.gameObject.CompareTag("Block"))
        {
            Destroy(this.gameObject);
            Color color = coinImage.color;
            color.a = 1;
            coinImage.color = color;
            hasCoin = true;
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