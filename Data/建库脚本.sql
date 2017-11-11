/*
门诊挂号系统数据库
*/
--创建数据库；
USE master;
IF DB_ID('OPRSBase') IS NOT NULL
	BEGIN
		ALTER DATABASE OPRSBase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE OPRSBase;
	END
CREATE DATABASE OPRSBase
	ON
		(NAME='Datafile'
		,FILENAME='E:\OPRSDataFile.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='E:\OPRSLogfile.ldf');
GO
USE OPRSBase;
--创建表；
----操作员表；
CREATE TABLE tb_operator
    (No 
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,password
        VARBINARY(160)
        NOT NULL);
INSERT tb_operator
    (No,Name,Password)
    VALUES
        ('3150707012','李靖',HASHBYTES('SHA','7012'))
        ,('1','test',HASHBYTES('SHA','1'));
----患者表；
CREATE TABLE tb_patient
    (No
        CHAR(15)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,age
        int
        NOT NULL
    ,sex
        bit
        NOT NULL
    ,birthday
        date
        NOT NULL
    ,nationality
        varchar(25)
    ,nation
        VARCHAR(15)
    ,email
        CHAR(45)
    ,tel
        CHAR(15)
        NOT NULL
    ,[Address]
        varchar(45)
    ,firstMan1
        VARCHAR(25)
    ,firstManTel1
        CHAR(15)
    ,firstMan2
        VARCHAR(25)
    ,firstManTel2
        CHAR(15)
    ,regDate
        DATE
        NOT NULL
    ,allergyHistory
        VARCHAR(255)
    ,operationHistory
        VARCHAR(255));
----就诊卡表；
CREATE TABLE tb_card
    (patientNo
        CHAR(15)
        PRIMARY KEY
        FOREIGN KEY REFERENCES tb_patient(No)
    ,balance
        money
        NOT NULL
        DEFAULT '0.00'
    ,creditLimit
        MONEY
    ,enMoney
        money
    ,coMoney
        money
    ,enTime
        date
    ,coTime
        date);
----社保卡表；
CREATE TABLE tb_socialCard
    (patientNo
        CHAR(15)
        PRIMARY KEY
        FOREIGN KEY REFERENCES tb_patient(No)
    ,balance
        money
        NOT NULL
        DEFAULT '0.00'
    ,creditLimit
        MONEY
    ,enMoney
        money
    ,coMoney
        money
    ,enTime
        date
    ,coTime
        date);
----科室表；
CREATE TABLE tb_dept
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
----医生表；
CREATE TABLE tb_doctor
    (No
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        CHAR(10)
        NOT NULL
    ,title
        varchar(25)
        NOT NULL
    ,deptNo
        CHAR(10)
        FOREIGN KEY REFERENCES tb_dept(No)
    ,visitTime
        date
    ,limitNum
        int
    ,numLeft
        int);
----挂号表；
CREATE TABLE tb_register
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,regType
        varchar(25)
        NOT NULL
    ,PRIORITY
        int
        NOT NULL
        DEFAULT '0'
    ,patientNo
        CHAR(15)
        NOT NULL
        FOREIGN KEY REFERENCES tb_patient(No)
    ,deptNo
        CHAR(10)
        FOREIGN KEY REFERENCES tb_dept(No)
    ,docNo
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_doctor(No)
    ,regFee
        money
        NOT NULL
        DEFAULT '0.00'
    ,medFee
        money
        NOT NULL
        DEFAULT '0.00'
    ,regDate
        date
        NOT NULL
    ,opUser
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_operator(No));
----发票表；
CREATE TABLE tb_receipt
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,regNo
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_register(No)
    ,patientNo
        CHAR(15)
        NOT NULL
        FOREIGN KEY REFERENCES tb_patient(No)
    ,recDate
        date
        NOT NULL
    ,charge
        money
        NOT NULL
        DEFAULT '0.00');

----病种表；
CREATE TABLE tb_drgs
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
----家床登记表；
CREATE TABLE tb_bedReg
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,drgsNo
        CHAR(10)
        FOREIGN KEY REFERENCES tb_drgs(No)
    ,deptNo
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_dept(No)
    ,receiptNo
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_receipt(No)
    ,beginDate
        date
        NOT NULL
    ,endDate
        date
        NOT NULL);
----排班表；
CREATE TABLE tb_schedual
    (weekday
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,deptNo
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_dept(No)
    ,docNo
        CHAR(10)
        NOT NULL
        UNIQUE
        FOREIGN KEY REFERENCES tb_doctor(No)
    ,num
        int
        NOT NULL
    ,numLeft
        int
        NOT NULL);
        
        
        
        
                        
            