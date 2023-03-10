
# 在创建表之前先删掉已有的表
drop table if exists Book_BasicInfo;

drop table if exists Book_Borrow;

drop table if exists Book_Info;

drop table if exists Book_Lost;

drop table if exists Book_Return;

drop table if exists Manager_Info;

drop table if exists Out_Fine;

drop table if exists Press_Info;

drop table if exists Reader_Info;

drop table if exists Reader_Type;

#创建图书基本信息表
/*==============================================================*/
/* Table: Book_BasicInfo                                        */
/*==============================================================*/
create table Book_BasicInfo
(
   ISBN                 varchar(18) not null,
   PID                  int not null,
   BName                varchar(30) not null,
   Writer               varchar(30) not null,
   Version              int not null,
   PubDate              date not null,
   Price                int,
   Intro                text,
   primary key (ISBN)
);
#创建图书借阅表
/*==============================================================*/
/* Table: Book_Borrow                                           */
/*==============================================================*/
create table Book_Borrow
(
   BoID                 int not null auto_increment,
   BID                  int,
   RID                  int,
   MID                  int,
   BoTime               datetime,
   ShouldReTime         datetime,
   ReNewTimes           int,
   primary key (BoID)
);
#创建图书信息表
/*==============================================================*/
/* Table: Book_Info                                             */
/*==============================================================*/
create table Book_Info
(
   BID                  int not null,
   ISBN                 varchar(18) not null,
   BCondition           bool not null,
   WareTime             datetime not null,
   primary key (BID)
);
#创建图书丢失表
/*==============================================================*/
/* Table: Book_Lost                                             */
/*==============================================================*/
create table Book_Lost
(
   LID                  int not null auto_increment,
   BID                  int not null,
   RID                  int not null,
   MID                  int not null,
   PayBack              int not null,
   OperTime             datetime not null,
   primary key (LID)
);
#创建图书归还表
/*==============================================================*/
/* Table: Book_Return                                           */
/*==============================================================*/
create table Book_Return
(
   ReID                 int not null auto_increment,
   MID                  int not null,
   BID                  int not null,
   RID                  int not null,
   ReTime               datetime not null,
   primary key (ReID)
);
#创建管理员信息表
/*==============================================================*/
/* Table: Manager_Info                                          */
/*==============================================================*/
create table Manager_Info
(
   MID                  int not null,
   MName                varchar(30) not null,
   Sex                  bit not null,
   Phone                tinyint not null,
   Post                 varchar(20) not null,
   primary key (MID)
);
#创建超期罚款表
/*==============================================================*/
/* Table: Out_Fine                                              */
/*==============================================================*/
create table Out_Fine
(
   FID                  int not null auto_increment,
   BID                  int not null,
   RID                  int not null,
   MID                  int not null,
   FinePrice            int not null,
   IsFin                bool not null,
   FineTime             datetime,
   Remark               text,
   primary key (FID)
);
#创建出版社信息表
/*==============================================================*/
/* Table: Press_Info                                            */
/*==============================================================*/
create table Press_Info
(
   PID                  int not null,
   PName                varchar(30) not null,
   Contact              varchar(30) not null,
   Phone                tinyint not null,
   Fax                  text,
   Address              varchar(50) not null,
   primary key (PID)
);
#创建读者信息表
/*==============================================================*/
/* Table: Reader_Info                                           */
/*==============================================================*/
create table Reader_Info
(
   RID                  int not null auto_increment,
   RTID                 int not null,
   RName                varchar(30) not null,
   Sex                  bit not null,
   Phone                tinyint not null,
   ReDate               datetime not null,
   ValDate              datetime not null,
   CurBNum              int,
   TotBNum              int,
   IsLost               bool,
   VioNum               int,
   Remark               text,
   primary key (RID)
);
#创建读者类别表
/*==============================================================*/
/* Table: Reader_Type                                           */
/*==============================================================*/
create table Reader_Type
(
   RTID                 int not null,
   RTName               varchar(30) not null,
   BNum                 int not null,
   BDay                 int not null,
   primary key (RTID)
);
#设置图书基本信息表外键PID
alter table Book_BasicInfo add constraint FK_Reference_2 foreign key (PID)
      references Press_Info (PID) on delete restrict on update restrict;
#设置图书借阅表外键BID
alter table Book_Borrow add constraint FK_Reference_4 foreign key (BID)
      references Book_Info (BID) on delete restrict on update restrict;
#设置图书借阅表外键RID
alter table Book_Borrow add constraint FK_Reference_5 foreign key (RID)
      references Reader_Info (RID) on delete restrict on update restrict;
#设置图书借阅表外键MID
alter table Book_Borrow add constraint FK_Reference_6 foreign key (MID)
      references Manager_Info (MID) on delete restrict on update restrict;
#设置图书信息表外键ISBN
alter table Book_Info add constraint FK_Reference_3 foreign key (ISBN)
      references Book_BasicInfo (ISBN) on delete restrict on update restrict;
#设置图书丢失表外键BID
alter table Book_Lost add constraint FK_Reference_13 foreign key (BID)
      references Book_Info (BID) on delete restrict on update restrict;
#设置图书丢失表外键RID
alter table Book_Lost add constraint FK_Reference_14 foreign key (RID)
      references Reader_Info (RID) on delete restrict on update restrict;
#设置图书丢失表外键MID
alter table Book_Lost add constraint FK_Reference_15 foreign key (MID)
      references Manager_Info (MID) on delete restrict on update restrict;
#设置图书归还表外键MID
alter table Book_Return add constraint FK_Reference_7 foreign key (MID)
      references Manager_Info (MID) on delete restrict on update restrict;
#设置图书归还表外键BID
alter table Book_Return add constraint FK_Reference_8 foreign key (BID)
      references Book_Info (BID) on delete restrict on update restrict;
#设置图书归还表外键RID
alter table Book_Return add constraint FK_Reference_9 foreign key (RID)
      references Reader_Info (RID) on delete restrict on update restrict;
#设置超期罚款表外键BID
alter table Out_Fine add constraint FK_Reference_10 foreign key (BID)
      references Book_Info (BID) on delete restrict on update restrict;
#设置超期罚款表外键RID
alter table Out_Fine add constraint FK_Reference_11 foreign key (RID)
      references Reader_Info (RID) on delete restrict on update restrict;
#设置超期罚款表外键MID
alter table Out_Fine add constraint FK_Reference_12 foreign key (MID)
      references Manager_Info (MID) on delete restrict on update restrict;
#设置读者信息表外键RTID
alter table Reader_Info add constraint FK_Reference_1 foreign key (RTID)
      references Reader_Type (RTID) on delete restrict on update restrict;

