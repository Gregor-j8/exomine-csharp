namespace ExomineAPI.Models.DTO;
public class ColonyDTO {
    public int Id {get; set;}
    public string Name {get; set;}
    public int ? Balance {get; set;}
    public List<ColonyMineralDTO>? ColonyMineral {get; set;}
}