
/*在创建表之前先删掉已有的表*/
if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_BasicInfo') and o.name = 'FK_BOOK_BAS_REFERENCE_PRESS_IN')
alter table Book_BasicInfo
   drop constraint FK_BOOK_BAS_REFERENCE_PRESS_IN
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Borrow') and o.name = 'FK_BOOK_BOR_REFERENCE_BOOK_INF')
alter table Book_Borrow
   drop constraint FK_BOOK_BOR_REFERENCE_BOOK_INF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Borrow') and o.name = 'FK_BOOK_BOR_REFERENCE_READER_I')
alter table Book_Borrow
   drop constraint FK_BOOK_BOR_REFERENCE_READER_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Borrow') and o.name = 'FK_BOOK_BOR_REFERENCE_MANAGER_')
alter table Book_Borrow
   drop constraint FK_BOOK_BOR_REFERENCE_MANAGER_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Info') and o.name = 'FK_BOOK_INF_REFERENCE_BOOK_BAS')
alter table Book_Info
   drop constraint FK_BOOK_INF_REFERENCE_BOOK_BAS
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Lost') and o.name = 'FK_BOOK_LOS_REFERENCE_BOOK_INF')
alter table Book_Lost
   drop constraint FK_BOOK_LOS_REFERENCE_BOOK_INF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Lost') and o.name = 'FK_BOOK_LOS_REFERENCE_READER_I')
alter table Book_Lost
   drop constraint FK_BOOK_LOS_REFERENCE_READER_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Lost') and o.name = 'FK_BOOK_LOS_REFERENCE_MANAGER_')
alter table Book_Lost
   drop constraint FK_BOOK_LOS_REFERENCE_MANAGER_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Return') and o.name = 'FK_BOOK_RET_REFERENCE_MANAGER_')
alter table Book_Return
   drop constraint FK_BOOK_RET_REFERENCE_MANAGER_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Return') and o.name = 'FK_BOOK_RET_REFERENCE_BOOK_INF')
alter table Book_Return
   drop constraint FK_BOOK_RET_REFERENCE_BOOK_INF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Book_Return') and o.name = 'FK_BOOK_RET_REFERENCE_READER_I')
alter table Book_Return
   drop constraint FK_BOOK_RET_REFERENCE_READER_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Out_Fine') and o.name = 'FK_OUT_FINE_REFERENCE_BOOK_INF')
alter table Out_Fine
   drop constraint FK_OUT_FINE_REFERENCE_BOOK_INF
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Out_Fine') and o.name = 'FK_OUT_FINE_REFERENCE_READER_I')
alter table Out_Fine
   drop constraint FK_OUT_FINE_REFERENCE_READER_I
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Out_Fine') and o.name = 'FK_OUT_FINE_REFERENCE_MANAGER_')
alter table Out_Fine
   drop constraint FK_OUT_FINE_REFERENCE_MANAGER_
go

if exists (select 1
   from sys.sysreferences r join sys.sysobjects o on (o.id = r.constid and o.type = 'F')
   where r.fkeyid = object_id('Reader_Info') and o.name = 'FK_READER_I_REFERENCE_READER_T')
alter table Reader_Info
   drop constraint FK_READER_I_REFERENCE_READER_T
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Book_BasicInfo')
            and   type = 'U')
   drop table Book_BasicInfo
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Book_Borrow')
            and   type = 'U')
   drop table Book_Borrow
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Book_Info')
            and   type = 'U')
   drop table Book_Info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Book_Lost')
            and   type = 'U')
   drop table Book_Lost
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Book_Return')
            and   type = 'U')
   drop table Book_Return
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Manager_Info')
            and   type = 'U')
   drop table Manager_Info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Out_Fine')
            and   type = 'U')
   drop table Out_Fine
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Press_Info')
            and   type = 'U')
   drop table Press_Info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Reader_Info')
            and   type = 'U')
   drop table Reader_Info
go

if exists (select 1
            from  sysobjects
           where  id = object_id('Reader_Type')
            and   type = 'U')
   drop table Reader_Type
go
/*创建图书基本信息表*/
/*==============================================================*/
/* Table: Book_BasicInfo                                        */
/*==============================================================*/
create table Book_BasicInfo (
   ISBN                 varchar(18)          not null,
   PID                  int                  not null,
   BName                varchar(30)          not null,
   Writer               varchar(30)          not null,
   Version              int                  not null,
   PubDate              date                 not null,
   Price                int                  null,
   Intro                text                 null,
   constraint PK_BOOK_BASICINFO primary key nonclustered (ISBN)
)
go
/*创建图书借阅表*/
/*==============================================================*/
/* Table: Book_Borrow                                           */
/*==============================================================*/
create table Book_Borrow (
   BoID                 int                  identity,
   BID                  int                  null,
   RID                  int                  null,
   MID                  int                  null,
   BoTime               datetime             null,
   ShouldReTime         datetime             null,
   ReNewTimes           int                  null,
   constraint PK_BOOK_BORROW primary key nonclustered (BoID)
)
go
/*创建图书信息表*/
/*==============================================================*/
/* Table: Book_Info                                             */
/*==============================================================*/
create table Book_Info (
   BID                  int                  not null,
   ISBN                 varchar(18)          not null,
   BCondition           bool                 not null,
   WareTime             datetime             not null,
   constraint PK_BOOK_INFO primary key nonclustered (BID)
)
go
/*创建图书丢失表*/
/*==============================================================*/
/* Table: Book_Lost                                             */
/*==============================================================*/
create table Book_Lost (
   LID                  int                  identity,
   BID                  int                  not null,
   RID                  int                  not null,
   MID                  int                  not null,
   PayBack              int                  not null,
   OperTime             datetime             not null,
   constraint PK_BOOK_LOST primary key nonclustered (LID)
)
go
/*创建图书归还表*/
/*==============================================================*/
/* Table: Book_Return                                           */
/*==============================================================*/
create table Book_Return (
   ReID                 int                  identity,
   MID                  int                  not null,
   BID                  int                  not null,
   RID                  int                  not null,
   ReTime               datetime             not null,
   constraint PK_BOOK_RETURN primary key nonclustered (ReID)
)
go
/*创建管理员信息表*/
/*==============================================================*/
/* Table: Manager_Info                                          */
/*==============================================================*/
create table Manager_Info (
   MID                  int                  not null,
   MName                varchar(30)          not null,
   Sex                  bit                  not null,
   Phone                tinyint              not null,
   Post                 varchar(20)          not null,
   constraint PK_MANAGER_INFO primary key nonclustered (MID)
)
go
/*创建超期罚款表*/
/*==============================================================*/
/* Table: Out_Fine                                              */
/*==============================================================*/
create table Out_Fine (
   FID                  int                  identity,
   BID                  int                  not null,
   RID                  int                  not null,
   MID                  int                  not null,
   FinePrice            int                  not null,
   IsFin                bool                 not null,
   FineTime             datetime             null,
   Remark               text                 null,
   constraint PK_OUT_FINE primary key nonclustered (FID)
)
go
/*创建出版社信息表*/
/*==============================================================*/
/* Table: Press_Info                                            */
/*==============================================================*/
create table Press_Info (
   PID                  int                  not null,
   PName                varchar(30)          not null,
   Contact              varchar(30)          not null,
   Phone                tinyint              not null,
   Fax                  text                 null,
   Address              varchar(50)          not null,
   constraint PK_PRESS_INFO primary key nonclustered (PID)
)
go
/*创建读者信息表*/
/*==============================================================*/
/* Table: Reader_Info                                           */
/*==============================================================*/
create table Reader_Info (
   RID                  int                  identity,
   RTID                 int                  not null,
   RName                varchar(30)          not null,
   Sex                  bit                  not null,
   Phone                tinyint              not null,
   ReDate               datetime             not null,
   ValDate              datetime             not null,
   CurBNum              int                  null,
   TotBNum              int                  null,
   IsLost               bool                 null,
   VioNum               int                  null,
   Remark               text                 null,
   constraint PK_READER_INFO primary key nonclustered (RID)
)
go
/*创建读者类别表*/
/*==============================================================*/
/* Table: Reader_Type                                           */
/*==============================================================*/
create table Reader_Type (
   RTID                 int                  not null,
   RTName               varchar(30)          not null,
   BNum                 int                  not null,
   BDay                 int                  not null,
   constraint PK_READER_TYPE primary key nonclustered (RTID)
)
go
/*设置图书基本信息表外键PID*/
alter table Book_BasicInfo
   add constraint FK_BOOK_BAS_REFERENCE_PRESS_IN foreign key (PID)
      references Press_Info (PID)
go
/*设置图书借阅表外键BID*/
alter table Book_Borrow
   add constraint FK_BOOK_BOR_REFERENCE_BOOK_INF foreign key (BID)
      references Book_Info (BID)
go
/*设置图书借阅表外键RID*/
alter table Book_Borrow
   add constraint FK_BOOK_BOR_REFERENCE_READER_I foreign key (RID)
      references Reader_Info (RID)
go
/*设置图书借阅表外键MID*/
alter table Book_Borrow
   add constraint FK_BOOK_BOR_REFERENCE_MANAGER_ foreign key (MID)
      references Manager_Info (MID)
go
/*设置图书信息表外键ISBN*/
alter table Book_Info
   add constraint FK_BOOK_INF_REFERENCE_BOOK_BAS foreign key (ISBN)
      references Book_BasicInfo (ISBN)
go
/*设置图书丢失表外键BID*/
alter table Book_Lost
   add constraint FK_BOOK_LOS_REFERENCE_BOOK_INF foreign key (BID)
      references Book_Info (BID)
go
/*设置图书丢失表外键RID*/
alter table Book_Lost
   add constraint FK_BOOK_LOS_REFERENCE_READER_I foreign key (RID)
      references Reader_Info (RID)
go
/*设置图书丢失表外键MID*/
alter table Book_Lost
   add constraint FK_BOOK_LOS_REFERENCE_MANAGER_ foreign key (MID)
      references Manager_Info (MID)
go
/*设置图书归还表外键MID*/
alter table Book_Return
   add constraint FK_BOOK_RET_REFERENCE_MANAGER_ foreign key (MID)
      references Manager_Info (MID)
go
/*设置图书归还表外键BID*/
alter table Book_Return
   add constraint FK_BOOK_RET_REFERENCE_BOOK_INF foreign key (BID)
      references Book_Info (BID)
go
/*设置图书归还表外键RID*/
alter table Book_Return
   add constraint FK_BOOK_RET_REFERENCE_READER_I foreign key (RID)
      references Reader_Info (RID)
go
/*设置超期罚款表外键BID*/
alter table Out_Fine
   add constraint FK_OUT_FINE_REFERENCE_BOOK_INF foreign key (BID)
      references Book_Info (BID)
go
/*设置超期罚款表外键RID*/
alter table Out_Fine
   add constraint FK_OUT_FINE_REFERENCE_READER_I foreign key (RID)
      references Reader_Info (RID)
go
/*设置超期罚款表外键MID*/
alter table Out_Fine
   add constraint FK_OUT_FINE_REFERENCE_MANAGER_ foreign key (MID)
      references Manager_Info (MID)
go
/*设置读者信息表外键RTID*/
alter table Reader_Info
   add constraint FK_READER_I_REFERENCE_READER_T foreign key (RTID)
      references Reader_Type (RTID)
go

