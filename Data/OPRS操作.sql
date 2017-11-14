/*
����Һ�ϵͳ���ݿ����
*/
USE OPRSBase;

----��ѯ���в�����Ϣ��
SELECT * 
FROM dbo.tb_patient;

----���ݲ���������ѯ��
SELECT *
FROM dbo.tb_patient
WHERE Name='����';

----���ݲ������֤�Ų�ѯ��
SELECT *
FROM dbo.tb_patient
WHERE id='365745199711126376';

----���ݲ��˱�Ų�ѯ��
SELECT *
FROM dbo.tb_patient
WHERE No='20171112030327';

----�������Ա��
INSERT tb_operator
    (No,Name,Password)
    VALUES('1','test',HASHBYTES('SHA','1'));

----��Ӳ��ˣ�
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
          id ,
          visitNo ,
          regDate ,
          allergyHistory ,
          operationHistory
        )
VALUES  ( '' , -- No - char(15)
          '' , -- Name - varchar(25)
          0 , -- age - int
          NULL , -- sex - bit
          '2017-11-13 02:51:47' , -- birthday - date
          '' , -- nationality - varchar(25)
          '' , -- nation - varchar(15)
          '' , -- email - char(45)
          '' , -- tel - char(15)
          '' , -- Address - varchar(45)
          '' , -- firstMan1 - varchar(25)
          '' , -- firstManTel1 - char(15)
          '' , -- firstMan2 - varchar(25)
          '' , -- firstManTel2 - char(15)
          '' , -- id - char(18)
          '' , -- visitNo - char(15)
          '2017-11-13 02:51:47' , -- regDate - date
          '' , -- allergyHistory - varchar(255)
          ''  -- operationHistory - varchar(255)
        )

----�޸Ĳ���;
UPDATE dbo.tb_patient
    SET Name='123',
        age=0,
        sex=0,
        birthday='2017-11-11 14:50:07',
        nationality='',
        nation='',
        email='',
        tel='123',
        Address='',
        firstMan1='',
        firstManTel1='',
        firstMan2='',
        firstManTel2='',
        id='',
        visitNo='',
        regDate='2017-11-11 14:50:07',
        allergyHistory='',
        operationHistory=''
    WHERE No='20171112104748';
    
----���ԤԼ;
INSERT dbo.tb_registration
        ( patientNo ,
          deptNo ,
          docNo ,
          regDate ,
          regTime ,
          operater
        )
SELECT '20171112102319',d2.NO,d1.No,'2017-11-12 02:23:19','2017-11-12 02:23:19','3150707012'
FROM dbo.tb_doctor d1,dbo.tb_dept d2
WHERE d1.NAME='������' AND d2.NAME='�ڿ�';

----��ѯ����ԤԼ��
SELECT *
FROM dbo.tb_registration;

----��ʾԤԼ;
SELECT r.NO ԤԼ��,r.patientNo ���߱��,p.Name ��������,d1.NAME ԤԼ����,d2.NAME ԤԼҽ��, r.regDate ԤԼ����,r.regTime ԤԼʱ��
FROM dbo.tb_registration r,dbo.tb_patient p, dbo.tb_dept d1, dbo.tb_doctor d2
WHERE r.docNo=d2.No AND r.deptNo=d1.NO AND r.patientNo=p.No AND r.regDate='2017-11-12'
ORDER BY r.NO,r.regDate,r.regTime;

----����ҽ����ѯ���ң�
SELECT d1.name FROM tb_dept d1,tb_doctor d2 WHERE d2.NAME='������' AND d2.deptNo=d1.NO;

----��ѯ���п��ң�
SELECT NO ���ұ��,NAME ��������,DSCP ��������
FROM dbo.tb_dept;

----ɾ��ָ������; --���Լ����
DELETE FROM dbo.tb_dept
WHERE NAME='���Կ�';

----���ӿ��ң�
INSERT dbo.tb_dept
        ( NAME,DSCP )
VALUES  ( '��������','����' );

----���¿��ң�
UPDATE dbo.tb_dept 
SET NAME='���¿���',dscp='���¿�������'
WHERE NO=16;

----��ѯ�ű�
SELECT id ���,NAME �Һ�����,price �۸�
FROM dbo.tb_regType;

----ɾ���ű�
DELETE FROM dbo.tb_regType
WHERE id=3;

----���Ӻű�
INSERT dbo.tb_regType
        ( NAME, price )
VALUES  ( 'test', -- NAME - char(45)
          100  -- price - money
          );
----�޸ĺű�
UPDATE dbo.tb_regType
SET NAME='�޸Ĳ���',price=100
WHERE id=4;