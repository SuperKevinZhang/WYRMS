using WY.RMS.Component.Data.EF;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using WY.RMS.Domain.Model.Member;

namespace WY.RMS.Component.Data.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<EFDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(EFDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
            List<Module> modules = new List<Module>
            {
                new Module { Id = 1, ParentId = null, Name = "权限管理", Code = 200,LinkUrl="#",  Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now},
                new Module { Id = 2, ParentId = 1, Name = "角色管理", LinkUrl = "~/Member/Role/Index",  Code = 201,Description = null, IsMenu = true, Enabled = true, UpdateDate = DateTime.Now},
                new Module { Id = 3, ParentId = 1, Name = "用户管理", LinkUrl = "~/Member/User/Index", Code = 202, Description = null, IsMenu = true, Enabled = true, UpdateDate = DateTime.Now },
                new Module { Id = 4, ParentId = 1, Name = "模块管理", LinkUrl = "~/Member/Module/Index",  Code = 203, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 5, ParentId = 1, Name = "授权管理", LinkUrl = "~/Member/Permission/Index",  Code = 204, Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                 new Module { Id = 6, ParentId = null, Name = "系统应用", LinkUrl = "#",  Code = 300,  Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
                new Module { Id = 7, ParentId = 6, Name = "操作日志管理", LinkUrl = "~/SysConfig/OperateLog/Index",Code = 301,Description = null, IsMenu = true, Enabled = true,  UpdateDate = DateTime.Now },
            };
            DbSet<Module> moduleSet = context.Set<Module>();
            moduleSet.AddOrUpdate(t => new { t.Name }, modules.ToArray());
            context.SaveChanges();

            List<Permission> permissions = new List<Permission>
            {
                new Permission{Id=1, Name="查询",Code=1, Description="描述" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]},
              new Permission{Id=2, Name="查询",Code=2, Description="描述" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[2]},
               new Permission{Id=3, Name="查询",Code=3, Description="描述" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[3]},
                new Permission{Id=4, Name="查询",Code=4, Description="描述" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[4]},
              new Permission{Id=5, Name="查询",Code=5, Description="描述" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[6]},
               new Permission{Id=6, Name="修改",Code=6, Description="描述" ,Enabled=true,UpdateDate=DateTime.Now,module=modules[1]},
            };
            DbSet<Permission> permissionSet = context.Set<Permission>();
            permissionSet.AddOrUpdate(m => new { m.Id }, permissionSet.ToArray());
            context.SaveChanges();
            List<Role> roles = new List<Role>
            {
                new Role { Id=1,  RoleName = "superadmin", Description="超级管理员",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                new Role { Id=2,  RoleName = "管理员", Description="系统管理员",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now,Permissions=permissions},
                 new Role { Id=3,  RoleName = "普通角色1", Description="普通角色1",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                  new Role { Id=4,  RoleName = "普通角色2", Description="普通角色2",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                   new Role { Id=5,  RoleName = "普通角色3", Description="普通角色3",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                    new Role { Id=6,  RoleName = "普通角色4", Description="普通角色4",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                     new Role { Id=7,  RoleName = "普通角色5", Description="普通角色5",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                      new Role { Id=8,  RoleName = "普通角色6", Description="普通角色6",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                       new Role { Id=9,  RoleName = "普通角色7", Description="普通角色7",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                        new Role { Id=10,  RoleName = "普通角色8", Description="普通角色8",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                         new Role { Id=11,  RoleName = "普通角色9", Description="普通角色9",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now },
                                new Role { Id=12,  RoleName = "普通角色10", Description="普通角色10",Enabled=true,OrderSort=1,UpdateDate=DateTime.Now }
            };
            DbSet<Role> roleSet = context.Set<Role>();
            roleSet.AddOrUpdate(m => new { m.RoleName }, roles.ToArray());
            context.SaveChanges();

            List<User> members = new List<User>
            {
                new User { Id=1, UserName = "admin", Password = "000102030405060708090a0b0c0d0e0f", Email = "375368093@qq.com", TrueName = "管理员",Phone="18181818181",Address="广东广州市天河区科韵路XX街XX号XXX房X号" ,Enabled=true,Roles=new List<Role>{roles[1]} },
                new User { Id=2, UserName = "xiaowu", Password = "000102030405060708090a0b0c0d0e0f", Email = "11111@1111.com", TrueName = "小吴",Phone="18181818181",Address="广东广州市天河区科韵路XX街X广东广州市天河区科韵路XX街XX号XXX房X号",Enabled=true,Roles=new List<Role>{roles[1]} }
            };
            DbSet<User> memberSet = context.Set<User>();
            memberSet.AddOrUpdate(m => new { m.UserName }, members.ToArray());
            context.SaveChanges();
        }
    }
}
