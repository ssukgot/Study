using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

    public Text goldDisplayer;

    public Text goldPerClickDisplayer;

    public Text goldPerSecDisplayer;

    public DataController dataController;

    void Update()
    {
        goldDisplayer.text = "GOLD : " + DataController.GetInstance().GetGold();
        goldPerClickDisplayer.text = "GOLD Per Click : " + DataController.GetInstance().GetGoldPerClick();
        goldPerSecDisplayer.text = "GOLD Per Sec : " + DataController.GetInstance().GetGoldPerSec();
    }

}
