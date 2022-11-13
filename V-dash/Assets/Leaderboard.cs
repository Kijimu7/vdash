using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker.Requests;
using TMPro;

public class Leaderboard : MonoBehaviour
{
    int leaderboardID = 8714;
    public TextMeshProUGUI playerName;
    public TextMeshProUGUI playerScore;
    // Start is called before the first frame update


    public IEnumerator SubmitScoreRoutine(int scoreToUpload)
    {
        bool done = false;
        string playerID = PlayerPrefs.GetString("PlayerID");
        LootLockerSDKManager.SubmitScore(playerID, scoreToUpload, leaderboardID, (response) =>
        {
            if (response.success)
            {
                Debug.Log("Sucessfully uploaded score");
                done = true;
            }
            else
            {
                Debug.Log("Failed" + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }

    [System.Obsolete]
    public IEnumerator FetchTopHighscoresRoutine()
    {
        bool done = false;
        LootLockerSDKManager.GetScoreListMain(leaderboardID, 10, 0, (response) =>
        {
            if (response.success)
            {
                string teamPlayerNames = "Names\n";
                string teamPlayerScores = "Scores\n";

                LootLockerLeaderboardMember[] members = response.items;

                for (int i = 0; i < members.Length; i++)
                {
                    teamPlayerNames += members[i].rank + ". ";
                    if (members[i].player.name != "")
                    {
                        teamPlayerNames += members[i].player.name;
                    }
                    else
                    {
                        teamPlayerNames += members[i].player.id;
                    }
                    teamPlayerScores += members[i].score + "\n";
                    teamPlayerNames += "\n";
                }
                done = true;
                playerName.text = teamPlayerNames;
                playerScore.text = teamPlayerScores;
            }
            else
            {
                Debug.Log("Failed" + response.Error);
                done = true;
            }
        });
        yield return new WaitWhile(() => done == false);
    }

}
