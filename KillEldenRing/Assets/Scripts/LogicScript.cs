using UnityEngine;
using TMPro;
public class LogicScript : MonoBehaviour
{
    [SerializeField] TMP_Text TextField_;
    [SerializeField] string PreText_;
    [SerializeField] int CurrentValue_ = 0;
    
    void UpdateValue()
    {
        TextField_.text = PreText_ + CurrentValue_.ToString();
    }

    void Update()
    {
        UpdateValue();
    }
}
