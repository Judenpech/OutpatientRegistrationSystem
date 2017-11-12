/*
����Һ�ϵͳ���ݿ�
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
		(NAME='Datafile'
		,FILENAME='E:\OPRSDataFile.mdf')
	LOG ON
		(NAME='Logfile'
		,FILENAME='E:\OPRSLogfile.ldf');
GO
USE OPRSBase;
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
        VARBINARY(160)
        NOT NULL);
INSERT tb_operator
    (No,Name,Password)
    VALUES
        ('3150707012','�',HASHBYTES('SHA','7012'))
        ,('1','test',HASHBYTES('SHA','1'));
----���߱�
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
    ,id --���֤��
        CHAR(18)
        UNIQUE
    ,visitNo --���￨��
        CHAR(15)
        UNIQUE
    ,regDate
        DATE
        NOT NULL
    ,allergyHistory
        VARCHAR(255)
    ,operationHistory
        VARCHAR(255));
INSERT dbo.tb_patient
        ( No ,
          Name ,
          age ,
          sex ,
          birthday ,
          nationality ,
          nation ,
          email ,
          tel ,
          Address ,
          firstMan1 ,
          firstManTel1 ,
          firstMan2 ,
          firstManTel2 ,
          id,
          visitNo,
          regDate ,
          allergyHistory ,
          operationHistory
        )
VALUES  ( '20171112102319' , -- No - char(15)
          '����' , -- Name - varchar(25)
          20 , -- age - int
          0 , -- sex - bit
          '1997-11-12 02:23:19' , -- birthday - date
          '�й�' , -- nationality - varchar(25)
          '��' , -- nation - varchar(15)
          'asd@f.com' , -- email - char(45)
          '18356438763' , -- tel - char(15)
          '����ʡ�������������Ͻ�������·1��' , -- Address - varchar(45)
          '��һ' , -- firstMan1 - varchar(25)
          '18276478345' , -- firstManTel1 - char(15)
          '�Ŷ�' , -- firstMan2 - varchar(25)
          '18297346592' , -- firstManTel2 - char(15)
          '365745199711126376' , -- id - char(18)
          '20171112001' , -- visitId - char(15)
          '2017-11-12 02:23:19' , -- regDate - date
          '��' , -- allergyHistory - varchar(255)
          '��'  -- operationHistory - varchar(255)
        )
----�����
CREATE TABLE tb_visit
    (patientNo
        CHAR(15)
        PRIMARY KEY
        FOREIGN KEY REFERENCES tb_patient(No)
    ,cardType
        BIT
        NOT NULL
    ,balance
        money
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

----���ֱ�
CREATE TABLE tb_drgs
    (NO
        CHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
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
        
        
        
        
                        
            