using FluentNHibernate.Mapping;
using MSM.Data.NhDatabase.NhModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSM.Data.NhDatabase.NhMappings
{
    public class ProjectMap : ClassMap<Project>
    {
        public ProjectMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("Project");
        }
    }

    public class PersonMap : ClassMap<Person>
    {
        public PersonMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Phone);
            Map(x => x.Email);
            Map(x => x.Address);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("Person");
        }
    }

    public class UserMap : ClassMap<User>
    {
        public UserMap()
        {
            Id(x => x.Id);
            Map(x => x.PersonId);
            Map(x => x.ProjectId);
            Map(x => x.RoleId);
            Map(x => x.Name);
            Map(x => x.Password);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("User");
        }
    }

    public class RoleMap : ClassMap<Role>
    {
        public RoleMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("Role");
        }
    }

    public class SMSTemplateMap : ClassMap<SMSTemplate>
    {
        public SMSTemplateMap()
        {
            Id(x => x.Id);
            Map(x => x.UserId);
            Map(x => x.SMSTemplateGroupId);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("SMSTemplate");
        }
    }

    public class MailTemplateGroupMap : ClassMap<MailTemplateGroup>
    {
        public MailTemplateGroupMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("MailTemplateGroup");
        }
    }

    public class MailTemplateMap : ClassMap<MailTemplate>
    {
        public MailTemplateMap()
        {
            Id(x => x.Id);
            Map(x => x.UserId);
            Map(x => x.MailTemplateGroupId);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("MailTemplate");
        }
    }

    public class MailTemplateSchemaMap : ClassMap<MailTemplateSchema>
    {
        public MailTemplateSchemaMap()
        {
            Id(x => x.Id);
            Map(x => x.MailTemplateGroupId);
            Map(x => x.Name);
            Map(x => x.Subject);
            Map(x => x.Body);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("MailTemplateSchema");
        }
    }

    public class SMSTemplateGroupMap : ClassMap<SMSTemplateGroup>
    {
        public SMSTemplateGroupMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("SMSTemplateGroup");
        }
    }

    public class SMSTemplateSchemaMap : ClassMap<SMSTemplateSchema>
    {
        public SMSTemplateSchemaMap()
        {
            Id(x => x.Id);
            Map(x => x.SMSTemplateGroupId);
            Map(x => x.Name);
            Map(x => x.Body);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("SMSTemplateSchema");
        }
    }

    public class FromListGroupMap : ClassMap<FromListGroup>
    {
        public FromListGroupMap()
        {
            Id(x => x.Id);
            Map(x => x.ProjectId);
            Map(x => x.Name);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("FromListGroup");
        }
    }

    public class DataPoolMap : ClassMap<DataPool>
    {
        public DataPoolMap()
        {
            Id(x => x.Id);
            Map(x => x.FromListGroupId);
            Map(x => x.Name);
            Map(x => x.Surname);
            Map(x => x.Email);
            Map(x => x.Phone);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("DataPool");
        }
    }

    public class SenderJobMap : ClassMap<SenderJob>
    {
        public SenderJobMap()
        {
            Id(x => x.Id);
            Map(x => x.Name);
            Map(x => x.TemplateTypeId);
            Map(x => x.TemplateId);
            Map(x => x.StartDate);
            Map(x => x.Counter);
            Map(x => x.SendPeriod);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("SenderJob");
        }
    }

    public class SendListMap : ClassMap<SendList>
    {
        public SendListMap()
        {
            Id(x => x.Id);
            Map(x => x.SenderJobId);
            Map(x => x.DataPoolId);
            Map(x => x.IsDeleted);
            Map(x => x.CreatedBy);
            Map(x => x.CreatedDate);
            Map(x => x.UpdatedBy);
            Map(x => x.UpdatedDate);
            Table("SendList");
        }
    }
     
 

}