using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class weapon25 : MonoBehaviour
{

    int count;

    private void Awake()
    {
        count = 0;
    }

    void Start()
    {
        for (int i = 0; i < 5; i++)
        {
            Debug.Log("반복문이 실행됐어요.");
        }

        // i=0, 0<5
        Debug.Log("반복문이 실행됐당께.");
        // i++

        // i=1, 1<5
        Debug.Log("반복문이 실행됐당께.");
        // i++

        // i=2, 2<5
        Debug.Log("반복문이 실행됐당께.");
        // i++

        // i=3, 3<5
        Debug.Log("반복문이 실행됐당께.");
        // i++

        // i=4, 4<5
        Debug.Log("반복문이 실행됐당께.");
        // i++

        // i=5, 5 =5
        Debug.Log("반복문이 실행됐당께.");
        // 반복문 종료


    }

    public void Gacha()
    {
        // 확률이 0.5%면 25강 강화 성공!
        // 확률이 99%면 강화 실패!
        // 나머지 0.5% 확률로 장비 파괴!

        int randomValue = Random.Range(1, 1001); // 1이상 1001미만의 랜덤한 값을 받아 오겠다. (1 ~ 1000) 

        if (20 <= count)
        {
            Debug.Log("장기백이다!");
            count = 0;
        }
        else if (randomValue <= 5) // 1 ~ 5 -> 0.5%
        {
            Debug.Log("25강 성공!");
        }
        else if (randomValue <= 10) // 6 ~ 10
        {
            Debug.Log("장비가 파괴되었다!");
        }
        else
        {
            Debug.Log("강화실패!");
        }

        Debug.Log($"랜덤한 값은 : {randomValue} 입니다");
        // count 81

        count++;
    }
}


