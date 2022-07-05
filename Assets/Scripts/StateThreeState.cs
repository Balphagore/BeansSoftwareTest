using UnityEngine;
using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;

namespace TaskFSM
{
    [State("StateThree")]
    public class StateThreeState : FSMState
    {
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
                case "SecondButton":
                    stateName = "StateTwo";
                    Settings.Model.EventManager.Invoke("ChangePanelColorEvent", Color.green);
                    break;
            }
            Settings.Model.Set("StateName", stateName);
            Parent.Change("StateTransit");
        }

        [Loop(1f)]
        private void LoopThis()
        {
            Settings.Model.Dec("Money");
        }
    }
}