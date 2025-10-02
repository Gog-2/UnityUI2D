using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LvlCell : MonoBehaviour
{
    [SerializeField] private TMP_Text lvlNumber;
    [SerializeField] private GameObject _lock;
    [SerializeField] private List<GameObject> Stars;
    public void Init(int lvlcounter,bool locked)
    {
        
        lvlNumber.text = lvlcounter.ToString();
        if (locked)
        {
            _lock.SetActive(true);
            return;
        }
        int starsget = Random.Range(0, 4);
        if (starsget == 0)
            return;
        for (int i = 0; i < starsget; i++)
        {
            Stars[i].gameObject.SetActive(true);
        }
    }
}
