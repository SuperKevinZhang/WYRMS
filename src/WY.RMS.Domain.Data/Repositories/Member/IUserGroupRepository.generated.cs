﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
//	   如存在本生成代码外的新需求，请在相同命名空间下创建同名分部类进行实现。
// </auto-generated>
//
// <copyright file="IUserGroupRepository.generated.cs">
//		Copyright(c)2013 WUYICN.All rights reserved.
//		CLR版本：4.5.1
//		开发组织：WUYI@中国
//		公司网站：http://www.gzuwuyi.cn
//		所属工程：WUYI.RMS.Domain.Data
//		生成时间：2016-02-18 10:13
// </copyright>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WY.RMS.Component.Data;
using WY.RMS.Component.Data.EF.Interface;
using WY.RMS.Domain.Model.Member;


namespace WY.RMS.Domain.Data.Repositories.Member
{
	/// <summary>
    ///   仓储操作层接口——用户组
    /// </summary>
    public partial interface IUserGroupRepository : IRepository<UserGroup, Int32>
    { }
}
