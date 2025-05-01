using UnityEngine;

public class HideObjectOnKeyPress  : MonoBehaviour
{
    public GameObject objectToHide;
    private bool isFirstHidden = false; // لحفظ حالة الكائن (إذا كان قد اختفى بالفعل)

    void Update()
    {
        // عند الضغط على زر C
        if (Input.GetKeyDown(KeyCode.C) && !isFirstHidden)
        {
            objectToHide.SetActive(false);  // إخفاء الكائن
            isFirstHidden = true; // تأكد من أن الزر C قد تم الضغط عليه
        }
        // عند الضغط على زر Q بعد الضغط على C
        else if (Input.GetKeyDown(KeyCode.Q) && isFirstHidden)
        {
            objectToHide.SetActive(false);  // إخفاء الكائن
        }
    }
}
