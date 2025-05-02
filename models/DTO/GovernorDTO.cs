namespace ExomineAPI.Models.DTO;
public class GovernorDTO
{
    public int Id {get; set;}
    public string Name {get; set;}
    public bool IsActive {get; set;}
    public int ColonyId {get; set;}
    public ColonyDTO ? colonyDTOs{get; set;}
}