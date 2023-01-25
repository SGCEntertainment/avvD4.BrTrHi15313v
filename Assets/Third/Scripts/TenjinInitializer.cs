using UnityEngine;

public class TenjinInitializer : MonoBehaviour
{
    private void Start()
    {
        TenjinConnect();
    }

    private void OnApplicationPause(bool pauseStatus)
    {
        if (!pauseStatus)
        {
            TenjinConnect();
        }
    }

    public void TenjinConnect()
    {
        BaseTenjin instance = Tenjin.getInstance("GGXBRF81QJTAEZWC5RCTVTENIFMZHJW2");
        instance.SetAppStoreType(AppStoreType.googleplay);

        // Sends install/open event to Tenjin
        instance.Connect();
    }
}
