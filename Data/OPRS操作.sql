/*
门诊挂号系统数据库--SQL操作
*/
USE OPRSBase;


--系统登录；
			--系统登录--查询用户是否存在；
			SELECT COUNT(1)
			FROM dbo.tb_operator
			WHERE No='2' AND password IS NULL;

			--系统登录--核对用户名和密码；
			SELECT *
			FROM dbo.tb_operator
			WHERE No='1' AND password=HASHBYTES('SHA','1');




--操作员设置;
			--操作员设置--新增操作员；
			INSERT tb_operator
				(No,Name,Password)
				VALUES('1','test',HASHBYTES('SHA','1'));
			    
			--操作员设置--修改操作员密码；
			UPDATE dbo.tb_operator
			SET password=HASHBYTES('SHA','2')
			WHERE No='1';
    
    
    
    
    
--患者登记;
			--患者登记--查询所有患者信息；
			SELECT * 
			FROM dbo.tb_patient;

			--患者登记--根据患者姓名查询；
			SELECT *
			FROM dbo.tb_patient
			WHERE Name='张三';

			--患者登记--根据患者身份证号查询；
			SELECT *
			FROM dbo.tb_patient
			WHERE id='365745199711126376';

			--患者登记--根据患者编号查询；
			SELECT *
			FROM dbo.tb_patient
			WHERE No='20171112030327';

			--患者登记--新增患者；
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

			--患者登记--修改患者;
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
  
  
  
  
    
--患者预约/挂号；
				--患者预约--加载医生信息；
				SELECT NAME
				FROM dbo.tb_doctor;

				--患者预约--加载科室名称；
				SELECT NAME 科室名称
				FROM dbo.tb_dept;

				--患者预约--加载号别；
				SELECT NAME,price
				FROM dbo.tb_regType;

				--患者预约--加载病人；
				SELECT Name
				FROM dbo.tb_patient;

				--患者预约--根据病人姓名查询病人其他信息；
				SELECT *
				FROM dbo.tb_patient
				WHERE Name='张三';

				--患者预约--根据号别查询挂号价格；
				SELECT price
				FROM dbo.tb_regType
				WHERE NAME='普通门诊';

				--患者预约--根据医生查询科室；
				SELECT d1.name 
				FROM tb_dept d1,tb_doctor d2 
				WHERE d2.NAME='邹良能' AND d2.deptNo=d1.NO;

				--患者预约--根据科室查询医生；
				SELECT d2.NAME
				FROM dbo.tb_dept d1
				JOIN dbo.tb_doctor  d2 ON d1.NO=d2.deptNo
				WHERE d1.NAME='内科';

				--患者预约--查询所有科室；
				SELECT NO 科室编号,NAME 科室名称,DSCP 科室描述
				FROM dbo.tb_dept;

				--患者预约--查询所有预约；
				SELECT *
				FROM dbo.tb_registration;

				--患者预约--新增预约;
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
				WHERE d1.NAME='邹良能' AND d2.NAME='内科';

				--患者预约--显示预约;
				SELECT r.NO 预约号,r.patientNo 患者编号,p.Name 患者姓名,d1.NAME 预约科室,d2.NAME 预约医生, r.regDate 预约日期,CONVERT(VARCHAR(5),r.regTime,114) 预约时间
				FROM dbo.tb_registration r
					 JOIN dbo.tb_patient p ON r.patientNo = p.No
					 ,dbo.tb_dept d1 
					 JOIN dbo.tb_doctor d2 ON d1.NO = d2.deptNo
				WHERE r.patientNo=p.No AND r.docNo=d2.No AND r.done=0
				ORDER BY r.NO,r.regDate,r.regTime;
				
				--患者预约--删除预约;
				DELETE FROM dbo.tb_registration
				WHERE NO=1;




--科室设置；
			--科室管理--查询所有科室;
			SELECT NO 科室编号,NAME 科室名称,pinyin 拼音码,DSCP 科室描述 
			FROM tb_dept; 

			--科室管理--删除科室; 
			DELETE FROM dbo.tb_dept
			WHERE NO='1';

			--科室管理--新增科室；
			INSERT dbo.tb_dept
					( NO,NAME,pinyin,DSCP )
			VALUES  ( '16','新增科室','','描述' );

			--科室管理--修改科室；
			UPDATE dbo.tb_dept 
			SET NO='17',NAME='更新科室',pinyin='',dscp='更新科室描述'
			WHERE NO='16';

			--科室管理--导出科室Excel数据；
			SELECT NO 科室编号,NAME 科室名称,pinyin 拼音码,DSCP 科室描述 
			FROM tb_dept

			--科室管理--查询所有科室数量;
			SELECT COUNT(no) 合计
			FROM dbo.tb_dept;


--挂号设置；
			--挂号设置--查询号别；
			SELECT id 编号,NAME 挂号名称,price 价格
			FROM dbo.tb_regType;

			--挂号设置--删除号别；
			DELETE FROM dbo.tb_regType
			WHERE id=3;

			--挂号设置--增加号别；
			INSERT dbo.tb_regType
					( NAME, price )
			VALUES  ( 'test', -- NAME - char(45)
					  100  -- price - money
					  );
			--挂号设置--修改号别；
			UPDATE dbo.tb_regType
			SET NAME='修改测试',price=100
			WHERE id=4;




--医生设置；
			--医生管理--查询所有医生信息；
			SELECT d1.No 工号,d1.NAME 姓名,d1.pinyin 拼音码,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长
			FROM dbo.tb_doctor d1,dbo.tb_dept d2
			WHERE d1.deptNo=d2.NO AND d2.Name='内科';

			--医生管理--新增医生；
			INSERT dbo.tb_doctor
					( No, NAME, pinyin, title, deptNo, specialty )
			SELECT '0031','新增医生','pym','实习生',d.NO,'擅长'
			FROM dbo.tb_dept d
			WHERE d.NAME='内科';

			--医生管理--修改医生；
			UPDATE dbo.tb_doctor
			SET No='0032',NAME='修改医生',pinyin='pym',title='实习生',specialty='修改擅长',deptNo=
				(SELECT deptNo 
				FROM dbo.tb_dept 
				WHERE NAME='中医科')
			WHERE No='0031';

			--医生管理--删除医生；
			DELETE FROM dbo.tb_doctor
			WHERE No='0031';



--评价管理；
			--评价管理--查询所有评价信息；
			SELECT *
			FROM dbo.tb_docScore;

			--评价管理--显示所有评价信息；
			SELECT d.id 编号,p.Name 病人姓名,d1.NAME 医生,d.comments 评价内容,d.score 等级,d.comDate 评价日期
			FROM tb_docScore d
			JOIN dbo.tb_patient p ON p.No=d.patientNo
			JOIN dbo.tb_doctor d1 ON d.docNo=d1.No
			ORDER BY d.id;

			--评价管理--删除评价信息；
			DELETE dbo.tb_docScore
			WHERE id=1;

			--评价管理--修改评价信息；
			UPDATE dbo.tb_docScore
			SET comments='修改评价',score='好',comDate='2017-11-16'
			WHERE id='1';
			
			
			
--医生查询；
			--医生查询--查询所有医生姓名；
			SELECT NAME
			FROM dbo.tb_doctor;

			--医生查询--查询所有科室名称；
			SELECT NAME
			FROM dbo.tb_dept;

			--医生查询--查询指定姓名的医生信息；
			SELECT d1.No no,d1.NAME name ,d1.title title,d2.NAME dept,d1.specialty specialty
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.NAME='邹良能' AND d1.deptNo=d2.NO;

			--医生查询--查询指定科室的所有医生信息；
			SELECT d1.No 医生工号,d1.NAME 姓名 ,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.title='内科' AND d1.deptNo=d2.NO;

			--医生查询--查询指定职称的所有医生信息；
			SELECT d1.No 医生工号,d1.NAME 姓名 ,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.title='主任医师' AND d1.deptNo=d2.NO;

			--医生查询--根据工号查询医生信息；
			SELECT d1.No 医生工号,d1.NAME 姓名 ,d1.title 职称,d2.NAME 所属科室,d1.specialty 擅长
			FROM dbo.tb_doctor d1 JOIN dbo.tb_dept d2 ON d1.deptNo=d2.NO
			WHERE d1.No='0001' AND d1.deptNo=d2.NO;



--前台缴费；

			--前台缴费--查询费用记录信息；
			SELECT *
			FROM dbo.tb_expensesRecord;

			--前台缴费--查询当日未交费病人；
			SELECT e.ticketNo 票号,e.regNo 挂号号码,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期
			FROM dbo.tb_expensesRecord e 
				JOIN dbo.tb_patient p ON e.patientNo=p.No
				JOIN dbo.tb_doctor d ON e.docNo=d.No 
				JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO
				JOIN dbo.tb_registration r ON e.regNo=r.NO
			WHERE e.havePaid=0 AND r.regDate='2017-11-12';

			--前台缴费--查询所有未交费病人；
			SELECT e.ticketNo 票号,e.regNo 挂号号码,e.patientNo 患者编号,p.Name 患者姓名,d1.NAME 就诊科室,d.NAME 就诊医生,r.regDate 就诊日期
			FROM dbo.tb_expensesRecord e 
				JOIN dbo.tb_patient p ON e.patientNo=p.No
				JOIN dbo.tb_doctor d ON e.docNo=d.No 
				JOIN dbo.tb_dept d1 ON d.deptNo=d1.NO
				JOIN dbo.tb_registration r ON e.regNo=r.NO
			WHERE e.havePaid=0;

			--前台缴费--根据票号查询费用记录信息；
			SELECT e.medicineFee 药品费,e.examFee 检验费,e.checkFee 检查费,e.diagFee 诊疗费,e.regFee 挂号费
			FROM dbo.tb_expensesRecord e 
			WHERE e.ticketNo='020171119001';

			--前台缴费--根据患者编号查询就诊/医疗卡信息；
			SELECT cardType,id,visitNo,balance,creditLimit
			FROM dbo.tb_card
			WHERE patientNo='20171112102319';

			--前台缴费--更新费用记录支付状态；
			UPDATE dbo.tb_expensesRecord 
			SET havePaid=1,payDate='2017-11-20'
			WHERE ticketNo='020171119001';

			--前台缴费--更新就诊/医疗卡余额；
			UPDATE dbo.tb_card
			SET balance=200
			WHERE patientNo='20171112102319';
			
			--前台缴费--重置费用记录支付状态；
			UPDATE dbo.tb_expensesRecord 
			SET havePaid=0
			WHERE ticketNo='020171119001';

			--前台缴费--重置就诊/医疗卡余额；
			UPDATE dbo.tb_card
			SET balance=200
			WHERE patientNo='20171112102319';


--欠费催款；
			--欠费催款--查询所有欠费人信息；
			SELECT c.patientNo 患者编号,p.Name 病人姓名,CASE c.cardType WHEN 0 THEN '就诊卡' WHEN 1 THEN '社保卡' END 卡类型,c.id 身份证号码,c.visitNo 就诊卡号,c.balance 欠款总计
			FROM dbo.tb_card c JOIN dbo.tb_patient p ON c.patientNo=p.No
			WHERE c.patientNo=p.No AND c.balance<0;

			SELECT tel,email
			FROM dbo.tb_patient
			WHERE No='20171116104903';

			--欠费催款--更新欠费信息；
			UPDATE dbo.tb_card
			SET balance=-100
			WHERE patientNo='20171116104903';
			
			
--就诊卡充值；
			--就诊卡充值--查询所有就诊卡病人；
			SELECT Name
			FROM dbo.tb_patient
			WHERE visitNo IS NOT NULL;

			--就诊卡充值--根据就诊卡号查询病人就诊卡信息；
			SELECT p.No 患者编号,p.Name 患者姓名,p.visitNo 就诊卡号,c.balance 余额
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo
			WHERE p.visitNo='20171112001';

			--就诊卡充值--根据患者编号查询病人就诊卡信息；
			SELECT p.No 患者编号,p.Name 患者姓名,p.visitNo 就诊卡号,c.balance 余额
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo
			WHERE p.No='20171112102319' AND p.visitNo IS NOT NULL;

			--就诊卡充值--根据患者姓名查询病人就诊卡信息；
			SELECT p.No 患者编号,p.Name 患者姓名,p.visitNo 就诊卡号,c.balance 余额
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo
			WHERE p.Name='张三' AND p.visitNo IS NOT NULL;

			--就诊卡充值--更新余额；
			UPDATE dbo.tb_card
			SET balance=100
			WHERE patientNo='20171112102319';
			
			
--科室查询；
			--科室查询--查询所有科室名称；
			SELECT NAME
			FROM dbo.tb_dept;

			--科室查询--根据科室名称查询科室信息；
			SELECT NO,NAME,DSCP
			FROM dbo.tb_dept
			WHERE NAME='内科';

			--科室查询--根据科室编号查询科室信息；
			SELECT NO,NAME,DSCP
			FROM dbo.tb_dept
			WHERE NO=1;
			
			
--就诊卡余额查询；
			--就诊卡余额查询--查询所有就诊卡病人；
			SELECT p.No 患者编号,p.Name 患者姓名,c.visitNo 就诊卡号,c.balance 余额
			FROM dbo.tb_patient p JOIN dbo.tb_card c ON p.No=c.patientNo AND p.visitNo=c.visitNo
			WHERE c.cardType=0;

			--就诊卡余额查询--根据就诊卡号查询病人就诊卡信息；
			SELECT COUNT(1)
			FROM dbo.tb_card c
			WHERE c.visitNo='20171112001';

			--就诊卡余额查询--根据患者编号查询病人就诊卡信息；
			SELECT COUNT(1)
			FROM dbo.tb_card c 
			WHERE c.patientNo='20171112102319' AND c.cardType=0;

			--就诊卡余额查询--根据患者姓名查询病人就诊卡信息；
			SELECT COUNT(1)
			FROM dbo.tb_card c JOIN dbo.tb_patient p ON p.No=c.patientNo AND p.visitNo=c.visitNo
			WHERE p.Name='张三';