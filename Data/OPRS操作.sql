/*
����Һ�ϵͳ���ݿ�SQL����
*/
USE OPRSBase;


--��¼��
SELECT *
FROM dbo.tb_operator
WHERE No='1' AND password=HASHBYTES('SHA','1');




--����Ա����;
			--����Ա����--��������Ա��
			INSERT tb_operator
				(No,Name,Password)
				VALUES('1','test',HASHBYTES('SHA','1'));
			    
			--����Ա����--�޸Ĳ���Ա���룻
			UPDATE dbo.tb_operator
			SET password=HASHBYTES('SHA','2')
			WHERE No='1';
    
    
    
    
    
--���ߵǼ�;
			--���ߵǼ�--��ѯ���л�����Ϣ��
			SELECT * 
			FROM dbo.tb_patient;

			--���ߵǼ�--���ݻ���������ѯ��
			SELECT *
			FROM dbo.tb_patient
			WHERE Name='����';

			--���ߵǼ�--���ݻ������֤�Ų�ѯ��
			SELECT *
			FROM dbo.tb_patient
			WHERE id='365745199711126376';

			--���ߵǼ�--���ݻ��߱�Ų�ѯ��
			SELECT *
			FROM dbo.tb_patient
			WHERE No='20171112030327';

			--���ߵǼ�--�������ߣ�
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

			--���ߵǼ�--�޸Ļ���;
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
  
  
  
  
    
--����ԤԼ/�Һţ�
				--����ԤԼ--����ҽ����Ϣ��
				SELECT NAME
				FROM dbo.tb_doctor;

				--����ԤԼ--���ؿ������ƣ�
				SELECT NAME ��������
				FROM dbo.tb_dept;

				--����ԤԼ--���غű�
				SELECT NAME,price
				FROM dbo.tb_regType;

				--����ԤԼ--���ز��ˣ�
				SELECT Name
				FROM dbo.tb_patient;

				--����ԤԼ--���ݲ���������ѯ����������Ϣ��
				SELECT *
				FROM dbo.tb_patient
				WHERE Name='����';

				--����ԤԼ--���ݺű��ѯ�Һż۸�
				SELECT price
				FROM dbo.tb_regType
				WHERE NAME='��ͨ����';

				--����ԤԼ--����ҽ����ѯ���ң�
				SELECT d1.name 
				FROM tb_dept d1,tb_doctor d2 
				WHERE d2.NAME='������' AND d2.deptNo=d1.NO;

				--����ԤԼ--���ݿ��Ҳ�ѯҽ����
				SELECT d2.NAME
				FROM dbo.tb_dept d1
				JOIN dbo.tb_doctor  d2 ON d1.NO=d2.deptNo
				WHERE d1.NAME='�ڿ�';

				--����ԤԼ--��ѯ���п��ң�
				SELECT NO ���ұ��,NAME ��������,DSCP ��������
				FROM dbo.tb_dept;

				--����ԤԼ--��ѯ����ԤԼ��
				SELECT *
				FROM dbo.tb_registration;

				--����ԤԼ--����ԤԼ;
				INSERT dbo.tb_registration
						( patientNo ,
						  deptNo ,
						  docNo ,
						  regDate ,
						  regTime ,
						  operater
						)
				SELECT '20171112102319',d2.NO,d1.No,'2017-11-12 02:23:19','2017-11-12 02:23:19','3150707012'
				FROM 
					dbo.tb_doctor d1 
					JOIN dbo.tb_dept d2 ON d1.deptNo = d2.NO 
				WHERE d1.NAME='������' AND d2.NAME='�ڿ�';

				--����ԤԼ--��ʾԤԼ;
				SELECT r.NO ԤԼ��,r.patientNo ���߱��,p.Name ��������,d1.NAME ԤԼ����,d2.NAME ԤԼҽ��, r.regDate ԤԼ����,r.regTime ԤԼʱ��
				FROM dbo.tb_registration r
					 JOIN dbo.tb_patient p ON r.patientNo = p.No
					 ,dbo.tb_dept d1 
					 JOIN dbo.tb_doctor d2 ON d1.NO = d2.deptNo
				WHERE r.patientNo=p.No AND r.docNo=d2.No AND r.done=0
				ORDER BY r.NO,r.regDate,r.regTime;




--���ҹ���
			--���ҹ���--ɾ������; 
			DELETE FROM dbo.tb_dept
			WHERE NAME='������';

			--���ҹ���--�������ң�
			INSERT dbo.tb_dept
					( NAME,DSCP )
			VALUES  ( '��������','����' );

			--���ҹ���--�޸Ŀ��ң�
			UPDATE dbo.tb_dept 
			SET NAME='���¿���',dscp='���¿�������'
			WHERE NO=16;



--�Һ����ã�
			--�Һ�����--��ѯ�ű�
			SELECT id ���,NAME �Һ�����,price �۸�
			FROM dbo.tb_regType;

			--�Һ�����--ɾ���ű�
			DELETE FROM dbo.tb_regType
			WHERE id=3;

			--�Һ�����--���Ӻű�
			INSERT dbo.tb_regType
					( NAME, price )
			VALUES  ( 'test', -- NAME - char(45)
					  100  -- price - money
					  );
			--�Һ�����--�޸ĺű�
			UPDATE dbo.tb_regType
			SET NAME='�޸Ĳ���',price=100
			WHERE id=4;




--ҽ������
			--ҽ������--��ѯ����ҽ����Ϣ��
			SELECT d1.No ����,d1.NAME ����,d1.title ְ��,d2.NAME ��������,d1.specialty �ó�
			FROM dbo.tb_doctor d1,dbo.tb_dept d2
			WHERE d1.deptNo=d2.NO;

			--ҽ������--����ҽ����
			INSERT dbo.tb_doctor
					( No, NAME, title, deptNo, specialty )
			SELECT '0031','����ҽ��','ʵϰ��',d.NO,'�ó�'
			FROM dbo.tb_dept d
			WHERE d.NAME='��ҽ��';

			--ҽ������--�޸�ҽ����
			UPDATE dbo.tb_doctor
			SET No='0032',NAME='�޸�ҽ��',title='ʵϰ��',specialty='�޸��ó�',deptNo=
			    (SELECT deptNo 
			    FROM dbo.tb_dept 
			    WHERE NAME='��ҽ��')
			WHERE No='0031';

			--ҽ������--ɾ��ҽ����
			DELETE FROM dbo.tb_doctor
			WHERE No='0031';



--���۹���
			--���۹���--��ѯ����������Ϣ��
			SELECT *
			FROM dbo.tb_docScore;

			--���۹���--��ʾ����������Ϣ��
			SELECT d.id ���,p.Name ��������,d1.NAME ҽ��,d.comments ��������,d.score �ȼ�,d.comDate ��������
			FROM tb_docScore d
			JOIN dbo.tb_patient p ON p.No=d.patientNo
			JOIN dbo.tb_doctor d1 ON d.docNo=d1.No
			ORDER BY d.id;

			--���۹���--ɾ��������Ϣ��
			DELETE dbo.tb_docScore
			WHERE id=1;

			--���۹���--�޸�������Ϣ��
			UPDATE dbo.tb_docScore
			SET comments='�޸�����',score='��',comDate='2017-11-16'
			WHERE id=1;

