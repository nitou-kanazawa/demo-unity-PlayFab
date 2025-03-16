using PlayFab;
using PlayFab.ClientModels;
using UnityEngine;

public class PlayFabLogin : MonoBehaviour {

    public void Start() {

        //PlayFabAuthService.OnLoginSuccess += OnLoginSuccess;
        //PlayFabAuthService.OnPlayFabError += OnLoginFailure;

        //PlayFabAuthService.Instance.Authenticate(AuthTypes.Silent);

        var request = new LoginWithCustomIDRequest {
            TitleId = PlayFabSettings.TitleId,
            CustomId = "200",
            CreateAccount = true
        };

        PlayFabClientAPI.LoginWithCustomID(request, OnLoginSuccess, OnLoginFailure);
    }

    private void OnLoginSuccess(LoginResult result) {
        Debug.Log("Congratulations, you made your first successful API call!");
    }

    private void OnLoginFailure(PlayFabError error) {
        Debug.LogWarning("Something went wrong with your first API call.  :(");
        Debug.LogError("Here's some debug information:");
        Debug.LogError(error.GenerateErrorReport());
    }
}