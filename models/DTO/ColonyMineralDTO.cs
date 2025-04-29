namespace ExomineAPI.Models.DTO;
public class ColonyMineralDTO {
    public int Id {get; set;}
    public int ColonyId {get; set;}
    public int MineralId {get; set;}
    public List<MineralDTO>? Minerals {get; set;}
    public int Quantity {get; set;}
}