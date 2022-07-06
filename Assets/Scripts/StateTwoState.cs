using UnityEngine;
using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;

namespace TaskFSM
{
    [State("StateTwo")]
    public class StateTwoState : FSMState
    {
        [Enter]
        private void EnterThis()
        {
            Settings.Model.Set("BtnFirstButtonEnable", true);
            Settings.Model.Set("BtnSecondButtonEnable", false);
            Settings.Model.Set("BtnThirdButtonEnable", true);
        }

        [Bind]
        private void OnBtn(string name)
        {
            string stateName = "";
            switch (name)
            {
                case "FirstButton":
                    stateName = "StateOne";
                    Settings.Model.EventManager.Invoke("ChangePanelColorEvent", Color.yellow);
                    break;
                case "ThirdButton":
                    stateName = "StateThree";
                    Settings.Model.EventManager.Invoke("ChangePanelColorEvent", Color.red);
                    break;
            }
            Settings.Model.Set("StateName", stateName);
            Parent.Change("StateTransit");
        }

        [Loop(1f)]
        private void LoopThis()
        {
            Settings.Model.Inc("Money");
        }

        [Exit]
        private void ExitThis()
        {
            Settings.Model.Set("BtnFirstButtonEnable", false);
            Settings.Model.Set("BtnSecondButtonEnable", false);
            Settings.Model.Set("BtnThirdButtonEnable", false);
        }
    }
}