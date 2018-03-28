using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magical
{

    int mp = 53;


    public void Magic(int mpdamage)
    {
        if (mp >= mpdamage)
        {
            mp -= mpdamage;
            Debug.Log("魔法攻撃をした。残りMPは" + mp);
        }
        else
        {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }

}

public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 25, 10, 30, 20, 5, 15 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 5; i > -1; i--)
        {
            Debug.Log(array[i]);
        }

        Magical magical = new Magical();


        for (int i = 0; i < 11; i++)
        {
            magical.Magic(5);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}