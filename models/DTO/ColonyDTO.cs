namespace ExomineAPI.Models.DTO;
using System.Collections.Generic;
public class ColonyDTO {
    public int Id {get; set;}
    public string Name {get; set;}
    public List<ColonyMineralDTO>? ColonyMineral {get; set;}
}