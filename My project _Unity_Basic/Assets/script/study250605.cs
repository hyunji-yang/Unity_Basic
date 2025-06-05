using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class study250605 : MonoBehaviour
{
    private string playerName = "양현지";
    private int age = 28;
    private string bloodType = "O";
    private string mbti = "ENTP";
    private int studyHoursPerDay = 8;
    private int screenTimeHours = 16;
    private string hobby = "RollPlayingGame";
    private string nickName = "현지";
    private int favoriteGameRank = 13783;
    private string favoriteKpopStar = "세븐틴";



    // Start is called before the first frame update
    void Start()
    {
        selfIntroduction();
        selfIntroduction(playerName,age);
    }

    public void selfIntroduction()
    {
        Debug.Log("저의 이름은" + playerName + "입니다.");
        Debug.Log($"저의 나이는 {age}살 입니다.");
        Debug.Log("제 혈액형은" + bloodType + "형 입니다.");
        Debug.Log("제 MBTI는" + mbti + "입니다.");
        Debug.Log($"저는 하루 {studyHoursPerDay}시간을 공부 하고");
        Debug.Log($"{screenTimeHours}시간 동안 컴퓨터를 합니다.");
        Debug.Log("제 취미는" + hobby + "입니다.");
        Debug.Log("게임에서" + nickName + "라는 닉네임을 사용하고 있고");
        Debug.Log($"랭킹은 전체 {favoriteGameRank}등 입니다.");
        Debug.Log("좋아하는 K-pop 아이돌은" + favoriteKpopStar +"입니다."); 
    }

    public void selfIntroduction(string _playerName, int _age)
    {
        Debug.Log("저의 이름은" + _playerName + "입니다.");
        Debug.Log($"저의 나이는 {_age}살 입니다.");
    }
  
}
