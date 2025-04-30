namespace ExomineAPI.Models.DTO;
public class FacilityMineralDTO {
        public int Id {get; set;}
        public int MiningFacilityId {get; set;}
        public List<MiningFacilityDTO>? Facility {get; set;}
        public List<MineralDTO>? Minerals {get; set;}
        public int MineralId {get; set;}
        public int Quantity {get; set;}
}