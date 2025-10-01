using System.Numerics;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Timer : MonoBehaviour
{
private float timerResuese = 0f, timerCycle = 0f;
[SerializeField]private int SpeedCycle = 3, SpeedResusrse = 2;
private BigInteger Resurse, Cycle;
[SerializeField]private Image ResurseUI, CycleUI;
[SerializeField]private TMP_Text ResurseText, CycleText;
private bool CycleTimerbool = false;
    void Update()
    {
       timerResuese += Time.deltaTime;
       ResurseUI.fillAmount = timerResuese / SpeedResusrse;
       if (timerResuese >= SpeedResusrse)
       {
           Resurse++;
           ResurseText.text = $"Resurse: {Resurse}";
           timerResuese = 0f;
       }

       if (CycleTimerbool)
       {
           timerCycle += Time.deltaTime;
           CycleUI.fillAmount = timerCycle /  SpeedCycle;
           if (timerCycle >= SpeedCycle)
               {
               CycleTimerbool = false;
               Cycle++;
               CycleText.text = $"Cycle:  {Cycle}";
               timerCycle = 0f;
               }
       }
    }

    public void CycleGeneration()
    {
        if (Resurse >= 5)
        {
            Resurse -= 5;
            ResurseText.text = $"Resurse: {Resurse}";
            CycleTimerbool = true;
        }
    }
}
