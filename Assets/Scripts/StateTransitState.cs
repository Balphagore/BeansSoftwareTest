using AxGrid;
using AxGrid.FSM;

namespace TaskFSM
{
    [State("StateTransit")]
    public class StateTransitState : FSMState
    {
        [Enter]
        private void EnterThis()
        {
            Settings.Model.Set("BtnFirstButtonEnable", false);
            Settings.Model.Set("BtnSecondButtonEnable", false);
            Settings.Model.Set("BtnThirdButtonEnable", false);
        }

        [One(1f)]
        private void ChangeState()
        {
            string stateName = Settings.Model.Get("StateName").ToString();
            switch(stateName)
            {
                case "StateOne":
                    Settings.Model.Set("BtnFirstButtonEnable", false);
                    Settings.Model.Set("BtnSecondButtonEnable", true);
                    Settings.Model.Set("BtnThirdButtonEnable", true);
                    break;
                case "StateTwo":
                    Settings.Model.Set("BtnFirstButtonEnable", true);
                    Settings.Model.Set("BtnSecondButtonEnable", false);
                    Settings.Model.Set("BtnThirdButtonEnable", true);
                    break;
                case "StateThree":
                    Settings.Model.Set("BtnFirstButtonEnable", true);
                    Settings.Model.Set("BtnSecondButtonEnable", true);
                    Settings.Model.Set("BtnThirdButtonEnable", false);
                    break;
            }
            Parent.Change(stateName);
        }
    }
}