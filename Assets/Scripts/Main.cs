using AxGrid;
using AxGrid.Base;
using AxGrid.FSM;
using UnityEngine;

namespace TaskFSM
{
    public class Main : MonoBehaviourExtBind
    {        
        [OnStart]
        private void StartThis()
        {
            Settings.Fsm = new FSM();
            Settings.Fsm.Add(new StateOneState());
            Settings.Fsm.Add(new StateTwoState());
            Settings.Fsm.Add(new StateThreeState());
            Settings.Fsm.Add(new StateTransitState());

            Settings.Fsm.Start("StateOne");
            Settings.Model.Set("BtnFirstButtonEnable", false);
        }

        [OnUpdate]
        private void UpdateThis()
        {            
            Settings.Fsm.Update(Time.deltaTime);
        }        
    }
}