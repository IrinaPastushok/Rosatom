using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
public class Change : MonoBehaviour
{
    public Sprite[] ImgList;
    SpriteRenderer Sprite;
    public int IndexImg = 1;
    public int temp = 25;
    public int n;
    public int b;
    // Start is called before the first frame update
    void Start()
    {
        //IndexImg = Random.Range(0, 3);
        Sprite = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        n = Random.Range(0, 10);
        if (n < 2)
        {
            b = Random.Range(-1, 2);
            if (b == -1)
            {
                temp--;
            }
            if (b == 1)
            {
                temp++;
            }
        }
        //IndexImg = Random.Range(0, 3);
        if (temp >= 30) IndexImg = 2;
        if ((temp > 15) && (temp < 30)) IndexImg = 1;
        if (temp <= 15) IndexImg = 0;
        Thread.Sleep(100);
        Sprite.sprite = ImgList[IndexImg];
    }
}
