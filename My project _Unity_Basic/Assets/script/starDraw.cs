using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class starDraw : MonoBehaviour
{
    void Start()
    {
        int n = 5;
        string result = "";

        //phase1
        for (int i = 1; i <= n; i++) // i 줄 위치, i는 5 이하 
        {
            for (int j = 1; j <= n; j++) // 공백 부분
            {
                result += "　";
            }

            
            for (int j = 1; j <= i; j++) // 별 부분, 줄 번호(i)만큼 별을 찍어요
            {
                result += "★";
            }

            result += "\n"; // 줄바꿈 
        }

        Debug.Log(result);
        result = "";


        //phase2
        for (int i = 0; i < n; i++) 
        {
            for (int j = 0; j < i; j++) 
            {
                result += "　";
            }

            
            for (int j = 0; j < n - i; j++) 
            {
                result += "★";
            }

            result += "\n"; 
        }

        Debug.Log(result);
        result = "";


        
        //phase3
        for (int i = 1; i <= n; i++) // i 줄 위치, i는 5 이하일 때 하나씩 늘려요 
        {
            for (int j = 1; j <= n; j++) // 공백 부분
            {
                result += "　";
            }

            
            for (int j = 1; j <= i; j++) // 별 부분, 줄 번호(i)만큼 별을 찍어요
            {
                result += "★";
            }

            result += "\n"; // 줄바꿈 
        }

        for (int i = 1; i <= n; i++) // i 줄 위치, i는 5 이하일 때 하나씩 늘려요
        {
            for (int j = 1; j <= n; j++) // 공백 부분
            {
                result += "　";
            }

            
            for (int j = 1; j <= n - i; j++) // 별 부분
            {
                result += "★";
            }

            result += "\n"; // 줄바꿈 
        }

        Debug.Log(result);
        result = "";


        //phase4
        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= n - i; j++) // 공백은 5개에서 i를 뺸 값, 하나씩 줄어든다. 
            {
                result += "　";
            }

            
            for (int j = 1; j <= i; j++) // 별은 처음에 1개, i와 같이 늘어나면 될 듯 
            {
                result += "★";
            }

            result += "\n"; 
        }

        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= i; j++) // 공백은 i개와 동일함. 하나씩 늘어난다. 
            {
                result += "　";
            }

            
            for (int j = 1; j <= n - i; j++) // 별은 처음에 4개, i개수따라 줄어들면 될 듯 
            {
                result += "★";
            }

            result += "\n"; 
        }

        Debug.Log(result);
        result = "";


        //phase5
        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= n - i; j++) // 공백은 5개에서 i를 뺸 값, 하나씩 줄어든다. 
            {
                result += "　";
            }

            
            for (int j = 1; j <= 2 * i - 1; j++) 
            {
                result += "★";
            }

            result += "\n"; 
        }

        for (int i = 1; i <= n; i++) 
        {
            for (int j = 1; j <= i; j++) // 공백은 i개와 동일함. 하나씩 늘어난다. 
            {
                result += "　";
            }

            
            for (int j = 1; j <= 2*n - 2*i - 1; j++) 
            {
                result += "★";
            }

            result += "\n"; 
        }

        Debug.Log(result);
        result = "";


    }
}
