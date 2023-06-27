using System.Text.RegularExpressions;
using System;
using UnityEngine;
using TMPro;

public class RegularExpression : MonoBehaviour
{
    // Test Script for RegularExpression
    public TMP_Text DebugCanvasText;            // Return Space
    public TMP_InputField DebugInputField;      // Input Text. ex) $10,000

    public void test()
    {
        double money = 0;
        string inputMoney = DebugInputField.text;

        string pattern = @"[^\D]";  // Pattern of Remove Number

        string currency = Regex.Replace(inputMoney, pattern, "");
        currency = currency.Replace(",", "").Replace(".", "");  // , . 제거

        money = double.Parse(inputMoney.Replace(currency, "").Replace(",", ""));
        money = Convert.ToInt32(Math.Ceiling(money));

        string serverIAPLog = $"Return Currency : {currency}, Money : {money}";

        DebugCanvasText.text = serverIAPLog;
    }

}




