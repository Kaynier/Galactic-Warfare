using TMPro;
using UnityEngine;

public class DialougeLines : MonoBehaviour
{
    [SerializeField] TMP_Text dialougeText;
    [SerializeField] string[] timelineTextLines;

    int currentLine = 0;

    public void NextDialougeLine(){
        currentLine++;
        dialougeText.text = timelineTextLines[currentLine];
    }
}
