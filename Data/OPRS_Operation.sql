/*
����Һ�ϵͳ���ݿ�--SQL����
*/
USE OPRSBase;


--ϵͳ��¼��
			--ϵͳ��¼--��ѯ�û��Ƿ���ڣ�
			SELECT COUNT(1)
			FROM dbo.tb_operator
			WHERE No='2' AND password IS NULL;

			--ϵͳ��¼--�˶��û��������룻
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
					  '2017-11-13' , -- birthday - date
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
					  '2017-11-13' , -- regDate - date
					  '' , -- allergyHistory - varchar(255)
					  ''  -- operationHistory - varchar(255)
					)

			--���ߵǼ�--�޸Ļ���;
			UPDATE dbo.tb_patient
				SET Name='123',
					age=0,
					sex=0,
					birthday='2017-11-11',
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
					regDate='2017-11-11',
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
			SELECT no ���߱��,Name ����
			FROM dbo.tb_patient;

			--����ԤԼ--���ݻ��߱�Ų�ѯ����������Ϣ��
			SELECT visitNo,id,tel,CASE WHEN visitNo IS NULL THEN '�籣��' ELSE '���￨' END ������ 
			FROM dbo.tb_patient
			WHERE No='20171116104903';

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
			SELECT '20171112102319',d2.NO,d1.No,'2017-11-12','08:23:19','3150707012'
			FROM 
				dbo.tb_doctor d1 
				JOIN dbo.tb_dept d2 ON d1.deptNo = d2.NO 
			WHERE d1.NAME='������' AND d2.NAME='�ڿ�';

			--����ԤԼ--��ʾԤԼ;
			SELECT r.NO ԤԼ��,r.patientNo ���߱��,p.Name ��������,d1.NAME ԤԼ����,d2.NAME ԤԼҽ��, r.regDate ԤԼ����,CONVERT(VARCHAR(5),r.regTime,114) ԤԼʱ��
			FROM dbo.tb_registration r
				 JOIN dbo.tb_patient p ON r.patientNo = p.No
				 ,dbo.tb_dept d1 
				 JOIN dbo.tb_doctor d2 ON d1.NO = d2.deptNo
			WHERE r.patientNo=p.No AND r.docNo=d2.No AND r.done=0
			ORDER BY r.NO,r.regDate,r.regTime;

			--����ԤԼ--ɾ��ԤԼ;
			DELETE FROM dbo.tb_registration
			WHERE NO=1;




--�������ã�
			--���ҹ���--��ѯ���п���;
			SELECT NO ���ұ��,NAME ��������,pinyin ƴ����,DSCP �������� 
			FROM tb_dept; 

			--���ҹ���--ɾ������; 
			DELETE FROM dbo.tb_dept
			WHERE NO='1';

			--���ҹ���--�������ң�
			INSERT dbo.tb_dept
					( NO,NAME,pinyin,DSCP )
			VALUES  ( '16','��������','','����' );

			--���ҹ���--�޸Ŀ��ң�
			UPDATE dbo.tb_dept 
			SET NO='17',NAME='���¿���',pinyin='',dscp='���¿�������'
			WHERE NO='16';

			--���ҹ���--��������Excel���ݣ�
			SELECT NO ���ұ��,NAME ��������,pinyin ƴ����,DSCP �������� 
			FROM tb_dept

			--���ҹ���--��ѯ���п�������;
			SELECT COUNT(no) �ϼ�
			FROM dbo.tb_dept;


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




--ҽ�����ã�
			--ҽ������--��ѯ����ҽ����Ϣ��
			SELECT d1.No ����,d1.NAME ����,d1.pinyin ƴ����,d1.title ְ��,d2.NAME ��������,d1.specialty �ó�
			FROM dbo.tb_doctor d1,dbo.tb_dept d2
			WHERE d1.deptNo=d2.NO AND d2.Name='�ڿ�';

			--ҽ������--����ҽ����
			INSERT dbo.tb_doctor
					( No, NAME, pinyin, title, deptNo, specialty )
			SELECT '0031','����ҽ��','pym','ʵϰ��',d.NO,'�ó�'
			FROM dbo.tb_dept d
			WHERE d.NAME='�ڿ�';

			--ҽ������--�޸�ҽ����
			UPDATE dbo.tb_doctor
			SET No='0032',NAME='�޸�ҽ��',pinyin='pym',title='ʵϰ��',specialty='�޸��ó�',deptNo=
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
			WHERE id='1';
			
			
			
--ҽ����ѯ��
			--ҽ����ѯ--��ѯ����ҽ��������
			SELECT NAME
			FROM dbo.tb_doctor;

			--ҽ����ѯ--��ѯ���п������ƣ�
			SELECT NAME
			FROM dbo.tb_dept;

			--ҽ����ѯ--��ѯָ��������ҽ����Ϣ��
			SELECT d1.No no,d1.NAME name ,d1.title title,d2.NAME dept,d1.specialty specialty
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.NAME='������' AND d1.deptNo=d2.NO;

			--ҽ����ѯ--��ѯָ�����ҵ�����ҽ����Ϣ��
			SELECT d1.No ҽ������,d1.NAME ���� ,d1.title ְ��,d2.NAME ��������,d1.specialty �ó�
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.title='�ڿ�' AND d1.deptNo=d2.NO;

			--ҽ����ѯ--��ѯָ��ְ�Ƶ�����ҽ����Ϣ��
			SELECT d1.No ҽ������,d1.NAME ���� ,d1.title ְ��,d2.NAME ��������,d1.specialty �ó�
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.title='����ҽʦ' AND d1.deptNo=d2.NO;

			--ҽ����ѯ--���ݹ��Ų�ѯҽ����Ϣ��
			SELECT d1.No ҽ������,d1.NAME ���� ,d1.title ְ��,d2.NAME ��������,d1.specialty �ó�
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.No='0001' AND d1.deptNo=d2.NO;



--ǰ̨�ɷѣ�

			--ǰ̨�ɷ�--��ѯ���ü�¼��Ϣ��
			SELECT *
			FROM dbo.tb_expensesRecord;

			--ǰ̨�ɷ�--��ѯ����δ���Ѳ��ˣ�
			SELECT e.ticketNo Ʊ��,e.regNo �Һź���,e.patientNo ���߱��,p.Name ��������,d1.NAME �������,d.NAME ����ҽ��,r.regDate ��������
			FROM dbo.tb_expensesRecord e 
				JOIN dbo.tb_patient p ON e.patientNo=p.No
				JOIN dbo.tb_doctor d ON e.docNo=d.No 
				JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO
				JOIN dbo.tb_registration r ON e.regNo=r.NO
			WHERE e.havePaid=0 AND r.regDate='2017-11-12';

			--ǰ̨�ɷ�--��ѯ����δ���Ѳ��ˣ�
			SELECT e.ticketNo Ʊ��,e.regNo �Һź���,e.patientNo ���߱��,p.Name ��������,d1.NAME �������,d.NAME ����ҽ��,r.regDate ��������
			FROM dbo.tb_expensesRecord e 
				JOIN dbo.tb_patient p ON e.patientNo=p.No
				JOIN dbo.tb_doctor d ON e.docNo=d.No 
				JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO
				JOIN dbo.tb_registration r ON e.regNo=r.NO
			WHERE e.havePaid=0;

			--ǰ̨�ɷ�--����Ʊ�Ų�ѯ���ü�¼��Ϣ��
			SELECT e.medicineFee ҩƷ��,e.examFee �����,e.checkFee ����,e.diagFee ���Ʒ�,e.regFee �Һŷ�
			FROM dbo.tb_expensesRecord e 
			WHERE e.ticketNo='020171119001';

			--ǰ̨�ɷ�--���ݻ��߱�Ų�ѯ����/ҽ�ƿ���Ϣ��
			SELECT cardType,id,visitNo,balance,creditLimit
			FROM dbo.tb_card
			WHERE patientNo='20171112102319';

			--ǰ̨�ɷ�--���·��ü�¼֧��״̬��
			UPDATE dbo.tb_expensesRecord 
			SET havePaid=1,payDate='2017-11-20'
			WHERE ticketNo='020171119001';

			--ǰ̨�ɷ�--���¾���/ҽ�ƿ���
			UPDATE dbo.tb_card
			SET balance=200
			WHERE patientNo='20171112102319';
			
			--ǰ̨�ɷ�--���÷��ü�¼֧��״̬��
			UPDATE dbo.tb_expensesRecord 
			SET havePaid=0
			WHERE ticketNo='020171119001';

			--ǰ̨�ɷ�--���þ���/ҽ�ƿ���
			UPDATE dbo.tb_card
			SET balance=200
			WHERE patientNo='20171112102319';


--Ƿ�Ѵ߿
			--Ƿ�Ѵ߿�--��ѯ����Ƿ������Ϣ��
			SELECT c.patientNo ���߱��,p.Name ��������,CASE c.cardType WHEN 0 THEN '���￨' WHEN 1 THEN '�籣��' END ������,c.id ���֤����,c.visitNo ���￨��,c.balance Ƿ���ܼ�
			FROM dbo.tb_card c JOIN dbo.tb_patient p ON c.patientNo=p.No
			WHERE c.patientNo=p.No AND c.balance<0;

			SELECT tel,email
			FROM dbo.tb_patient
			WHERE No='20171116104903';

			--Ƿ�Ѵ߿�--����Ƿ����Ϣ��
			UPDATE dbo.tb_card
			SET balance=-100
			WHERE patientNo='20171116104903';
			
			
--���￨��ֵ��
			--���￨��ֵ--��ѯ���о��￨���ˣ�
			SELECT Name
			FROM dbo.tb_patient
			WHERE visitNo IS NOT NULL;

			--���￨��ֵ--���ݾ��￨�Ų�ѯ���˾��￨��Ϣ��
			SELECT p.No ���߱��,p.Name ��������,p.visitNo ���￨��,c.balance ���
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo
			WHERE p.visitNo='20171112001';

			--���￨��ֵ--���ݻ��߱�Ų�ѯ���˾��￨��Ϣ��
			SELECT p.No ���߱��,p.Name ��������,p.visitNo ���￨��,c.balance ���
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo
			WHERE p.No='20171112102319' AND p.visitNo IS NOT NULL;

			--���￨��ֵ--���ݻ���������ѯ���˾��￨��Ϣ��
			SELECT p.No ���߱��,p.Name ��������,p.visitNo ���￨��,c.balance ���
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo
			WHERE p.Name='����' AND p.visitNo IS NOT NULL;

			--���￨��ֵ--������
			UPDATE dbo.tb_card
			SET balance=100
			WHERE patientNo='20171112102319';
			
			
--���Ҳ�ѯ��
			--���Ҳ�ѯ--��ѯ���п������ƣ�
			SELECT NAME
			FROM dbo.tb_dept;

			--���Ҳ�ѯ--���ݿ������Ʋ�ѯ������Ϣ��
			SELECT NO,NAME,DSCP
			FROM dbo.tb_dept
			WHERE NAME='�ڿ�';

			--���Ҳ�ѯ--���ݿ��ұ�Ų�ѯ������Ϣ��
			SELECT NO,NAME,DSCP
			FROM dbo.tb_dept
			WHERE NO=1;
			
			
--���￨����ѯ��
			--���￨����ѯ--��ѯ���о��￨���ˣ�
			SELECT p.No ���߱��,p.Name ��������,c.visitNo ���￨��,c.balance ���
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo AND p.visitNo=c.visitNo
			WHERE c.cardType=0;

			--���￨����ѯ--���ݾ��￨�Ų�ѯ���˾��￨��Ϣ��
			SELECT COUNT(1)
			FROM dbo.tb_card c
			WHERE c.visitNo='20171112001';

			--���￨����ѯ--���ݻ��߱�Ų�ѯ���˾��￨��Ϣ��
			SELECT COUNT(1)
			FROM dbo.tb_card c 
			WHERE c.patientNo='20171112102319' AND c.cardType=0;

			--���￨����ѯ--���ݻ���������ѯ���˾��￨��Ϣ��
			SELECT COUNT(1)
			FROM dbo.tb_card c JOIN dbo.tb_patient p ON p.No=c.patientNo AND p.visitNo=c.visitNo
			WHERE p.Name='����';
			
			
			
--ϵͳ��ʼ��--ϵͳ�ؽ���
			--ϵͳ��ʼ��--ϵͳ�ؽ�--���ҵ�����ݣ�
			DELETE FROM dbo.tb_expensesRecord;
			DELETE FROM dbo.tb_registration;
			DELETE FROM dbo.tb_docScore;
			DELETE FROM dbo.tb_receipt;

			--ϵͳ��ʼ��--ϵͳ�ؽ�--��ջ������ϣ�
			DELETE FROM dbo.tb_patient;
			DELETE FROM dbo.tb_card;
			DELETE FROM dbo.tb_dept;
			DELETE FROM dbo.tb_doctor;
			DELETE FROM dbo.tb_regType;

			--ϵͳ��ʼ��--ҽԺע�᣻
			SELECT name,ADDRESS
			FROM tb_hospital
			WHERE signUpCode='3150707012';

			UPDATE tb_hospital
			SET NAME='123',ADDRESS='123'
			WHERE signUpCode='3150707012';
