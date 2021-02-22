using UnityEngine;
public class WealthManager:MonoBehaviour
{
    public DisplayWealth displayWealth;

    public int pickUp;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            var wealth= Calculate(pickUp, (int)Time.timeSinceLevelLoad);
            displayWealth.DisplayTotalWeath(wealth);

        }
    }

    public int Calculate(int pickUp, int timeSpend)
    {
        return  pickUp * 100- timeSpend;
    }
}