using UnityEngine;
using UnityEngine.UI;
using AxGrid.Base;
using AxGrid.Model;

public class ColorBinder : MonoBehaviourExtBind
{
    [SerializeField]
    private Image colorPanel;

    [Bind("ChangePanelColorEvent")]
    public void BindEvent(Color color)
    {
        colorPanel.color = color;
    }
}