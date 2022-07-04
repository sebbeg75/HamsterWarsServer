using DataAccess.Models;
using Microsoft.AspNetCore.Components;


namespace HamsterWars.Pages
{
    public partial class HamsterBattle : ComponentBase
    {
        public List<Hamster>? contendersList;
        public Hamster? contender1;
        public Hamster? contender2;
        public Hamster? oldContender1;
        public Hamster? oldContender2;


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
            await _bR.AddAndUpdateHamster(hamsterWinner.Id, hamsterLosser.Id);

            NextContenders();
            StateHasChanged();
        }

        public void NextContenders()
        {
            (contender1, contender2) = _bR.GetContenders(contendersList);

        }

        public void ReloadBattle(Hamster hamsterWinner, Hamster hamsterLosser)
        {
            oldContender1 = hamsterWinner;
            oldContender2 = hamsterLosser;
        }
    }
}
