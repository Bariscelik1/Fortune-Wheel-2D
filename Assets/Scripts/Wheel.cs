using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel : MonoBehaviour
{
    [SerializeField]
    float RotatePower;
    [SerializeField]
    float StopPower;

    private Rigidbody2D rb;
    int inRotate;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    float t;
    private void Update()
    {

        if (rb.angularVelocity > 0)
        {
            rb.angularVelocity -= StopPower * Time.deltaTime;

            rb.angularVelocity = Mathf.Clamp(rb.angularVelocity, 0, 1440);
        }

        if (rb.angularVelocity == 0 && inRotate == 1)
        {
            t += 1 * Time.deltaTime;
            if (t >= 0.5f)
            {
                GetReward();

                inRotate = 0;
                t = 0;
            }
        }
    }


    public void Rotate()
    {
        RotatePower = Random.Range(500, 700); //ödüllerin rastgele gelmesi için 
        if (inRotate == 0)
        {
            rb.AddTorque(RotatePower);
            inRotate = 1;
        }
    }



    public void GetReward()
    {

        
        float rot = transform.eulerAngles.z;

        //Çarktaki bölme sayýsý kadar else if

        if (rot > 0  && rot <= 25.714f ) //0 ile 360/14(çarktaki bölme sayýsý) arasý
        {
            //Çark döndüðünde ok her zaman bölmenin tam üstünde kalmýyor o yüzden oku bölmenin tam ortasýna getirmek için alttaki kodu yazmalýyýz.
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f);
            Win(100);
        }
        else if (rot > 25.714f  && rot <= 25.714f*2 ) // 1. ile 2. bölme arasý 360/14 ile 360/14*2 derece arasý
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*2);
            Win(100);
        }
        else if (rot > 25.714f*2  && rot <= 25.714f*3 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*3);
            Win(100);
        }
        else if (rot > 25.714f*3  && rot <= 25.714f*4 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*4);
            Win(100);
        }
        else if (rot > 25.714f*4  && rot <= 25.714f*5 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*5);
            Win(100);
        }
        else if (rot > 25.714f*5 && rot <= 25.714f*6 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*6);
            Win(100);
        }
        else if (rot > 25.714f*6  && rot <= 25.714f*7 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*7);
            Win(100);
        }
        else if (rot > 25.714f*7  && rot <= 25.714f*8 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*8);
            Win(100);
        }
        else if (rot > 25.714f*8 && rot <= 25.714f*9 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*9);
            Win(100);
        }
        else if (rot > 25.714f*9  && rot <= 25.714f*10 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*10);
            Win(100);
        }
        else if (rot > 25.714f*10 && rot <= 25.714f*11)
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*11);
            Win(100);
        }
        else if (rot > 25.714f*11 && rot <= 25.714f*12 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*12);
            Win(100);
        }
        else if (rot > 25.714f*12  && rot <= 25.714f*13)
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*13);
            Win(100);
        }
        else if (rot > 25.714f*13  && rot <= 25.714f*14 )
        {
            GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 25.714f*14);
            Win(100);
        }

    }


    public void Win(int Score)
    {
        print(Score);
    }


}
