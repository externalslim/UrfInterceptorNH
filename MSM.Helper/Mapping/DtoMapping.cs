using AutoMapper;
using MSM.Data.NhDatabase.NhModels;
using MSM.Helper.Dtos.Project;
using MSM.Helper.Dtos.Person;
using MSM.Helper.Dtos.User;
using MSM.Helper.Dtos.Role;
using MSM.Helper.Dtos.SMSTemplate;
using MSM.Helper.Dtos.MailTemplateGroup;
using MSM.Helper.Dtos.MailTemplate;
using MSM.Helper.Dtos.MailTemplateSchema;
using MSM.Helper.Dtos.SMSTemplateGroup;
using MSM.Helper.Dtos.SMSTemplateSchema;
using MSM.Helper.Dtos.FromListGroup;
using MSM.Helper.Dtos.DataPool;
using MSM.Helper.Dtos.SenderJob;
using MSM.Helper.Dtos.SendList;

namespace MSM.Helper.Mapping
{
    public static class DtoMapping
    {
        public static void Map()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Project, ProjectDto>();
                cfg.CreateMap<ProjectInput, Project>();
                cfg.CreateMap<ProjectDto, Project>();

                cfg.CreateMap<Person, PersonDto>();
                cfg.CreateMap<PersonInput, Person>();
                cfg.CreateMap<PersonDto, Person>();

                cfg.CreateMap<User, UserDto>();
                cfg.CreateMap<UserInput, User>();
                cfg.CreateMap<UserDto, User>();

                cfg.CreateMap<Role, RoleDto>();
                cfg.CreateMap<RoleInput, Role>();
                cfg.CreateMap<RoleDto, Role>();

                cfg.CreateMap<SMSTemplate, SMSTemplateDto>();
                cfg.CreateMap<SMSTemplateInput, SMSTemplate>();
                cfg.CreateMap<SMSTemplateDto, SMSTemplate>();

                cfg.CreateMap<MailTemplateGroup, MailTemplateGroupDto>();
                cfg.CreateMap<MailTemplateGroupInput, MailTemplateGroup>();
                cfg.CreateMap<MailTemplateGroupDto, MailTemplateGroup>();

                cfg.CreateMap<MailTemplate, MailTemplateDto>();
                cfg.CreateMap<MailTemplateInput, MailTemplate>();
                cfg.CreateMap<MailTemplateDto, MailTemplate>();

                cfg.CreateMap<MailTemplateSchema, MailTemplateSchemaDto>();
                cfg.CreateMap<MailTemplateSchemaInput, MailTemplateSchema>();
                cfg.CreateMap<MailTemplateSchemaDto, MailTemplateSchema>();

                cfg.CreateMap<SMSTemplateGroup, SMSTemplateGroupDto>();
                cfg.CreateMap<SMSTemplateGroupInput, SMSTemplateGroup>();
                cfg.CreateMap<SMSTemplateGroupDto, SMSTemplateGroup>();

                cfg.CreateMap<SMSTemplateSchema, SMSTemplateSchemaDto>();
                cfg.CreateMap<SMSTemplateSchemaInput, SMSTemplateSchema>();
                cfg.CreateMap<SMSTemplateSchemaDto, SMSTemplateSchema>();

                cfg.CreateMap<FromListGroup, FromListGroupDto>();
                cfg.CreateMap<FromListGroupInput, FromListGroup>();
                cfg.CreateMap<FromListGroupDto, FromListGroup>();

                cfg.CreateMap<DataPool, DataPoolDto>();
                cfg.CreateMap<DataPoolInput, DataPool>();
                cfg.CreateMap<DataPoolDto, DataPool>();

                cfg.CreateMap<SenderJob, SenderJobDto>();
                cfg.CreateMap<SenderJobInput, SenderJob>();
                cfg.CreateMap<SenderJobDto, SenderJob>();

                cfg.CreateMap<SendList, SendListDto>();
                cfg.CreateMap<SendListInput, SendList>();
                cfg.CreateMap<SendListDto, SendList>();
            });
        }
    }
}
