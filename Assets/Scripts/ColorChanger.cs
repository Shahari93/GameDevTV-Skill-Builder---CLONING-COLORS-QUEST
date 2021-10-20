// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using UnityEngine;

public enum ColorSelect
{
    Red,
    Yellow,
    Blue
};

public class ColorChanger : MonoBehaviour
{
    public ColorSelect colors;
    private SpriteRenderer mySpriteRenderer;

    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        AssignColor();
    }

    public void AssignColor()
    {
        switch (colors)
        {
            case ColorSelect.Red:
                mySpriteRenderer.color = Color.red;
                break;
            case ColorSelect.Yellow:
                mySpriteRenderer.color = Color.yellow;
                break;
            case ColorSelect.Blue:
                mySpriteRenderer.color = Color.blue;
                break;
        }
    }
}