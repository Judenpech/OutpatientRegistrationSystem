/*
门诊挂号系统数据库--建库脚本
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
		(NAME='OPRSDatafile'
		,FILENAME='E:\OPRSDataFile.mdf')
	LOG ON
		(NAME='OPRSLogfile'
		,FILENAME='E:\OPRSLogfile.ldf');
GO
USE OPRSBase;

--创建表；

---操作员表；
CREATE TABLE tb_operator
    (No 
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,password
        VARBINARY(160));
        
---操作员表--插入操作员数据；
INSERT tb_operator
	(No,Name,Password)
	VALUES
		('3150707012','李靖',HASHBYTES('SHA','7012'))
		,('1','test',HASHBYTES('SHA','1'))
		,('2','test1',NULL);
		       
---患者表；
CREATE TABLE tb_patient
    (No
        VARCHAR(15)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,age
        int
        NOT NULL
    ,sex    -- 0(男),1(女)
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
        varCHAR(45)
    ,tel
        varCHAR(15)
        NOT NULL
    ,Address
        varchar(45)
    ,firstMan1
        VARCHAR(25)
    ,firstManTel1
        CHAR(15)
    ,firstMan2
        VARCHAR(25)
    ,firstManTel2
        CHAR(15)
    ,id      --身份证号
        varCHAR(18)
        UNIQUE
    ,visitNo --就诊卡号
        varCHAR(15)
        UNIQUE
    ,regDate
        DATE
        NOT NULL
    ,allergyHistory
        VARCHAR(255)
    ,operationHistory
        VARCHAR(255));
        
        
---就诊/医疗卡表；
CREATE TABLE tb_card
    (patientNo
        varCHAR(15)
        PRIMARY KEY
    ,cardType  -- 0(就诊卡)，1(社保卡)
        BIT
        NOT NULL
    ,id
		varCHAR(18)
	,visitNo
		varCHAR(15)
    ,creditLimit
		money
    ,balance
        money
        DEFAULT '0.00');
            
---费用记录表；
 CREATE TABLE tb_expensesRecord
	(ticketNo
		CHAR(15)
		PRIMARY KEY
	,patientNo
		varCHAR(15)
	,id
		varCHAR(18)
	,visitNo
		varCHAR(15)
	,regNo
		int
	,docNo
		varchar(10)
	,medicineFee
		money
	,examFee
		money
	,checkFee 
		money
	,diagFee
		money
	,regFee
		money
	,havePaid
		BIT
		DEFAULT 0
	,payDate
		datetime);     

---科室表；
CREATE TABLE tb_dept
    (NO
        VARCHAR(18)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL
    ,pinyin
		VARCHAR(18)
    ,DSCP
        VARCHAR(455));
        
---医生表；
CREATE TABLE tb_doctor
    (No
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,pinyin
		VARCHAR(18)
    ,NAME
        VARCHAR(10)
        NOT NULL
    ,title
        varchar(25)
        NOT NULL
    ,deptNo
        INT
    ,specialty
        VARCHAR(455)
    ,isValid
		bit);
        

        
---预约挂号表；
CREATE TABLE tb_registration
    (NO
        INT
        IDENTITY(1,1)
        NOT NULL
        PRIMARY KEY
    ,patientNo
        varCHAR(15)
        NOT NULL
    ,deptNo
        INT
    ,docNo
        VARCHAR(10)
    ,regDate
        date
        NOT NULL
    ,regTime
        DATETIME
        NOT NULL
    ,done
        BIT
        DEFAULT(0)
    ,operater
        CHAR(10)
        NOT NULL);

    
---挂号类别表；
CREATE TABLE tb_regType
    (id
        INT
        IDENTITY(1,1)
        PRIMARY KEY
    ,NAME
        VARCHAR(45)
        NOT NULL
    ,price
        MONEY
        NOT NULL);
        
       
---医生评价表；
CREATE TABLE tb_docScore
    (id
        INT
        NOT NULL
        IDENTITY(1,1)
        PRIMARY KEY
    ,patientNo
        varCHAR(15)
        NOT NULL
    ,docNo
        VARCHAR(10)
        NOT NULL
    ,score
        VARCHAR(10)
        NOT NULL
    ,comments
        VARCHAR(455)
    ,comDate
        DATE
        NOT NULL);
        
        
        
                      
       
---发票表；
CREATE TABLE tb_receipt
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,regNo
        INT
        NOT NULL
        FOREIGN KEY REFERENCES tb_registration(No)
    ,patientNo
        VARCHAR(15)
        NOT NULL
        FOREIGN KEY REFERENCES tb_patient(No)
    ,recDate
        date
        NOT NULL
    ,charge
        money
        NOT NULL
        DEFAULT '0.00');

        
        
        
        
                        
            