using System.Text.RegularExpressions;
using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RegularExpressions : MonoBehaviour
{
    // 정규표현식 테스트

    void Start()
    {
        test();
    }

    private void test()
    {
        // 숫자만 얻기
        string example_dollar = "$1,812.99";
        string example_CaDollar = "CA$10,000.00";
        string example_won = "₩10,000,000";
        string example_france = "Fr10,000.00";

        double money = 0;

        char isWon = '0';
        string inputMoney = example_won;

        string pattern = @"[^\D]";  // 숫자 제거 패턴
        string asdf = Regex.Replace(inputMoney, pattern, "");
        asdf = asdf.Replace(",", "").Replace(".", "");  // , . 제거
        Debug.Log(asdf);    // 리턴값 : 통화

        money = double.Parse(inputMoney.Replace(asdf, "").Replace(",", ""));
        money = Convert.ToInt32(Math.Ceiling(money));
        Debug.Log(money);

        if (asdf == "₩")
        {
            isWon = '₩';
        }
        else
        {
            isWon = '$';
        }
        Debug.Log(isWon);

        string serverIAPLog = $"~IAP LOG~\nexample_dollar = {example_dollar}\nexample_CaDollar = {example_CaDollar}\nexample_won = {example_won}\nexample_france = {example_france}";

        Debug.Log(serverIAPLog);

        // 특수문자를 제외하고 리턴
        //pattern = @"\W"; //@"[^0-9]"
        //asdf = Regex.Replace(example_dollar, pattern, "");
        //Debug.Log(asdf);
    }

}




