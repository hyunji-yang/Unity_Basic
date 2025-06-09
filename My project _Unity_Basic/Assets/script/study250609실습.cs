using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class study250609실습 : MonoBehaviour
{
    // List<자료형> 식별자 = new List<자료형>();
    List<string> tier4cardList = new List<string>();

    // Start is called before the first frame update
    void Start()
    {

        /*
        string[] array = new string[18];
        array[0] = "각성한 진저웨일 카드";
        array[1] = "교활한 카마인 카드";
        array[2] = "구스토 카드";
        array[3] = "도철을 다루는 웨이 카드";
        array[4] = "라제니스를 이끄는 니나브 카드";
        array[5] = "바실리오 카드";
        array[6] = "부활하는 카제로스 카드";
        array[7] = "선택한 아만 카드";
        array[8] = "심연의 방랑자 카드";
        array[9] = "악몽의 아브렐슈드 카드";
        array[10] = "욕망의 비아키스 카드";
        array[11] = "유적을 찾은 카단 카드";
        array[12] = "작전을 지휘하는 샨디 카드";
        array[13] = "전장을 지배하는 아제나 카드";
        array[14] = "절망의 카멘 카드";
        array[15] = "찢겨진 발탄 카드";
        array[16] = "총사령관 실리안 카드";
        array[17] = "춤추는 쿠크세이튼 카드";
        array[18] = "피요르긴을 휘두르는 바훈트르 카드";
        */

        tier4cardList.Add("각성한 진저웨일 카드"); // 0번
        tier4cardList.Add("교활한 카마인 카드"); // 1번
        tier4cardList.Add("구스토 카드"); // 2번
        tier4cardList.Add("도철을 다루는 웨이 카드"); // 3번
        tier4cardList.Add("라제니스를 이끄는 니나브 카드"); // 4번
        tier4cardList.Add("바실리오 카드"); // 5번
        tier4cardList.Add("부활하는 카제로스 카드"); // 6번
        tier4cardList.Add("선택한 아만 카드"); // 7번
        tier4cardList.Add("심연의 방랑자 카드"); // 8번
        tier4cardList.Add("악몽의 아브렐슈드 카드"); // 9번
        tier4cardList.Add("욕망의 비아키스 카드"); // 10번
        tier4cardList.Add("유적을 찾은 카단 카드"); // 11번
        tier4cardList.Add("작전을 지휘하는 샨디 카드"); // 12번
        tier4cardList.Add("전장을 지배하는 아제나 카드"); // 13번
        tier4cardList.Add("절망의 카멘 카드"); // 14번
        tier4cardList.Add("찢겨진 발탄 카드"); // 15번
        tier4cardList.Add("총사령관 실리안 카드"); // 16번
        tier4cardList.Add("춤추는 쿠크세이튼 카드"); // 17번
        tier4cardList.Add("피요르긴을 휘두르는 바훈트르 카드"); // 18번


        // array[접근하고 싶은 Index];
        // tier4cardList[접근하고 싶은 Index];

        // Debug.Log(array[2]); //구스토 카드
        Debug.Log(tier4cardList[2]); // 구스토 카드

        int[] arr = new int [18];
        List<int> list = new List<int>();

        void Start()
        {
            UnityEngine.Debug.Log(arr.Length); // 배열의 크기 18
            UnityEngine.Debug.Log(list.Count); // 리스트의 크기 : 0
        } 
    }
    
    public void tier4CardDraw()
    {   
        Debug.Log("=== 10연속 카드 열기 시작 ===");
        for (int i = 0; i < 10; i++)
        {
           int randomIndex = Random.Range(0, tier4cardList.Count); // 0 이상 Count 미만
           string selectedCard = tier4cardList[randomIndex];
           Debug.Log($"{i + 1}번째 카드: {selectedCard}");
        }

        Debug.Log("=== 종료 ===");
    }




}


/*
// List<자료형> 식별자 = new List<자료형>();

List<string> tier4cardList = new List<string>();
tier4cardList.Add("각성한 진저웨일 카드") // 0번
tier4cardList.Add("교활한 카마인 카드") // 1번
tier4cardList.Add("구스토 카드") // 2번
tier4cardList.Add("도철을 다루는 웨이 카드") // 3번
tier4cardList.Add("라제니스를 이끄는 니나브 카드") // 4번
tier4cardList.Add("바실리오 카드") // 5번
tier4cardList.Add("부활하는 카제로스 카드") // 6번
tier4cardList.Add("선택한 아만 카드") // 7번
tier4cardList.Add("심연의 방랑자 카드") // 8번
tier4cardList.Add("악몽의 아브렐슈드 카드") // 9번
tier4cardList.Add("욕망의 비아키스 카드") // 10번
tier4cardList.Add("유적을 찾은 카단 카드") // 11번
tier4cardList.Add("작전을 지휘하는 샨디 카드") // 12번
tier4cardList.Add("전장을 지배하는 아제나 카드") // 13번
tier4cardList.Add("절망의 카멘 카드") // 14번
tier4cardList.Add("찢겨진 발탄 카드") // 15번
tier4cardList.Add("총사령관 실리안 카드") // 16번
tier4cardList.Add("춤추는 쿠크세이튼 카드") // 17번
tier4cardList.Add("피요르긴을 휘두르는 바훈트르 카드") // 18번


// array[접근하고 싶은 Index];
// tier4cardList[접근하고 싶은 Index];

array[2]; //구스토 카드
tier4cardList[2]; // 구스토 카드

int[] arr = new int [18];
List<int> list = new List<int>();

void Start()
{
    UnityEngine.Debug.Log(arr.Length); // 배열의 크기 18
    UnityEngine.Debug.Log(list.Count); // 리스트의 크기 : 0
}
*/