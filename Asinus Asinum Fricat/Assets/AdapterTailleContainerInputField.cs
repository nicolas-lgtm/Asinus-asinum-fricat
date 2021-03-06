using System.Collections;
using TMPro;
using UnityEngine;

public class AdapterTailleContainerInputField : MonoBehaviour
{
    [SerializeField] float minInputFieldHeight;
    public void AdapterTaillePublicTransport() { StartCoroutine(AdapterCanvas()); }

    IEnumerator AdapterCanvas()
    {
        yield return new WaitForEndOfFrame();

        if (GetComponentInParent<AdapterTailleParent>())
        {
            Debug.Log(transform.parent.name);
            transform.parent.GetComponent<RectTransform>().sizeDelta = TaillePlusGrandInputField();
            GetComponentInParent<AdapterTailleParent>().UpdateCanvas();
        }

        Vector2 inputFieldSize = GetComponent<TMP_InputField>().GetComponent<RectTransform>().sizeDelta;
        if (inputFieldSize.y < minInputFieldHeight) GetComponent<TMP_InputField>().GetComponent<RectTransform>().sizeDelta = new Vector2(inputFieldSize.x, minInputFieldHeight);
    }

    Vector2 TaillePlusGrandInputField()
    {
        for (int i = 0; i < transform.parent.childCount; i++)
        {
            GameObject child = transform.parent.GetChild(i).gameObject;

            if (child.GetComponent<TMP_InputField>())
            {
                if (child.GetComponent<TMP_InputField>().GetComponent<RectTransform>().sizeDelta.y > GetComponent<RectTransform>().sizeDelta.y) return child.GetComponent<TMP_InputField>().GetComponent<RectTransform>().sizeDelta;
            }
        }
        Debug.Log(GetComponent<RectTransform>().sizeDelta);

        return GetComponent<RectTransform>().sizeDelta;
    }
}
