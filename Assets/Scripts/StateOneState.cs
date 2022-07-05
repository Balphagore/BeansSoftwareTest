using UnityEngine;
using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;

namespace TaskFSM
{
    [State("StateOne")]
    public class StateOneState : FSMState
    {
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
    }
}