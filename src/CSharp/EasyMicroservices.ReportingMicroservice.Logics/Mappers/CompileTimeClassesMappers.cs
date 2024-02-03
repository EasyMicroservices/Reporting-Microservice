//using System.Threading.Tasks;
//using EasyMicroservices.Mapper.CompileTimeMapper.Interfaces;
//using EasyMicroservices.Mapper.Interfaces;
//using System.Linq;

//namespace CompileTimeMapper
//{
//    public class ReportingEntity_ReportingContract_Mapper : IMapper
//    {
//        readonly IMapperProvider _mapper;
//        public ReportingEntity_ReportingContract_Mapper(IMapperProvider mapper)
//        {
//            _mapper = mapper;
//        }
//        public global::EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity Map(global::EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity()
//            {
//                Id = fromObject.Id,
//                ParentId = fromObject.ParentId,
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity
//            };
//            return mapped;
//        }
//        public global::EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract Map(global::EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract()
//            {
//                Id = fromObject.Id,
//                ParentId = fromObject.ParentId,
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity
//            };
//            return mapped;
//        }
//        public async Task<global::EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity> MapAsync(global::EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity()
//            {
//                Id = fromObject.Id,
//                ParentId = fromObject.ParentId,
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity
//            };
//            return mapped;
//        }
//        public async Task<global::EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract> MapAsync(global::EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            var mapped = new global::EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract()
//            {
//                Id = fromObject.Id,
//                ParentId = fromObject.ParentId,
//                Name = fromObject.Name,
//                Text = fromObject.Text,
//                Email = fromObject.Email,
//                Website = fromObject.Website,
//                CreationDateTime = fromObject.CreationDateTime,
//                ModificationDateTime = fromObject.ModificationDateTime,
//                IsDeleted = fromObject.IsDeleted,
//                DeletedDateTime = fromObject.DeletedDateTime,
//                UniqueIdentity = fromObject.UniqueIdentity

//            };
//            return mapped;
//        }
//        public object MapObject(object fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            if (fromObject.GetType() == typeof(EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity))
//                return Map((EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity)fromObject, uniqueRecordId, language, parameters);
//            return Map((EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract)fromObject, uniqueRecordId, language, parameters);
//        }
//        public async Task<object> MapObjectAsync(object fromObject, string uniqueRecordId, string language, object[] parameters)
//        {
//            if (fromObject == default)
//                return default;
//            if (fromObject.GetType() == typeof(EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity))
//                return await MapAsync((EasyMicroservices.ReportingMicroservice.Database.Entities.ReportingEntity)fromObject, uniqueRecordId, language, parameters);
//            return await MapAsync((EasyMicroservices.ReportingMicroservice.Contracts.Common.ReportingContract)fromObject, uniqueRecordId, language, parameters);
//        }
//    }
//}