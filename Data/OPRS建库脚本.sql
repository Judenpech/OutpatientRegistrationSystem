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
		(NAME='OPRSDatafile'
		,FILENAME='E:\OPRSDataFile.mdf')
	LOG ON
		(NAME='OPRSLogfile'
		,FILENAME='E:\OPRSLogfile.ldf');
GO
USE OPRSBase;

--������

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
        VARBINARY(160)
        NOT NULL);
        
---����Ա��--�������Ա���ݣ�
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
    ,id      --���֤��
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
        
----���߱�--���뻼�����ݣ�
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
		  '1997-11-12' , -- birthday - date
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
		  '2017-11-12' , -- regDate - date
		  '��' , -- allergyHistory - varchar(255)
		  '��'),  -- operationHistory - varchar(255)
		  ( '20171116104903' , -- No - char(15)
		  '����' , -- Name - varchar(25)
		  21 , -- age - int
		  1 , -- sex - bit
		  '1996-11-12' , -- birthday - date
		  '�й�' , -- nationality - varchar(25)
		  '��' , -- nation - varchar(15)
		  'qwe@r.com' , -- email - char(45)
		  '18332359125' , -- tel - char(15)
		  '����ʡ�������������Ͻ�������·1��' , -- Address - varchar(45)
		  '��һ' , -- firstMan1 - varchar(25)
		  '18276489878' , -- firstManTel1 - char(15)
		  '���' , -- firstMan2 - varchar(25)
		  '18215234675' , -- firstManTel2 - char(15)
		  '432312199611124323' , -- id - char(18)
		  NULL , -- visitId - char(15)
		  '2017-11-16' , -- regDate - date
		  'â������' , -- allergyHistory - varchar(255)
		  '��')  -- operationHistory - varchar(255))
        
----����/ҽ�ƿ���
CREATE TABLE tb_card
    (patientNo
        CHAR(15)
        PRIMARY KEY
    ,cardType  -- 0(���￨)��1(�籣��)
        BIT
        NOT NULL
    ,id
		CHAR(18)
	,visitNo
		CHAR(15)
    ,creditLimit
		money
    ,balance
        money
        DEFAULT '0.00');
        
----����/ҽ�ƿ���--�������/ҽ�ƿ����ݣ�
INSERT dbo.tb_card
        ( patientNo ,
          cardType ,
          id ,
          visitNo ,
          creditLimit ,
          balance
        )
VALUES  ( '20171112102319' , -- patientNo - char(15)
          0 , -- cardType - bit
          NULL , -- id - char(18)
          '20171112001' , -- visitNo - char(15)
          100 , -- creditLimit - money
          300  -- balance - money
        ),
        ( '20171116104903' , -- patientNo - char(15)
          0 , -- cardType - bit
          '432312199611124323' , -- id - char(18)
          NULL , -- visitNo - char(15)
          50 , -- creditLimit - money
          200  -- balance - money
        );    
            
----���ü�¼��
 CREATE TABLE tb_expensesRecord
	(ticketNo
		CHAR(15)
		PRIMARY KEY
	,mediRecordNo
		CHAR(15)
	,patientNo
		CHAR(15)
	,id
		CHAR(18)
	,visitNo
		CHAR(15)
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
----���ü�¼��--������ü�¼���ݣ�
INSERT dbo.tb_expensesRecord
        ( ticketNo ,
          mediRecordNo ,
          patientNo ,
          id ,
          visitNo ,
          regNo ,
          docNo ,
          medicineFee ,
          examFee ,
          checkFee ,
          diagFee ,
          regFee ,
          payDate
        )
VALUES  ( '020171119001' , -- ticketNo - char(10)
          '120171119001' , -- mediRecordNo - char(15)
          '20171112102319' , -- patientNo - char(15)
          NULL , -- id - char(18)
          '20171112001' , -- visitNo - char(15)
          1 , -- regNo - int
          '0001' , -- docNo - varchar(10)
          45.5 , -- medicineFee - money
          140 , -- examFee - money
          12 , -- checkFee - money
          36 , -- diagFee - money
          28 , -- regFee - money
          NULL  -- payDate - datetime
        ); 
----���ұ�
CREATE TABLE tb_dept
    (NO
        INT
        IDENTITY(1,1)
        NOT NULL
        PRIMARY KEY
    ,NAME
        varchar(25)
        NOT NULL
    ,DSCP
        VARCHAR(455));
        
----���ұ�--����������ݣ�
INSERT dbo.tb_dept
		( NAME )
VALUES  ( '�ڿ�')
		,('���')
		,('������')
		,('����')
		,('�ۿ�')
		,('�����ʺ��')
		,('��ǻ��')
		,('Ƥ����')
		,('�������')
		,('�����')
		,('����ҽѧ��')
		,('ȫ��ҽ�ƿ�')
		,('ҽѧӰ���')
		,('��ҽ��')
		,('������');
        
----ҽ����
CREATE TABLE tb_doctor
    (No
        VARCHAR(10)
        NOT NULL
        PRIMARY KEY
    ,NAME
        VARCHAR(10)
        NOT NULL
    ,title
        varchar(25)
        NOT NULL
    ,deptNo
        INT
    ,specialty
        VARCHAR(455));
        
----ҽ����--����ҽ�����ݣ�
INSERT dbo.tb_doctor
	( No ,
	  NAME ,
	  title ,
	  deptNo ,
	  specialty
	)
VALUES  ( '0001' , '������' , '����ҽʦ' , '1' , '�ó���������Կ��ԡ��β���Ⱦ��COPD��֧�������š��ν�ˡ���Ĥ�׵Ⱥ����������μ���Ѫ������˥�ߵ�Σ��֢���ȣ����ȿ�չ�ΰ����Ӱ������ƵȾ�׼ҽ�ơ�'),
	( '0002' , '�ֽ�' , '����ҽʦ' , '1' , '���ڴ����ڿ��ٴ��������ó������ڿơ������ڿơ��ڷ��ڿơ���Ѫѹ���ȵ����Ρ�'),
	( '0003' , '������' , '����ҽʦ' , '2' , '�μӹ�������һֱ���¹ǿ��ٴ��������񣬻����˷ḻ��רҵ֪ʶ���ٴ�ҽ�ƾ��顣�ڴ��˹ǿơ��ؽ����������������ó��ؽڡ��������ˡ����������μ�ϥ�ؽھ���΢��������'),
	( '0004' , '���' , '������ҽʦ' , '2' , '���������ٴ�����20���꣬�����˷ḻ���ٴ����顣������ǻ����������������չ�˸�ǻ�������г����������޲�����Ƣ�г�����θ���������ֺ�֢�����ȡ�'),
	( '0005' , '����' , '������ҽʦ' , '3' , '���¸������ٴ�����20���꣬������ʵ�����ۻ����ͷḻ���ٴ����顣���꿪չ��ͽ����ת̥ͷ����ͷλ�Ѳ����ӹ�����ʽ��ϼ��ӹ���������֧�����������ʹ������еĴ��Ѫ��'),
	( '0006' , '������' , '����ҽʦ' , '3' , '�ó��¾�ʧ��������֢���ӹ��������ѳ����ס���ǻ���Լ������ӹ���Ĥ��λ֢��������ǻʹ��������ؼ�������������̥������ϸ�������ȣ������Ρ�'),
	( '0007' , '��ɽ' , '����ҽʦ' , '4' , '�Զ��Ƴ������෢���зḻ�ٴ����顣�ó�С����������������ͯ��֢����������񰡢���鲡�ȼ��������Ρ�'),
	( '0008' , '������' , '������ҽʦ' , '4' , '�ó���ͯ���������Կ��ԡ������Կ��Եȵ����Ρ��Զ���Σ��֢���������Ѳ��������нϷḻ���ٴ����顣'),
	( '0009' , '�º�Ų' , '������ҽʦ' , '5' , '�����ۿ��ٴ�����ѧ������30�꣬�ó������ϡ�����ۡ��۵ײ����۱����Լ����ⲻ�����ۿƼ��������Ρ�'),
	( '0010' , '����Զ' , '����ҽʦ' , '5' , '�����ۿ��ٴ�����ѧ�����й���20���꣬���н�ǿ���ۿ�רҵˮƽ���ó�����ۡ��۵ײ����۴��ˡ��۱��������Ρ�'),
	( '0011' , '����¥' , '����ҽʦ' , '6' , '��ҵ��һֱ���¶����ʺ��ٴ��������Զ෢��������Σ�ؼ��������μ����������˷ḻ�ľ��顣������չ�˶����ʺ�Ƹ�������������ڿ����±�ǻ������������ж��������������������ȡ�'),
	( '0012' , '�麣��' , '������ҽʦ' , '6' , '���¶����ʺ���ٴ�����20���꣬�Ա��Ƴ��������෢�������Ѳ��������зḻ�ٴ����顣�ڱ�Ӧ�Ա��׵��ۺ����ơ���΢����ơ����ھ������������Ա��ס���Ϣ�⡢����ס����и�ƫ��'),
	( '0013' , 'ׯ��Ң' , '������ҽʦ' , '7' , '�ó�����������������ȫ����ݡ����ݡ��̶����޸�������������̻�ǰ�������޸��Լ�������ݡ���Ͳ�ܡ���������޸���'),
	( '0014' , '�ź��' , '����ҽʦ' , '7' , '�ִ��¿�ǻ�����Ƽ���ǻ���ۺ����﹤�����ó����������޸�����ǻ��沿���������ټ��������Σ��ǹ����п���λ�ڹ̶�������������������̻�ǰ�������޸�����ֲ�����������ȡ�'),
	( '0015' , '¬����' , '����ҽʦ' , '8' , '���ƴ�״������ݡ������硢����Ǵ���Ƥ���ס�ӲƤ���ȼ�����'),
	( '0016' , '������' , '����ҽʦ' , '8' , '����Ƥ�ס�ʪ�ݡ���Ѣ���ࡢ�������ѷ�����м��������Ǵ���Ѫ���׵�Ƥ���Ƴ����������Ѳ������Σ����ܲ���÷��������ʪ����Բ������μ�Ƥ�����ݼ��ⷽ�����зḻ���ٴ����顣'),
	( '0017' , 'Ѧ����' , '������ҽʦ' , '9' , '���¸�Ⱦ��רҵ20���꣬�ٴ�����ḻ���ó���Ⱦ�Ƴ������Ͷ෢��������Ϻ����ƣ��Ը����ر��ǲ����Ժ����������Ը����ж��ؼ�������Ʋ��ԡ�'),
	( '0018' , '���Ľ�' , '����ҽʦ' , '9' , ''),
	( '0019' , '�½���' , '����ҽʦ' , '10' , '�ó�����ҽ�����������֢��ǿ��֢��ʧ��֢���������֢�ȸ��ྫ����������'),
	( '0020' , '��־��' , '����ҽʦ' , '10' , '�ó���ʧ��֢������֢��������ʹ������֢�����֢���������֢�ȵ����Ρ�'),
	( '0021' , '��ܿ' , '����ҽʦ' , '11' , '�ó���1��������ƶ�ͯ��̱���з�ָ��ڡ��������˻ָ��ڣ�2��������ƴ�״���������ʹ�������Թ�������֢��������ʹ����׵������׵����ͻ��֢�������Թǹؽڲ���3����ҩ���'),
	( '0022' , '��̩��' , '����ҽʦ' , '11' , '�ó���1�������С������ˡ��������˼������������ϰ��������뿵����2��ҽ����ϣ����������������ϣ���ϼ���Ĥ���������Ʒ��������Ἴ����չ��������ʹ���˶�������3��ͷʹ��ѣ�Ρ��з硢ʧ�ߡ���������ʹ���ȴ���θ���������ҵȳ��������෢�������Բ�����ҽ���μ��ǽ�������'),
	( '0023' , '����' , '����ҽʦ' , '12' , '�ó������Ƽ�Σ�ز�֢�������������Էμ��������Ĳ�����������Ĥ�ס���Ѫ�Ⱥ�����������ұ��'),
	( '0024' , '�¼�ɽ' , '����ҽʦ' , '12' , '�ó������������ڿƼ����겡���ڿ����Ѳ������μ���Σ��֢���ȡ�'),
	( '0025' , '���ƽ' , '������ҽʦ' , '13' , '�ó���1�������Ľ������ƣ�2��Ѫ�ܼ�����ǻ�����ƣ�Ѫ�ܳ�������֧������������3����������صĽ������ƣ��ӹ�����˨��������������˨���������Ѫ����4����������صĽ���'),
	( '0026' , '�ƾ���' , '������ҽʦ' , '13' , '�ó����׿�����ת������������'),
	( '0027' , '�ձ�ΰ' , '������ҽʦ' , '14' , '��ҽ20���꣬������ҽ��������θ�ס����������񡢸β������з����֢�ȼ��������зḻ���ٴ����顣�ó���������ҽ��ϵķ�����������ϵͳ������ϵͳ������'),
	( '0028' , '������' , '����ҽʦ' , '14' , '�ó�����ҽ�ڿƼ������������Բ���֢�����������󼰷š����ƺ���ҽҩ����Ƣθ������˯���ϰ����ູ���ǽ�������ȡ�'),
	( '0029' , 'Ѧ����' , '������ҽʦ' , '15' , '�ó�����ǰ���估�����������������Σ�θ�����󳦰����ΰ���ʳ�ܰ����ΰ������ٰ��ȣ����������������������ƣ�����ɸ����ѯ��'),
	( '0030' , '��ӳ��' , '����ҽʦ' , '15' , '�ó����ΰ������ٰ��������ܰ�����θ�����󳦰������ʰ��ȶ����������ڿ����ơ�');
        
----ԤԼ�Һű�
CREATE TABLE tb_registration
    (NO
        INT
        IDENTITY(1,1)
        NOT NULL
        PRIMARY KEY
    ,patientNo
        CHAR(15)
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
----ԤԼ�Һű�--����ԤԼ�Һ�����;
INSERT dbo.tb_registration
		( patientNo ,
		  deptNo ,
		  docNo ,
		  regDate ,
		  regTime ,
		  operater
		)
SELECT '20171112102319',d2.NO,d1.No,'2017-11-12','08:23:19','3150707012'
FROM 
	dbo.tb_doctor d1 
	JOIN dbo.tb_dept d2 ON d1.deptNo = d2.NO 
WHERE d1.NAME='������' AND d2.NAME='�ڿ�';    
    
----�Һ�����
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
        
----�Һ�����--����Һ�������ݣ�
INSERT dbo.tb_regType
		( NAME, price )
VALUES  ('��ͨ����',13)
	   ,('ר������',28);
       
----ҽ�����۱�
CREATE TABLE tb_docScore
    (id
        INT
        NOT NULL
        IDENTITY(1,1)
        PRIMARY KEY
    ,patientNo
        CHAR(15)
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
        
----ҽ�����۱�--�����������ݣ�
INSERT dbo.tb_docScore
        ( patientNo ,
          docNo ,
          score ,
          comments ,
          comDate
        )
VALUES  ( '20171112102319' , -- patientNo - char(15)
          '0001' , -- docNo - varchar(10)
          '��' , -- score - varchar(10)
          '��' , -- comments - varchar(455)
          '2017-11-16 06:40:12'  -- comDate - date
        );               
       
----��Ʊ��
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
        INT
        NOT NULL
        FOREIGN KEY REFERENCES tb_dept(No)
    ,docNo
        VARCHAR(10)
        NOT NULL
        UNIQUE
        FOREIGN KEY REFERENCES tb_doctor(No)
    ,num
        int
        NOT NULL
    ,numLeft
        int
        NOT NULL);
        
        
        
        
                        
            