/*
����Һ�ϵͳ���ݿ�
*/
--�������ݿ⣻
USE master;
IF DB_ID('ORSBase') IS NOT NULL
	BEGIN
		ALTER DATABASE ORSBase
			SET SINGLE_USER
			WITH ROLLBACK IMMEDIATE;
		DROP DATABASE ORSBase;
	END
CREATE DATABASE ORSBase
	ON
		(NAME='Datafile'
		,FILENAME='E:\ORSDataFile.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='E:\ORSLogfile.ldf');
GO
USE ORSBase;
--������
----����Ա��
CREATE TABLE tb_operator
    (No 
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,Name
        VARCHAR(25)
        NOT NULL
    ,password
        VARBINARY(128)
        NOT NULL);
INSERT tb_operator
    (No,Name,Password)
    VALUES
    ('3150707035','��˼��',HASHBYTES('MD5','7035'))
    ,('3150707012','�',HASHBYTES('MD5','7012'))
    ,('3150707046','�޲�',HASHBYTES('MD5','7046'));
----���߱�
CREATE TABLE tb_patient
    ([No]
        CHAR(10)
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
    ,fistMan1
        VARCHAR(25)
    ,firstManTel1
        CHAR(15)
    ,fistMan2
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
----���￨��
CREATE TABLE tb_card
    (patientNo
        CHAR(10)
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
----�籣����
CREATE TABLE tb_socialCard
    (patientNo
        CHAR(10)
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
----���ұ�
CREATE TABLE tb_dept
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
----ҽ����
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
----�Һű�
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
        CHAR(10)
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
----��Ʊ��
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
        CHAR(10)
        NOT NULL
        FOREIGN KEY REFERENCES tb_patient(No)
    ,recDate
        date
        NOT NULL
    ,charge
        money
        NOT NULL
        DEFAULT '0.00');

----���ֱ�
CREATE TABLE tb_drgs
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL);
----�Ҵ��ǼǱ�
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
----�Ű��
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
        
        
        
        
                        
            