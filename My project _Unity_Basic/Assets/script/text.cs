/* 
    //유니티의 주석은 '//'을 사용한다.
    여러줄 주석은 /* */ 
    //단축키 : Ctrl + K + C / Ctrl + K + U

    //Debug.Log의 역할은 로블록스에서 print의 역할과 비슷한 역할을 한다. 콘솔창에 로그를 띄워주는 역할이 메인이다.


    //TMI
    //Debug.Log("내용") : 하얀색으로 표시되는 기본 로그
    //Debug.LogWarning("내용) : 앞의 아이콘이 노란색 !로 표기
    //Debug.LogWarning("내용") : 앞의 아이콘이 빨간색으로 표기
    
    //이런 것들도 있습니다.하지만 플머가 노란색, 빨간색으로 뜨면 싫어하니 Log정도만 사용하셔도 됩니다
    //Debug.Log("안녕하세요");
    //Debug.Log("반갑습니다"); //유니티에서 모든 문장의 끝에는 반드시 세미콜론(;)을 사용해 주어야한다.
    //Ctrl+K+D 들여쓰기 자동 정렬

    /*
    Void 함수는 반환되는 값이 없을 때, 리턴하지 않을 때 
    -- 유니티 라이프 사이클 
    Awake : 최초 1회만 실행, 가장 먼저 실행해야 할 때, start를 먼저 쓰고 awake를 나중에 써도 awake부터 실행
    ★ OnEnable : 오브젝트가 켜질 때 스크립트 활성화, 활성화 시 실행
    ★ Start : 1회만 실행
    ★ Update : 매번 실행
    OnDisable : 비활성화 시 실행, 활성화 → 비활성화 될 때마다
    OnDistroy : 오브젝트가 삭제 될 때 1회만 실행 
    */

    /*
    변수의 종류
    1. 정수 - int, long 등 int-4bite, long-8bite
    2. 실수 - float, double 
    3. char는 문자를 담을 수 있는 변수, string은 문자열을 담을 수 있는 변수 / String Name = "슬라임";
    4. 참과 거짓 - boolean은 참(True)과 거짓(False)를 나타낼 때 사용합니다. boolean을 줄여서 bool로 사용합니다.
    */

    /*
    여러 요소를 구분하는 이름을 식별자(ID/Identifier)라고 합니다.
    playerAttackPower로 플레이어의 공격력을 알 수 있지만, power만으로는 누구의 힘인지 알 수 없습니다
    작업을 진행하는 다른 사람들이 의미를 쉽게 파악할 수 있도록 풀어서 써야 함. 
    식별자는 규칙에 맞게 작성
    
    특수한 의미를 갖는 키워드는 제외 예를들면 start 등은 쓸 수 없음
    숫자로 시작할 수 없음
    대소문자를 구분할 수 있음.
    
    카멜 표기법 - 단어의 접두어를 대문자로 표기하는 방법 ex. playerAttackPower
    파스칼 표기법 - 모든 단어의 접두어를 대문자로 표기하는 방법 ex. PlayerAttackPower
    
    범위 - 식별자는 유효한 범위를 가지게 됩니다. 
        Player에게 들어가 있는 정보를 Moster가 마음대로 쓸 수 없습니다. 
        서로 다른 범위의 데이터는 함부로 접근할 수 없습니다.
*/



using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class text : MonoBehaviour
{
    // Awake는 게임 오브젝트가 활성화될 때 최초 1회 실행됩니다.
    void Awake()
    {
        Debug.Log("최초 한번만 실행됩니다.");
    }

    //void OnEnable()
    //{
    //    Debug.Log("활성화 될 때 실행됩니다.");
    //}

    // Start는 게임 시작 시 1회 실행됩니다.
    void Start()
    {
        Debug.Log("한번만 실행됩니다.");
    }

    // Update는 매 프레임마다 실행됩니다.
    void Update()
    {
        Debug.Log("매 프레임마다 여러번 실행됩니다.");
    }

    // OnDestroy는 게임 오브젝트가 삭제될 때 실행됩니다.
    void OnDestroy()
    {
        Debug.Log("오브젝트가 삭제될 때 실행됩니다.");
    }

    // 간단한 더하기 함수 (리턴값 있음)
    int Sum(int value1, int value2)
    {
        return value1 + value2;
    }

    /*
    // 유니티의 주석 방식
    // 한 줄 주석 : //
    // 여러 줄 주석 : /* ~ * /
    // 단축키 : Ctrl + K + C (주석 처리), Ctrl + K + U (주석 해제)
    
    // Debug.Log 역할은 로블록스의 print와 비슷하며,
    // 콘솔창에 로그를 출력합니다.

    // Debug.Log("내용") : 일반 로그 (하얀색)
    // Debug.LogWarning("내용") : 경고 로그 (노란색 느낌표)
    // Debug.LogError("내용") : 에러 로그 (빨간색 느낌표)
    */
}

public class script : MonoBehaviour
{
    private int playerLevel = 10;

    void Awake()
    {
        Debug.Log("최초 한번만 실행됩니다.");
    }

    void Start()
    {
        Debug.Log("나의 레벨은 " + playerLevel + "입니다.");
        Debug.Log($"나의 레벨은 {playerLevel}입니다.");
    }

    void Update()
    {
        Debug.Log("매 프레임마다 여러번 실행됩니다.");
    }

    void OnDestroy()
    {
        Debug.Log("오브젝트가 삭제될 때 실행됩니다.");
    }

    // 오브젝트가 활성화될 때마다 실행됩니다.
    void OnEnable()
    {
        Debug.Log(Random.Range(1, 100)); // 1 이상 100 미만 난수 출력
    }
}

// 플레이어 클래스, 플레이어 레벨을 관리
public class APlayer
{
    private int playerLevel = 10;

    // 플레이어 레벨 반환 함수
    public int Level()
    {
        return playerLevel;
    }
}

// 몬스터 클래스, 몬스터 레벨을 설정하는 기능 포함
public class Monster
{
    private int monsterLevel;

    // 플레이어 레벨을 받아 몬스터 레벨 설정
    public void SetLevel(int _playerLevel)
    {
        monsterLevel = _playerLevel;
    }
}

// 게임 관리 클래스, 플레이어와 몬스터 객체 생성 및 몬스터 소환 기능
public class Game
{
    APlayer A = new APlayer();
    Monster B = new Monster();

    // 몬스터의 레벨을 플레이어 레벨에 맞춰 설정
    public void MonsterSpawn()
    {
        B.SetLevel(A.Level());
    }
}

/*
Random (난수 생성)
유니티에서는 다음과 같이 사용합니다:
Random.Range(1, 10); // 1 이상 10 미만 범위의 난수 반환
*/
