// GameDev.tv ChallengeClub.Got questionsor wantto shareyour niftysolution?
// Head over to - http://community.gamedev.tv

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorChanger : MonoBehaviour
{
    private SpriteRenderer mySpriteRenderer;

    void Awake()
    {
        mySpriteRenderer = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {

    }
}
