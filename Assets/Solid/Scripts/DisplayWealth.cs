using UnityEngine;
using UnityEngine.UI;
public class DisplayWealth:MonoBehaviour
{
    public Text text;
    public void DisplayTotalWeath(int wealth)
    {
        text.text = wealth.ToString();
    }
}