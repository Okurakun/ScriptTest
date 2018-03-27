using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*public class Test : MonoBehaviour
{
    void Start()
    {
        int[] array = { 25, 10, 30, 20, 5, 15 };

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }

        for (int i = 5; i <= array.Length; i--)


        {
            Debug.Log(array[i]);

            if (i == 0)
                break;
        }



    }
    */

    public class Magical
    {

        int mp = 53;


        public void Magic(int mpdamage)
        {
            mp -= mpdamage;

            if (mp >= 3)
            {
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

 