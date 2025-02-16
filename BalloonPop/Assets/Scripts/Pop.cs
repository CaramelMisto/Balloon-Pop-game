using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pop : MonoBehaviour
{
    public int score = 1;
    public int clicktopop = 5;
    public float scale_increase_per_click = 0.1f;
    public Score scorecount;

    private void OnMouseDown()
    {
        clicktopop -= 1;

        //increase x y and z scales per click
        transform.localScale += Vector3.one * scale_increase_per_click;

        if (clicktopop == 0 )
        {
            scorecount.Scoreincrease(score);
            Destroy(gameObject);

        }
    }
      

}
