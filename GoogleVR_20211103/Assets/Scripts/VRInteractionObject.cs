using UnityEngine;
using UnityEngine.Events;

public class VRInteractionObject : MonoBehaviour
{
    /// <summary>
    /// 1.�ޥ� using Events
    /// 2.�w�qpublic UnityEvent���}���
    /// 3.�Q�n���榹�ƥ󤺮e���a��I�s �ƥ� .Invoke();
    /// 4.�ݩʭ��O�]�m�ƥ󤺮e
    /// </summary>
    
    [Header("�ƥ�G�ݨ�.���}�P�I��")]
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
