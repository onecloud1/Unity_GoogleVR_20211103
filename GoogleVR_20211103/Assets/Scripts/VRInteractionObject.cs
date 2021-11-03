using UnityEngine;
using UnityEngine.Events;

public class VRInteractionObject : MonoBehaviour
{
    /// <summary>
    /// 1.引用 using Events
    /// 2.定義public UnityEvent公開欄位
    /// 3.想要執行此事件內容的地方呼叫 事件 .Invoke();
    /// 4.屬性面板設置事件內容
    /// </summary>
    
    [Header("事件：看到.離開與點擊")]
    public UnityEvent onEnter;
    public UnityEvent onExit;
    public UnityEvent onClick;


    public void OnPointerEnter()
    {

        onEnter.Invoke();
    }

    public void OnPointerExit()
    {

        onExit.Invoke();
    }

    public void OnPointerClick()
    {

        onClick.Invoke();
    }
}
