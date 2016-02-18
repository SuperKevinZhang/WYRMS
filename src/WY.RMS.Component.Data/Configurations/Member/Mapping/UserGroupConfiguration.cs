﻿/************************************
 * 描述：尚未添加描述
 * 作者：吴毅
 * 日期：2015/11/11 14:05:25  
*************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WY.RMS.Domain.Model.Member;

namespace WY.RMS.Component.Data.Configurations.Member
{
    internal partial class UserGroupConfiguration
    {
        partial void UserGroupConfigurationAppend()
        {
            this.Property(t => t.Id).HasColumnName("Id").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.HasMany(g => g.Users).WithMany(u => u.UserGroups);
            this.HasMany(g => g.Roles).WithMany(r => r.UserGroups);
        }


    }
}
