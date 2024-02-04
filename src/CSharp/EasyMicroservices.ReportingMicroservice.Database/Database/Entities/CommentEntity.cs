using EasyMicroservices.ReportingMicroservice.Database.Schemas;
using EasyMicroservices.Cores.Database.Interfaces;
using EasyMicroservices.Cores.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EasyMicroservices.ReportingMicroservice.Database.Entities
{
    public class ReportingEntity : Reportingchema, IIdSchema<long>
    {
        public long? ParentId { get; set; }
        public long Id { get; set; }
    }
}
