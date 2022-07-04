using DataAccess.Models;
using Microsoft.AspNetCore.Components;


namespace HamsterWars.Pages
{
    public partial class HamsterBattle : ComponentBase
    {
        private List<Hamster>? contendersList;
        private Hamster? contender1;
        private Hamster? contender2;
        private Hamster? oldContender1;
        private Hamster? oldContender2;
        private Battle BattleResult = new();

        protected override async Task OnInitializedAsync()
        {
            await GetBothHamsters();
        }

        public async Task GetBothHamsters()
        {
            if (contendersList is null)
            {
                contendersList = await _hR.GetHamsters();
            }
            (contender1, contender2) = _bR.GetContenders(contendersList);
        }

        public void AddWinner(Hamster hamsterWinner)
        {
            hamsterWinner.Wins++;
            hamsterWinner.Games++;
        }

        public void AddLosser(Hamster hamsterLosser)
        {
            hamsterLosser.Losses++;
            hamsterLosser.Games++;
        }  

        public async Task UpdateBattleStatus(Hamster hamsterWinner, Hamster hamsterLosser)
        {
            AddWinner(hamsterWinner);
            AddLosser(hamsterLosser);
            await _hR.UpdateHamster(hamsterWinner);
            await _hR.UpdateHamster(hamsterLosser);
            ReloadBattle(hamsterWinner, hamsterLosser);
            await _bR.AddBattle(BattleResult);
            await _bR.UpdateBattle(BattleResult);
            NextContenders();
            
            await Task.Run(() => Thread.Sleep(50));
        }

        public void NextContenders()
        {
            (contender1, contender2) = _bR.GetContenders(contendersList);
            StateHasChanged();   
        }

        public void ReloadBattle(Hamster hamsterWinner, Hamster hamsterLosser)
        {
            oldContender1 = hamsterWinner;
            oldContender2 = hamsterLosser;
        }
    }
}
