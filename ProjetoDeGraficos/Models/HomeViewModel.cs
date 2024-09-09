namespace ProjetoDeGraficos.Models;

public class HomeViewModel
{
    public List<int> Criancas {  get; set; }
    public List<int> Jovens {  get; set; }
    public List<int> Idosos {  get; set; }
    public List<HomeViewModel> homeList { get; set; }

    public HomeViewModel()  
    { 
        Criancas = new List<int>()
        {
            40,30,33,36,50,26,53,41
        };
        Jovens = new List<int>()
        {
            60,52,48,48,59,45,60,50
        };
        Idosos = new List<int>()
        {
            10,15,12,20,18,11,8,22
        };
        homeList = new List<HomeViewModel>();
    }
}
