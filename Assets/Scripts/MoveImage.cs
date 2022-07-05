using AxGrid.Base;
using AxGrid.Model;
using AxGrid.Path;
using UnityEngine;

namespace TaskFSM
{
    public class MoveImage : MonoBehaviourExtBind
    {
        [Bind]
        public void OnStateNameChanged(string stateName)
        {
            switch (stateName)
            {
                case "StateOne":
                    MoveImageTo(transform.localPosition, new Vector3(-600, 200, 0));
                    break;
                case "StateTwo":
                    MoveImageTo(transform.localPosition, new Vector3(0, 200, 0));
                    break;
                case "StateThree":
                    MoveImageTo(transform.localPosition, new Vector3(600, 200, 0));
                    break;
            }
        }

        public void MoveImageTo(Vector3 from, Vector3 to)
        {
            Path = CPath.Create()
                .EasingLinear(1f, 0, 1, f =>
                {
                    transform.localPosition = Vector3.Lerp(from, to, f);
                });
        }
    }
}