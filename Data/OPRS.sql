/*
����Һ�ϵͳ���ݿ�--����ű�
*/

--�������ݿ⣻
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

--������

--ҽԺ��Ϣ��
CREATE TABLE tb_Hospital
	(NAME
	VARCHAR(45)
	,[ADDRESS]
	VARCHAR(255)
	,signUpCode
	CHAR(10)
	PRIMARY KEY);
	
---����Ա��
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
        
---����Ա��--�������Ա���ݣ�
INSERT tb_operator
	(No,Name,Password)
	VALUES
		('3150707012','�',HASHBYTES('SHA','7012'))
		,('1','test',HASHBYTES('SHA','1'))
		,('2','test1',NULL);
		       
---���߱�
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
    ,sex    -- 0(��),1(Ů)
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
    ,id      --���֤��
        varCHAR(18)
        UNIQUE
    ,visitNo --���￨��
        varCHAR(15)
        UNIQUE
    ,regDate
        DATE
        NOT NULL
    ,allergyHistory
        VARCHAR(255)
    ,operationHistory
        VARCHAR(255));
        
        
---����/ҽ�ƿ���
CREATE TABLE tb_card
    (patientNo
        varCHAR(15)
        PRIMARY KEY
    ,cardType  -- 0(���￨)��1(�籣��)
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
            
---���ü�¼��
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

---���ұ�
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
        
---ҽ����
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
        

        
---ԤԼ�Һű�
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

    
---�Һ�����
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
        
       
---ҽ�����۱�
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
        
        
        
                      
       
---��Ʊ��
CREATE TABLE tb_receipt
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,regNo
        INT
        NOT NULL
    ,patientNo
        VARCHAR(15)
        NOT NULL
    ,recDate
        date
        NOT NULL
    ,charge
        money
        NOT NULL
        DEFAULT '0.00');

        
        
        
        
                        
            