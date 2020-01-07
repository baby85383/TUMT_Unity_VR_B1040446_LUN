using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public Text playerscore;
    public static int getscore;

    private void Update()
    {
        playerscore.text = "分數：" + getscore;
    }
}
