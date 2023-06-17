using System;
namespace Software2KnowledgeCheck1
{
	internal class Constructionlogic
    {
        public void CreateApartment(Apartment apartment, List<Building> buildings)
        {
            // Get materials
            var materialRepo = new MaterialsRepo();
            var materialsNeeded = materialRepo.GetMaterials();

            var permitRepo = new ZoningAndPermitRepo();

            var buildingWasMade = ConstructBuilding<Apartment>(materialsNeeded, permitRepo.GetPermit(), permitRepo.ZoningApproves());

            if (buildingWasMade)
            {
                buildings.Add(apartment);
            }
        }

        public bool ConstructBuilding<T>(List<Material> materials, bool permit, bool zoning) where T : Building
        {
            if (permit && zoning)
            {
                foreach (var material in materials)
                {
                    var firststep = material.MaterialConstructionFirstStep();

                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

