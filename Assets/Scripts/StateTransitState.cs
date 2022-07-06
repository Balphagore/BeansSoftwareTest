using AxGrid;
using AxGrid.FSM;
using AxGrid.Model;

namespace TaskFSM
{
    [State("StateTransit")]
    public class StateTransitState : FSMState
    {
        [Bind("OnMoveDone")]
        private void ChangeState()
        {
            Parent.Change(Settings.Model.Get("StateName").ToString());
        }
    }
}