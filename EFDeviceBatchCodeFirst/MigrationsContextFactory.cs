using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFDeviceBatchCodeFirst
{
    public class MigrationsContextFactory : IDbContextFactory<DeviceBatchContext>
    {
        public DeviceBatchContext Create()
        {
            return new DeviceBatchContext();
        }
    }
}
