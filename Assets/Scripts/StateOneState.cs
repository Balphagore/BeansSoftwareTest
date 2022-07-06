using UnityEngine;
using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;

namespace TaskFSM
{
    [State("StateOne")]
    public class StateOneState : FSMState
    {
        [Enter]
        private void EnterThis()
        {
            Settings.Model.Set("BtnFirstButtonEnable", false);
            Settings.Model.Set("BtnSecondButtonEnable", true);
            Settings.Model.Set("BtnThirdButtonEnable", true);
        }

        [Bind]
        private void OnBtn(string name)
        {
            string stateName = "";
            switch (name)
            {
                case "SecondButton":
                    stateName = "StateTwo";
                    Settings.Model.EventManager.Invoke("ChangePanelColorEvent", Color.green);
                    break;
                case "ThirdButton":
                    stateName = "StateThree";
                    Settings.Model.EventManager.Invoke("ChangePanelColorEvent", Color.red);
                    break;
            }
            Settings.Model.Set("StateName", stateName);
            Parent.Change("StateTransit");
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