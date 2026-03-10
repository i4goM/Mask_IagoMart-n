using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class HoldButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Image progress;
    public GameObject target;

    float holdTime = 2f;
    float timer = 0f;
    bool holding = false;

    public void OnPointerDown(PointerEventData eventData)
    {
        holding = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        holding = false;
        timer = 0;
        progress.fillAmount = 0;
    }

    void Update()
    {
        if (holding)
        {
            timer += Time.deltaTime;
            progress.fillAmount = timer / holdTime;

            if (timer >= holdTime)
            {
                target.SetActive(!target.activeSelf);
                timer = 0;
                progress.fillAmount = 0;
            }
        }
    }
}