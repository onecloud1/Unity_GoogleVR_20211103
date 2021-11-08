using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;


/// <summary>
/// 倒數計時
/// 並執行［某件事情］
/// 例如：離開遊戲.重新開始.顯示選單
/// </summary>
public class CountDownAndDoSomething : MonoBehaviour
{
    [Header("倒數時間"), Range(1, 5)]
    public float timeCountDown = 3;
    [Header("倒數時間")]
    public UnityEvent onTimeup;
    [Header("介面")]
    public Image imgBar;

    private float timeMax;

    /// <summary>
    /// 開始倒數： ture 開始 . flase 停止
    /// Unity Event 可以存取
    /// 1.實體物件
    /// 2.存取方法僅限：無或者一個參數.有資料類型限制(基本類型)
    /// 3.存取公開屬性：有資料類型限制(基本類型)
    /// </summary>
    public bool startCountDown { get; set; }

  
    //喚醒事件：在 Start 前執行一次
    private void Awake()
    {
        timeMax = timeCountDown;
    }

    private void Update()
    {
        CoundDown();
    }

    private float timer;

    private void CoundDown()
    {
        if (startCountDown) //如果  開始 倒數
        {
            if(timer < timeCountDown) //如果 計時器 小於 倒數時間
            {
                timer += Time.deltaTime; //累加時間(於 Upadte 內呼叫)
            }
            else
            {
                onTimeup.Invoke(); // 否則 計時器 大於等於 倒數時間 就 呼叫事件
            }

            imgBar.fillAmount = timer / timeCountDown;
        }
        else
        {
            timer = 0;
            imgBar.fillAmount = 0;
        }
    }
}
