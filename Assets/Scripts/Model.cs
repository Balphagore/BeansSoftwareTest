using AxGrid.Base;

public class Model : MonoBehaviourExt
{
    [OnStart]
    private void Init()
    {
        Model.Set("Money", 0);
        Model.Set("StateName", "StateOne");
    }
}