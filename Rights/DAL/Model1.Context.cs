﻿

//------------------------------------------------------------------------------
// <auto-generated>
//     此代码已从模板生成。
//
//     手动更改此文件可能导致应用程序出现意外的行为。
//     如果重新生成代码，将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Langben.DAL
{

using System;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


public partial class SysEntities : DbContext
{
    public SysEntities()
        : base("name=SysEntities")
    {

    }

    protected override void OnModelCreating(DbModelBuilder modelBuilder)
    {
        throw new UnintentionalCodeFirstException();
    }


    public virtual DbSet<FileUploader> FileUploader { get; set; }

    public virtual DbSet<SysAnnouncement> SysAnnouncement { get; set; }

    public virtual DbSet<SysDepartment> SysDepartment { get; set; }

    public virtual DbSet<SysDocument> SysDocument { get; set; }

    public virtual DbSet<SysDocumentTalk> SysDocumentTalk { get; set; }

    public virtual DbSet<SysException> SysException { get; set; }

    public virtual DbSet<SysField> SysField { get; set; }

    public virtual DbSet<SysLog> SysLog { get; set; }

    public virtual DbSet<SysMenu> SysMenu { get; set; }

    public virtual DbSet<SysMenuSysRoleSysOperation> SysMenuSysRoleSysOperation { get; set; }

    public virtual DbSet<SysNotice> SysNotice { get; set; }

    public virtual DbSet<SysOperation> SysOperation { get; set; }

    public virtual DbSet<SysPerson> SysPerson { get; set; }

    public virtual DbSet<SysRole> SysRole { get; set; }

}

}

