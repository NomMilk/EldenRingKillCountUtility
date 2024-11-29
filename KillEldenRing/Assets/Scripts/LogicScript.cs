using UnityEngine;
using TMPro;
public class LogicScript : MonoBehaviour
{
    [SerializeField] TMP_Text TextField_;
    [SerializeField] string PreText_;
    [SerializeField] TextAsset ScoreFile_;
    
    void UpdateValue()
    {
        TextField_.text = PreText_ + ScoreFile_.ToString();
    }

    void Update()
    {
        UpdateValue();
    }
}
