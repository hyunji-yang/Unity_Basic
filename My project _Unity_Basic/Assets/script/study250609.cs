using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class study250609 : MonoBehaviour
{
    void Start()
    {
        int RandomValue = Random.Range(1,101); //1 이상 100미만의 랜덤한 값을 받아오겠다.(1~100)

        Debug.Log($"랜덤한 값은 : {RandomValue}입니다.");

        if(RandomValue <= 4) // 4%의 확률, 1~4
        {
            Debug.Log("전설 카드 팩이 나왔습니다.");
        }
        else if(RandomValue <= 24) // 20%의 확률, 5~24
        {
            Debug.Log("영웅 카드 팩이 나왔습니다.");
        }
        else
        {
            Debug.Log("희귀 카드 팩이 나왔습니다.");
        }


    }

}
