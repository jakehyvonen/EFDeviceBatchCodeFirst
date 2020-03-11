using System.Collections.Generic;
using System.Data.Entity;

namespace EFDeviceBatchCodeFirst
{
    public class DeviceBatchDBInitializer : CreateDatabaseIfNotExists<DeviceBatchContext>
    {
        protected override void Seed(DeviceBatchContext context)
        {
            System.Diagnostics.Debug.WriteLine("DeviceBatchDBInitializer Seed()");
            IList<PhysicalRole> roles = new List<PhysicalRole>
            {
                new PhysicalRole { ShortName = "AN", LongName = "Anode" },
                new PhysicalRole { ShortName = "HIL", LongName = "Hole Injection Layer" },
                new PhysicalRole { ShortName = "HTL", LongName = "Hole Transport Layer" },
                new PhysicalRole { ShortName = "HBL", LongName = "Hole Blocking Layer" },
                new PhysicalRole { ShortName = "EML", LongName = "Emissive Layer" },
                new PhysicalRole { ShortName = "EIL", LongName = "Electron Injection Layer" },
                new PhysicalRole { ShortName = "ETL", LongName = "Electron Transport Layer" },
                new PhysicalRole { ShortName = "EBL", LongName = "Electron Blocking Layer" },
                new PhysicalRole { ShortName = "CAT", LongName = "Cathode" },
                new PhysicalRole { ShortName = "ENC", LongName = "Encapsulation" },
                new PhysicalRole { ShortName = "PL", LongName = "Passivation Layer" },
                new PhysicalRole { ShortName = "ESL", LongName = "Electron Spreading Layer" },
                new PhysicalRole { ShortName = "UN", LongName = "Unassigned Role" }
            };

            IList<DepositionMethod> methods = new List<DepositionMethod>
            {
                new DepositionMethod { Name = "Thermal Evaporation" },
                new DepositionMethod { Name = "Spincoating" },
                new DepositionMethod { Name = "Sputtering" },
                new DepositionMethod { Name = "Inkjet Printing" },
                new DepositionMethod { Name = "Manual Pipetting" },
                new DepositionMethod { Name = "TCO Substrate" },
                new DepositionMethod { Name = "Unassigned Method" }
            };

            IList<Employee> employees = new List<Employee>
            {
                new Employee { FirstName = "Alex", LastName = "Titov" },
                new Employee { FirstName = "Anil", LastName = "Desireddy" },
                new Employee { FirstName = "Baek", LastName = "Kim" },
                new Employee { FirstName = "Chen", LastName = "Ying" },
                new Employee { FirstName = "Eric", LastName = "Tang" },
                new Employee { FirstName = "Jake", LastName = "Hyvonen" },
                new Employee { FirstName = "Krishna", LastName = "Acharya" },
                new Employee {FirstName = "Xiaoyu",LastName = "Zhang"}
            };

            IList<EquipmentResource> resources = new List<EquipmentResource>
            {
                new EquipmentResource { Name = "Batch Test System 1", IsAvailable = true, ChannelsAvailable = 1 },
                new EquipmentResource { Name = "Batch Test System 2", IsAvailable = true, ChannelsAvailable = 1 },
                new EquipmentResource { Name = "Crysco Lifetime System", IsAvailable = true, ChannelsAvailable = 22 }
            };

            context.PhysicalRoles.AddRange(roles);
            context.DepositionMethods.AddRange(methods);
            context.Employees.AddRange(employees);
            context.EquipmentResources.AddRange(resources);
            base.Seed(context);
        }
    }

}
