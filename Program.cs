using ExomineAPI.Models;
using ExomineAPI.Models.DTO;
var builder = WebApplication.CreateBuilder(args);

List<Governor> governors = new List<Governor>() {

    new Governor {
      Id = 1,
      Name = "Morb Harrington",
      IsActive = true,
      ColonyId = 1
    },
    new Governor {
      Id = 2,
      Name = "Margaret Thompson",
      IsActive = true,
      ColonyId = 2
    },
     new Governor {
      Id = 3,
      Name = "Zilliam Starr",
      IsActive = true,
      ColonyId = 3
    },
    new Governor {
      Id = 4,
      Name = "Lazer Razor",
      IsActive = false,
      ColonyId = 4
    },
     new Governor {
      Id = 5,
      Name = "Nova Thorne",
      IsActive = true,
      ColonyId = 5
    },
     new Governor {
      Id = 6,
      Name = "Ham Sammich",
      IsActive = true,
      ColonyId = 3
    },
     new Governor {
      Id = 7,
      Name = "Xena Warrior-Princess",
      IsActive = true,
      ColonyId = 4
    },
     new Governor {
      Id = 8,
      Name = "Krater Rubble",
      IsActive = true,
      ColonyId = 5
    }
};

List<Colony> colonies = new List<Colony>() {
    new Colony() {
        Id = 1,
        Name = "Nova Prime",
        Balance = 1000
    },
    new Colony() {
        Id = 2,
        Name = "Kepler Outpost",
        Balance = 1200
    },
    new Colony() {
        Id = 3,
        Name = "Titan Haven",
        Balance = 1500
    },
    new Colony() {
        Id = 4,
        Name = "Andromeda Station",
        Balance = 800
    },
    new Colony() {
        Id = 5,
        Name = "Orion's Reach",
        Balance = 1100
    }
};



List<Mineral> minerals = new List<Mineral>(){
    new Mineral() {
        Id = 1,
        Name = "Unobtanium",
        Price = 150
    },
    new Mineral() {
        Id = 2,
        Name = "Voidium",
        Price = 250
    },
    new Mineral() {
        Id = 3,
        Name = "Nebulite",
        Price = 350
    },
    new Mineral() {
        Id = 4,
        Name = "Quantium Shardium",
        Price = 450
    },
    new Mineral() {
        Id = 5,
        Name = "Darkstar Ore",
        Price = 550
    }
};

List<MiningFacilities> miningFacilities = new List<MiningFacilities>(){
    new MiningFacilities() {
      Id = 1,
      Name = "Celestial Excavation Hub",
      IsActive = true
    },
    new MiningFacilities() {
      Id = 2,
      Name = "Nebula Core Refinery",
      IsActive = false
    },
    new MiningFacilities() {
      Id = 3,
      Name = "Titan Deep Drills",
      IsActive = true
    },
    new MiningFacilities() {
      Id = 4,
      Name = "Eclipse Ore Extractors",
      IsActive = false
    },
    new MiningFacilities() {
      Id = 5,
      Name = "Quantum Harvest Station",
      IsActive = true
    }
};

List<ColonyMineral> Colonyminerals = new List<ColonyMineral>(){
     new ColonyMineral {
      ColonyId = 1,
      MineralId = 1,
      Quantity = 503,
      Id = 1
    },
     new ColonyMineral {
      ColonyId = 2,
      MineralId = 2,
      Quantity = 753,
      Id = 2
    },
     new ColonyMineral {
      ColonyId = 3,
      MineralId = 3,
      Quantity = 1201,
      Id = 3
    },
     new ColonyMineral {
      Id = 4,
      ColonyId = 4,
      MineralId = 4,
      Quantity = 450
    },
     new ColonyMineral {
      ColonyId = 5,
      MineralId = 5,
      Quantity = 906,
      Id = 5
    },
     new ColonyMineral {
      Id = 6,
      ColonyId = 2,
      MineralId = 4,
      Quantity = 750
    },
     new ColonyMineral {
      ColonyId = 3,
      MineralId = 2,
      Quantity = 1201,
      Id = 7
    },
     new ColonyMineral {
      ColonyId = 4,
      MineralId = 3,
      Quantity = 451,
      Id = 8
    },
     new ColonyMineral {
      ColonyId = 1,
      MineralId = 5,
      Quantity = 4,
      Id = 9
    },
     new ColonyMineral {
      ColonyId = 2,
      MineralId = 3,
      Quantity = 7,
      Id = 10
    },
     new ColonyMineral {
      ColonyId = 2,
      MineralId = 1,
      Quantity = 1,
      Id = 11
    },
     new ColonyMineral {
      ColonyId = 2,
      MineralId = 5,
      Quantity = 1,
      Id = 12
    },
     new ColonyMineral {
      ColonyId = 4,
      MineralId = 5,
      Quantity = 1,
      Id = 13
    },
     new ColonyMineral {
      ColonyId = 3,
      MineralId = 5,
      Quantity = 2,
      Id = 14
    },
     new ColonyMineral {
      ColonyId = 5,
      MineralId = 3,
      Quantity = 2,
      Id = 15
    }
};

List<FacilityMineral> FacilitiesMinerals = new List<FacilityMineral> {
      new FacilityMineral {
      MiningFacilityId = 1,
      MineralsId = 1,
      Quantity = 98,
      Id = 1
    },
     new FacilityMineral {
      Id = 2,
      MiningFacilityId = 2,
      MineralsId = 2,
      Quantity = 107
    },
     new FacilityMineral {
      MiningFacilityId = 3,
      MineralsId = 3,
      Quantity = 148,
      Id = 3
    },
     new FacilityMineral {
      Id = 4,
      MiningFacilityId = 4,
      MineralsId = 4,
      Quantity = 62
    },
     new FacilityMineral {
      MiningFacilityId = 5,
      MineralsId = 5,
      Quantity = 593,
      Id = 5
    },
     new FacilityMineral {
      Id = 6,
      MiningFacilityId = 4,
      MineralsId = 1,
      Quantity = 99
    },
     new FacilityMineral {
      MiningFacilityId = 3,
      MineralsId = 2,
      Quantity = 102,
      Id = 7
    },
     new FacilityMineral {
      MiningFacilityId = 5,
      MineralsId = 3,
      Quantity = 159,
      Id = 8
    },
     new FacilityMineral {
      Id = 9,
      MiningFacilityId = 2,
      MineralsId = 4,
      Quantity = 62
    },
     new FacilityMineral {
      MiningFacilityId = 1,
      MineralsId = 5,
      Quantity = 591,
      Id = 10
    }
};


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(options =>
{
    options.AddDefaultPolicy(policy =>
    {
        policy.WithOrigins(
            "http://localhost:3000" 
        )
        .AllowAnyHeader()
        .AllowAnyMethod();
    });
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(); 
app.UseHttpsRedirection();

// need join  table
app.MapGet("/api/colonies", () => 
{
    return colonies.Select(c => new ColonyDTO 
    {
       Id = c.Id,
       Name = c.Name 
    }); 
}); 

app.MapGet("/api/governors", () => {
    return governors.Select(g => new GovernorDTO
    {
        Id = g.Id,
        Name = g.Name,
        IsActive = g.IsActive,
        ColonyId = g.ColonyId
    });
});

// need join  table
app.MapGet("api/minerals", () => {
    return minerals.Select(m => new MineralDTO
    {
        Id = m.Id,
        Name = m.Name
    });
});

app.MapGet("/api/miningfacilities", () => {
    return miningFacilities.Select(f => new MiningFacilityDTO
    {
        Id = f.Id,
        Name = f.Name,
        IsActive = f.IsActive
    });
});

app.MapGet("/api/fm/", () => {
    return FacilitiesMinerals.Select(fm => {
    List<Mineral> m = minerals.Where(m => m.Id == fm.MineralsId).ToList();
    List<MiningFacilities> Mining = miningFacilities.Where(m => m.Id == fm.MiningFacilityId).ToList();

    return new FacilityMineralDTO {
        Id = fm.Id, 
        MiningFacilityId = fm.MiningFacilityId,
        Facility = Mining.Select(f => new MiningFacilityDTO {
            Id = f.Id,
            Name = f.Name,
            IsActive = f.IsActive
        }).ToList(),
        MineralId = fm.MineralsId,
        Minerals = m.Select(m => new MineralDTO {
            Id = m.Id,
            Name = m.Name,
        }).ToList(),
        Quantity = fm.Quantity 
    };
    });
});

app.MapGet("/api/facilityminerals/minerals/{id}", (int id) => {
    FacilityMineral fm = FacilitiesMinerals.FirstOrDefault(f => f.Id == id);
    List<Mineral> m = minerals.Where(m => m.Id == fm.MineralsId).ToList();

    return new FacilityMineralDTO {
        Id = fm.Id, 
        MiningFacilityId = fm.MiningFacilityId,
        MineralId = fm.MineralsId,
        Minerals = m.Select(m => new MineralDTO {
            Id = m.Id,
            Name = m.Name,
        }).ToList(),
        Quantity = fm.Quantity 
    };
});
app.MapGet("/api/miningfacilities/{id}", (int id) => {
    MiningFacilities facility = miningFacilities.FirstOrDefault(f => f.Id == id);
    return new MiningFacilityDTO
    {
        Id = facility.Id,
        Name = facility.Name,
        IsActive = facility.IsActive
    };
});

app.MapGet("/api/facilityMinerals/{id}", (int id) => {
  FacilityMineral facilityMineral = FacilitiesMinerals.FirstOrDefault(f => f.Id == id);

  return new FacilityMineralDTO
  {
    Id = facilityMineral.Id,
    MiningFacilityId = facilityMineral.MiningFacilityId,
    MineralId = facilityMineral.MineralsId,
    Quantity = facilityMineral.Quantity,
  };
});

app.MapPost("/api/colonyMinerals", (ColonyMineral colonyMineral) => {

  if(colonyMineral == null){
    return Results.BadRequest();
  }

  colonyMineral.Id = Colonyminerals.Max(cm => cm.Id) + 1;
  Colonyminerals.Add(colonyMineral);

  return Results.Created($"/api/colonyMinerals/{colonyMineral.Id}", new ColonyMineralDTO {
    Id = colonyMineral.Id,
    ColonyId = colonyMineral.ColonyId,
    MineralId = colonyMineral.MineralId,
    Quantity = colonyMineral.Quantity,
  });
});

app.MapPut("/api/facilityMinerals/{id}", (int id, FacilityMineralDTO updatedFM) =>
{
  FacilityMineral facilityMineral = FacilitiesMinerals.FirstOrDefault(f => f.Id == id);
  facilityMineral.MiningFacilityId = updatedFM.MiningFacilityId;
  facilityMineral.MineralsId = updatedFM.MineralId;
  facilityMineral.Quantity = updatedFM.Quantity;
  
  return Results.NoContent();
  
}
);

app.MapPut("api/colonyMinerals/{id}", (int id, ColonyMineralDTO CMDTO) => {

  if(CMDTO == null){
    return Results.BadRequest();
  }
  
  ColonyMineral colonyMineral = Colonyminerals.FirstOrDefault(cm => cm.Id == id);
  colonyMineral.ColonyId = CMDTO.ColonyId;
  colonyMineral.MineralId = CMDTO.MineralId;
  colonyMineral.Quantity = CMDTO.Quantity;

  return Results.NoContent();

});

app.Run();